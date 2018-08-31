using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Data.Oracle.Repositories;
using Model;
using Web.Models;

namespace Web.Controllers
{
    [Authorize(Roles = "VisualizadorUNOEE_Editor, VisualizadorUNOEE_Consulta")]
    public class HomeController : Controller
    {
        private IMiembroRepository miembroRepository = null;
        private IEmpresaRepository empresaRepository = null;
        private IAreaRepository areaRepository = null;
        private IPermisoRepository permisosRepository = null;

        public HomeController(IMiembroRepository miembroRepository, 
            IEmpresaRepository empresaRepository, 
            IAreaRepository areaRepository,
            IPermisoRepository permisosRepository)
        {
            this.miembroRepository = miembroRepository;
            this.empresaRepository = empresaRepository;
            this.areaRepository = areaRepository;
            this.permisosRepository = permisosRepository;
        }


        [ValidateInput(false)]
        public ActionResult Index()
        {
            ViewBag.EsEditor = EsEditor();
            
            var permisoVM = new PermisoVM();
            return View(permisoVM);
        }

        private static bool EsEditor()
        {
            System.Security.Principal.IPrincipal principle = System.Threading.Thread.CurrentPrincipal;
            bool isInRole = principle.IsInRole("VisualizadorUNOEE_Editor");
            return isInRole;
        }

        [Authorize(Roles = "VisualizadorUNOEE_Editor")]
        [ValidateInput(false),HttpPost]
        public JsonResult GrabarDescripcionArea(int idArea, string descripcion)
        {
            var entidades = new VisualizadorPermisosUNOEEEntities();
            var descripcionArea = entidades.DescripcionAreas.FirstOrDefault(item => item.IdArea == idArea);
            if (descripcionArea == null)
            {
                entidades.DescripcionAreas.Add(
                    new DescripcionArea
                    {
                        DescripcionArea1 = descripcion,
                        Usuario = HttpContext.User.Identity.Name,
                        IdArea = idArea,
                        Fecha = DateTime.Now
                    });
            }
            else {
                descripcionArea.IdArea = idArea;
                descripcionArea.DescripcionArea1 = descripcion;
                descripcionArea.Usuario = HttpContext.User.Identity.Name;
                descripcionArea.Fecha = DateTime.Now;
                var entry = entidades.Entry(descripcionArea);
                entry.Property(e => e.DescripcionArea1).IsModified = true;
                entry.Property(e => e.Usuario).IsModified = true;
                entry.Property(e => e.Fecha).IsModified = true;
                entidades.Entry(descripcionArea).State = EntityState.Modified;
                    
            }

            entidades.SaveChanges();
            
            return new JsonResult
            {
                ContentType = "application/json",
                ContentEncoding = Encoding.Default,
                Data = new { resultado = "ok" },
                JsonRequestBehavior = JsonRequestBehavior.DenyGet,
                MaxJsonLength = int.MaxValue
            };
        }

        [ChildActionOnly]
        public PartialViewResult GetEmpresas() {
            IEnumerable<Empresa> empresas = new List<Empresa>();
            if (Session["EMPRESAS"] == null) {
                Session["EMPRESAS"] = empresaRepository.List();
            }
            empresas = (IEnumerable<Empresa>)Session["EMPRESAS"];
            return PartialView("~/Views/Shared/ListaEmpresas.cshtml", empresas);
        }

        [HttpGet]
        public ActionResult GetAreas(int id) {
            
            IEnumerable<Area> areas = new List<Area>();
            if (id>0) {
                if (Session[$"AREAS {id}"] == null)
                {
                    Session[$"AREAS {id}"] = areaRepository.List(id);
                }
                areas = (IEnumerable<Area>)Session[$"AREAS {id}"];
            }
            return PartialView("~/Views/Shared/ListaAreas.cshtml", areas);
        }

        
        [HttpGet]
        public ActionResult GetMiembros(int? idEmpresa, int? idArea)
        {

            IEnumerable<Miembro> miembros = new List<Miembro>();
            if (idEmpresa.HasValue && idArea.HasValue)
            {
                if (Session[$"MIEMBROS {idEmpresa} {idArea}"] == null) {
                    Session[$"MIEMBROS {idEmpresa} {idArea}"] = miembroRepository.List(idEmpresa.Value, idArea.Value);
                }
                miembros = (IEnumerable<Miembro>)Session[$"MIEMBROS {idEmpresa} {idArea}"];
            }
            return PartialView("~/Views/Shared/ListaMiembros.cshtml", miembros);
        }

        [HttpGet]
        public ActionResult GetDescripcionDelArea(int? idEmpresa, int? idArea)
        {
            var entidades = new VisualizadorPermisosUNOEEEntities();
            var descripcionArea = entidades.DescripcionAreas.FirstOrDefault(item => item.IdArea == idArea);
            if (descripcionArea == null) { 
                descripcionArea = new DescripcionArea();
            }
            return PartialView("~/Views/Shared/DescripcionArea.cshtml", descripcionArea);
        }

        public JsonResult GetPermisos(int? idEmpresa, int? idArea)
        {
            
            IEnumerable<Permiso> permisos = new List<Permiso>();
            string key = $"PERMISOS_{idEmpresa}_{idArea}";
            if (Session[key] == null)
            {
                var lista = permisosRepository.ListByArea(idEmpresa.Value, idArea.Value).ToList();
                
                Session[key] = lista;
            }
            
            permisos = (IEnumerable<Permiso>)Session[key];
            

            return new JsonResult
            {
                ContentType = "application/json",
                ContentEncoding = Encoding.Default,
                Data = permisos,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                MaxJsonLength = int.MaxValue
            };
        }
        [AllowAnonymous]
        public JsonResult GetTodosPermisos()
        {

            var permisosCompletos = permisosRepository.List();

            IEnumerable<Permiso> permisos = new List<Permiso>();
            string key = $"PERMISOS";
            if (Session[key] == null)
            {
                var lista = permisosRepository.List().ToList();
                Session[key] = lista;
            }

            permisos = (IEnumerable<Permiso>)Session[key];


            return new JsonResult
            {
                ContentType = "application/json",
                ContentEncoding = Encoding.Default,
                Data = permisos,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                MaxJsonLength = int.MaxValue
            };
        }

        [HttpGet]
        public ActionResult TreeView()
        {
            IEnumerable<Permiso> permisos = new List<Permiso>();

            //if (Session["ARBOL DE PERMISOS"] == null)
            //{
            //    var lista = permisosRepository.List();
            //    Session["ARBOL DE PERMISOS"] = lista;
            //}
            
            //permisos = (IEnumerable<Permiso>)Session["ARBOL DE PERMISOS"];
            
            return PartialView(permisos);
        }
        
    }
}