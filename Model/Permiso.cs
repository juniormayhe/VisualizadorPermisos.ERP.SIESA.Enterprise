using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Permiso
    {
        public int IdPermiso { get; set; }
        public string NombrePermiso { get; set; }
        public int? IdPermisoPadre { get; set; }
        public string Constante { get; set; }
        public string Ruta{ get; set; }

        public virtual Permiso Padre { get; set; }
        public virtual List<Permiso> Children { get; set; }

        public static Dictionary<int, string> Metodo = new Dictionary<int, string>(){
            { 1435,
    "Financiero - Activos fijos"
}, {
    3188,
    "Financiero - Activos fijos > Consultas"
}, {
    3189,
    "Financiero - Activos fijos > Consultas > Consulta movimiento de activos fijos"
}, {
    6776,
    "Financiero - Activos fijos > Consultas > Consulta saldo de activos fijos bajo NCIF"
}, {
    547,
    "Archivo"
}, {
    3375,
    "Archivo > Acumulados"
}, {
    3376,
    "Archivo > Acumulados > Acumular"
}, {
    3384,
    "Archivo > Acumulados > Acumular > Activos fijos"
}, {
    3381,
    "Archivo > Acumulados > Acumular > Compras"
}, {
    3377,
    "Archivo > Acumulados > Acumular > Contabilidad"
}, {
    3378,
    "Archivo > Acumulados > Acumular > Cuentas por cobrar"
}, {
    3379,
    "Archivo > Acumulados > Acumular > Cuentas por pagar"
}, {
    3706,
    "Archivo > Acumulados > Acumular > Existencias"
}, {
    3380,
    "Archivo > Acumulados > Acumular > Inventarios"
}, {
    3383,
    "Archivo > Acumulados > Acumular > Manufactura"
}, {
    3385,
    "Archivo > Acumulados > Acumular > Vehiculos"
}, {
    3382,
    "Archivo > Acumulados > Acumular > Ventas"
}, {
    4441,
    "Archivo > Acumulados > Acumular > Ventas POS"
}, {
    3386,
    "Archivo > Acumulados > Configurar"
}, {
    3387,
    "Archivo > Acumulados > Eliminar"
}, {
    3388,
    "Archivo > Acumulados > Generar"
}, {
    4655,
    "Archivo > Analysis services"
}, {
    4656,
    "Archivo > Analysis services > Parametros"
}, {
    4657,
    "Archivo > Analysis services > Parametros > Consultar"
}, {
    4658,
    "Archivo > Analysis services > Parametros > Modificar"
}, {
    4659,
    "Archivo > Analysis services > Parametros > Reporte"
}, {
    8072,
    "Archivo > Automatización de procesos"
}, {
    8073,
    "Archivo > Automatización de procesos > Adicionar"
}, {
    8074,
    "Archivo > Automatización de procesos > Consultar"
}, {
    8075,
    "Archivo > Automatización de procesos > Duplicar"
}, {
    8076,
    "Archivo > Automatización de procesos > Eliminar"
}, {
    8077,
    "Archivo > Automatización de procesos > Modificar"
}, {
    8078,
    "Archivo > Automatización de procesos > Reporte"
}, {
    8456,
    "Archivo > Automatización de procesos > Opciones"
}, {
    8457,
    "Archivo > Automatización de procesos > Opciones > Stock de seguridad - Si"
}, {
    932,
    "Archivo > Dispositivos > Basculas"
}, {
    935,
    "Archivo > Dispositivos > Basculas > Adicionar"
}, {
    936,
    "Archivo > Dispositivos > Basculas > Consultar"
}, {
    937,
    "Archivo > Dispositivos > Basculas > Duplicar"
}, {
    938,
    "Archivo > Dispositivos > Basculas > Eliminar"
}, {
    939,
    "Archivo > Dispositivos > Basculas > Modificar"
}, {
    950,
    "Archivo > Dispositivos > Basculas > Reporte"
}, {
    3448,
    "Archivo > BIABLE"
}, {
    3449,
    "Archivo > BIABLE > Parametros"
}, {
    3450,
    "Archivo > BIABLE > Parametros > Adicionar"
}, {
    3451,
    "Archivo > BIABLE > Parametros > Consultar"
}, {
    3452,
    "Archivo > BIABLE > Parametros > Duplicar"
}, {
    3453,
    "Archivo > BIABLE > Parametros > Eliminar"
}, {
    3454,
    "Archivo > BIABLE > Parametros > Modificar"
}, {
    3455,
    "Archivo > BIABLE > Parametros > Reportes"
}, {
    1800,
    "Archivo > Seguridad > Cambiar clave interna"
}, {
    548,
    "Archivo > Dispositivos > Caracteres de impresión"
}, {
    549,
    "Archivo > Dispositivos > Caracteres de impresión > Adicionar"
}, {
    552,
    "Archivo > Dispositivos > Caracteres de impresión > Consultar"
}, {
    553,
    "Archivo > Dispositivos > Caracteres de impresión > Duplicar"
}, {
    551,
    "Archivo > Dispositivos > Caracteres de impresión > Eliminar"
}, {
    550,
    "Archivo > Dispositivos > Caracteres de impresión > Modificar"
}, {
    12103,
    "Archivo > Consulta correo envio por cola"
}, {
    9196,
    "Archivo > Diccionario de datos"
}, {
    9197,
    "Archivo > Diccionario de datos > Reporte"
}, {
    1444,
    "Archivo > Dispositivos"
}, {
    3783,
    "Archivo > Entidades dinámicas"
}, {
    3986,
    "Archivo > Entidades dinámicas > Consulta"
}, {
    3784,
    "Archivo > Entidades dinámicas > Entidad"
}, {
    3785,
    "Archivo > Entidades dinámicas > Entidad > Adicionar"
}, {
    3791,
    "Archivo > Entidades dinámicas > Entidad > Cambiar código"
}, {
    3786,
    "Archivo > Entidades dinámicas > Entidad > Consultar"
}, {
    3787,
    "Archivo > Entidades dinámicas > Entidad > Duplicar"
}, {
    3788,
    "Archivo > Entidades dinámicas > Entidad > Eliminar"
}, {
    11116,
    "Archivo > Entidades dinámicas > Entidad > Eliminar entidad con sus movimientos"
}, {
    3789,
    "Archivo > Entidades dinámicas > Entidad > Modificar"
}, {
    3790,
    "Archivo > Entidades dinámicas > Entidad > Reporte"
}, {
    3876,
    "Archivo > Entidades dinámicas > Grupos de entidades"
}, {
    3877,
    "Archivo > Entidades dinámicas > Grupos de entidades > Adicionar"
}, {
    3878,
    "Archivo > Entidades dinámicas > Grupos de entidades > Cambiar código"
}, {
    3879,
    "Archivo > Entidades dinámicas > Grupos de entidades > Consultar"
}, {
    3880,
    "Archivo > Entidades dinámicas > Grupos de entidades > Duplicar"
}, {
    3881,
    "Archivo > Entidades dinámicas > Grupos de entidades > Eliminar"
}, {
    8438,
    "Archivo > Entidades dinámicas > Grupos de entidades > Eliminar entidades con movimiento"
}, {
    11115,
    "Archivo > Entidades dinámicas > Grupos de entidades > Eliminar grupo entidad con sus movimiento"
}, {
    3882,
    "Archivo > Entidades dinámicas > Grupos de entidades > Modificar"
}, {
    3883,
    "Archivo > Entidades dinámicas > Grupos de entidades > Reporte"
}, {
    7918,
    "Archivo > Entidades dinámicas > Importar entidades del sistema"
}, {
    3852,
    "Archivo > Entidades dinámicas > Maestros generales"
}, {
    3853,
    "Archivo > Entidades dinámicas > Maestros generales > Adicionar"
}, {
    3854,
    "Archivo > Entidades dinámicas > Maestros generales > Cambiar código"
}, {
    3855,
    "Archivo > Entidades dinámicas > Maestros generales > Consultar"
}, {
    3856,
    "Archivo > Entidades dinámicas > Maestros generales > Duplicar"
}, {
    3857,
    "Archivo > Entidades dinámicas > Maestros generales > Eliminar"
}, {
    3858,
    "Archivo > Entidades dinámicas > Maestros generales > Modificar"
}, {
    3859,
    "Archivo > Entidades dinámicas > Maestros generales > Reporte"
}, {
    3884,
    "Archivo > Entidades dinámicas > Servidor archivos adjuntos"
}, {
    934,
    "Archivo > Dispositivos > Configuración de estaciones"
}, {
    945,
    "Archivo > Dispositivos > Configuración de estaciones > Adicionar"
}, {
    946,
    "Archivo > Dispositivos > Configuración de estaciones > Consultar"
}, {
    947,
    "Archivo > Dispositivos > Configuración de estaciones > Duplicar"
}, {
    948,
    "Archivo > Dispositivos > Configuración de estaciones > Eliminar"
}, {
    949,
    "Archivo > Dispositivos > Configuración de estaciones > Modificar"
}, {
    952,
    "Archivo > Dispositivos > Configuración de estaciones > Reporte"
}, {
    3246,
    "Archivo > Exportar datos"
}, {
    3249,
    "Archivo > Exportar datos > Configuracion para exportar datos"
}, {
    3250,
    "Archivo > Exportar datos > Configuracion para exportar datos > Adicionar"
}, {
    3254,
    "Archivo > Exportar datos > Configuracion para exportar datos > Consultar"
}, {
    3253,
    "Archivo > Exportar datos > Configuracion para exportar datos > Duplicar"
}, {
    3252,
    "Archivo > Exportar datos > Configuracion para exportar datos > Eliminar"
}, {
    3251,
    "Archivo > Exportar datos > Configuracion para exportar datos > Modificar"
}, {
    3255,
    "Archivo > Exportar datos > Configuracion para exportar datos > Reporte"
}, {
    3256,
    "Archivo > Exportar datos > Exportar"
}, {
    8359,
    "Archivo > Exportar datos > Exportar documentos"
}, {
    3247,
    "Archivo > Exportar datos > Log de exportaciones"
}, {
    3248,
    "Archivo > Exportar datos > Log de exportaciones > Eliminar"
}, {
    3417,
    "Archivo > Exportar EDI"
}, {
    7470,
    "Archivo > Exportar EDI > Aviso de recibo"
}, {
    7477,
    "Archivo > Exportar EDI > Aviso de recibo > Análisis de diferencias"
}, {
    7472,
    "Archivo > Exportar EDI > Aviso de recibo > Aviso de recibo"
}, {
    7483,
    "Archivo > Exportar EDI > Aviso de recibo > Aviso de recibo > Adicionar"
}, {
    7474,
    "Archivo > Exportar EDI > Aviso de recibo > Aviso de recibo > Anular"
}, {
    7473,
    "Archivo > Exportar EDI > Aviso de recibo > Aviso de recibo > Cerrar"
}, {
    7484,
    "Archivo > Exportar EDI > Aviso de recibo > Aviso de recibo > Consultar"
}, {
    7482,
    "Archivo > Exportar EDI > Aviso de recibo > Aviso de recibo > Generar documentos de ajustes"
}, {
    7475,
    "Archivo > Exportar EDI > Aviso de recibo > Aviso de recibo > Habilitar impresión"
}, {
    7476,
    "Archivo > Exportar EDI > Aviso de recibo > Aviso de recibo > Imprimir"
}, {
    7478,
    "Archivo > Exportar EDI > Aviso de recibo > Consulta aviso de recibo"
}, {
    7479,
    "Archivo > Exportar EDI > Aviso de recibo > Imprimir documentos"
}, {
    7471,
    "Archivo > Exportar EDI > Aviso de recibo > Recepción aviso de recibo"
}, {
    3624,
    "Archivo > Exportar EDI > Aviso de despacho MAD"
}, {
    8891,
    "Archivo > Exportar EDI > Estado de cuenta"
}, {
    4665,
    "Archivo > Exportar EDI > Factura electrónica"
}, {
    11643,
    "Archivo > Exportar EDI > Factura electrónica > Automatización"
}, {
    8892,
    "Archivo > Exportar EDI > Impuestos"
}, {
    3953,
    "Archivo > Exportar EDI > Ordenes de compras > Generar documento"
}, {
    7596,
    "Archivo > Exportar EDI > Ordenes de compras"
}, {
    7597,
    "Archivo > Exportar EDI > Ordenes de compras > Automatización"
}, {
    3750,
    "Archivo > Exportar EDI > Pricat"
}, {
    3769,
    "Archivo > Exportar EDI > Pricat > Maestro datos Pricat"
}, {
    3770,
    "Archivo > Exportar EDI > Pricat > Maestro datos Pricat > Adicionar"
}, {
    3771,
    "Archivo > Exportar EDI > Pricat > Maestro datos Pricat > Consultar"
}, {
    3781,
    "Archivo > Exportar EDI > Pricat > Maestro datos Pricat > Duplicar"
}, {
    3772,
    "Archivo > Exportar EDI > Pricat > Maestro datos Pricat > Eliminar"
}, {
    3773,
    "Archivo > Exportar EDI > Pricat > Maestro datos Pricat > Modificar"
}, {
    3774,
    "Archivo > Exportar EDI > Pricat > Maestro datos Pricat > Reporte"
}, {
    10458,
    "Archivo > Exportar EDI > Pricat > Maestros equivalentes"
}, {
    10459,
    "Archivo > Exportar EDI > Pricat > Maestros equivalentes > Adicionar"
}, {
    10460,
    "Archivo > Exportar EDI > Pricat > Maestros equivalentes > Consultar"
}, {
    10461,
    "Archivo > Exportar EDI > Pricat > Maestros equivalentes > Duplicar"
}, {
    10462,
    "Archivo > Exportar EDI > Pricat > Maestros equivalentes > Eliminar"
}, {
    10463,
    "Archivo > Exportar EDI > Pricat > Maestros equivalentes > Modificar"
}, {
    10464,
    "Archivo > Exportar EDI > Pricat > Maestros equivalentes > Reporte"
}, {
    3747,
    "Archivo > Exportar EDI > Pricat > Generar"
}, {
    3418,
    "Archivo > Exportar EDI > Pricat > Generar SAC"
}, {
    3775,
    "Archivo > Exportar EDI > Pricat > Maestros tipo cliente"
}, {
    3776,
    "Archivo > Exportar EDI > Pricat > Maestros tipo cliente > Adicionar"
}, {
    3777,
    "Archivo > Exportar EDI > Pricat > Maestros tipo cliente > Consulta"
}, {
    3782,
    "Archivo > Exportar EDI > Pricat > Maestros tipo cliente > Duplicar"
}, {
    3778,
    "Archivo > Exportar EDI > Pricat > Maestros tipo cliente > Eliminar"
}, {
    3779,
    "Archivo > Exportar EDI > Pricat > Maestros tipo cliente > Modificar"
}, {
    3780,
    "Archivo > Exportar EDI > Pricat > Maestros tipo cliente > Reporte"
}, {
    7415,
    "Archivo > Exportar EDI > Reporte de inventario"
}, {
    7414,
    "Archivo > Exportar EDI > Reporte de ventas"
}, {
    1564,
    "Archivo > Exportar maestros"
}, {
    8377,
    "Archivo > Exportar proveedor servicios"
}, {
    8361,
    "Archivo > Exportar datos > Exportar documentos > Desmarcar doctos transmitidos"
}, {
    8360,
    "Archivo > Exportar datos > Exportar documentos > Exportar"
}, {
    883,
    "Archivo > Formatos"
}, {
    884,
    "Archivo > Formatos > Adicionar"
}, {
    885,
    "Archivo > Formatos > Eliminar"
}, {
    1570,
    "Archivo > Formatos de pago electrónico"
}, {
    1571,
    "Archivo > Formatos de pago electrónico > Adicionar"
}, {
    1572,
    "Archivo > Formatos de pago electrónico > Eliminar"
}, {
    2426,
    "Archivo > Importar datos"
}, {
    2446,
    "Archivo > Importar datos > Actualizar"
}, {
    7217,
    "Archivo > Importar datos > Documentos eliminados"
}, {
    2430,
    "Archivo > Importar datos > Eliminar lote de importación"
}, {
    3487,
    "Archivo > Importar datos > Habilitar, no permitir importaciones parciales"
}, {
    2427,
    "Archivo > Importar datos > Importar"
}, {
    12017,
    "Archivo > Importar datos > Importar fotos"
}, {
    3688,
    "Archivo > Importar datos > Importar > No permitir importaciones parciales"
}, {
    2428,
    "Archivo > Importar datos > Log de importación"
}, {
    2575,
    "Archivo > Importar datos > Log de importación > Activar conector"
}, {
    2576,
    "Archivo > Importar datos > Log de importación > Eliminar conector"
}, {
    2429,
    "Archivo > Importar datos > Log de importación > Eliminar log de importación"
}, {
    10873,
    "Archivo > Importar datos > Log de importación > Reversar documentos"
}, {
    11789,
    "Archivo > Importar datos > Reversar documentos"
}, {
    7809,
    "Archivo > Importar datos > Validar inconsistencias"
}, {
    933,
    "Archivo > Dispositivos > Lectores de barras"
}, {
    940,
    "Archivo > Dispositivos > Lectores de barras > Adicionar"
}, {
    941,
    "Archivo > Dispositivos > Lectores de barras > Consultar"
}, {
    942,
    "Archivo > Dispositivos > Lectores de barras > Duplicar"
}, {
    943,
    "Archivo > Dispositivos > Lectores de barras > Eliminar"
}, {
    944,
    "Archivo > Dispositivos > Lectores de barras > Modificar"
}, {
    951,
    "Archivo > Dispositivos > Lectores de barras > Reporte"
}, {
    1618,
    "Archivo > Localizar actualizador"
}, {
    3886,
    "Archivo > Localizar postscript"
}, {
    1617,
    "Archivo > Localizar reportes"
}, {
    1428,
    "Archivo > Log"
}, {
    11163,
    "Archivo > Log > Activar o Inactivar log"
}, {
    2839,
    "Archivo > Log > Eliminar Log"
}, {
    1787,
    "Archivo > Maestros por usuarios"
}, {
    10154,
    "Archivo > Inbox"
}, {
    10155,
    "Archivo > Inbox > Administrar alertas"
}, {
    11429,
    "Archivo > Inbox > Permitir crear carpetas publicas"
}, {
    886,
    "Archivo > Menus"
}, {
    887,
    "Archivo > Menus > Modificar"
}, {
    11204,
    "Archivo > Menus > Modificar genérico"
}, {
    3545,
    "Archivo > Montos por usuario"
}, {
    3546,
    "Archivo > Montos por usuario > Adicionar"
}, {
    3547,
    "Archivo > Montos por usuario > Consultar"
}, {
    3548,
    "Archivo > Montos por usuario > Duplicar"
}, {
    3549,
    "Archivo > Montos por usuario > Eliminar"
}, {
    3550,
    "Archivo > Montos por usuario > Modificar"
}, {
    3551,
    "Archivo > Montos por usuario > Reporte"
}, {
    3514,
    "Archivo > Preferencias"
}, {
    3516,
    "Archivo > Preferencias > Permite actualizar todos los usuarios"
}, {
    3515,
    "Archivo > Preferencias > Permite actualizar usuario conectado"
}, {
    4730,
    "Archivo > Seguridad > Reportes de seguridad"
}, {
    4731,
    "Archivo > Seguridad > Reportes de seguridad > Permite ver todos los usuarios"
}, {
    10513,
    "Archivo > Seguridad"
}, {
    10514,
    "Archivo > Seguridad > Administrador"
}, {
    6920,
    "Archivo > Sincronización"
}, {
    6921,
    "Archivo > Sincronización > Base de datos"
}, {
    7028,
    "Archivo > Sincronización > Base de datos > Adicionar"
}, {
    7029,
    "Archivo > Sincronización > Base de datos > Consultar"
}, {
    7030,
    "Archivo > Sincronización > Base de datos > Duplicar"
}, {
    7031,
    "Archivo > Sincronización > Base de datos > Eliminar"
}, {
    7032,
    "Archivo > Sincronización > Base de datos > Modificar"
}, {
    7033,
    "Archivo > Sincronización > Base de datos > Reporte"
}, {
    6924,
    "Archivo > Sincronización > Consulta de paquetes"
}, {
    6922,
    "Archivo > Sincronización > Enviar"
}, {
    6923,
    "Archivo > Sincronización > Recibir"
}, {
    10239,
    "Archivo > Tracking y aprobaciones"
}, {
    10619,
    "Archivo > Tracking y aprobaciones > Asignación de rutas"
}, {
    10620,
    "Archivo > Tracking y aprobaciones > Asignación de rutas > Adicionar"
}, {
    10621,
    "Archivo > Tracking y aprobaciones > Asignación de rutas > Consultar"
}, {
    10622,
    "Archivo > Tracking y aprobaciones > Asignación de rutas > Duplicar"
}, {
    10623,
    "Archivo > Tracking y aprobaciones > Asignación de rutas > Eliminar"
}, {
    10624,
    "Archivo > Tracking y aprobaciones > Asignación de rutas > Modificar"
}, {
    10625,
    "Archivo > Tracking y aprobaciones > Asignación de rutas > Reporte"
}, {
    10250,
    "Archivo > Tracking y aprobaciones > Actividades genéricas"
}, {
    10251,
    "Archivo > Tracking y aprobaciones > Actividades genéricas > Adicionar"
}, {
    10252,
    "Archivo > Tracking y aprobaciones > Actividades genéricas > Consultar"
}, {
    10253,
    "Archivo > Tracking y aprobaciones > Actividades genéricas > Duplicar"
}, {
    10254,
    "Archivo > Tracking y aprobaciones > Actividades genéricas > Eliminar"
}, {
    10255,
    "Archivo > Tracking y aprobaciones > Actividades genéricas > Modificar"
}, {
    10256,
    "Archivo > Tracking y aprobaciones > Actividades genéricas > Reporte"
}, {
    10257,
    "Archivo > Tracking y aprobaciones > Equipos de funcionarios"
}, {
    10258,
    "Archivo > Tracking y aprobaciones > Equipos de funcionarios > Adicionar"
}, {
    10259,
    "Archivo > Tracking y aprobaciones > Equipos de funcionarios > Consultar"
}, {
    10260,
    "Archivo > Tracking y aprobaciones > Equipos de funcionarios > Duplicar"
}, {
    10261,
    "Archivo > Tracking y aprobaciones > Equipos de funcionarios > Eliminar"
}, {
    10262,
    "Archivo > Tracking y aprobaciones > Equipos de funcionarios > Modificar"
}, {
    10263,
    "Archivo > Tracking y aprobaciones > Equipos de funcionarios > Reporte"
}, {
    10240,
    "Archivo > Tracking y aprobaciones > Rutas de seguimiento"
}, {
    10241,
    "Archivo > Tracking y aprobaciones > Rutas de seguimiento > Adicionar"
}, {
    10244,
    "Archivo > Tracking y aprobaciones > Rutas de seguimiento > Consultar"
}, {
    10274,
    "Archivo > Tracking y aprobaciones > Rutas de seguimiento > Deshacer inactivación"
}, {
    10243,
    "Archivo > Tracking y aprobaciones > Rutas de seguimiento > Deshacer liberación"
}, {
    10245,
    "Archivo > Tracking y aprobaciones > Rutas de seguimiento > Duplicar"
}, {
    10246,
    "Archivo > Tracking y aprobaciones > Rutas de seguimiento > Eliminar"
}, {
    10247,
    "Archivo > Tracking y aprobaciones > Rutas de seguimiento > Inactivar"
}, {
    10242,
    "Archivo > Tracking y aprobaciones > Rutas de seguimiento > Liberar"
}, {
    10248,
    "Archivo > Tracking y aprobaciones > Rutas de seguimiento > Modificar"
}, {
    10249,
    "Archivo > Tracking y aprobaciones > Rutas de seguimiento > Reporte"
}, {
    11017,
    "Archivo > Tracking y aprobaciones > Rutas de aprobación"
}, {
    11018,
    "Archivo > Tracking y aprobaciones > Rutas de aprobación > Adicionar"
}, {
    11019,
    "Archivo > Tracking y aprobaciones > Rutas de aprobación > Consultar"
}, {
    11022,
    "Archivo > Tracking y aprobaciones > Rutas de aprobación > Duplicar"
}, {
    11023,
    "Archivo > Tracking y aprobaciones > Rutas de aprobación > Eliminar"
}, {
    11020,
    "Archivo > Tracking y aprobaciones > Rutas de aprobación > Deshacer inactivación"
}, {
    11024,
    "Archivo > Tracking y aprobaciones > Rutas de aprobación > Inactivar"
}, {
    11021,
    "Archivo > Tracking y aprobaciones > Rutas de aprobación > Deshacer lliberación"
}, {
    11025,
    "Archivo > Tracking y aprobaciones > Rutas de aprobación > Liberar"
}, {
    11026,
    "Archivo > Tracking y aprobaciones > Rutas de aprobación > Modificar"
}, {
    11027,
    "Archivo > Tracking y aprobaciones > Rutas de aprobación > Reporte"
}, {
    3619,
    "Archivo > Web Services"
}, {
    11748,
    "Archivo > Web Services > Configuración"
}, {
    11749,
    "Archivo > Web Services > Configuración > Adicionar"
}, {
    11750,
    "Archivo > Web Services > Configuración > Consultar"
}, {
    11751,
    "Archivo > Web Services > Configuración > Duplicar"
}, {
    11752,
    "Archivo > Web Services > Configuración > Eliminar"
}, {
    11753,
    "Archivo > Web Services > Configuración > Modificar"
}, {
    11754,
    "Archivo > Web Services > Configuración > Reporte"
}, {
    3620,
    "Archivo > Web Services > Consultas WS por usuario"
}, {
    3768,
    "Archivo > Web Services > Importar consultas"
}, {
    7272,
    "Control de Calidad"
}, {
    8792,
    "Control de Calidad > Anulación de solicitudes"
}, {
    7277,
    "Control de Calidad > Cierre de solicitudes"
}, {
    7376,
    "Control de Calidad > Cierre de solicitudes > Anular"
}, {
    7377,
    "Control de Calidad > Cierre de solicitudes > Cerrar"
}, {
    12590,
    "Control de Calidad > Cierre de solicitudes > Imprimir al cerrar el documento"
}, {
    7274,
    "Control de Calidad > Consultas"
}, {
    8781,
    "Control de Calidad > Consultas > Items ruta de calidad"
}, {
    11782,
    "Control de Calidad > Consultas > Muestreo"
}, {
    9940,
    "Control de Calidad > Consultas > Solicitudes cerradas"
}, {
    7275,
    "Control de Calidad > Consultas > Solicitudes de inspección"
}, {
    7357,
    "Control de Calidad > Consultas > Solicitudes por secuencia"
}, {
    7278,
    "Control de Calidad > Generación de solicitud de inspección"
}, {
    7279,
    "Control de Calidad > Imprimir documentos"
}, {
    7280,
    "Control de Calidad > Imprimir documentos > Solicitudes de inspección"
}, {
    7379,
    "Control de Calidad > Imprimir documentos > Solicitudes de inspección > Habilitar impresión"
}, {
    7378,
    "Control de Calidad > Imprimir documentos > Solicitudes de inspección > Imprimir"
}, {
    7276,
    "Control de Calidad > Inspección"
}, {
    7373,
    "Control de Calidad > Inspección > Adicionar"
}, {
    7375,
    "Control de Calidad > Inspección > Eliminar"
}, {
    11340,
    "Control de Calidad > Inspección > Heredar inspección a registro del mismo lote"
}, {
    12591,
    "Control de Calidad > Inspección > Imprimir al procesar el documento"
}, {
    7374,
    "Control de Calidad > Inspección > Modificar"
}, {
    11783,
    "Control de Calidad > Muestreo"
}, {
    11784,
    "Control de Calidad > Muestreo > Captura"
}, {
    11785,
    "Control de Calidad > Muestreo > Captura > Adicionar"
}, {
    11786,
    "Control de Calidad > Muestreo > Captura > Eliminar"
}, {
    11787,
    "Control de Calidad > Muestreo > Captura > Modificar"
}, {
    11788,
    "Control de Calidad > Muestreo > Generación de inspección"
}, {
    304,
    "Financiero - Cuentas por cobrar"
}, {
    3441,
    "Financiero - Cuentas por cobrar > Acumulados"
}, {
    3442,
    "Financiero - Cuentas por cobrar > Acumulados > Cubo de CxC"
}, {
    11051,
    "Financiero - Cuentas por cobrar > Automatización de documentos"
}, {
    3589,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados"
}, {
    3606,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Reversión"
}, {
    3607,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Reversión > Adicionar"
}, {
    3608,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Reversión > Anular"
}, {
    3621,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Reversión > Aprobar"
}, {
    8264,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Reversión > Permitir cambiar caja preferida"
}, {
    3609,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Reversión > Consultar"
}, {
    3648,
    "Financiero - Cuentas por cobrar > Habilitar impresión documentos > Habilitar impresión cheques postfechados reversión"
}, {
    3647,
    "Financiero - Cuentas por cobrar > Imprimir documentos > imprimir cheque postfechado reversión"
}, {
    3610,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Reversión > Modificar"
}, {
    9868,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Reversión > Modificar entidades dinámicas docto aprobados"
}, {
    9869,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Reversión > Modificar entidades dinámicas docto en elaboración"
}, {
    3598,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Recibo oficial"
}, {
    3599,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Recibo oficial > Adicionar"
}, {
    3600,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Recibo oficial > Anular"
}, {
    3601,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Recibo oficial > Aprobar"
}, {
    3604,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Recibo oficial > Permite cambiar caja preferida"
}, {
    3602,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Recibo oficial > Consultar"
}, {
    3603,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Recibo oficial > Modificar"
}, {
    9864,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Recibo oficial > Modificar entidades dinámicas docto aprobados"
}, {
    9865,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Recibo oficial > Modificar entidades dinámicas docto en elaboración"
}, {
    3605,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Recibo oficial > Reversar"
}, {
    3590,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Recibo provisional"
}, {
    3591,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Recibo provisional > Adicionar"
}, {
    3592,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Recibo provisional > Anular"
}, {
    3593,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Recibo provisional > Aprobar"
}, {
    3596,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Recibo provisional > Permitir cambiar caja preferida"
}, {
    3594,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Recibo provisional > Consultar"
}, {
    3595,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Recibo provisional > Modificar"
}, {
    9866,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Recibo provisional > Modificar entidades dinámicas docto aprobados"
}, {
    9867,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Recibo provisional > Modificar entidades dinámicas docto en elaboración"
}, {
    3597,
    "Financiero - Cuentas por cobrar > Recibos de caja > Cheques postfechados > Recibo provisional > Reversar"
}, {
    438,
    "Financiero - Cuentas por cobrar > Recibos de caja > Clientes"
}, {
    463,
    "Financiero - Cuentas por cobrar > Recibos de caja > Clientes > Adicionar"
}, {
    467,
    "Financiero - Cuentas por cobrar > Recibos de caja > Clientes > Anular"
}, {
    466,
    "Financiero - Cuentas por cobrar > Recibos de caja > Clientes > Aprobar"
}, {
    3519,
    "Financiero - Cuentas por cobrar > Recibos de caja > Clientes > Permitir cambiar caja preferida"
}, {
    462,
    "Financiero - Cuentas por cobrar > Recibos de caja > Clientes > Consultar"
}, {
    464,
    "Financiero - Cuentas por cobrar > Recibos de caja > Clientes > Modficiar"
}, {
    9862,
    "Financiero - Cuentas por cobrar > Recibos de caja > Clientes > Modificar entidades dinámicas docto aprobados"
}, {
    9863,
    "Financiero - Cuentas por cobrar > Recibos de caja > Clientes > Modificar entidades dinámicas docto en elaboración"
}, {
    10838,
    "Financiero - Cuentas por cobrar > Recibos de caja > Clientes > Permitir modificar pronto pago"
}, {
    4852,
    "Financiero - Cuentas por cobrar > Recibos de caja > Clientes > Permitir no controlar valor en medios de pago"
}, {
    7753,
    "Financiero - Cuentas por cobrar > Recibos de caja > Clientes > No obligar valor impuesto en recaudos"
}, {
    465,
    "Financiero - Cuentas por cobrar > Recibos de caja > Clientes > Reversar"
}, {
    436,
    "Financiero - Cuentas por cobrar > Egresos de caja > Consignaciones"
}, {
    448,
    "Financiero - Cuentas por cobrar > Egresos de caja > Consignaciones > Adicionar"
}, {
    451,
    "Financiero - Cuentas por cobrar > Egresos de caja > Consignaciones > Anular"
}, {
    450,
    "Financiero - Cuentas por cobrar > Egresos de caja > Consignaciones > Aprobar"
}, {
    4451,
    "Financiero - Cuentas por cobrar > Egresos de caja > Consignaciones automaticas"
}, {
    3517,
    "Financiero - Cuentas por cobrar > Egresos de caja > Consignaciones > Permite cambiar caja preferida"
}, {
    447,
    "Financiero - Cuentas por cobrar > Egresos de caja > Consignaciones > Consulta"
}, {
    453,
    "Financiero - Cuentas por cobrar > Habilitar impresión documentos > Habilitar impresión consignacion"
}, {
    452,
    "Financiero - Cuentas por cobrar > Imprimir documentos > Imprimir consignacion"
}, {
    449,
    "Financiero - Cuentas por cobrar > Egresos de caja > Consignaciones > Modificar"
}, {
    7105,
    "Financiero - Cuentas por cobrar > Egresos de caja > Consignaciones de tarjetas"
}, {
    7106,
    "Financiero - Cuentas por cobrar > Egresos de caja > Consignaciones de tarjetas > Adicionar"
}, {
    7107,
    "Financiero - Cuentas por cobrar > Egresos de caja > Consignaciones de tarjetas > Anular"
}, {
    7108,
    "Financiero - Cuentas por cobrar > Egresos de caja > Consignaciones de tarjetas > Aprobar"
}, {
    7111,
    "Financiero - Cuentas por cobrar > Egresos de caja > Consignaciones de tarjetas > Permitir cambiar caja preferida"
}, {
    7109,
    "Financiero - Cuentas por cobrar > Egresos de caja > Consignaciones de tarjetas > Consulta"
}, {
    7110,
    "Financiero - Cuentas por cobrar > Egresos de caja > Consignaciones de tarjetas > Modificar"
}, {
    2470,
    "Financiero - Cuentas por cobrar > Consultas > Resumen de saldos de clientes"
}, {
    434,
    "Financiero - Cuentas por cobrar > Consultas"
}, {
    3721,
    "Financiero - Cuentas por cobrar > Consultas > Analisis de recaudos"
}, {
    3645,
    "Financiero - Cuentas por cobrar > Consultas > Caja"
}, {
    472,
    "Financiero - Cuentas por cobrar > Consultas > Cheques devueltos"
}, {
    471,
    "Financiero - Cuentas por cobrar > Consultas > Cheques posfechados"
}, {
    6775,
    "Financiero - Cuentas por cobrar > Consultas > Cheques posfechados > Modificar fecha de consignación"
}, {
    1341,
    "Financiero - Venta de servicios > Consultas > Cotizaciones"
}, {
    1964,
    "Financiero - Venta de servicios > Consultas > Cotizaciones por servicio"
}, {
    3911,
    "Financiero - Cuentas por cobrar > Consultas > Documentos por numero de cheque"
}, {
    470,
    "Financiero - Cuentas por cobrar > Consultas > Estado de cuenta"
}, {
    1966,
    "Financiero - Venta de servicios > Consultas > Facturas y notas"
}, {
    12028,
    "Financiero - Venta de servicios > Consultas > Facturas y notas > Modificar notas"
}, {
    1967,
    "Financiero - Venta de servicios > Consultas > Facturas y notas por servicio"
}, {
    1799,
    "Financiero - Cuentas por cobrar > Consultas > Liquidación de intereses por mora"
}, {
    3646,
    "Financiero - Cuentas por cobrar > Consultas > Caja > Movimientos de caja"
}, {
    554,
    "Financiero - Cuentas por cobrar > Consultas > Movimiento del cliente"
}, {
    1340,
    "Financiero - Venta de servicios > Consultas > Ordenes de venta"
}, {
    1965,
    "Financiero - Venta de servicios > Consultas > Ordenes de venta por servicio"
}, {
    1339,
    "Financiero - Venta de servicios > Consultas > Registros fijos"
}, {
    1963,
    "Financiero - Venta de servicios > Consultas > Registros fijos por servicio"
}, {
    854,
    "Financiero - Cuentas por cobrar > Consultas > Caja > Saldos de caja"
}, {
    6359,
    "Financiero - Cuentas por cobrar > Consultas > Saldos abiertos por número"
}, {
    3191,
    "Financiero - Cuentas por cobrar > Consultas > Seguimiento de documentos"
}, {
    1090,
    "Financiero - Venta de servicios > Cotizaciones"
}, {
    1106,
    "Financiero - Venta de servicios > Cotizaciones > Adicionar"
}, {
    1109,
    "Financiero - Venta de servicios > Cotizaciones > Anular"
}, {
    1105,
    "Financiero - Venta de servicios > Cotizaciones > Consultar"
}, {
    1319,
    "Financiero - Venta de servicios > Habilitar impresión documentos > Habilitar impresión cotizaciones"
}, {
    1110,
    "Financiero - Venta de servicios > Imprimir documentos > Imprimir cotizaciones"
}, {
    1107,
    "Financiero - Venta de servicios > Cotizaciones > Modificar"
}, {
    4803,
    "Financiero - Venta de servicios > Cotizaciones > Modificar entidades dinámicas en doctos aprobados"
}, {
    1108,
    "Financiero - Venta de servicios > Cotizaciones > Ordenar"
}, {
    6684,
    "Financiero - Cuentas por cobrar > Centrales de riesgos"
}, {
    6701,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Consultas"
}, {
    6703,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Consultas > Cifin"
}, {
    6702,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Consultas > Data credito"
}, {
    6704,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Generación de archivos"
}, {
    6708,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Generación de archivos > Cifin"
}, {
    6709,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Generación de archivos > Cifin > Generar"
}, {
    6710,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Generación de archivos > Cifin > Habilitar generación"
}, {
    6705,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Generación de archivos > Data credito"
}, {
    6706,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Generación de archivos > Data credito > Generar"
}, {
    6707,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Generación de archivos > Data credito > Habilitar generación"
}, {
    6698,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Generación información base"
}, {
    6699,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Generación información base > Generar"
}, {
    6700,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Generación información base > Inactivar"
}, {
    6685,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Maestros"
}, {
    6693,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Maestros > Clientes"
}, {
    6696,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Maestros > Clientes > Consultar"
}, {
    6695,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Maestros > Clientes > Eliminar"
}, {
    6694,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Maestros > Clientes > Modificar"
}, {
    6697,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Maestros > Clientes > Reporte"
}, {
    6733,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Maestros > Tipos de identificacion"
}, {
    6686,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Maestros > Tipos de cartera"
}, {
    6687,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Maestros > Tipos de cartera > Adicionar"
}, {
    6690,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Maestros > Tipos de cartera > Consultar"
}, {
    6692,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Maestros > Tipos de cartera > Duplicar"
}, {
    6689,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Maestros > Tipos de cartera > Eliminar"
}, {
    6688,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Maestros > Tipos de cartera > Modificar"
}, {
    6691,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Maestros > Tipos de cartera > Reporte"
}, {
    7223,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Saldos iniciales"
}, {
    7228,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Saldos iniciales > Eliminar"
}, {
    7229,
    "Financiero - Cuentas por cobrar > Centrales de riesgos > Saldos iniciales > Modificar"
}, {
    8312,
    "Financiero - Cuentas por cobrar > Deterioro de cartera"
}, {
    8315,
    "Financiero - Cuentas por cobrar > Deterioro de cartera > Consultas"
}, {
    8323,
    "Financiero - Cuentas por cobrar > Deterioro de cartera > Consultas > Deterioro de cartera"
}, {
    8314,
    "Financiero - Cuentas por cobrar > Deterioro de cartera > Procesos > Generación"
}, {
    8345,
    "Financiero - Cuentas por cobrar > Deterioro de cartera > Procesos > Generación > Permitir modificar valor deterioro"
}, {
    8313,
    "Financiero - Cuentas por cobrar > Deterioro de cartera > Maestros"
}, {
    8316,
    "Financiero - Cuentas por cobrar > Deterioro de cartera > Maestros > Políticas"
}, {
    8317,
    "Financiero - Cuentas por cobrar > Deterioro de cartera > Maestros > Políticas > Adicionar"
}, {
    8318,
    "Financiero - Cuentas por cobrar > Deterioro de cartera > Maestros > Políticas > Cambiar código"
}, {
    8319,
    "Financiero - Cuentas por cobrar > Deterioro de cartera > Maestros > Políticas > Consultar"
}, {
    8320,
    "Financiero - Cuentas por cobrar > Deterioro de cartera > Maestros > Políticas > Duplicar"
}, {
    8321,
    "Financiero - Cuentas por cobrar > Deterioro de cartera > Maestros > Políticas > Eliminar"
}, {
    8322,
    "Financiero - Cuentas por cobrar > Deterioro de cartera > Maestros > Políticas > Modificar"
}, {
    8344,
    "Financiero - Cuentas por cobrar > Deterioro de cartera > Procesos"
}, {
    8346,
    "Financiero - Cuentas por cobrar > Deterioro de cartera > Procesos > Reversión"
}, {
    8347,
    "Financiero - Cuentas por cobrar > Deterioro de cartera > Procesos > Reversión > Permitir modificar valor deterioro"
}, {
    433,
    "Financiero - Cuentas por cobrar > Egresos de caja"
}, {
    1013,
    "Financiero - Venta de servicios > Facturación"
}, {
    1021,
    "Financiero - Venta de servicios > Facturación > Adicionar"
}, {
    8467,
    "Financiero - Venta de servicios > Facturación > Permitir cruzar anticipos múltiples libros"
}, {
    4372,
    "Financiero - Venta de servicios > Facturación > Permitir anticipos de otra auxiliar de anticipos"
}, {
    3216,
    "Financiero - Venta de servicios > Facturación > Permitir anticipos de otra sucursal"
}, {
    3120,
    "Financiero - Venta de servicios > Facturación > Permitir anticipos de otra U.N."
}, {
    10181,
    "Financiero - Venta de servicios > Facturación > Permitir anticipos de otro cliente"
}, {
    3121,
    "Financiero - Venta de servicios > Facturación > Permitir anticipos de otro C.O."
}, {
    1022,
    "Financiero - Venta de servicios > Facturación > Anular"
}, {
    3715,
    "Financiero - Venta de servicios > Facturación > Anular facturas sin imprimir"
}, {
    1023,
    "Financiero - Venta de servicios > Facturación > Aprobar"
}, {
    10890,
    "Financiero - Venta de servicios > Facturación > Permitir cambiar instrumento financiero sugerido"
}, {
    7999,
    "Financiero - Venta de servicios > Facturación > Permitir cambiar pronto pago"
}, {
    9700,
    "Financiero - Venta de servicios > Facturación > Permitir capturar instrumento financiero"
}, {
    8973,
    "Financiero - Venta de servicios > Facturación > Permitir facturar clientes bloqueados"
}, {
    8975,
    "Financiero - Venta de servicios > Facturación > Permitir facturar clientes bloqueados por cupo"
}, {
    8974,
    "Financiero - Venta de servicios > Facturación > Permitir facturar clientes bloqueados por mora"
}, {
    1024,
    "Financiero - Venta de servicios > Facturación > Consultar"
}, {
    2578,
    "Financiero - Venta de servicios > Facturación > Permitir contabilizar por C.O."
}, {
    10182,
    "Financiero - Venta de servicios > Facturación > Permitir cruzar CxP"
}, {
    8624,
    "Financiero - Venta de servicios > Facturación > Permitir facturas de contado"
}, {
    1084,
    "Financiero - Venta de servicios > Habilitar impresión documentos > Habilitar impresión factura"
}, {
    1026,
    "Financiero - Venta de servicios > Imprimir documentos > Imprimir factura"
}, {
    2586,
    "Financiero - Venta de servicios > Intereses por mora > Intereses por mora por periodo"
}, {
    4806,
    "Financiero - Venta de servicios > Intereses por mora"
}, {
    4807,
    "Financiero - Venta de servicios > Intereses por mora > Intereses por mora a un corte"
}, {
    1027,
    "Financiero - Venta de servicios > Facturación > Modificar"
}, {
    4080,
    "Financiero - Venta de servicios > Facturación > Modificar entidades dinámicas en doctos aprobados"
}, {
    2482,
    "Financiero - Cuentas por cobrar > Generales"
}, {
    3985,
    "Financiero - Cuentas por cobrar > Generales > Permitir afectar seguimiento a documentos"
}, {
    4725,
    "Financiero - Cuentas por cobrar > Generales > Permitir fecha vcto menor que fechas docto"
}, {
    3862,
    "Financiero - Cuentas por cobrar > Generales > Filtrar el cliente con el C.O. del documento"
}, {
    11763,
    "Financiero - Cuentas por cobrar > Generales > No filtrar empleados en vendedores"
}, {
    11764,
    "Financiero - Cuentas por cobrar > Generales > No mostrar solo configurados como vendedores"
}, {
    2483,
    "Financiero - Cuentas por cobrar > Generales > Permite alterar saldos de creación"
}, {
    2485,
    "Financiero - Cuentas por cobrar > Generales > Permite aplicar un valor mayor que el saldo"
}, {
    2572,
    "Financiero - Cuentas por cobrar > Generales > Permite creditar saldos abiertos cancelados"
}, {
    2484,
    "Financiero - Cuentas por cobrar > Generales > Permite debitar saldos abiertos cancelados"
}, {
    3306,
    "Financiero - Cuentas por cobrar > Generales > Permite crear saldos de nat. contraria al auxiliar"
}, {
    3957,
    "Financiero - Cuentas por cobrar > Gestión de cobros"
}, {
    3976,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Consultas"
}, {
    3977,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Consultas > Ordenes de cobro - ODC"
}, {
    3978,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Consultas > Planillas de cobro"
}, {
    6474,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Consultas > Resumen de planillas de cobro"
}, {
    3958,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Generación de ordenes de cobro - ODC"
}, {
    3959,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Generación de ordenes de cobro - ODC > Adicionar"
}, {
    3960,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Generación de ordenes de cobro - ODC > Anular"
}, {
    4695,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Generación de ordenes de cobro - ODC > Permitir generar ODC sin planilla de transportador"
}, {
    3961,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Generación de planillas de cobro"
}, {
    3962,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Generación de planillas de cobro > Adicionar"
}, {
    3966,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Generación de planillas de cobro > Anular"
}, {
    3965,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Generación de planillas de cobro > Aprobar"
}, {
    3964,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Generación de planillas de cobro > Consultar"
}, {
    3963,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Generación de planillas de cobro > Modificar"
}, {
    3967,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Generación de planillas de cobro > Permitir planillas de saldos abiertos"
}, {
    3982,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Habilitar impresión de documentos"
}, {
    3983,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Habilitar impresión de documentos > Habilitar impresión de ordenes de cobro - ODC"
}, {
    3984,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Habilitar impresión de documentos > Habilitar impresión de planillas de cobro"
}, {
    3979,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Imprimir documentos"
}, {
    3980,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Imprimir documentos > Imprimir ordenes de cobro - ODC"
}, {
    3981,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Imprimir documentos > Imprimir planilla de cobro"
}, {
    3968,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Legalización de planillas de cobro"
}, {
    3969,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Legalización de planillas de cobro > Adicionar registo control"
}, {
    3975,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Legalización de planillas de cobro > Anular ODC"
}, {
    3972,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Legalización de planillas de cobro > Anular recibos de caja"
}, {
    6728,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Legalización de planillas de cobro > Permitir cambiar caja preferida"
}, {
    4028,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Legalización de planillas de cobro > Permite consultar notas"
}, {
    3971,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Legalización de planillas de cobro > Legalizar registro control"
}, {
    3974,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Legalización de planillas de cobro > Liberar ODC"
}, {
    3970,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Legalización de planillas de cobro > Modificar registo control"
}, {
    4041,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Legalización de planillas de cobro > Modificar calculo de valor local o alterno"
}, {
    11110,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Legalización de planillas de cobro > No controla tope máximo en otros ingresos"
}, {
    3973,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Legalización de planillas de cobro > Transferir ODC"
}, {
    6371,
    "Financiero - Cuentas por cobrar > Gestión de cobros > Legalización de planillas de cobro > Modificar fecha de registro control"
}, {
    2166,
    "Financiero - Cuentas por cobrar > Habilitar impresión documentos"
}, {
    2165,
    "Financiero - Cuentas por cobrar > Imprimir documentos"
}, {
    4255,
    "Financiero - Cuentas por cobrar > Intereses por mora a un corte"
}, {
    4258,
    "Financiero - Cuentas por cobrar > Intereses por mora a un corte > Consultar"
}, {
    4257,
    "Financiero - Cuentas por cobrar > Intereses por mora a un corte > Documentos liquidados"
}, {
    4256,
    "Financiero - Cuentas por cobrar > Intereses por mora a un corte > Generar intereses a un corte"
}, {
    4109,
    "Financiero - Cuentas por cobrar > Letras"
}, {
    4282,
    "Financiero - Cuentas por cobrar > Letras > Anulación de letras"
}, {
    4150,
    "Financiero - Cuentas por cobrar > Letras > Asignacion numero de letra"
}, {
    4152,
    "Financiero - Cuentas por cobrar > Letras > Consultas"
}, {
    4153,
    "Financiero - Cuentas por cobrar > Letras > Consultas > Letras"
}, {
    4281,
    "Financiero - Cuentas por cobrar > Letras > Consultas > Planillas de traslado"
}, {
    4137,
    "Financiero - Cuentas por cobrar > Letras > Generación de letras"
}, {
    4138,
    "Financiero - Cuentas por cobrar > Letras > Generación de letras > Generar"
}, {
    4139,
    "Financiero - Cuentas por cobrar > Letras > Generación de letras > Generar multiples letras"
}, {
    4141,
    "Financiero - Cuentas por cobrar > Letras > Generación de letras > Modificar fecha de vencimiento"
}, {
    4142,
    "Financiero - Cuentas por cobrar > Letras > Generación de letras > Modificar valor"
}, {
    4140,
    "Financiero - Cuentas por cobrar > Letras > Generación de letras > Unificar saldos abiertos"
}, {
    4157,
    "Financiero - Cuentas por cobrar > Letras > Habilitar impresión de documentos"
}, {
    4158,
    "Financiero - Cuentas por cobrar > Letras > Habilitar impresión de documentos > Letras"
}, {
    4159,
    "Financiero - Cuentas por cobrar > Letras > Habilitar impresión de documentos > Planillas de traslado"
}, {
    4155,
    "Financiero - Cuentas por cobrar > Letras > Imprimir documentos > Letras"
}, {
    4156,
    "Financiero - Cuentas por cobrar > Letras > Imprimir documentos > Planillas de traslado"
}, {
    4154,
    "Financiero - Cuentas por cobrar > Letras > Imprimir documentos"
}, {
    4110,
    "Financiero - Cuentas por cobrar > Letras > Maestros"
}, {
    4132,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Clientes"
}, {
    4133,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Clientes > Consultar"
}, {
    4134,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Clientes > Eliminar"
}, {
    4135,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Clientes > Modificar"
}, {
    4136,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Clientes > Reporte"
}, {
    4125,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Conceptos"
}, {
    4126,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Conceptos > Adicionar"
}, {
    4127,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Conceptos > Consultar"
}, {
    4128,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Conceptos > Duplicar"
}, {
    4129,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Conceptos > Eliminar"
}, {
    4130,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Conceptos > Modificar"
}, {
    4131,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Conceptos > Reporte"
}, {
    4111,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Estados"
}, {
    4112,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Estados > Adicionar"
}, {
    4113,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Estados > Consultar"
}, {
    4114,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Estados > Duplicar"
}, {
    4115,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Estados > Eliminar"
}, {
    4116,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Estados > Modificar"
}, {
    4117,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Estados > Reporte"
}, {
    4118,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Ubicaciones"
}, {
    4119,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Ubicaciones > Adicionar"
}, {
    4120,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Ubicaciones > Consultar"
}, {
    4121,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Ubicaciones > Duplicar"
}, {
    4122,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Ubicaciones > Eliminar"
}, {
    4123,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Ubicaciones > Modificar"
}, {
    4124,
    "Financiero - Cuentas por cobrar > Letras > Maestros > Ubicaciones > Reporte"
}, {
    4151,
    "Financiero - Cuentas por cobrar > Letras > Novedades de letras"
}, {
    4143,
    "Financiero - Cuentas por cobrar > Letras > Planilla de traslado"
}, {
    4144,
    "Financiero - Cuentas por cobrar > Letras > Planilla de traslado > Adicionar"
}, {
    4149,
    "Financiero - Cuentas por cobrar > Letras > Planilla de traslado > Anular"
}, {
    4148,
    "Financiero - Cuentas por cobrar > Letras > Planilla de traslado > Aprobar"
}, {
    4146,
    "Financiero - Cuentas por cobrar > Letras > Planilla de traslado > Consultar"
}, {
    4147,
    "Financiero - Cuentas por cobrar > Letras > Planilla de traslado > Imprimir"
}, {
    4145,
    "Financiero - Cuentas por cobrar > Letras > Planilla de traslado > Modificar"
}, {
    6711,
    "Financiero - Cuentas por cobrar > Recibos de caja > Maestros"
}, {
    6712,
    "Financiero - Cuentas por cobrar > Recibos de caja > Maestros > Conceptos de recaudos"
}, {
    6713,
    "Financiero - Cuentas por cobrar > Recibos de caja > Maestros > Conceptos de recaudos > Adicionar"
}, {
    6716,
    "Financiero - Cuentas por cobrar > Recibos de caja > Maestros > Conceptos de recaudos > Consultar"
}, {
    6718,
    "Financiero - Cuentas por cobrar > Recibos de caja > Maestros > Conceptos de recaudos > Duplicar"
}, {
    6715,
    "Financiero - Cuentas por cobrar > Recibos de caja > Maestros > Conceptos de recaudos > Eliminar"
}, {
    6714,
    "Financiero - Cuentas por cobrar > Recibos de caja > Maestros > Conceptos de recaudos > Modificar"
}, {
    6717,
    "Financiero - Cuentas por cobrar > Recibos de caja > Maestros > Conceptos de recaudos > Reporte"
}, {
    6719,
    "Financiero - Cuentas por cobrar > Recibos de caja > Maestros > Planillas de recaudos"
}, {
    6720,
    "Financiero - Cuentas por cobrar > Recibos de caja > Maestros > Planillas de recaudos > Adicionar"
}, {
    6723,
    "Financiero - Cuentas por cobrar > Recibos de caja > Maestros > Planillas de recaudos > Consultar"
}, {
    6725,
    "Financiero - Cuentas por cobrar > Recibos de caja > Maestros > Planillas de recaudos > Duplicar"
}, {
    6722,
    "Financiero - Cuentas por cobrar > Recibos de caja > Maestros > Planillas de recaudos > Eliminar"
}, {
    6721,
    "Financiero - Cuentas por cobrar > Recibos de caja > Maestros > Planillas de recaudos > Modificar"
}, {
    6724,
    "Financiero - Cuentas por cobrar > Recibos de caja > Maestros > Planillas de recaudos > Reporte"
}, {
    2647,
    "Financiero - Cuentas por cobrar > Notas"
}, {
    10803,
    "Financiero - Cuentas por cobrar > Notas > Ajuste automático saldo cartera"
}, {
    8570,
    "Financiero - Cuentas por cobrar > Notas > Conciliación cheques efectivamente recaudados"
}, {
    2648,
    "Financiero - Cuentas por cobrar > Notas > Reclasificación de cuentas por cobrar"
}, {
    2651,
    "Financiero - Cuentas por cobrar > Notas > Reclasificación de cuentas por cobrar > Anular"
}, {
    2652,
    "Financiero - Cuentas por cobrar > Notas > Reclasificación de cuentas por cobrar > Aprobar"
}, {
    4727,
    "Financiero - Cuentas por cobrar > Notas > Reclasificación de cuentas por cobrar > Permitir cambiar tercero contrapartida"
}, {
    2653,
    "Financiero - Cuentas por cobrar > Notas > Reclasificación de cuentas por cobrar > Consultar"
}, {
    9945,
    "Financiero - Cuentas por cobrar > Notas > Reclasificación de cuentas por cobrar > Permitir cruzar múltiples clientes o proveedores"
}, {
    2649,
    "Financiero - Cuentas por cobrar > Notas > Reclasificación de cuentas por cobrar > Cruzar con cuentas por cobrar"
}, {
    2650,
    "Financiero - Cuentas por cobrar > Notas > Reclasificación de cuentas por cobrar > Cruzar con cuentas por pagar"
}, {
    2656,
    "Financiero - Cuentas por cobrar > Notas > Reclasificación de cuentas por cobrar > Habilitar impresión"
}, {
    2654,
    "Financiero - Cuentas por cobrar > Imprimir documentos > Imprimir notas de reclasificacion de cxc"
}, {
    2655,
    "Financiero - Cuentas por cobrar > Notas > Reclasificación de cuentas por cobrar > Reversar"
}, {
    6510,
    "Financiero - Cuentas por cobrar > Notas > Reclasificación de cuentas por cobrar > Modificar entidades dinámicas en doctos aprobados"
}, {
    6509,
    "Financiero - Cuentas por cobrar > Notas > Reclasificación de cuentas por cobrar > Modificar entidades dinámicas docto en elaboración"
}, {
    3434,
    "Financiero - Cuentas por cobrar > Notas > Traslado de cuentas por cobrar"
}, {
    3439,
    "Financiero - Cuentas por cobrar > Notas > Traslado de cuentas por cobrar > Cambiar vendedor"
}, {
    3436,
    "Financiero - Cuentas por cobrar > Notas > Traslado de cuentas por cobrar > Generar"
}, {
    1068,
    "Financiero - Venta de servicios > Notas crédito"
}, {
    1077,
    "Financiero - Venta de servicios > Notas crédito > Adicionar"
}, {
    1078,
    "Financiero - Venta de servicios > Notas crédito > Anular"
}, {
    3716,
    "Financiero - Venta de servicios > Notas crédito > Anular nota crédito sin imprimir"
}, {
    1079,
    "Financiero - Venta de servicios > Notas crédito > Aprobar"
}, {
    1080,
    "Financiero - Venta de servicios > Notas crédito > Consultar"
}, {
    2580,
    "Financiero - Venta de servicios > Notas crédito > Permitir contabilizar por C.O."
}, {
    8468,
    "Financiero - Venta de servicios > Notas crédito > Pemitir cruzar facturas múltiples libros"
}, {
    1081,
    "Financiero - Venta de servicios > Habilitar impresión documentos > Habilitar impresión notas"
}, {
    1082,
    "Financiero - Venta de servicios > Imprimir documentos > Imprimir notas"
}, {
    1083,
    "Financiero - Venta de servicios > Notas crédito > Modificar"
}, {
    4081,
    "Financiero - Venta de servicios > Notas crédito > Modificar entidades dinámicas en doctos aprobados"
}, {
    1088,
    "Financiero - Venta de servicios > Ordenes de venta"
}, {
    1097,
    "Financiero - Venta de servicios > Ordenes de venta > Adicionar"
}, {
    1100,
    "Financiero - Venta de servicios > Ordenes de venta > Anular"
}, {
    1099,
    "Financiero - Venta de servicios > Ordenes de venta > Aprobar"
}, {
    4211,
    "Financiero - Venta de servicios > Ordenes de venta > Permitir cambiar condicion de pago"
}, {
    1102,
    "Financiero - Venta de servicios > Ordenes de venta > Confirmar"
}, {
    1096,
    "Financiero - Venta de servicios > Ordenes de venta > Consultar"
}, {
    6526,
    "Financiero - Venta de servicios > Ordenes de venta > Desaprobar"
}, {
    1103,
    "Financiero - Venta de servicios > Ordenes de venta > Facturar"
}, {
    1320,
    "Financiero - Venta de servicios > Habilitar impresión documentos > Habilitar impresión orden"
}, {
    1104,
    "Financiero - Venta de servicios > Imprimir documentos > Imprimir orden"
}, {
    1098,
    "Financiero - Venta de servicios > Ordenes de venta > Modificar"
}, {
    4804,
    "Financiero - Venta de servicios > Ordenes de venta > Modificar entidades dinámicas en doctos aprobados"
}, {
    9188,
    "Financiero - Venta de servicios > Ordenes de venta > Al facturar permitir modificar tasas de cambio"
}, {
    4210,
    "Financiero - Venta de servicios > Ordenes de venta > No validar estado de la fecha"
}, {
    1101,
    "Financiero - Venta de servicios > Ordenes de venta > Rechazar"
}, {
    3520,
    "Financiero - Cuentas por cobrar > Recibos de caja > Otros ingresos > Permitir cambiar caja preferida"
}, {
    437,
    "Financiero - Cuentas por cobrar > Egresos de caja > Otros egresos"
}, {
    441,
    "Financiero - Cuentas por cobrar > Egresos de caja > Otros egresos > Adicionar"
}, {
    444,
    "Financiero - Cuentas por cobrar > Egresos de caja > Otros egresos > Anular"
}, {
    443,
    "Financiero - Cuentas por cobrar > Egresos de caja > Otros egresos > Aprobar"
}, {
    3518,
    "Financiero - Cuentas por cobrar > Egresos de caja > Otros egresos > Permite cambiar caja preferida"
}, {
    7554,
    "Financiero - Cuentas por cobrar > Egresos de caja > Otros egresos > Capturar múltiples libros"
}, {
    440,
    "Financiero - Cuentas por cobrar > Egresos de caja > Otros egresos > Consultar"
}, {
    446,
    "Financiero - Cuentas por cobrar > Habilitar impresión documentos > Habilitar impresión otros egresos"
}, {
    445,
    "Financiero - Cuentas por cobrar > Imprimir documentos > Imprimir otros egresos"
}, {
    442,
    "Financiero - Cuentas por cobrar > Egresos de caja > Otros egresos > Modificar"
}, {
    6754,
    "Financiero - Cuentas por cobrar > Egresos de caja > Otros egresos > Modificar entidades dinámicas docto aprobados"
}, {
    6753,
    "Financiero - Cuentas por cobrar > Egresos de caja > Otros egresos > Modificar entidades dinámicas docto en elaboración"
}, {
    439,
    "Financiero - Cuentas por cobrar > Recibos de caja > Otros ingresos"
}, {
    455,
    "Financiero - Cuentas por cobrar > Recibos de caja > Otros ingresos > Adicionar"
}, {
    459,
    "Financiero - Cuentas por cobrar > Recibos de caja > Otros ingresos > Anular"
}, {
    458,
    "Financiero - Cuentas por cobrar > Recibos de caja > Otros ingresos > Aprobar"
}, {
    7555,
    "Financiero - Cuentas por cobrar > Recibos de caja > Otros ingresos > Capturar múltiples libros"
}, {
    454,
    "Financiero - Cuentas por cobrar > Recibos de caja > Otros ingresos > Consultar"
}, {
    456,
    "Financiero - Cuentas por cobrar > Recibos de caja > Otros ingresos > Modificar"
}, {
    6752,
    "Financiero - Cuentas por cobrar > Recibos de caja > Otros ingresos > Modificar entidades dinámicas docto aprobados"
}, {
    6751,
    "Financiero - Cuentas por cobrar > Recibos de caja > Otros ingresos > Modificar entidades dinámicas docto en elaboración"
}, {
    11654,
    "Financiero - Cuentas por cobrar > Recibos de caja > Otros ingresos > Modificar notas a doctos con movimientos"
}, {
    4853,
    "Financiero - Cuentas por cobrar > Recibos de caja > Otros ingresos > Permitir no controlar valor en medios de pago"
}, {
    457,
    "Financiero - Cuentas por cobrar > Recibos de caja > Otros ingresos > Reversar"
}, {
    7754,
    "Financiero - Cuentas por cobrar > Recibos de caja > Otros ingresos > No obligar valor impuesto en recaudos"
}, {
    8485,
    "-No implementado > Otros motivos"
}, {
    4397,
    "Financiero - Cuentas por cobrar > Recibos de caja > PATE"
}, {
    4398,
    "Financiero - Cuentas por cobrar > Recibos de caja > PATE > Importar formato"
}, {
    4399,
    "Financiero - Cuentas por cobrar > Recibos de caja > PATE > Importar formato > Adicionar"
}, {
    4400,
    "Financiero - Cuentas por cobrar > Recibos de caja > PATE > Importar formato > Eliminar"
}, {
    4401,
    "Financiero - Cuentas por cobrar > Recibos de caja > PATE > Proceso de recaudos"
}, {
    3521,
    "Financiero - Cuentas por cobrar > Procesos"
}, {
    3522,
    "Financiero - Cuentas por cobrar > Procesos > Cambiar vendedor de la cuenta por cobrar"
}, {
    4011,
    "Financiero - Cuentas por cobrar > Provision cartera"
}, {
    4025,
    "Financiero - Cuentas por cobrar > Provision cartera > Abonos y deducciones cartera provisionada"
}, {
    4012,
    "Financiero - Cuentas por cobrar > Provision cartera > Configurar provisión"
}, {
    4013,
    "Financiero - Cuentas por cobrar > Provision cartera > Configurar provisión > Maestro de provisiones"
}, {
    4014,
    "Financiero - Cuentas por cobrar > Provision cartera > Configurar provisión > Maestro de provisiones > Adicionar"
}, {
    4015,
    "Financiero - Cuentas por cobrar > Provision cartera > Configurar provisión > Maestro de provisiones > Consultar"
}, {
    4016,
    "Financiero - Cuentas por cobrar > Provision cartera > Configurar provisión > Maestro de provisiones > Eliminar"
}, {
    4017,
    "Financiero - Cuentas por cobrar > Provision cartera > Configurar provisión > Maestro de provisiones > Modificar"
}, {
    4018,
    "Financiero - Cuentas por cobrar > Provision cartera > Configurar provisión > Saldos iniciales de provision"
}, {
    4019,
    "Financiero - Cuentas por cobrar > Provision cartera > Configurar provisión > Saldos iniciales de provision > Adicionar"
}, {
    4020,
    "Financiero - Cuentas por cobrar > Provision cartera > Configurar provisión > Saldos iniciales de provision > Consultar"
}, {
    4021,
    "Financiero - Cuentas por cobrar > Provision cartera > Configurar provisión > Saldos iniciales de provision > Eliminar"
}, {
    4022,
    "Financiero - Cuentas por cobrar > Provision cartera > Configurar provisión > Saldos iniciales de provision > Modificar"
}, {
    4023,
    "Financiero - Cuentas por cobrar > Provision cartera > Configurar provisión > Saldos iniciales de provision > Reporte"
}, {
    4026,
    "Financiero - Cuentas por cobrar > Provision cartera > Consulta"
}, {
    4027,
    "Financiero - Cuentas por cobrar > Provision cartera > Consulta > Consulta provisión de cartera"
}, {
    4024,
    "Financiero - Cuentas por cobrar > Provision cartera > Generar provisión de cartera"
}, {
    6726,
    "Financiero - Cuentas por cobrar > Recibos de caja > Recaudo"
}, {
    10189,
    "Financiero - Cuentas por cobrar > Recibos de caja > Recaudo > Calcular descuento pronto pago"
}, {
    10190,
    "Financiero - Cuentas por cobrar > Recibos de caja > Recaudo > Permitir modificar descuento pronto pago"
}, {
    7093,
    "Financiero - Cuentas por cobrar > Recibos de caja > Recaudo > Permitir modificar valor impuesto en recaudos"
}, {
    7752,
    "Financiero - Cuentas por cobrar > Recibos de caja > Recaudo > No obligar valor impuesto en recaudos"
}, {
    6727,
    "Financiero - Cuentas por cobrar > Recibos de caja > Recaudo > Permitir cambiar caja preferida"
}, {
    11927,
    "Financiero - Cuentas por cobrar > Recibos de caja > Recaudo > Al obligar recaudo de interés permitir menor valor"
}, {
    11926,
    "Financiero - Cuentas por cobrar > Recibos de caja > Recaudo > Permitir recaudo sin intereses"
}, {
    469,
    "Financiero - Cuentas por cobrar > Habilitar impresión documentos > Habilitar impresión recibos de caja"
}, {
    468,
    "Financiero - Cuentas por cobrar > Imprimir documentos > Imprimir recibo de caja"
}, {
    432,
    "Financiero - Cuentas por cobrar > Recibos de caja"
}, {
    1089,
    "Financiero - Venta de servicios > Registros fijos"
}, {
    1094,
    "Financiero - Venta de servicios > Registros fijos > Activar"
}, {
    1092,
    "Financiero - Venta de servicios > Registros fijos > Adicionar"
}, {
    1202,
    "Financiero - Venta de servicios > Registros fijos > Anular"
}, {
    3432,
    "Financiero - Venta de servicios > Registros fijos > Cambiar precios automaticamente"
}, {
    1091,
    "Financiero - Venta de servicios > Registros fijos > Consultar"
}, {
    3433,
    "Financiero - Venta de servicios > Registros fijos > Facturar"
}, {
    1203,
    "Financiero - Venta de servicios > Registros fijos > Generar orden"
}, {
    1095,
    "Financiero - Venta de servicios > Imprimir documentos > Imprimir reg fijos"
}, {
    1093,
    "Financiero - Venta de servicios > Registros fijos > Modificar"
}, {
    4805,
    "Financiero - Venta de servicios > Registros fijos > Modificar entidades dinámicas en doctos aprobados"
}, {
    9189,
    "Financiero - Venta de servicios > Registros fijos > Al facturar permitir modificar tasas de cambio"
}, {
    1201,
    "Financiero - Venta de servicios > Registros fijos > Suspender"
}, {
    435,
    "Financiero - Cuentas por cobrar > Reportes"
}, {
    481,
    "Financiero - Cuentas por cobrar > Reportes > Análisis de cupo de crédito"
}, {
    485,
    "Financiero - Cuentas por cobrar > Reportes > Cheques devueltos"
}, {
    484,
    "Financiero - Cuentas por cobrar > Reportes > Cheques postfechados"
}, {
    480,
    "Financiero - Cuentas por cobrar > Reportes > Circularización"
}, {
    476,
    "Financiero - Cuentas por cobrar > Reportes > Cuadre de caja"
}, {
    477,
    "Financiero - Cuentas por cobrar > Reportes > Estado de cuenta"
}, {
    479,
    "Financiero - Cuentas por cobrar > Reportes > Extractos"
}, {
    3956,
    "Financiero - Cuentas por cobrar > Reportes > Planilla de caja"
}, {
    483,
    "Financiero - Cuentas por cobrar > Reportes > Recaudos por vendedor"
}, {
    482,
    "Financiero - Cuentas por cobrar > Reportes > Relación de recaudos"
}, {
    478,
    "Financiero - Cuentas por cobrar > Reportes > Vencimiento por edades"
}, {
    6551,
    "Financiero - Venta de servicios > Imprimir documentos > Impresora fiscal"
}, {
    4888,
    "Centros Comerciales > Contratos"
}, {
    6537,
    "Centros Comerciales > Contratos > Attachment de Contratos"
}, {
    7099,
    "Centros Comerciales > Contratos > Cambiar tercero del contrato"
}, {
    7100,
    "Centros Comerciales > Contratos > Cambiar tercero del contrato > Adicionar"
}, {
    7101,
    "Centros Comerciales > Contratos > Cambiar tercero del contrato > Filtro"
}, {
    7102,
    "Centros Comerciales > Contratos > Cambiar tercero del contrato > Generar"
}, {
    5501,
    "Centros Comerciales > Contratos > Categoria comercial"
}, {
    5791,
    "Centros Comerciales > Contratos > Categoria comercial > Adicionar"
}, {
    5792,
    "Centros Comerciales > Contratos > Categoria comercial > Consultar"
}, {
    5793,
    "Centros Comerciales > Contratos > Categoria comercial > Duplicar"
}, {
    5794,
    "Centros Comerciales > Contratos > Categoria comercial > Eliminar"
}, {
    5795,
    "Centros Comerciales > Contratos > Categoria comercial > Modificar"
}, {
    5796,
    "Centros Comerciales > Contratos > Categoria comercial > Reporte"
}, {
    5502,
    "Centros Comerciales > Contratos > Clasificacion presupuestal"
}, {
    5797,
    "Centros Comerciales > Contratos > Clasificacion presupuestal > Adicionar"
}, {
    5798,
    "Centros Comerciales > Contratos > Clasificacion presupuestal > Consultar"
}, {
    5799,
    "Centros Comerciales > Contratos > Clasificacion presupuestal > Duplicar"
}, {
    5800,
    "Centros Comerciales > Contratos > Clasificacion presupuestal > Eliminar"
}, {
    5801,
    "Centros Comerciales > Contratos > Clasificacion presupuestal > Modificar"
}, {
    5802,
    "Centros Comerciales > Contratos > Clasificacion presupuestal > Reporte"
}, {
    6479,
    "Centros Comerciales > Contratos > Claves de bitacora"
}, {
    6480,
    "Centros Comerciales > Contratos > Claves de bitacora > Adicionar"
}, {
    6481,
    "Centros Comerciales > Contratos > Claves de bitacora > Consultar"
}, {
    6482,
    "Centros Comerciales > Contratos > Claves de bitacora > Duplicar"
}, {
    6483,
    "Centros Comerciales > Contratos > Claves de bitacora > Eliminar"
}, {
    6484,
    "Centros Comerciales > Contratos > Claves de bitacora > Modificar"
}, {
    6485,
    "Centros Comerciales > Contratos > Claves de bitacora > Reporte"
}, {
    5507,
    "Centros Comerciales > Contratos > Consulta de Contratos"
}, {
    5827,
    "Centros Comerciales > Contratos > Consulta de Contratos > Adicionar"
}, {
    5828,
    "Centros Comerciales > Contratos > Consulta de Contratos > Consultar"
}, {
    5829,
    "Centros Comerciales > Contratos > Consulta de Contratos > Duplicar"
}, {
    5830,
    "Centros Comerciales > Contratos > Consulta de Contratos > Eliminar"
}, {
    5831,
    "Centros Comerciales > Contratos > Consulta de Contratos > Modificar"
}, {
    5832,
    "Centros Comerciales > Contratos > Consulta de Contratos > Procesar"
}, {
    5508,
    "Centros Comerciales > Contratos > Consulta de Polizas"
}, {
    5833,
    "Centros Comerciales > Contratos > Consulta de Polizas > Adicionar"
}, {
    5834,
    "Centros Comerciales > Contratos > Consulta de Polizas > Consultar"
}, {
    5835,
    "Centros Comerciales > Contratos > Consulta de Polizas > Duplicar"
}, {
    5836,
    "Centros Comerciales > Contratos > Consulta de Polizas > Eliminar"
}, {
    5837,
    "Centros Comerciales > Contratos > Consulta de Polizas > Modificar"
}, {
    5838,
    "Centros Comerciales > Contratos > Consulta de Polizas > Procesar"
}, {
    5510,
    "Centros Comerciales > Contratos > Contratos"
}, {
    5845,
    "Centros Comerciales > Contratos > Contratos > Adicionar"
}, {
    5846,
    "Centros Comerciales > Contratos > Contratos > Consultar"
}, {
    5847,
    "Centros Comerciales > Contratos > Contratos > Duplicar"
}, {
    5848,
    "Centros Comerciales > Contratos > Contratos > Eliminar"
}, {
    6454,
    "Centros Comerciales > Contratos > Contratos en Litigio"
}, {
    6455,
    "Centros Comerciales > Contratos > Contratos en Litigio > Modificar"
}, {
    5849,
    "Centros Comerciales > Contratos > Contratos > Modificar"
}, {
    5850,
    "Centros Comerciales > Contratos > Contratos > Reporte"
}, {
    6435,
    "Centros Comerciales > Contratos > Contratos Adicionales"
}, {
    6436,
    "Centros Comerciales > Contratos > Contratos Adicionales > Adicionar"
}, {
    6437,
    "Centros Comerciales > Contratos > Contratos Adicionales > Consultar"
}, {
    6438,
    "Centros Comerciales > Contratos > Contratos Adicionales > Duplicar"
}, {
    6439,
    "Centros Comerciales > Contratos > Contratos Adicionales > Eliminar"
}, {
    6440,
    "Centros Comerciales > Contratos > Contratos Adicionales > Modificar"
}, {
    6441,
    "Centros Comerciales > Contratos > Contratos Adicionales > Reporte"
}, {
    6676,
    "Centros Comerciales > Contratos > Contratos Adicionales > Contratos Inmuebles"
}, {
    6442,
    "Centros Comerciales > Contratos > Copiar Contrato"
}, {
    6443,
    "Centros Comerciales > Contratos > Copiar Contrato > Adicionar"
}, {
    6444,
    "Centros Comerciales > Contratos > Copiar Contrato > Filtro"
}, {
    6445,
    "Centros Comerciales > Contratos > Copiar Contrato > Generar"
}, {
    5503,
    "Centros Comerciales > Contratos > Estado del contrato"
}, {
    5803,
    "Centros Comerciales > Contratos > Estado del contrato > Adicionar"
}, {
    5804,
    "Centros Comerciales > Contratos > Estado del contrato > Consultar"
}, {
    5805,
    "Centros Comerciales > Contratos > Estado del contrato > Duplicar"
}, {
    5806,
    "Centros Comerciales > Contratos > Estado del contrato > Eliminar"
}, {
    5807,
    "Centros Comerciales > Contratos > Estado del contrato > Modificar"
}, {
    5808,
    "Centros Comerciales > Contratos > Estado del contrato > Reporte"
}, {
    6450,
    "Centros Comerciales > Contratos > Generacion Incrementos"
}, {
    6451,
    "Centros Comerciales > Contratos > Generacion Incrementos > Adicionar"
}, {
    6452,
    "Centros Comerciales > Contratos > Generacion Incrementos > Filtro"
}, {
    6453,
    "Centros Comerciales > Contratos > Generacion Incrementos > Generar"
}, {
    6446,
    "Centros Comerciales > Contratos > Impresion Contrato"
}, {
    6447,
    "Centros Comerciales > Contratos > Impresion Contrato > Adicionar"
}, {
    6448,
    "Centros Comerciales > Contratos > Impresion Contrato > Filtro"
}, {
    6449,
    "Centros Comerciales > Contratos > Impresion Contrato > Generar"
}, {
    6463,
    "Centros Comerciales > Contratos > Liberacion de Novedades"
}, {
    6464,
    "Centros Comerciales > Contratos > Liberacion de Novedades > Adicionar"
}, {
    6465,
    "Centros Comerciales > Contratos > Liberacion de Novedades > Filtro"
}, {
    6466,
    "Centros Comerciales > Contratos > Liberacion de Novedades > Generar"
}, {
    6515,
    "Centros Comerciales > Contratos > Reporte de Contratos"
}, {
    6516,
    "Centros Comerciales > Contratos > Reporte de Contratos > Adicionar"
}, {
    6517,
    "Centros Comerciales > Contratos > Reporte de Contratos > Consultar"
}, {
    6518,
    "Centros Comerciales > Contratos > Reporte de Contratos > Duplicar"
}, {
    6519,
    "Centros Comerciales > Contratos > Reporte de Contratos > Eliminar"
}, {
    6520,
    "Centros Comerciales > Contratos > Reporte de Contratos > Modificar"
}, {
    6521,
    "Centros Comerciales > Contratos > Reporte de Contratos > Reporte"
}, {
    6456,
    "Centros Comerciales > Contratos > Reporte de Novedades retenidas"
}, {
    6457,
    "Centros Comerciales > Contratos > Reporte de Novedades retenidas > Adicionar"
}, {
    6458,
    "Centros Comerciales > Contratos > Reporte de Novedades retenidas > Consultar"
}, {
    6459,
    "Centros Comerciales > Contratos > Reporte de Novedades retenidas > Duplicar"
}, {
    6460,
    "Centros Comerciales > Contratos > Reporte de Novedades retenidas > Eliminar"
}, {
    6461,
    "Centros Comerciales > Contratos > Reporte de Novedades retenidas > Modificar"
}, {
    6462,
    "Centros Comerciales > Contratos > Reporte de Novedades retenidas > Reporte"
}, {
    5506,
    "Centros Comerciales > Contratos > Tipos de amparo"
}, {
    5821,
    "Centros Comerciales > Contratos > Tipos de amparo > Adicionar"
}, {
    5822,
    "Centros Comerciales > Contratos > Tipos de amparo > Consultar"
}, {
    5823,
    "Centros Comerciales > Contratos > Tipos de amparo > Duplicar"
}, {
    5824,
    "Centros Comerciales > Contratos > Tipos de amparo > Eliminar"
}, {
    5825,
    "Centros Comerciales > Contratos > Tipos de amparo > Modificar"
}, {
    5826,
    "Centros Comerciales > Contratos > Tipos de amparo > Reporte"
}, {
    5500,
    "Centros Comerciales > Contratos > Tipos de contrato"
}, {
    5785,
    "Centros Comerciales > Contratos > Tipos de contrato > Adicionar"
}, {
    5786,
    "Centros Comerciales > Contratos > Tipos de contrato > Consultar"
}, {
    5787,
    "Centros Comerciales > Contratos > Tipos de contrato > Duplicar"
}, {
    5788,
    "Centros Comerciales > Contratos > Tipos de contrato > Eliminar"
}, {
    5789,
    "Centros Comerciales > Contratos > Tipos de contrato > Modificar"
}, {
    5790,
    "Centros Comerciales > Contratos > Tipos de contrato > Reporte"
}, {
    5504,
    "Centros Comerciales > Contratos > Tipos de sujetos"
}, {
    5809,
    "Centros Comerciales > Contratos > Tipos de sujetos > Adicionar"
}, {
    5810,
    "Centros Comerciales > Contratos > Tipos de sujetos > Consultar"
}, {
    5811,
    "Centros Comerciales > Contratos > Tipos de sujetos > Duplicar"
}, {
    5812,
    "Centros Comerciales > Contratos > Tipos de sujetos > Eliminar"
}, {
    5813,
    "Centros Comerciales > Contratos > Tipos de sujetos > Modificar"
}, {
    5814,
    "Centros Comerciales > Contratos > Tipos de sujetos > Reporte"
}, {
    5505,
    "Centros Comerciales > Contratos > Tipos de vigencia"
}, {
    5815,
    "Centros Comerciales > Contratos > Tipos de vigencia > Adicionar"
}, {
    5816,
    "Centros Comerciales > Contratos > Tipos de vigencia > Consultar"
}, {
    5817,
    "Centros Comerciales > Contratos > Tipos de vigencia > Duplicar"
}, {
    5818,
    "Centros Comerciales > Contratos > Tipos de vigencia > Eliminar"
}, {
    5819,
    "Centros Comerciales > Contratos > Tipos de vigencia > Modificar"
}, {
    5820,
    "Centros Comerciales > Contratos > Tipos de vigencia > Reporte"
}, {
    5509,
    "Centros Comerciales > Contratos > Consulta de Inmuebles en contratos"
}, {
    5839,
    "Centros Comerciales > Contratos > Consulta de Inmuebles en contratos > Adicionar"
}, {
    5840,
    "Centros Comerciales > Contratos > Consulta de Inmuebles en contratos > Consultar"
}, {
    5841,
    "Centros Comerciales > Contratos > Consulta de Inmuebles en contratos > Duplicar"
}, {
    5842,
    "Centros Comerciales > Contratos > Consulta de Inmuebles en contratos > Eliminar"
}, {
    5843,
    "Centros Comerciales > Contratos > Consulta de Inmuebles en contratos > Modificar"
}, {
    5844,
    "Centros Comerciales > Contratos > Consulta de Inmuebles en contratos > Procesar"
}, {
    4887,
    "Centros Comerciales > Facturacion"
}, {
    5480,
    "Centros Comerciales > Facturacion > Anulacion de facturas"
}, {
    5613,
    "Centros Comerciales > Facturacion > Anulacion de facturas > Adicionar"
}, {
    5614,
    "Centros Comerciales > Facturacion > Anulacion de facturas > Filtro"
}, {
    5615,
    "Centros Comerciales > Facturacion > Anulacion de facturas > Generar"
}, {
    7095,
    "Centros Comerciales > Facturacion > Apertura/Cierre de Lotes"
}, {
    7096,
    "Centros Comerciales > Facturacion > Apertura/Cierre de Lotes > Adicionar"
}, {
    7097,
    "Centros Comerciales > Facturacion > Apertura/Cierre de Lotes > Filtro"
}, {
    7098,
    "Centros Comerciales > Facturacion > Apertura/Cierre de Lotes > Generar"
}, {
    5492,
    "Centros Comerciales > Facturacion > Aprobación de Facturas"
}, {
    5673,
    "Centros Comerciales > Facturacion > Aprobación de Facturas > Adicionar"
}, {
    5674,
    "Centros Comerciales > Facturacion > Aprobación de Facturas > Filtro"
}, {
    5675,
    "Centros Comerciales > Facturacion > Aprobación de Facturas > Generar"
}, {
    5490,
    "Centros Comerciales > Facturacion > Consulta de Consumos"
}, {
    5664,
    "Centros Comerciales > Facturacion > Consulta de Consumos > Adicionar"
}, {
    5665,
    "Centros Comerciales > Facturacion > Consulta de Consumos > Consultar"
}, {
    5666,
    "Centros Comerciales > Facturacion > Consulta de Consumos > Duplicar"
}, {
    5667,
    "Centros Comerciales > Facturacion > Consulta de Consumos > Eliminar"
}, {
    5668,
    "Centros Comerciales > Facturacion > Consulta de Consumos > Modificar"
}, {
    5669,
    "Centros Comerciales > Facturacion > Consulta de Consumos > Procesar"
}, {
    5483,
    "Centros Comerciales > Facturacion > Consulta de Facturas"
}, {
    5622,
    "Centros Comerciales > Facturacion > Consulta de Facturas > Adicionar"
}, {
    5623,
    "Centros Comerciales > Facturacion > Consulta de Facturas > Consultar"
}, {
    5624,
    "Centros Comerciales > Facturacion > Consulta de Facturas > Duplicar"
}, {
    5625,
    "Centros Comerciales > Facturacion > Consulta de Facturas > Eliminar"
}, {
    5626,
    "Centros Comerciales > Facturacion > Consulta de Facturas > Modificar"
}, {
    5627,
    "Centros Comerciales > Facturacion > Consulta de Facturas > Procesar"
}, {
    5497,
    "Centros Comerciales > Facturacion > Consulta de Novedades"
}, {
    5694,
    "Centros Comerciales > Facturacion > Consulta de Novedades > Adicionar"
}, {
    5695,
    "Centros Comerciales > Facturacion > Consulta de Novedades > Consultar"
}, {
    5696,
    "Centros Comerciales > Facturacion > Consulta de Novedades > Duplicar"
}, {
    5697,
    "Centros Comerciales > Facturacion > Consulta de Novedades > Eliminar"
}, {
    5698,
    "Centros Comerciales > Facturacion > Consulta de Novedades > Modificar"
}, {
    5699,
    "Centros Comerciales > Facturacion > Consulta de Novedades > Procesar"
}, {
    5484,
    "Centros Comerciales > Facturacion > Consulta de Transacciones"
}, {
    5628,
    "Centros Comerciales > Facturacion > Consulta de Transacciones > Adicionar"
}, {
    5629,
    "Centros Comerciales > Facturacion > Consulta de Transacciones > Consultar"
}, {
    5630,
    "Centros Comerciales > Facturacion > Consulta de Transacciones > Duplicar"
}, {
    5631,
    "Centros Comerciales > Facturacion > Consulta de Transacciones > Eliminar"
}, {
    5632,
    "Centros Comerciales > Facturacion > Consulta de Transacciones > Modificar"
}, {
    5633,
    "Centros Comerciales > Facturacion > Consulta de Transacciones > Procesar"
}, {
    5498,
    "Centros Comerciales > Facturacion > Consulta de ventas variables"
}, {
    5700,
    "Centros Comerciales > Facturacion > Consulta de ventas variables > Adicionar"
}, {
    5701,
    "Centros Comerciales > Facturacion > Consulta de ventas variables > Consultar"
}, {
    5702,
    "Centros Comerciales > Facturacion > Consulta de ventas variables > Duplicar"
}, {
    5703,
    "Centros Comerciales > Facturacion > Consulta de ventas variables > Eliminar"
}, {
    5704,
    "Centros Comerciales > Facturacion > Consulta de ventas variables > Modificar"
}, {
    5705,
    "Centros Comerciales > Facturacion > Consulta de ventas variables > Procesar"
}, {
    5499,
    "Centros Comerciales > Facturacion > Facturas"
}, {
    5899,
    "Centros Comerciales > Facturacion > Facturas > Adicionar"
}, {
    5900,
    "Centros Comerciales > Facturacion > Facturas > Consultar"
}, {
    5901,
    "Centros Comerciales > Facturacion > Facturas > Duplicar"
}, {
    5902,
    "Centros Comerciales > Facturacion > Facturas > Eliminar"
}, {
    6928,
    "Centros Comerciales > Facturacion > Facturas > Impuestos de facturas"
}, {
    5903,
    "Centros Comerciales > Facturacion > Facturas > Modificar"
}, {
    6926,
    "Centros Comerciales > Facturacion > Facturas > Novedades  de facturas"
}, {
    5904,
    "Centros Comerciales > Facturacion > Facturas > Reporte"
}, {
    6927,
    "Centros Comerciales > Facturacion > Facturas > Retenciones de facturas"
}, {
    5479,
    "Centros Comerciales > Facturacion > Generacion de facturas"
}, {
    5610,
    "Centros Comerciales > Facturacion > Generacion de facturas > Adicionar"
}, {
    5611,
    "Centros Comerciales > Facturacion > Generacion de facturas > Filtro"
}, {
    5612,
    "Centros Comerciales > Facturacion > Generacion de facturas > Generar"
}, {
    6475,
    "Centros Comerciales > Facturacion > Generacion Plano de Facturas"
}, {
    6476,
    "Centros Comerciales > Facturacion > Generacion Plano de Facturas > Adicionar"
}, {
    6477,
    "Centros Comerciales > Facturacion > Generacion Plano de Facturas > Filtro"
}, {
    6478,
    "Centros Comerciales > Facturacion > Generacion Plano de Facturas > Generar"
}, {
    5482,
    "Centros Comerciales > Facturacion > Impresion de facturas"
}, {
    5619,
    "Centros Comerciales > Facturacion > Impresion de facturas > Adicionar"
}, {
    5620,
    "Centros Comerciales > Facturacion > Impresion de facturas > Filtro"
}, {
    5621,
    "Centros Comerciales > Facturacion > Impresion de facturas > Generar"
}, {
    5489,
    "Centros Comerciales > Facturacion > Informe Diario de Ventas"
}, {
    5658,
    "Centros Comerciales > Facturacion > Informe Diario de Ventas > Adicionar"
}, {
    5659,
    "Centros Comerciales > Facturacion > Informe Diario de Ventas > Consultar"
}, {
    5660,
    "Centros Comerciales > Facturacion > Informe Diario de Ventas > Duplicar"
}, {
    5661,
    "Centros Comerciales > Facturacion > Informe Diario de Ventas > Eliminar"
}, {
    5662,
    "Centros Comerciales > Facturacion > Informe Diario de Ventas > Modificar"
}, {
    5663,
    "Centros Comerciales > Facturacion > Informe Diario de Ventas > Reporte"
}, {
    5478,
    "Centros Comerciales > Facturacion > Lotes de Facturacion"
}, {
    5604,
    "Centros Comerciales > Facturacion > Lotes de Facturacion > Adicionar"
}, {
    5605,
    "Centros Comerciales > Facturacion > Lotes de Facturacion > Consultar"
}, {
    5606,
    "Centros Comerciales > Facturacion > Lotes de Facturacion > Duplicar"
}, {
    5607,
    "Centros Comerciales > Facturacion > Lotes de Facturacion > Eliminar"
}, {
    5608,
    "Centros Comerciales > Facturacion > Lotes de Facturacion > Modificar"
}, {
    5609,
    "Centros Comerciales > Facturacion > Lotes de Facturacion > Reporte"
}, {
    6467,
    "Centros Comerciales > Facturacion > Notas Credito con base en Facturas"
}, {
    6468,
    "Centros Comerciales > Facturacion > Notas Credito con base en Facturas > Adicionar"
}, {
    6469,
    "Centros Comerciales > Facturacion > Notas Credito con base en Facturas > Consultar"
}, {
    6470,
    "Centros Comerciales > Facturacion > Notas Credito con base en Facturas > Duplicar"
}, {
    6471,
    "Centros Comerciales > Facturacion > Notas Credito con base en Facturas > Eliminar"
}, {
    6538,
    "Centros Comerciales > Facturacion > Notas Credito con base en Facturas > Filtro"
}, {
    6539,
    "Centros Comerciales > Facturacion > Notas Credito con base en Facturas > Generar"
}, {
    6472,
    "Centros Comerciales > Facturacion > Notas Credito con base en Facturas > Modificar"
}, {
    6473,
    "Centros Comerciales > Facturacion > Notas Credito con base en Facturas > Reporte"
}, {
    5495,
    "Centros Comerciales > Facturacion > Novedades con base en cxc"
}, {
    5685,
    "Centros Comerciales > Facturacion > Novedades con base en cxc > Adicionar"
}, {
    5686,
    "Centros Comerciales > Facturacion > Novedades con base en cxc > Filtro"
}, {
    5687,
    "Centros Comerciales > Facturacion > Novedades con base en cxc > Generar"
}, {
    5494,
    "Centros Comerciales > Facturacion > Novedades Genericas"
}, {
    5682,
    "Centros Comerciales > Facturacion > Novedades Genericas > Adicionar"
}, {
    5683,
    "Centros Comerciales > Facturacion > Novedades Genericas > Filtro"
}, {
    5684,
    "Centros Comerciales > Facturacion > Novedades Genericas > Generar"
}, {
    5493,
    "Centros Comerciales > Facturacion > Novedades Individuales"
}, {
    5676,
    "Centros Comerciales > Facturacion > Novedades Individuales > Adicionar"
}, {
    5677,
    "Centros Comerciales > Facturacion > Novedades Individuales > Consultar"
}, {
    5678,
    "Centros Comerciales > Facturacion > Novedades Individuales > Duplicar"
}, {
    5679,
    "Centros Comerciales > Facturacion > Novedades Individuales > Eliminar"
}, {
    5680,
    "Centros Comerciales > Facturacion > Novedades Individuales > Modificar"
}, {
    5681,
    "Centros Comerciales > Facturacion > Novedades Individuales > Reporte"
}, {
    5477,
    "Centros Comerciales > Facturacion > Novedades Retiro"
}, {
    5601,
    "Centros Comerciales > Facturacion > Novedades Retiro > Adicionar"
}, {
    5602,
    "Centros Comerciales > Facturacion > Novedades Retiro > Filtro"
}, {
    5603,
    "Centros Comerciales > Facturacion > Novedades Retiro > Generar"
}, {
    5491,
    "Centros Comerciales > Facturacion > Procesos Especiales"
}, {
    5670,
    "Centros Comerciales > Facturacion > Procesos Especiales > Adicionar"
}, {
    5671,
    "Centros Comerciales > Facturacion > Procesos Especiales > Filtro"
}, {
    5672,
    "Centros Comerciales > Facturacion > Procesos Especiales > Generar"
}, {
    5488,
    "Centros Comerciales > Facturacion > Reporte de Consumos"
}, {
    5652,
    "Centros Comerciales > Facturacion > Reporte de Consumos > Adicionar"
}, {
    5653,
    "Centros Comerciales > Facturacion > Reporte de Consumos > Consultar"
}, {
    5654,
    "Centros Comerciales > Facturacion > Reporte de Consumos > Duplicar"
}, {
    5655,
    "Centros Comerciales > Facturacion > Reporte de Consumos > Eliminar"
}, {
    5656,
    "Centros Comerciales > Facturacion > Reporte de Consumos > Modificar"
}, {
    5657,
    "Centros Comerciales > Facturacion > Reporte de Consumos > Reporte"
}, {
    5487,
    "Centros Comerciales > Facturacion > Reporte de Facturas"
}, {
    5646,
    "Centros Comerciales > Facturacion > Reporte de Facturas > Adicionar"
}, {
    5647,
    "Centros Comerciales > Facturacion > Reporte de Facturas > Consultar"
}, {
    5648,
    "Centros Comerciales > Facturacion > Reporte de Facturas > Duplicar"
}, {
    5649,
    "Centros Comerciales > Facturacion > Reporte de Facturas > Eliminar"
}, {
    5650,
    "Centros Comerciales > Facturacion > Reporte de Facturas > Modificar"
}, {
    5651,
    "Centros Comerciales > Facturacion > Reporte de Facturas > Reporte"
}, {
    5485,
    "Centros Comerciales > Facturacion > Reporte de Novedades"
}, {
    5634,
    "Centros Comerciales > Facturacion > Reporte de Novedades > Adicionar"
}, {
    5635,
    "Centros Comerciales > Facturacion > Reporte de Novedades > Consultar"
}, {
    5636,
    "Centros Comerciales > Facturacion > Reporte de Novedades > Duplicar"
}, {
    5637,
    "Centros Comerciales > Facturacion > Reporte de Novedades > Eliminar"
}, {
    5638,
    "Centros Comerciales > Facturacion > Reporte de Novedades > Modificar"
}, {
    5639,
    "Centros Comerciales > Facturacion > Reporte de Novedades > Reporte"
}, {
    5486,
    "Centros Comerciales > Facturacion > Reporte de ventas variables"
}, {
    5640,
    "Centros Comerciales > Facturacion > Reporte de ventas variables > Adicionar"
}, {
    5641,
    "Centros Comerciales > Facturacion > Reporte de ventas variables > Consultar"
}, {
    5642,
    "Centros Comerciales > Facturacion > Reporte de ventas variables > Duplicar"
}, {
    5643,
    "Centros Comerciales > Facturacion > Reporte de ventas variables > Eliminar"
}, {
    5644,
    "Centros Comerciales > Facturacion > Reporte de ventas variables > Modificar"
}, {
    5645,
    "Centros Comerciales > Facturacion > Reporte de ventas variables > Reporte"
}, {
    5481,
    "Centros Comerciales > Facturacion > Retiro de Facturas"
}, {
    5616,
    "Centros Comerciales > Facturacion > Retiro de Facturas > Adicionar"
}, {
    5617,
    "Centros Comerciales > Facturacion > Retiro de Facturas > Filtro"
}, {
    5618,
    "Centros Comerciales > Facturacion > Retiro de Facturas > Generar"
}, {
    5496,
    "Centros Comerciales > Facturacion > Ventas variables"
}, {
    5688,
    "Centros Comerciales > Facturacion > Ventas variables > Adicionar"
}, {
    5689,
    "Centros Comerciales > Facturacion > Ventas variables > Consultar"
}, {
    5690,
    "Centros Comerciales > Facturacion > Ventas variables > Duplicar"
}, {
    5691,
    "Centros Comerciales > Facturacion > Ventas variables > Eliminar"
}, {
    5692,
    "Centros Comerciales > Facturacion > Ventas variables > Modificar"
}, {
    5693,
    "Centros Comerciales > Facturacion > Ventas variables > Reporte"
}, {
    6527,
    "Centros Comerciales > Facturacion > Ventas Variables"
}, {
    6528,
    "Centros Comerciales > Facturacion > Ventas Variables > Adicionar"
}, {
    6529,
    "Centros Comerciales > Facturacion > Ventas Variables > Consultar"
}, {
    6530,
    "Centros Comerciales > Facturacion > Ventas Variables > Duplicar"
}, {
    6531,
    "Centros Comerciales > Facturacion > Ventas Variables > Eliminar"
}, {
    6532,
    "Centros Comerciales > Facturacion > Ventas Variables > Modificar"
}, {
    6533,
    "Centros Comerciales > Facturacion > Ventas Variables > Reporte"
}, {
    5473,
    "Centros Comerciales > Maestros > Categoria por tarifa"
}, {
    5589,
    "Centros Comerciales > Maestros > Categoria por tarifa > Adicionar"
}, {
    5590,
    "Centros Comerciales > Maestros > Categoria por tarifa > Consultar"
}, {
    5591,
    "Centros Comerciales > Maestros > Categoria por tarifa > Duplicar"
}, {
    5592,
    "Centros Comerciales > Maestros > Categoria por tarifa > Eliminar"
}, {
    5593,
    "Centros Comerciales > Maestros > Categoria por tarifa > Modificar"
}, {
    5594,
    "Centros Comerciales > Maestros > Categoria por tarifa > Reporte"
}, {
    4886,
    "Centros Comerciales > Maestros"
}, {
    5468,
    "Centros Comerciales > Maestros > Conceptos"
}, {
    5559,
    "Centros Comerciales > Maestros > Conceptos > Adicionar"
}, {
    5560,
    "Centros Comerciales > Maestros > Conceptos > Consultar"
}, {
    5561,
    "Centros Comerciales > Maestros > Conceptos > Duplicar"
}, {
    5562,
    "Centros Comerciales > Maestros > Conceptos > Eliminar"
}, {
    5563,
    "Centros Comerciales > Maestros > Conceptos > Modificar"
}, {
    5564,
    "Centros Comerciales > Maestros > Conceptos > Reporte"
}, {
    5470,
    "Centros Comerciales > Maestros > Consulta de conceptos"
}, {
    5571,
    "Centros Comerciales > Maestros > Consulta de conceptos > Adicionar"
}, {
    5572,
    "Centros Comerciales > Maestros > Consulta de conceptos > Consultar"
}, {
    5573,
    "Centros Comerciales > Maestros > Consulta de conceptos > Duplicar"
}, {
    5574,
    "Centros Comerciales > Maestros > Consulta de conceptos > Eliminar"
}, {
    5575,
    "Centros Comerciales > Maestros > Consulta de conceptos > Modificar"
}, {
    5576,
    "Centros Comerciales > Maestros > Consulta de conceptos > Procesar"
}, {
    5474,
    "Centros Comerciales > Maestros > Consulta de Inmuebles"
}, {
    5595,
    "Centros Comerciales > Maestros > Consulta de Inmuebles > Adicionar"
}, {
    5596,
    "Centros Comerciales > Maestros > Consulta de Inmuebles > Consultar"
}, {
    5597,
    "Centros Comerciales > Maestros > Consulta de Inmuebles > Duplicar"
}, {
    5598,
    "Centros Comerciales > Maestros > Consulta de Inmuebles > Eliminar"
}, {
    5599,
    "Centros Comerciales > Maestros > Consulta de Inmuebles > Modificar"
}, {
    5600,
    "Centros Comerciales > Maestros > Consulta de Inmuebles > Procesar"
}, {
    5471,
    "Centros Comerciales > Maestros > Consulta de Maestros"
}, {
    5577,
    "Centros Comerciales > Maestros > Consulta de Maestros > Adicionar"
}, {
    5578,
    "Centros Comerciales > Maestros > Consulta de Maestros > Consultar"
}, {
    5579,
    "Centros Comerciales > Maestros > Consulta de Maestros > Duplicar"
}, {
    5580,
    "Centros Comerciales > Maestros > Consulta de Maestros > Eliminar"
}, {
    5581,
    "Centros Comerciales > Maestros > Consulta de Maestros > Modificar"
}, {
    5582,
    "Centros Comerciales > Maestros > Consulta de Maestros > Procesar"
}, {
    5475,
    "Centros Comerciales > Maestros > Equivalencias de Impuestos"
}, {
    5887,
    "Centros Comerciales > Maestros > Equivalencias de Impuestos > Adicionar"
}, {
    5888,
    "Centros Comerciales > Maestros > Equivalencias de Impuestos > Consultar"
}, {
    5889,
    "Centros Comerciales > Maestros > Equivalencias de Impuestos > Duplicar"
}, {
    5890,
    "Centros Comerciales > Maestros > Equivalencias de Impuestos > Eliminar"
}, {
    5891,
    "Centros Comerciales > Maestros > Equivalencias de Impuestos > Modificar"
}, {
    5892,
    "Centros Comerciales > Maestros > Equivalencias de Impuestos > Reporte"
}, {
    5476,
    "Centros Comerciales > Maestros > Equivalencias de Retenciones"
}, {
    5893,
    "Centros Comerciales > Maestros > Equivalencias de Retenciones > Adicionar"
}, {
    5894,
    "Centros Comerciales > Maestros > Equivalencias de Retenciones > Consultar"
}, {
    5895,
    "Centros Comerciales > Maestros > Equivalencias de Retenciones > Duplicar"
}, {
    5896,
    "Centros Comerciales > Maestros > Equivalencias de Retenciones > Eliminar"
}, {
    5897,
    "Centros Comerciales > Maestros > Equivalencias de Retenciones > Modificar"
}, {
    5898,
    "Centros Comerciales > Maestros > Equivalencias de Retenciones > Reporte"
}, {
    5462,
    "Centros Comerciales > Maestros > Estados de Inmuebles"
}, {
    5523,
    "Centros Comerciales > Maestros > Estados de Inmuebles > Adicionar"
}, {
    5524,
    "Centros Comerciales > Maestros > Estados de Inmuebles > Consultar"
}, {
    5525,
    "Centros Comerciales > Maestros > Estados de Inmuebles > Duplicar"
}, {
    5526,
    "Centros Comerciales > Maestros > Estados de Inmuebles > Eliminar"
}, {
    5527,
    "Centros Comerciales > Maestros > Estados de Inmuebles > Modificar"
}, {
    5528,
    "Centros Comerciales > Maestros > Estados de Inmuebles > Reporte"
}, {
    5467,
    "Centros Comerciales > Maestros > Inmuebles"
}, {
    5553,
    "Centros Comerciales > Maestros > Inmuebles > Adicionar"
}, {
    5554,
    "Centros Comerciales > Maestros > Inmuebles > Consultar"
}, {
    5555,
    "Centros Comerciales > Maestros > Inmuebles > Duplicar"
}, {
    5556,
    "Centros Comerciales > Maestros > Inmuebles > Eliminar"
}, {
    5557,
    "Centros Comerciales > Maestros > Inmuebles > Modificar"
}, {
    5558,
    "Centros Comerciales > Maestros > Inmuebles > Reporte"
}, {
    6428,
    "Centros Comerciales > Maestros > Monedas"
}, {
    6429,
    "Centros Comerciales > Maestros > Monedas > Adicionar"
}, {
    6430,
    "Centros Comerciales > Maestros > Monedas > Consultar"
}, {
    6431,
    "Centros Comerciales > Maestros > Monedas > Duplicar"
}, {
    6432,
    "Centros Comerciales > Maestros > Monedas > Eliminar"
}, {
    6433,
    "Centros Comerciales > Maestros > Monedas > Modificar"
}, {
    6434,
    "Centros Comerciales > Maestros > Monedas > Reporte"
}, {
    5460,
    "Centros Comerciales > Maestros > Parametros por año"
}, {
    5511,
    "Centros Comerciales > Maestros > Parametros por año > Adicionar"
}, {
    5512,
    "Centros Comerciales > Maestros > Parametros por año > Consultar"
}, {
    5513,
    "Centros Comerciales > Maestros > Parametros por año > Duplicar"
}, {
    5514,
    "Centros Comerciales > Maestros > Parametros por año > Eliminar"
}, {
    5515,
    "Centros Comerciales > Maestros > Parametros por año > Modificar"
}, {
    5516,
    "Centros Comerciales > Maestros > Parametros por año > Reporte"
}, {
    5472,
    "Centros Comerciales > Maestros > Parametros por compañia"
}, {
    5583,
    "Centros Comerciales > Maestros > Parametros por compañia > Adicionar"
}, {
    5584,
    "Centros Comerciales > Maestros > Parametros por compañia > Consultar"
}, {
    5585,
    "Centros Comerciales > Maestros > Parametros por compañia > Duplicar"
}, {
    5586,
    "Centros Comerciales > Maestros > Parametros por compañia > Eliminar"
}, {
    5587,
    "Centros Comerciales > Maestros > Parametros por compañia > Modificar"
}, {
    5588,
    "Centros Comerciales > Maestros > Parametros por compañia > Reporte"
}, {
    5469,
    "Centros Comerciales > Maestros > Tipos de conceptos de venta"
}, {
    5565,
    "Centros Comerciales > Maestros > Tipos de conceptos de venta > Adicionar"
}, {
    5566,
    "Centros Comerciales > Maestros > Tipos de conceptos de venta > Consultar"
}, {
    5567,
    "Centros Comerciales > Maestros > Tipos de conceptos de venta > Duplicar"
}, {
    5568,
    "Centros Comerciales > Maestros > Tipos de conceptos de venta > Eliminar"
}, {
    5569,
    "Centros Comerciales > Maestros > Tipos de conceptos de venta > Modificar"
}, {
    5570,
    "Centros Comerciales > Maestros > Tipos de conceptos de venta > Reporte"
}, {
    5461,
    "Centros Comerciales > Maestros > Tipos de Inmuebles"
}, {
    5518,
    "Centros Comerciales > Maestros > Tipos de Inmuebles > Adicionar"
}, {
    5519,
    "Centros Comerciales > Maestros > Tipos de Inmuebles > Consultar"
}, {
    5520,
    "Centros Comerciales > Maestros > Tipos de Inmuebles > Duplicar"
}, {
    5521,
    "Centros Comerciales > Maestros > Tipos de Inmuebles > Eliminar"
}, {
    5522,
    "Centros Comerciales > Maestros > Tipos de Inmuebles > Modificar"
}, {
    5517,
    "Centros Comerciales > Maestros > Tipos de Inmuebles > Reporte"
}, {
    5465,
    "Centros Comerciales > Maestros > Tipos de Presupuesto"
}, {
    5541,
    "Centros Comerciales > Maestros > Tipos de Presupuesto > Adicionar"
}, {
    5542,
    "Centros Comerciales > Maestros > Tipos de Presupuesto > Consultar"
}, {
    5543,
    "Centros Comerciales > Maestros > Tipos de Presupuesto > Duplicar"
}, {
    5544,
    "Centros Comerciales > Maestros > Tipos de Presupuesto > Eliminar"
}, {
    5545,
    "Centros Comerciales > Maestros > Tipos de Presupuesto > Modificar"
}, {
    5546,
    "Centros Comerciales > Maestros > Tipos de Presupuesto > Reporte"
}, {
    5463,
    "Centros Comerciales > Maestros > Tipos de Propiedad"
}, {
    5529,
    "Centros Comerciales > Maestros > Tipos de Propiedad > Adicionar"
}, {
    5530,
    "Centros Comerciales > Maestros > Tipos de Propiedad > Consultar"
}, {
    5531,
    "Centros Comerciales > Maestros > Tipos de Propiedad > Duplicar"
}, {
    5532,
    "Centros Comerciales > Maestros > Tipos de Propiedad > Eliminar"
}, {
    5533,
    "Centros Comerciales > Maestros > Tipos de Propiedad > Modificar"
}, {
    5534,
    "Centros Comerciales > Maestros > Tipos de Propiedad > Reporte"
}, {
    5466,
    "Centros Comerciales > Maestros > Tipos de tarifas"
}, {
    5547,
    "Centros Comerciales > Maestros > Tipos de tarifas > Adicionar"
}, {
    5548,
    "Centros Comerciales > Maestros > Tipos de tarifas > Consultar"
}, {
    5549,
    "Centros Comerciales > Maestros > Tipos de tarifas > Duplicar"
}, {
    5550,
    "Centros Comerciales > Maestros > Tipos de tarifas > Eliminar"
}, {
    5551,
    "Centros Comerciales > Maestros > Tipos de tarifas > Modificar"
}, {
    5552,
    "Centros Comerciales > Maestros > Tipos de tarifas > Reporte"
}, {
    5464,
    "Centros Comerciales > Maestros > Ubicaciones de Inmuebles"
}, {
    5535,
    "Centros Comerciales > Maestros > Ubicaciones de Inmuebles > Adicionar"
}, {
    5536,
    "Centros Comerciales > Maestros > Ubicaciones de Inmuebles > Consultar"
}, {
    5537,
    "Centros Comerciales > Maestros > Ubicaciones de Inmuebles > Duplicar"
}, {
    5538,
    "Centros Comerciales > Maestros > Ubicaciones de Inmuebles > Eliminar"
}, {
    5539,
    "Centros Comerciales > Maestros > Ubicaciones de Inmuebles > Modificar"
}, {
    5540,
    "Centros Comerciales > Maestros > Ubicaciones de Inmuebles > Reporte"
}, {
    4881,
    "Centros Comerciales"
}, {
    1383,
    "Comercial - Compras"
}, {
    3411,
    "Comercial - Compras > Acumulados"
}, {
    3412,
    "Comercial - Compras > Acumulados > Cubo de compras"
}, {
    4249,
    "Comercial - Compras > Acumulados > Cubo de compras sumarizado"
}, {
    1477,
    "Comercial - Compras > Ajustes de compra por entrada"
}, {
    1478,
    "Comercial - Compras > Ajustes de compra por entrada > Adicionar"
}, {
    4677,
    "Comercial - Compras > Ajustes de compra por entrada > Permitir ajuste en valor cuando no hay existencia"
}, {
    1479,
    "Comercial - Compras > Ajustes de compra por entrada > Anular"
}, {
    1480,
    "Comercial - Compras > Ajustes de compra por entrada > Aprobar"
}, {
    1481,
    "Comercial - Compras > Ajustes de compra por entrada > Consultar"
}, {
    3560,
    "Comercial - Compras > Ajustes de compra por entrada > Permitir documentos sin referencia"
}, {
    1482,
    "Comercial - Compras > Ajustes de compra por entrada > Habilitar impresión"
}, {
    1483,
    "Comercial - Compras > Ajustes de compra por entrada > Imprimir"
}, {
    1484,
    "Comercial - Compras > Ajustes de compra por entrada > Modificar"
}, {
    4275,
    "Comercial - Compras > Ajustes de compra por entrada > Modificar entidades dinámicas en doctos aprobados"
}, {
    3740,
    "Comercial - Compras > Ajustes de compra por entrada > Permitir mandatos de diferente C.O."
}, {
    1493,
    "Comercial - Compras > Ajustes de compra por salida"
}, {
    1494,
    "Comercial - Compras > Ajustes de compra por salida > Adicionar"
}, {
    1495,
    "Comercial - Compras > Ajustes de compra por salida > Anular"
}, {
    1496,
    "Comercial - Compras > Ajustes de compra por salida > Aprobar"
}, {
    1497,
    "Comercial - Compras > Ajustes de compra por salida > Consultar"
}, {
    3561,
    "Comercial - Compras > Ajustes de compra por salida > Permitir documentos sin referencia"
}, {
    1500,
    "Comercial - Compras > Ajustes de compra por salida > Habilitar impresión"
}, {
    1498,
    "Comercial - Compras > Ajustes de compra por salida > Imprimir"
}, {
    1499,
    "Comercial - Compras > Ajustes de compra por salida > Modificar"
}, {
    4276,
    "Comercial - Compras > Ajustes de compra por salida > Modificar entidades dinámicas en doctos aprobados"
}, {
    3741,
    "Comercial - Compras > Ajustes de compra por salida > Permitir mandatos de diferente C.O."
}, {
    3940,
    "Comercial - Compras > Analisis proveedor"
}, {
    3941,
    "Comercial - Compras > Analisis proveedor > Calcular dias promedio de pago"
}, {
    3942,
    "Comercial - Compras > Analisis proveedor > Permitir consultar cartera"
}, {
    3945,
    "Comercial - Compras > Analisis proveedor > Permitir consultar compras"
}, {
    3944,
    "Comercial - Compras > Analisis proveedor > Permitir consultar ordenes"
}, {
    3943,
    "Comercial - Compras > Analisis proveedor > Permitir consultar proveedor"
}, {
    6497,
    "Comercial - Compras > Aprobar ordenes de compra"
}, {
    3536,
    "Comercial - Compras > Aprobar ordenes de compra retenidas"
}, {
    3537,
    "Comercial - Compras > Aprobar ordenes de compra retenidas > Aprobar ordenes retenidas por monto"
}, {
    3539,
    "Comercial - Compras > Aprobar ordenes de compra retenidas > Mostrar ordenes de compra financiero"
}, {
    3538,
    "Comercial - Compras > Aprobar ordenes de compra retenidas > Aprobar ordenes retenidas por presupuesto"
}, {
    12800,
    "Comercial - Compras > Aprobar ordenes de compra retenidas > Aprobar órdenes de compra retenidas por proyecto"
}, {
    4625,
    "Comercial - Compras > Aprobación de solicitudes de compra"
}, {
    4626,
    "Comercial - Compras > Aprobación de solicitudes de compra retenidas"
}, {
    4751,
    "Comercial - Compras > Apropiación"
}, {
    4757,
    "Comercial - Compras > Habilitar impresión documentos > Habilitar impresión apropiaciones"
}, {
    4758,
    "Comercial - Compras > Imprimir documentos > Imprimir apropiaciones"
}, {
    4752,
    "Comercial - Compras > Apropiación > Adicionar"
}, {
    4753,
    "Comercial - Compras > Apropiación > Anular"
}, {
    4754,
    "Comercial - Compras > Apropiación > Aprobar"
}, {
    4755,
    "Comercial - Compras > Apropiación > Consultar"
}, {
    4756,
    "Comercial - Compras > Apropiación > Modificar"
}, {
    9710,
    "Comercial - Compras > Automatización de documentos"
}, {
    12080,
    "Comercial - Compras > Cancelación de saldos de importación"
}, {
    12081,
    "Comercial - Compras > Cancelación de saldos de importación > Adicionar"
}, {
    12082,
    "Comercial - Compras > Cancelación de saldos de importación > Anular"
}, {
    12083,
    "Comercial - Compras > Cancelación de saldos de importación > Aprobar"
}, {
    12084,
    "Comercial - Compras > Cancelación de saldos de importación > Bloquea ajuste en costo cuando no hay existencia"
}, {
    12085,
    "Comercial - Compras > Cancelación de saldos de importación > Consultar"
}, {
    12090,
    "Comercial - Compras > Cancelación de saldos de importación > Permitir documentos sin referencia"
}, {
    12086,
    "Comercial - Compras > Cancelación de saldos de importación > Habilitar impresión"
}, {
    12087,
    "Comercial - Compras > Cancelación de saldos de importación > Imprimir"
}, {
    12088,
    "Comercial - Compras > Cancelación de saldos de importación > Modificar"
}, {
    12089,
    "Comercial - Compras > Cancelación de saldos de importación > Modificar entidades dinámicas en doctos aprobado"
}, {
    1501,
    "Comercial - Compras > Consultas"
}, {
    4576,
    "Comercial - Compras > Consultas > Activaciones de kanban"
}, {
    4535,
    "Comercial - Compras > Consultas > Análisis de kanban"
}, {
    4761,
    "Comercial - Compras > Consultas > Apropiación"
}, {
    4762,
    "Comercial - Compras > Consultas > Apropiación por ítem"
}, {
    3048,
    "Comercial - Compras > Consultas > Consignación por documento"
}, {
    2818,
    "Comercial - Compras > Consultas > Consignación recibida"
}, {
    1506,
    "Comercial - Compras > Consultas > Cotizaciones"
}, {
    3623,
    "Comercial - Compras > Consultas > Cotizaciones por cantidad de descuento"
}, {
    1512,
    "Comercial - Compras > Consultas > Análisis de cumplimiento de ordenes"
}, {
    1508,
    "Comercial - Compras > Consultas > Documentos de compra"
}, {
    1511,
    "Comercial - Compras > Consultas > Documentos de compra por item"
}, {
    10616,
    "Comercial - Compras > Consultas > Entidades de documentos"
}, {
    1513,
    "Comercial - Compras > Consultas > Facturas y notas de proveedor"
}, {
    11773,
    "Comercial - Compras > Consultas > Importaciones"
}, {
    4573,
    "Comercial - Compras > Consultas > Oferta de proveedores"
}, {
    1504,
    "Comercial - Compras > Consultas > Ordenes de compra"
}, {
    1505,
    "Comercial - Compras > Consultas > Ordenes de compra por item"
}, {
    8083,
    "Comercial - Compras > Consultas > Ordenes de compra por item > Modificar notas"
}, {
    8084,
    "Comercial - Compras > Consultas > Ordenes de compra por item > Modificar notas > Permitir modificar la fecha de entrega"
}, {
    10667,
    "Comercial - Compras > Consultas > Órdenes de compra - tracking"
}, {
    9190,
    "Comercial - Compras > Consultas > Reporte de seriales"
}, {
    7034,
    "Comercial - Compras > Consultas > Resumen de documentos de compra"
}, {
    2821,
    "Comercial - Compras > Consultas > Resumen de liquidacion de fletes"
}, {
    3193,
    "Comercial - Compras > Consultas > Seguimiento de documentos"
}, {
    1502,
    "Comercial - Compras > Consultas > Solicitudes de compra"
}, {
    1503,
    "Comercial - Compras > Consultas > Solicitudes de compra por item"
}, {
    4571,
    "Comercial - Compras > Consultas > Solicitudes de oferta"
}, {
    4572,
    "Comercial - Compras > Consultas > Solicitudes de oferta por ítem"
}, {
    1575,
    "Comercial - Compras > Consultas > Valoración de solicitud de compra"
}, {
    4570,
    "Comercial - Compras > Cuadro comparativo"
}, {
    12069,
    "-No implementado > Dar por cumplida una importación"
}, {
    12070,
    "-No implementado > Dar por cumplida una importación > Adicionar"
}, {
    12071,
    "-No implementado > Dar por cumplida una importación > Anular"
}, {
    12072,
    "-No implementado > Dar por cumplida una importación > Aprobar"
}, {
    12073,
    "-No implementado > Dar por cumplida una importación > Bloquea ajuste en costo cuando no hay existencia"
}, {
    12074,
    "-No implementado > Dar por cumplida una importación > Consultar"
}, {
    12079,
    "-No implementado > Dar por cumplida una importación > Permitir documentos sin referencia"
}, {
    12075,
    "-No implementado > Dar por cumplida una importación > Habilitar impresión"
}, {
    12076,
    "-No implementado > Dar por cumplida una importación > Imprimir"
}, {
    12077,
    "-No implementado > Dar por cumplida una importación > Modificar"
}, {
    12078,
    "-No implementado > Dar por cumplida una importación > Modificar entidades dinámicas en doctos aprobado"
}, {
    6514,
    "Comercial - Compras > Dar por cumplidas ordenes de compra"
}, {
    4627,
    "Comercial - Compras > Dar por cumplida solicitudes de compra"
}, {
    1485,
    "Comercial - Compras > Devoluciones desde entradas"
}, {
    1486,
    "Comercial - Compras > Devoluciones desde entradas > Adicionar"
}, {
    1487,
    "Comercial - Compras > Devoluciones desde entradas > Anular"
}, {
    1488,
    "Comercial - Compras > Devoluciones desde entradas > Aprobar"
}, {
    12572,
    "Comercial - Compras > Devoluciones desde entradas > Asumir costo para entradas con ajuste pronto pago"
}, {
    1489,
    "Comercial - Compras > Devoluciones desde entradas > Consultar"
}, {
    8886,
    "Comercial - Compras > Devoluciones desde entradas > Presentar costos de la transacción"
}, {
    3562,
    "Comercial - Compras > Devoluciones desde entradas > Permitir documentos sin referencia"
}, {
    1490,
    "Comercial - Compras > Devoluciones desde entradas > Habilitar impresión"
}, {
    1491,
    "Comercial - Compras > Devoluciones desde entradas > Imprimir"
}, {
    1492,
    "Comercial - Compras > Devoluciones desde entradas > Modificar"
}, {
    4268,
    "Comercial - Compras > Devoluciones desde entradas > Modificar entidades dinámicas en doctos aprobados"
}, {
    6944,
    "Comercial - Compras > Devoluciones desde entradas > Permitir devoluciones con saldo en costo"
}, {
    3738,
    "Comercial - Compras > Devoluciones desde entradas > Permitir mandatos de diferentes C.O."
}, {
    6419,
    "Comercial - Compras > Devoluciones desde entradas > Permitir modificar valores"
}, {
    3279,
    "Comercial - Compras > Devoluciones directas"
}, {
    3280,
    "Comercial - Compras > Devoluciones directas > Adicionar"
}, {
    3287,
    "Comercial - Compras > Devoluciones directas > Alterar precios"
}, {
    3281,
    "Comercial - Compras > Devoluciones directas > Anular"
}, {
    3282,
    "Comercial - Compras > Devoluciones directas > Aprobar"
}, {
    7802,
    "Comercial - Compras > Devoluciones directas > Capturar cantidad en código de barras automático"
}, {
    3283,
    "Comercial - Compras > Devoluciones directas > Consultar"
}, {
    8823,
    "Comercial - Compras > Devoluciones directas > Presentar costos de la transacción"
}, {
    3563,
    "Comercial - Compras > Devoluciones directas > Permitir documentos sin referencia"
}, {
    7741,
    "Comercial - Compras > Devoluciones directas > Exigir devoluciones del mismo proveedor"
}, {
    3284,
    "Comercial - Compras > Devoluciones directas > Habilitar impresion"
}, {
    3285,
    "Comercial - Compras > Devoluciones directas > Imprimir"
}, {
    3286,
    "Comercial - Compras > Devoluciones directas > Modificar"
}, {
    4269,
    "Comercial - Compras > Devoluciones directas > Modificar entidades dinámicas en doctos aprobados"
}, {
    6945,
    "Comercial - Compras > Devoluciones directas > Permitir devoluciones con saldo en costo"
}, {
    3739,
    "Comercial - Compras > Devoluciones directas > Permitir mandatos de diferentes C.O."
}, {
    4673,
    "Comercial - Compras > Devoluciones directas > Sugerir costo promedio de ítem"
}, {
    4528,
    "Comercial - Compras > Entradas desde Kanban"
}, {
    4529,
    "Comercial - Compras > Entradas desde Kanban > Adicionar"
}, {
    4530,
    "Comercial - Compras > Entradas desde Kanban > Anular"
}, {
    4556,
    "Comercial - Compras > Entradas desde Kanban > Permitir modificar fecha de la entrada"
}, {
    7976,
    "Comercial - Compras > Entradas desde Kanban > Permitir sobrepasar monto anual por proveedor"
}, {
    1460,
    "Comercial - Compras > Entradas desde orden de compra"
}, {
    1461,
    "Comercial - Compras > Entradas desde orden de compra > Adicionar"
}, {
    2449,
    "Comercial - Compras > Entradas desde orden de compra > Adicionar items"
}, {
    3170,
    "Comercial - Compras > Entradas desde orden de compra > Alterar precios"
}, {
    1462,
    "Comercial - Compras > Entradas desde orden de compra > Anular"
}, {
    1463,
    "Comercial - Compras > Entradas desde orden de compra > Aprobar"
}, {
    7118,
    "Comercial - Compras > Entradas desde orden de compra > Capturar cantidad en código de barras automático"
}, {
    1464,
    "Comercial - Compras > Entradas desde orden de compra > Consultar"
}, {
    8885,
    "Comercial - Compras > Entradas desde orden de compra > Presentar costos de la transacción"
}, {
    7469,
    "Comercial - Compras > Entradas desde orden de compra > Presentar costo unitario"
}, {
    8272,
    "Comercial - Compras > Entradas desde orden de compra > Dar por cumplida la orden al aprobar"
}, {
    3564,
    "Comercial - Compras > Entradas desde orden de compra > Permitir documentos sin referencia"
}, {
    8557,
    "Comercial - Compras > Entradas desde orden de compra > Validar la fecha de entrada contra la fecha OC"
}, {
    2459,
    "Comercial - Compras > Entradas desde orden de compra > Facturar"
}, {
    7115,
    "Comercial - Compras > Entradas desde orden de compra > Generar automático"
}, {
    12243,
    "Comercial - Compras > Entradas desde orden de compra > Permitir generar con UM adicional"
}, {
    1465,
    "Comercial - Compras > Entradas desde orden de compra > Habilitar impresión"
}, {
    1466,
    "Comercial - Compras > Entradas desde orden de compra > Imprimir"
}, {
    1467,
    "Comercial - Compras > Entradas desde orden de compra > Modificar"
}, {
    4270,
    "Comercial - Compras > Entradas desde orden de compra > Modificar entidades dinámicas en doctos aprobados"
}, {
    8197,
    "Comercial - Compras > Entradas desde orden de compra > Presentar solo movimientos de la OC del mismo CO"
}, {
    3735,
    "Comercial - Compras > Entradas desde orden de compra > Permitir mandatos de diferente C.O."
}, {
    6561,
    "Comercial - Compras > Entradas desde orden de compra > Permitir modificar el centro de costo de la O.C."
}, {
    6758,
    "Comercial - Compras > Entradas desde orden de compra > Permitir modificar la descrip. del mov. a generar"
}, {
    8889,
    "Comercial - Compras > Entradas desde orden de compra > Presentar precio en unidad de inventario"
}, {
    11639,
    "Comercial - Compras > Entradas desde orden de compra > Permitir registro manuales de sobrecostos en OC"
}, {
    4759,
    "Comercial - Compras > Entradas desde orden de compra > Sobrecostos menor valor en dsctos condicionados"
}, {
    3198,
    "Comercial - Compras > Entradas desde orden de compra > Liquidar sobrecostos con base en lista de precios"
}, {
    2450,
    "Comercial - Compras > Entradas desde orden de compra > Sobrecostos mayor valor"
}, {
    7977,
    "Comercial - Compras > Entradas desde orden de compra > Permitir sobrepasar monto anual por proveedor"
}, {
    6765,
    "Comercial - Compras > Entradas desde orden de compra > Validar documento referencia"
}, {
    1445,
    "Comercial - Compras > Entradas por compra"
}, {
    1447,
    "Comercial - Compras > Entradas por compra > Adicionar"
}, {
    3171,
    "Comercial - Compras > Entradas por compra > Alterar precios"
}, {
    1448,
    "Comercial - Compras > Entradas por compra > Anular"
}, {
    1449,
    "Comercial - Compras > Entradas por compra > Aprobar"
}, {
    1450,
    "Comercial - Compras > Entradas por compra > Consultar"
}, {
    7468,
    "Comercial - Compras > Entradas por compra > Presentar costo unitario"
}, {
    3565,
    "Comercial - Compras > Entradas por compra > Permitir documentos sin referencia"
}, {
    2458,
    "Comercial - Compras > Entradas por compra > Facturar"
}, {
    9528,
    "Comercial - Compras > Entradas por compra > Facturar > Automática"
}, {
    11637,
    "Comercial - Compras > Entradas por compra > Facturar > Heredar notas de la entrada"
}, {
    1451,
    "Comercial - Compras > Habilitar impresión documentos > Habilitar impresión entradas, devol., ajustes"
}, {
    1452,
    "Comercial - Compras > Imprimir documentos > Imprimir entradas, devol., ajustes"
}, {
    10870,
    "Comercial - Compras > Entradas por compra > Exigir costo estándar para ítem de inventario"
}, {
    1453,
    "Comercial - Compras > Entradas por compra > Modificar"
}, {
    4271,
    "Comercial - Compras > Entradas por compra > Modificar entidades dinámicas en doctos aprobados"
}, {
    8762,
    "Comercial - Compras > Entradas por compra > Permitir bodegas de diferentes CO"
}, {
    7582,
    "Comercial - Compras > Entradas desde orden de compra > Permitir entradas desde O.C. desde diferentes C.O."
}, {
    8761,
    "Comercial - Compras > Entradas por compra > Permitir ítems sin precio"
}, {
    3734,
    "Comercial - Compras > Entradas por compra > Permitir mandatos de diferente C.O."
}, {
    8890,
    "Comercial - Compras > Entradas por compra > Presentar precio en unidad de inventario"
}, {
    8789,
    "Comercial - Compras > Entradas por compra > Grabar referencia alterna en descripción del movto"
}, {
    4760,
    "Comercial - Compras > Entradas por compra > Sobrecostos menor valor en dsctos condicionados"
}, {
    3197,
    "Comercial - Compras > Entradas por compra > Liquidar sobrecostos con base en lista de precios"
}, {
    2451,
    "Comercial - Compras > Entradas por compra > Sobrecostos mayor valor"
}, {
    7978,
    "Comercial - Compras > Entradas por compra > Permitir sobrepasar monto anual por proveedor"
}, {
    6762,
    "Comercial - Compras > Entradas por compra > Validar documento referencia"
}, {
    11906,
    "Comercial - Compras > Entradas desde importación"
}, {
    11907,
    "Comercial - Compras > Entradas desde importación > Adicionar"
}, {
    11908,
    "Comercial - Compras > Entradas desde importación > Anular"
}, {
    11909,
    "Comercial - Compras > Entradas desde importación > Aprobar"
}, {
    11910,
    "Comercial - Compras > Entradas desde importación > Capturar cantidad en código de barras automático"
}, {
    11911,
    "Comercial - Compras > Entradas desde importación > Consultar"
}, {
    12016,
    "Comercial - Compras > Importaciones > Facturar costos de destino"
}, {
    12015,
    "Comercial - Compras > Importaciones > Facturar costos de nacionalización"
}, {
    12014,
    "Comercial - Compras > Importaciones > Facturar costos de origen"
}, {
    12013,
    "Comercial - Compras > Importaciones > Facturar costos de proveedor"
}, {
    11912,
    "Comercial - Compras > Entradas desde importación > Generar automático"
}, {
    11913,
    "Comercial - Compras > Entradas desde importación > Habilitar impresión"
}, {
    11914,
    "Comercial - Compras > Entradas desde importación > Imprimir"
}, {
    11915,
    "Comercial - Compras > Entradas desde importación > Modificar"
}, {
    11916,
    "Comercial - Compras > Entradas desde importación > Modificar entidades dinámicas en doctos aprobados"
}, {
    11917,
    "Comercial - Compras > Entradas desde importación > Permitir documentos sin referencia"
}, {
    11918,
    "Comercial - Compras > Entradas desde importación > Validar fecha de entrada contra la fecha de import"
}, {
    1514,
    "Comercial - Compras > Factura desde entrada"
}, {
    1516,
    "Comercial - Compras > Factura desde entrada > Adicionar"
}, {
    7590,
    "Comercial - Compras > Factura desde entrada > Alterar condición de pago"
}, {
    4373,
    "Comercial - Compras > Factura desde entrada > Permitir anticipos de otra auxiliar de anticipos"
}, {
    3123,
    "Comercial - Compras > Factura desde entrada > Permitir anticipos de otra U.N."
}, {
    3124,
    "Comercial - Compras > Factura desde entrada > Permitir anticipos de otro C.O."
}, {
    2936,
    "Comercial - Compras > Factura desde entrada > Permitir anticipos de otro proveedor"
}, {
    1517,
    "Comercial - Compras > Factura desde entrada > Anular"
}, {
    1518,
    "Comercial - Compras > Factura desde entrada > Aprobar"
}, {
    10891,
    "Comercial - Compras > Factura desde entrada > Permitir cambiar instrumento financiero sugerido"
}, {
    8000,
    "Comercial - Compras > Factura desde entrada > Permitir cambiar pronto pago"
}, {
    9703,
    "Comercial - Compras > Factura desde entrada > Permitir capturar instrumento financiero"
}, {
    1519,
    "Comercial - Compras > Factura desde entrada > Consultar"
}, {
    10457,
    "Comercial - Compras > Factura desde entrada > Permitir cruzar anticipos múltiples libros"
}, {
    9725,
    "Comercial - Compras > Factura desde entrada > Permitir distribuir la cartera al contabilizar"
}, {
    11200,
    "Comercial - Compras > Factura desde entrada > Ver documentos solo hasta la fecha de causación"
}, {
    3930,
    "Comercial - Compras > Factura desde entrada > Permit causar facturas de mas de 180 dias"
}, {
    8558,
    "Comercial - Compras > Factura desde entrada > Validar la fecha factura contra la fecha entrada"
}, {
    2481,
    "Comercial - Compras > Factura desde entrada > Filtrar por C.O del documento"
}, {
    1520,
    "Comercial - Compras > Habilitar impresión documentos > Habilitar impresión facturas y notas"
}, {
    1521,
    "Comercial - Compras > Imprimir documentos > Imprimir facturas y notas"
}, {
    1522,
    "Comercial - Compras > Factura desde entrada > Modificar"
}, {
    4078,
    "Comercial - Compras > Factura desde entrada > Modificar entidades dinámicas en doctos aprobados"
}, {
    3742,
    "Comercial - Compras > Factura desde entrada > Permitir mandatos de diferente C.O."
}, {
    7613,
    "Comercial - Compras > Factura desde entrada > Validar documento proveedor por tercero"
}, {
    3863,
    "Comercial - Compras > Generales"
}, {
    8881,
    "Comercial - Compras > Generales > Filtrar la captura ítem con el proveedor asociado"
}, {
    8758,
    "Comercial - Compras > Generales > Captura ubicaciones por plan de criterio"
}, {
    3865,
    "Comercial - Compras > Generales > Permitir modificar C.Costo de la CxP"
}, {
    3866,
    "Comercial - Compras > Generales > Permitir modificar F.E. de la CxP"
}, {
    3914,
    "Comercial - Compras > Generales > Permitir modificar retenciones en facturas"
}, {
    3915,
    "Comercial - Compras > Generales > Permitir modificar retenciones en notas"
}, {
    3864,
    "Comercial - Compras > Generales > Permitir modificar U.N. de la CxP"
}, {
    10871,
    "Comercial - Compras > Generales > Mostrar solo los ítem con cotizaciones"
}, {
    6363,
    "Comercial - Compras > Generar ajustes desde entradas"
}, {
    10795,
    "Comercial - Compras > Generación de pedidos desde órdenes de compra"
}, {
    12051,
    "Comercial - Compras > Generación de pedidos desde órdenes de compra > Exigir lista de precios libre"
}, {
    2159,
    "Comercial - Compras > Habilitar impresión documentos"
}, {
    11644,
    "Comercial - Compras > Importaciones"
}, {
    11645,
    "Comercial - Compras > Importaciones > Adicionar"
}, {
    11646,
    "Comercial - Compras > Importaciones > Anular"
}, {
    11647,
    "Comercial - Compras > Importaciones > Aprobar"
}, {
    11648,
    "Comercial - Compras > Importaciones > Cerrar"
}, {
    11649,
    "Comercial - Compras > Importaciones > Consultar"
}, {
    11650,
    "Comercial - Compras > Importaciones > Desaprobar"
}, {
    11651,
    "Comercial - Compras > Importaciones > Deshacer cierre"
}, {
    11652,
    "Comercial - Compras > Importaciones > Duplicar"
}, {
    12397,
    "Comercial - Compras > Importaciones > Permitir excluir conceptos"
}, {
    11653,
    "Comercial - Compras > Importaciones > Modificar"
}, {
    2156,
    "Comercial - Compras > Imprimir documentos"
}, {
    7871,
    "Comercial - Compras > Imprimir documentos > Envío de correos"
}, {
    4509,
    "Comercial - Compras > Kanban"
}, {
    4510,
    "Comercial - Compras > Kanban > Activacion"
}, {
    4511,
    "Comercial - Compras > Kanban > Activacion > Adicionar"
}, {
    4512,
    "Comercial - Compras > Kanban > Activacion > Anular"
}, {
    4555,
    "Comercial - Compras > Kanban > Activacion > Permitir modificar fecha de activación"
}, {
    4520,
    "Comercial - Compras > Kanban > Consecutivos"
}, {
    4513,
    "Comercial - Compras > Kanban > Tarjetas"
}, {
    4514,
    "Comercial - Compras > Kanban > Tarjetas > Adicionar"
}, {
    4515,
    "Comercial - Compras > Kanban > Tarjetas > Consultar"
}, {
    4516,
    "Comercial - Compras > Kanban > Tarjetas > Duplicar"
}, {
    4517,
    "Comercial - Compras > Kanban > Tarjetas > Eliminar"
}, {
    4518,
    "Comercial - Compras > Kanban > Tarjetas > Modificar"
}, {
    4519,
    "Comercial - Compras > Kanban > Tarjetas > Reporte"
}, {
    8379,
    "Comercial - Compras > Kanban > Tarjetas > Sugerir precio de la cotización"
}, {
    2721,
    "Comercial - Compras > Liquidación de fletes"
}, {
    2722,
    "Comercial - Compras > Liquidación de fletes > Adicionar"
}, {
    2723,
    "Comercial - Compras > Liquidación de fletes > Anular"
}, {
    2724,
    "Comercial - Compras > Liquidación de fletes > Aprobar"
}, {
    4722,
    "Comercial - Compras > Liquidación de fletes > Permitir capturar facturas/notas"
}, {
    4723,
    "Comercial - Compras > Liquidación de fletes > Permitir capturar planillas de cuadre"
}, {
    4721,
    "Comercial - Compras > Liquidación de fletes > Permitir capturar remisiones/devoluciones"
}, {
    2725,
    "Comercial - Compras > Liquidación de fletes > Consultar"
}, {
    12588,
    "Comercial - Compras > Liquidación de fletes > Documentos pendientes de fletes"
}, {
    3566,
    "Comercial - Compras > Liquidación de fletes > Permitir documentos sin referencia"
}, {
    2726,
    "Comercial - Compras > Liquidación de fletes > Facturar"
}, {
    2727,
    "Comercial - Compras > Liquidación de fletes > Modificar"
}, {
    2711,
    "Comercial - Compras > Liquidación de fletes > Modificar cantidad fletes"
}, {
    2712,
    "Comercial - Compras > Liquidación de fletes > Modificar valor fletes"
}, {
    4274,
    "Comercial - Compras > Liquidación de fletes > Modificar entidades dinámicas en doctos aprobados"
}, {
    9115,
    "Comercial - Compras > Liquidación de fletes > Permitir capturar transito"
}, {
    8080,
    "Comercial - Compras > Mercancia en consignación > Factura desde consignación > Modificar entidades dinámicas en doctos aprobados"
}, {
    8081,
    "Comercial - Compras > Mercancia en consignación > Notas desde consignación > Modificar entidades dinámicas en doctos aporbados"
}, {
    2772,
    "Comercial - Compras > Mercancia en consignación"
}, {
    2773,
    "Comercial - Compras > Mercancia en consignación > Factura desde consignación"
}, {
    2774,
    "Comercial - Compras > Mercancia en consignación > Factura desde consignación > Adicionar"
}, {
    2777,
    "Comercial - Compras > Mercancia en consignación > Factura desde consignación > Anular"
}, {
    2776,
    "Comercial - Compras > Mercancia en consignación > Factura desde consignación > Aprobar"
}, {
    2778,
    "Comercial - Compras > Mercancia en consignación > Factura desde consignación > Consultar"
}, {
    2775,
    "Comercial - Compras > Mercancia en consignación > Factura desde consignación > Modificar"
}, {
    9704,
    "Comercial - Compras > Mercancia en consignación > Factura desde consignación > Permitir capturar instrumento financiero"
}, {
    7592,
    "Comercial - Compras > Mercancia en consignación > Factura desde consignación > Alterar condición de pago"
}, {
    2779,
    "Comercial - Compras > Mercancia en consignación > Notas desde consignación"
}, {
    2780,
    "Comercial - Compras > Mercancia en consignación > Notas desde consignación > Adicionar"
}, {
    2783,
    "Comercial - Compras > Mercancia en consignación > Notas desde consignación > Anular"
}, {
    2782,
    "Comercial - Compras > Mercancia en consignación > Notas desde consignación > Aprobar"
}, {
    2784,
    "Comercial - Compras > Mercancia en consignación > Notas desde consignación > Consultar"
}, {
    2781,
    "Comercial - Compras > Mercancia en consignación > Notas desde consignación > Modificar"
}, {
    7593,
    "Comercial - Compras > Mercancia en consignación > Notas desde consignación > Alterar condición de pago"
}, {
    10897,
    "Comercial - Compras > Mercancia en consignación > Factura desde consignación > Permitir cambiar instrumento financiero sugerido"
}, {
    8004,
    "Comercial - Compras > Mercancia en consignación > Factura desde consignación > Permitir cambiar pronto pago"
}, {
    7617,
    "Comercial - Compras > Mercancia en consignación > Factura desde consignación > Validar documento proveedor por tercero"
}, {
    7618,
    "Comercial - Compras > Mercancia en consignación > Notas desde consignación > Validar documento proveedor por tercero"
}, {
    1515,
    "Comercial - Compras > Notas desde entradas"
}, {
    1523,
    "Comercial - Compras > Notas desde entradas > Adicionar"
}, {
    7591,
    "Comercial - Compras > Notas desde entradas > Alterar condición de pago"
}, {
    1524,
    "Comercial - Compras > Notas desde entradas > Anular"
}, {
    1525,
    "Comercial - Compras > Notas desde entradas > Aprobar"
}, {
    10311,
    "Comercial - Compras > Notas desde entradas > Permitir cambiar pronto pago"
}, {
    1526,
    "Comercial - Compras > Notas desde entradas > Consultar"
}, {
    11053,
    "Comercial - Compras > Notas desde entradas > Permitir cruzar anticipos en múltiples libros"
}, {
    1527,
    "Comercial - Compras > Notas desde entradas > Habilitar impresión"
}, {
    1528,
    "Comercial - Compras > Notas desde entradas > Imprimir"
}, {
    1529,
    "Comercial - Compras > Notas desde entradas > Modificar"
}, {
    4079,
    "Comercial - Compras > Notas desde entradas > Modificar entidades dinámicas en doctos aprobados"
}, {
    9726,
    "Comercial - Compras > Notas desde entradas > Permitir distribuir la cartera al contabilizar"
}, {
    3743,
    "Comercial - Compras > Notas desde entradas > Permitir mandatos de diferente C.O."
}, {
    7619,
    "Comercial - Compras > Notas desde entradas > Validar documento proveedor por tercero"
}, {
    9835,
    "Comercial - Compras > Órdenes de compra desde planeadas y cotización"
}, {
    9905,
    "Comercial - Compras > Órdenes de compra desde planeadas y cotización > Asignar la fecha de entrega OC con base al docto"
}, {
    9871,
    "Comercial - Compras > Órdenes de compra desde planeadas y cotización > Permitir generar con nuevo motivo, info contable"
}, {
    9872,
    "Comercial - Compras > Órdenes de compra desde planeadas y cotización > Permitir seleccionar MPS"
}, {
    9873,
    "Comercial - Compras > Órdenes de compra desde planeadas y cotización > Permitir seleccionar MRP"
}, {
    9876,
    "Comercial - Compras > Órdenes de compra desde planeadas y cotización > Seleccionar opción de ver ordenes planeadas en UM"
}, {
    9874,
    "Comercial - Compras > Órdenes de compra desde planeadas y cotización > Permitir seleccionar tipo de orden en firme"
}, {
    9875,
    "Comercial - Compras > Órdenes de compra desde planeadas y cotización > Permitir seleccionar tipo de orden planeada"
}, {
    4585,
    "Comercial - Compras > Ordenes de compra desde solicitudes de oferta"
}, {
    6780,
    "Comercial - Compras > Ordenes de compra desde solicitud oferta colectiva"
}, {
    2574,
    "Comercial - Compras > Ordenes de compra desde S.C. y ordenes planeadas"
}, {
    9195,
    "Comercial - Compras > Ordenes de compra desde S.C. y ordenes planeadas > Permitir generar con nuevo motivo, info contable"
}, {
    8269,
    "Comercial - Compras > Ordenes de compra desde S.C. y ordenes planeadas > Asignar la fecha de entrega OC con base al docto"
}, {
    7227,
    "Comercial - Compras > Ordenes de compra desde S.C. y ordenes planeadas > Modificar cantidad en orden planeada"
}, {
    7611,
    "Comercial - Compras > Ordenes de compra desde S.C. y ordenes planeadas > Validar politica de orden al modificar la orden"
}, {
    4683,
    "Comercial - Compras > Ordenes de compra desde S.C. y ordenes planeadas > Seleccionar opción de ordenes planeadas"
}, {
    4784,
    "Comercial - Compras > Ordenes de compra desde S.C. y ordenes planeadas > Permitir seleccionar MPS"
}, {
    4785,
    "Comercial - Compras > Ordenes de compra desde S.C. y ordenes planeadas > Permitir seleccionar MRP"
}, {
    4783,
    "Comercial - Compras > Ordenes de compra desde S.C. y ordenes planeadas > Permitir seleccionar tipo de orden en firme"
}, {
    4782,
    "Comercial - Compras > Ordenes de compra desde S.C. y ordenes planeadas > Permitir seleccionar tipo de orden planeada"
}, {
    4682,
    "Comercial - Compras > Ordenes de compra desde S.C. y ordenes planeadas > Seleccionar opción de solicitudes"
}, {
    4684,
    "Comercial - Compras > Ordenes de compra desde S.C. y ordenes planeadas > Seleccionar opcion de ver ordenes planeadas en UM"
}, {
    10669,
    "Comercial - Compras > Ordenes de compra desde S.C. y ordenes planeadas > Sugerir último precio y descuento"
}, {
    4567,
    "Comercial - Compras > Oferta de proveedores"
}, {
    4568,
    "Comercial - Compras > Oferta de proveedores > Cerrar"
}, {
    4569,
    "Comercial - Compras > Oferta de proveedores > Modificar"
}, {
    1385,
    "Comercial - Compras > Ordenes de compra"
}, {
    1394,
    "Comercial - Compras > Ordenes de compra > Adicionar"
}, {
    7131,
    "Comercial - Compras > Ordenes de compra > Adicionar ítem en OC desde solicitud"
}, {
    11324,
    "Comercial - Compras > Ordenes de compra > Permitir adicionar ítems en doctos aprobados"
}, {
    3319,
    "Comercial - Compras > Ordenes de compra > Alterar condición de pago"
}, {
    1402,
    "Comercial - Compras > Ordenes de compra > Alterar precios"
}, {
    1397,
    "Comercial - Compras > Ordenes de compra > Anular"
}, {
    1398,
    "Comercial - Compras > Ordenes de compra > Aprobar"
}, {
    11567,
    "Comercial - Compras > Ordenes de compra > Cambiar ítems"
}, {
    11052,
    "-No implementado > Permitir cambiar fecha de entrega en aprobados"
}, {
    8116,
    "Comercial - Compras > Ordenes de compra > Permitir cambiar descuentos globales doctos aprob"
}, {
    11928,
    "Comercial - Compras > Ordenes de compra > Cancelar tracking al dar por cumplida la O.C."
}, {
    3722,
    "Comercial - Compras > Ordenes de compra > Capturar precios para ítems sin vigencia"
}, {
    1396,
    "Comercial - Compras > Ordenes de compra > Consultar"
}, {
    3290,
    "Comercial - Compras > Ordenes de compra > Controlar bodega de asignacion"
}, {
    2962,
    "Comercial - Compras > Ordenes de compra > Controlar excesos de la cantidad solicitada"
}, {
    1401,
    "Comercial - Compras > Ordenes de compra > Dar por cumplido"
}, {
    7120,
    "Comercial - Compras > Ordenes de compra > Desaprobar"
}, {
    1429,
    "Comercial - Compras > Ordenes de compra > Generar desde solicitud"
}, {
    2961,
    "Comercial - Compras > Ordenes de compra > Deshabilitar cambios de tasas de la moneda"
}, {
    8200,
    "Comercial - Compras > Ordenes de compra > Duplicar"
}, {
    8201,
    "Comercial - Compras > Ordenes de compra > Duplicar > Permitir crear con otra bodega"
}, {
    11101,
    "Comercial - Compras > Ordenes de compra > Exige solicitante en orden de compra directa"
}, {
    1399,
    "Comercial - Compras > Habilitar impresión documentos > Habilitar impresión ordenes de compra"
}, {
    1400,
    "Comercial - Compras > Imprimir documentos > Imprimir ordenes de compra"
}, {
    1395,
    "Comercial - Compras > Ordenes de compra > Modificar"
}, {
    2480,
    "Comercial - Compras > Ordenes de compra > Modificar item de la solicitud"
}, {
    8384,
    "Comercial - Compras > Ordenes de compra > Modificar datos básicos"
}, {
    8385,
    "Comercial - Compras > Ordenes de compra > Modificar datos básicos > Comprador"
}, {
    8386,
    "Comercial - Compras > Ordenes de compra > Modificar datos básicos > Condición de pago"
}, {
    8387,
    "Comercial - Compras > Ordenes de compra > Modificar datos básicos > Notas"
}, {
    12695,
    "Comercial - Compras > Ordenes de compra > Modificar datos básicos > Permitir cuando tiene ruta de aprobación"
}, {
    8388,
    "Comercial - Compras > Ordenes de compra > Modificar datos básicos > Proveedor"
}, {
    4005,
    "Comercial - Compras > Ordenes de compra > Modificar entidades dinamicas en doctos. aprobados"
}, {
    6747,
    "Comercial - Compras > Ordenes de compra > Modificar entidades dinamicas docto en elaboración"
}, {
    7132,
    "Comercial - Compras > Ordenes de compra > Modificar información contable de la solicitud"
}, {
    12514,
    "Comercial - Compras > Ordenes de compra > Modificar el precio en documentos aprobados"
}, {
    3535,
    "Comercial - Compras > Ordenes de compra > No validar monto de aprobación"
}, {
    4491,
    "Comercial - Compras > Ordenes de compra > No validar precios de trazabilidad"
}, {
    2922,
    "Comercial - Compras > Ordenes de compra > Obligar documento referencia"
}, {
    2946,
    "Comercial - Compras > Ordenes de compra > Permite filtrar el C.O. de las solicitudes"
}, {
    7873,
    "Comercial - Compras > Ordenes de compra > Permitir bodegas de diferente CO"
}, {
    7892,
    "Comercial - Compras > Ordenes de compra > Permitir capturar proveedor de sobrecostos"
}, {
    3733,
    "Comercial - Compras > Ordenes de compra > Permitir mandatos de diferente C.O."
}, {
    12694,
    "Comercial - Compras > Ordenes de compra > Presentar disponible del presupuesto al adicionar"
}, {
    8790,
    "Comercial - Compras > Ordenes de compra > Grabar referencia alterna en descripción del movto"
}, {
    1430,
    "Comercial - Compras > Ordenes de compra > Generar sin solicitud"
}, {
    4395,
    "Comercial - Compras > Ordenes de compra > Permitir sobrepasar monto anual por proveedor"
}, {
    6549,
    "Comercial - Compras > Ordenes de compra > Sugerir la última Operación capturada"
}, {
    8925,
    "Comercial - Compras > Ordenes de compra > Sugerir solo el precio de la cotización"
}, {
    4788,
    "Comercial - Compras > Ordenes de compra > Sugerir el último centro de costos capturado"
}, {
    7839,
    "Comercial - Compras > Ordenes de compra > Sugerir la última fecha de entrega"
}, {
    7035,
    "Comercial - Compras > Ordenes de compra > Sugerir el último precio de compra"
}, {
    4786,
    "Comercial - Compras > Ordenes de compra > Transferencias de O.C"
}, {
    6764,
    "Comercial - Compras > Ordenes de compra > Validar documento referencia"
}, {
    7877,
    "Comercial - Compras > Ordenes de compra > Validar días hábiles para compra"
}, {
    7157,
    "Comercial - Compras > Presupuesto"
}, {
    10944,
    "Comercial - Compras > Presupuesto > Aprobación"
}, {
    7168,
    "Comercial - Compras > Presupuesto > Apropiación"
}, {
    7169,
    "Comercial - Compras > Presupuesto > Apropiación > Adicionar"
}, {
    7171,
    "Comercial - Compras > Presupuesto > Apropiación > Eliminar"
}, {
    7170,
    "Comercial - Compras > Presupuesto > Apropiación > Modificar"
}, {
    7184,
    "Comercial - Compras > Presupuesto > Consultas"
}, {
    12784,
    "Comercial - Compras > Presupuesto > Consultas > Análisis de presupuesto controlado"
}, {
    7185,
    "Comercial - Compras > Presupuesto > Consultas > Presupuestos controlados"
}, {
    7186,
    "Comercial - Compras > Presupuesto > Consultas > Presupuestos no controlados"
}, {
    9614,
    "Comercial - Compras > Presupuesto > Consultas > Presupuesto controlado ejecución"
}, {
    9613,
    "Comercial - Compras > Presupuesto > Consultas > Presupuesto controlado movimiento"
}, {
    9616,
    "Comercial - Compras > Presupuesto > Consultas > Presupuesto no controlado ejecucion"
}, {
    9615,
    "Comercial - Compras > Presupuesto > Consultas > Presupuesto no controlado movimiento"
}, {
    7158,
    "Comercial - Compras > Presupuesto > Control presupuestal"
}, {
    7159,
    "Comercial - Compras > Presupuesto > Control presupuestal > Adicionar"
}, {
    7165,
    "Comercial - Compras > Presupuesto > Control presupuestal > Aprobar"
}, {
    7167,
    "Comercial - Compras > Presupuesto > Control presupuestal > Cerrar"
}, {
    7162,
    "Comercial - Compras > Presupuesto > Control presupuestal > Consultar"
}, {
    7166,
    "Comercial - Compras > Presupuesto > Control presupuestal > Desaprobar"
}, {
    7163,
    "Comercial - Compras > Presupuesto > Control presupuestal > Duplicar"
}, {
    7161,
    "Comercial - Compras > Presupuesto > Control presupuestal > Eliminar"
}, {
    7160,
    "Comercial - Compras > Presupuesto > Control presupuestal > Modificar"
}, {
    7164,
    "Comercial - Compras > Presupuesto > Control presupuestal > Reporte"
}, {
    8380,
    "Comercial - Compras > Presupuesto > Control presupuestal > Permitir adicionar reponsables con ppto aprobado"
}, {
    10824,
    "Comercial - Compras > Presupuesto > Generación"
}, {
    7172,
    "Comercial - Compras > Presupuesto > Traslados, adiciones y reducciones"
}, {
    7173,
    "Comercial - Compras > Presupuesto > Traslados, adiciones y reducciones > Adiciones - Adicionar"
}, {
    7175,
    "Comercial - Compras > Presupuesto > Traslados, adiciones y reducciones > Adiciones - Eliminar"
}, {
    7174,
    "Comercial - Compras > Presupuesto > Traslados, adiciones y reducciones > Adiciones - Modificar"
}, {
    7183,
    "Comercial - Compras > Presupuesto > Traslados, adiciones y reducciones > Eliminar"
}, {
    7179,
    "Comercial - Compras > Presupuesto > Traslados, adiciones y reducciones > Reducciones - Adicionar"
}, {
    7181,
    "Comercial - Compras > Presupuesto > Traslados, adiciones y reducciones > Reducciones - Eliminar"
}, {
    7180,
    "Comercial - Compras > Presupuesto > Traslados, adiciones y reducciones > Reducciones - Modificar"
}, {
    7182,
    "Comercial - Compras > Presupuesto > Traslados, adiciones y reducciones > Reporte"
}, {
    7176,
    "Comercial - Compras > Presupuesto > Traslados, adiciones y reducciones > Traslados - Adicionar"
}, {
    7178,
    "Comercial - Compras > Presupuesto > Traslados, adiciones y reducciones > Traslados - Eliminar"
}, {
    7177,
    "Comercial - Compras > Presupuesto > Traslados, adiciones y reducciones > Traslados - Modificar"
}, {
    3049,
    "Comercial - Compras > Revaloración de consignación por documento"
}, {
    3471,
    "Comercial - Compras > Sobrecostos"
}, {
    3473,
    "Comercial - Compras > Sobrecostos > Cantidad"
}, {
    3472,
    "Comercial - Compras > Sobrecostos > Costos"
}, {
    3474,
    "Comercial - Compras > Sobrecostos > Peso"
}, {
    8297,
    "Comercial - Compras > Sobrecostos > Tasa de arancel"
}, {
    3475,
    "Comercial - Compras > Sobrecostos > Volumen"
}, {
    1468,
    "Comercial - Compras > Sobrecostos por mayor valor"
}, {
    1470,
    "Comercial - Compras > Sobrecostos por mayor valor > Adicionar"
}, {
    1471,
    "Comercial - Compras > Sobrecostos por mayor valor > Anular"
}, {
    1472,
    "Comercial - Compras > Sobrecostos por mayor valor > Aprobar"
}, {
    3372,
    "Comercial - Compras > Sobrecostos por mayor valor > Bloquea sobrecostos cuando no hay existencias"
}, {
    1473,
    "Comercial - Compras > Sobrecostos por mayor valor > Consultar"
}, {
    3567,
    "Comercial - Compras > Sobrecostos por mayor valor > Permitir documentos sin referencia"
}, {
    2460,
    "Comercial - Compras > Sobrecostos por mayor valor > Facturar"
}, {
    1474,
    "Comercial - Compras > Sobrecostos por mayor valor > Habilitar impresión"
}, {
    1475,
    "Comercial - Compras > Sobrecostos por mayor valor > Imprimir"
}, {
    12516,
    "Comercial - Compras > Sobrecostos por mayor valor > Liquidar con base en tarifas para transferencias"
}, {
    1476,
    "Comercial - Compras > Sobrecostos por mayor valor > Modificar"
}, {
    4272,
    "Comercial - Compras > Sobrecostos por mayor valor > Modificar entidades dinámicas en doctos aprobados"
}, {
    3736,
    "Comercial - Compras > Sobrecostos por mayor valor > Permitir mandatos de diferente C.O."
}, {
    3199,
    "Comercial - Compras > Sobrecostos por mayor valor > Liquidar sobrecostos con base en lista de precios"
}, {
    1446,
    "Comercial - Compras > Sobrecostos por menor valor"
}, {
    1454,
    "Comercial - Compras > Sobrecostos por menor valor > Adicionar"
}, {
    1455,
    "Comercial - Compras > Sobrecostos por menor valor > Anular"
}, {
    1456,
    "Comercial - Compras > Sobrecostos por menor valor > Aprobar"
}, {
    1457,
    "Comercial - Compras > Sobrecostos por menor valor > Consultar"
}, {
    3568,
    "Comercial - Compras > Sobrecostos por menor valor > Permitir documentos sin referencia"
}, {
    1458,
    "Comercial - Compras > Sobrecostos por menor valor > Habilitar impresión"
}, {
    1469,
    "Comercial - Compras > Sobrecostos por menor valor > Imprimir"
}, {
    1459,
    "Comercial - Compras > Sobrecostos por menor valor > Modificar"
}, {
    4273,
    "Comercial - Compras > Sobrecostos por menor valor > Modificar entidades dinámicas en doctos aprobados"
}, {
    3737,
    "Comercial - Compras > Sobrecostos por menor valor > Permitir mandatos de diferente C.O."
}, {
    3200,
    "Comercial - Compras > Sobrecostos por menor valor > Liquidar sobrecostos con base en lista de precios"
}, {
    1384,
    "Comercial - Compras > Solicitud de compra"
}, {
    1386,
    "Comercial - Compras > Solicitud de compra > Adicionar"
}, {
    1389,
    "Comercial - Compras > Solicitud de compra > Anular"
}, {
    1390,
    "Comercial - Compras > Solicitud de compra > Aprobar"
}, {
    1388,
    "Comercial - Compras > Solicitud de compra > Consultar"
}, {
    3289,
    "Comercial - Compras > Solicitud de compra > Controlar bodega de asignacion"
}, {
    1393,
    "Comercial - Compras > Solicitud de compra > Dar por cumplido"
}, {
    10017,
    "Comercial - Compras > Solicitud de compra > Desaprobar"
}, {
    3588,
    "Comercial - Compras > Solicitud de compra desde requisición"
}, {
    12056,
    "Comercial - Compras > Solicitud de compra desde requisición > Heredar datos de la requisición"
}, {
    7404,
    "Comercial - Compras > Solicitud de compra desde requisición por docto"
}, {
    2963,
    "Comercial - Compras > Solicitud de compra > Deshabilitar cambios de tasas de la moneda"
}, {
    4877,
    "Comercial - Compras > Solicitud de compra > Duplicar"
}, {
    1391,
    "Comercial - Compras > Habilitar impresión documentos > Habilitar impresión solicitudes"
}, {
    1392,
    "Comercial - Compras > Imprimir documentos > Imprimir solicitudes"
}, {
    1387,
    "Comercial - Compras > Solicitud de compra > Modificar"
}, {
    4006,
    "Comercial - Compras > Solicitud de compra > Modificar entidades dinamicas en doctos. aprobados"
}, {
    4798,
    "Comercial - Compras > Solicitud de compra > Modificar entidades dinámicas en docto elaboración"
}, {
    4377,
    "Comercial - Compras > Solicitud de compra > No exigir notas al cambiar la fecha de entrega"
}, {
    4654,
    "Comercial - Compras > Solicitud de compra > No validar monto de aprobación"
}, {
    2921,
    "Comercial - Compras > Solicitud de compra > Obligar documento referencia"
}, {
    4588,
    "Comercial - Compras > Habilitar impresión documentos > Habilitar impresión solicitudes de oferta"
}, {
    4589,
    "Comercial - Compras > Imprimir documentos > Imprimir solicitudes de oferta"
}, {
    4378,
    "Comercial - Compras > Solicitud de compra > Presentar cantidad disponible"
}, {
    8923,
    "Comercial - Compras > Solicitud de compra > Presentar las existencias a la fecha"
}, {
    12057,
    "Comercial - Compras > Solicitud de compra desde requisición por docto > Heredar datos de la requisición"
}, {
    7876,
    "Comercial - Compras > Solicitud de compra > Validar días hábiles para compra"
}, {
    9943,
    "Comercial - Compras > Solicitud de oferta desde solicitudes"
}, {
    4558,
    "Comercial - Compras > Solicitud de oferta directa"
}, {
    4559,
    "Comercial - Compras > Solicitud de oferta directa > Adicionar"
}, {
    4560,
    "Comercial - Compras > Solicitud de oferta directa > Anular"
}, {
    4561,
    "Comercial - Compras > Solicitud de oferta directa > Aprobar"
}, {
    4590,
    "Comercial - Compras > Solicitud de oferta directa > Cerrar"
}, {
    4562,
    "Comercial - Compras > Solicitud de oferta directa > Consultar"
}, {
    4563,
    "Comercial - Compras > Solicitud de oferta directa > Dar por cumplido"
}, {
    10075,
    "Comercial - Compras > Solicitud de oferta directa > Permitir eliminar ítems en documentos cerrados"
}, {
    4566,
    "Comercial - Compras > Solicitud de oferta directa > Permitir documentos sin referencia"
}, {
    4564,
    "Comercial - Compras > Solicitud de oferta directa > Modificar"
}, {
    4565,
    "Comercial - Compras > Solicitud de oferta directa > Modificar entidades dinámicas en doctos aprobados"
}, {
    10035,
    "Comercial - Compras > Transferencia órdenes de compra controlada"
}, {
    10103,
    "Comercial - Compras > Transferencia órdenes de compra controlada > Permitir cambiar la bodega"
}, {
    10981,
    "Comercial - Compras > Transferencia órdenes de compra controlada > Permitir cambiar el centro de costo"
}, {
    10105,
    "Comercial - Compras > Transferencia órdenes de compra controlada > Permitir recalcular descuento"
}, {
    10104,
    "Comercial - Compras > Transferencia órdenes de compra controlada > Permitir recalcular precio"
}, {
    1439,
    "Financiero - Compra de servicios"
}, {
    3540,
    "Financiero - Compra de servicios > Aprobar de ordenes de compra retenidas"
}, {
    3541,
    "Financiero - Compra de servicios > Aprobar de ordenes de compra retenidas > Aprobar ordenes retenidas por monto"
}, {
    3543,
    "Financiero - Compra de servicios > Aprobar de ordenes de compra retenidas > Mostrar ordenes de compra comercial"
}, {
    3542,
    "Financiero - Compra de servicios > Aprobar de ordenes de compra retenidas > Aprobar ordenes retenidas por presupuesto"
}, {
    9709,
    "Financiero - Compra de servicios > Automatización de documentos"
}, {
    10029,
    "Financiero - Compra de servicios > Caja Menor"
}, {
    10114,
    "Financiero - Compra de servicios > Caja Menor > Consultas"
}, {
    10115,
    "Financiero - Compra de servicios > Caja Menor > Consultas > Mostrar saldos de caja menor"
}, {
    10156,
    "Financiero - Compra de servicios > Caja Menor > Consultas > Movimiento caja menor"
}, {
    10032,
    "Financiero - Compra de servicios > Caja Menor > Documentos"
}, {
    10033,
    "Financiero - Compra de servicios > Caja Menor > Documentos > Administración"
}, {
    10068,
    "Financiero - Compra de servicios > Caja Menor > Documentos > Administración > Asignación"
}, {
    10071,
    "Financiero - Compra de servicios > Caja Menor > Documentos > Administración > Cancelación"
}, {
    10070,
    "Financiero - Compra de servicios > Caja Menor > Documentos > Administración > Disminución"
}, {
    10069,
    "Financiero - Compra de servicios > Caja Menor > Documentos > Administración > Incremento"
}, {
    10975,
    "Financiero - Compra de servicios > Caja Menor > Documentos > Administración > Modificar Beneficiario"
}, {
    10072,
    "Financiero - Compra de servicios > Caja Menor > Documentos > Administración > Reembolso"
}, {
    10034,
    "Financiero - Compra de servicios > Caja Menor > Documentos > Legalización"
}, {
    10078,
    "Financiero - Compra de servicios > Caja Menor > Documentos > Legalización > Adicionar"
}, {
    10079,
    "Financiero - Compra de servicios > Caja Menor > Documentos > Legalización > Anular"
}, {
    10080,
    "Financiero - Compra de servicios > Caja Menor > Documentos > Legalización > Aprobar"
}, {
    10081,
    "Financiero - Compra de servicios > Caja Menor > Documentos > Legalización > Consultar"
}, {
    11259,
    "Financiero - Compra de servicios > Caja Menor > Documentos > Legalización > Permitir cajas menores con diferente C.O.del docto"
}, {
    10085,
    "Financiero - Compra de servicios > Caja Menor > Documentos > Legalización > Modificar entidades dinámicas doctos aprobados"
}, {
    10082,
    "Financiero - Compra de servicios > Caja Menor > Documentos > Legalización > Habilitar impresión"
}, {
    10083,
    "Financiero - Compra de servicios > Caja Menor > Documentos > Legalización > Imprimir"
}, {
    10084,
    "Financiero - Compra de servicios > Caja Menor > Documentos > Legalización > Modificar"
}, {
    10030,
    "Financiero - Compra de servicios > Caja Menor > Maestros"
}, {
    10031,
    "Financiero - Compra de servicios > Caja Menor > Maestros > Caja Menor"
}, {
    1442,
    "Financiero - Compra de servicios > Consultas"
}, {
    3869,
    "Financiero - Compra de servicios > Generales"
}, {
    8266,
    "Financiero - Compra de servicios > Generales > Permitir anular con fecha de aprobación diferente"
}, {
    3870,
    "Financiero - Compra de servicios > Generales > Permitir modificar C.Costo de la CxP"
}, {
    3872,
    "Financiero - Compra de servicios > Generales > Permitir modificar F.E. de la CxP"
}, {
    3916,
    "Financiero - Compra de servicios > Generales > Permitir modificar retenciones en facturas"
}, {
    3917,
    "Financiero - Compra de servicios > Generales > Permitir modificar retenciones en notas"
}, {
    3871,
    "Financiero - Compra de servicios > Generales > Permitir modificar U.N. de la CxP"
}, {
    2160,
    "Financiero - Compra de servicios > Habilitar impresión documentos"
}, {
    2161,
    "Financiero - Compra de servicios > Imprimir documentos"
}, {
    10602,
    "Financiero - Compra de servicios > Legalización gastos-anticipos"
}, {
    10840,
    "-No implementado > Permitir cruzar CxP"
}, {
    7388,
    "Financiero - Compra de servicios > Retención a trabajadores independientes"
}, {
    7398,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Deducibles de retención por proveedor"
}, {
    7395,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Deducibles de retención por proveedor > Adicionar"
}, {
    7397,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Deducibles de retención por proveedor > Eliminar"
}, {
    7396,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Deducibles de retención por proveedor > Modificar"
}, {
    7399,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Liquidación"
}, {
    7400,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Liquidación > Generar"
}, {
    7406,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Liquidación > Refrescar"
}, {
    12065,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Liquidación Ley 1819 de 2016"
}, {
    12067,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Liquidación Ley 1819 de 2016 > Generar"
}, {
    12068,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Liquidación Ley 1819 de 2016 > Refresar"
}, {
    7389,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Maestros asociados"
}, {
    7394,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Maestros asociados > Factor de unidad tributaria"
}, {
    7390,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Maestros asociados > Tarifas"
}, {
    7391,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Maestros asociados > Tarifas > Adicionar"
}, {
    7393,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Maestros asociados > Tarifas > Eliminar"
}, {
    7392,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Maestros asociados > Tarifas > Modificar"
}, {
    8342,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Reporte liquidación"
}, {
    12066,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Reporte de liq. Ley 1819 de 2016"
}, {
    10036,
    "Financiero - Compra de servicios > Caja Menor > Maestros > Caja Menor > Adicionar"
}, {
    10037,
    "Financiero - Compra de servicios > Caja Menor > Maestros > Caja Menor > Consultar"
}, {
    10038,
    "Financiero - Compra de servicios > Caja Menor > Maestros > Caja Menor > Duplicar"
}, {
    10039,
    "Financiero - Compra de servicios > Caja Menor > Maestros > Caja Menor > Eliminar"
}, {
    10040,
    "Financiero - Compra de servicios > Caja Menor > Maestros > Caja Menor > Modificar"
}, {
    10041,
    "Financiero - Compra de servicios > Caja Menor > Maestros > Caja Menor > Reporte"
}, {
    10603,
    "Financiero - Compra de servicios > Legalización gastos-anticipos > Adicionar"
}, {
    10604,
    "Financiero - Compra de servicios > Legalización gastos-anticipos > Anular"
}, {
    10605,
    "Financiero - Compra de servicios > Legalización gastos-anticipos > Aprobar"
}, {
    10606,
    "Financiero - Compra de servicios > Legalización gastos-anticipos > Consultar"
}, {
    10664,
    "Financiero - Compra de servicios > Legalización gastos-anticipos > Permitir generar CxC a otro cliente"
}, {
    10610,
    "Financiero - Compra de servicios > Legalización gastos-anticipos > Modificar entidades dinámicas en doctos aprobados"
}, {
    10607,
    "Financiero - Compra de servicios > Legalización gastos-anticipos > Habilitar impresión"
}, {
    10608,
    "Financiero - Compra de servicios > Legalización gastos-anticipos > Imprimir"
}, {
    10609,
    "Financiero - Compra de servicios > Legalización gastos-anticipos > Modificar"
}, {
    10612,
    "Financiero - Compra de servicios > Legalización gastos-anticipos > Permitir cruzar CxC"
}, {
    10611,
    "Financiero - Compra de servicios > Legalización gastos-anticipos > Permitir anticipos de otro proveedor"
}, {
    7909,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Maestros asociados > Parámetros"
}, {
    7917,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Maestros asociados > Parámetros > Eliminar"
}, {
    7916,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Maestros asociados > Parámetros > Modificar"
}, {
    7907,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Maestros asociados > Tarifas art. 383"
}, {
    7910,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Maestros asociados > Tarifas art. 383 > Adicionar"
}, {
    7911,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Maestros asociados > Tarifas art. 383 > Eliminar"
}, {
    7912,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Maestros asociados > Tarifas art. 383 > Modificar"
}, {
    7908,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Maestros asociados > Tarifas art. 384"
}, {
    7913,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Maestros asociados > Tarifas art. 384 > Adicionar"
}, {
    7914,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Maestros asociados > Tarifas art. 384 > Eliminar"
}, {
    7915,
    "Financiero - Compra de servicios > Retención a trabajadores independientes > Maestros asociados > Tarifas art. 384 > Modificar"
}, {
    305,
    "Financiero - Contabilidad"
}, {
    361,
    "Financiero - Contabilidad > Procesos periódicos > Periodos > Activar periodo"
}, {
    9117,
    "Financiero - Contabilidad > Procesos periódicos > Activar/Inactivar auxiliares de cierre"
}, {
    1135,
    "Financiero - Activos fijos > Documentos"
}, {
    1154,
    "Financiero - Activos fijos > Documentos > Ajuste"
}, {
    1161,
    "Financiero - Activos fijos > Documentos > Ajuste > Adicionar"
}, {
    1160,
    "Financiero - Activos fijos > Documentos > Ajuste > Anular"
}, {
    1159,
    "Financiero - Activos fijos > Documentos > Ajuste > Aprobar"
}, {
    1158,
    "Financiero - Activos fijos > Documentos > Ajuste > Consultar"
}, {
    1157,
    "Financiero - Activos fijos > Documentos > Ajuste > Eliminar movimiento"
}, {
    4660,
    "Financiero - Activos fijos > Documentos > Ajuste > Importar"
}, {
    1155,
    "Financiero - Activos fijos > Documentos > Ajuste > Modificar"
}, {
    6557,
    "Financiero - Activos fijos > Documentos > Adopcion por primera vez"
}, {
    6558,
    "Financiero - Activos fijos > Documentos > Adopcion por primera vez > Adicionar"
}, {
    6559,
    "Financiero - Activos fijos > Documentos > Adopcion por primera vez > Anular"
}, {
    6560,
    "Financiero - Activos fijos > Documentos > Adopcion por primera vez > Consultar"
}, {
    1190,
    "Financiero - Activos fijos > Documentos > Dar de alta"
}, {
    1197,
    "Financiero - Activos fijos > Documentos > Dar de alta > Adicionar"
}, {
    1196,
    "Financiero - Activos fijos > Documentos > Dar de alta > Anular"
}, {
    1195,
    "Financiero - Activos fijos > Documentos > Dar de alta > Aprobar"
}, {
    1194,
    "Financiero - Activos fijos > Documentos > Dar de alta > Consultar"
}, {
    1193,
    "Financiero - Activos fijos > Documentos > Dar de alta > Eliminar movimiento"
}, {
    4662,
    "Financiero - Activos fijos > Documentos > Dar de alta > Importar"
}, {
    1191,
    "Financiero - Activos fijos > Documentos > Dar de alta > Modificar"
}, {
    1181,
    "Financiero - Activos fijos > Documentos > Dar de baja"
}, {
    1188,
    "Financiero - Activos fijos > Documentos > Dar de baja > Adicionar"
}, {
    1187,
    "Financiero - Activos fijos > Documentos > Dar de baja > Anular"
}, {
    1186,
    "Financiero - Activos fijos > Documentos > Dar de baja > Aprobar"
}, {
    1185,
    "Financiero - Activos fijos > Documentos > Dar de baja > Consultar"
}, {
    1184,
    "Financiero - Activos fijos > Documentos > Dar de baja > Eliminar movimiento"
}, {
    4663,
    "Financiero - Activos fijos > Documentos > Dar de baja > Importar"
}, {
    1182,
    "Financiero - Activos fijos > Documentos > Dar de baja > Modificar"
}, {
    1145,
    "Financiero - Activos fijos > Documentos > Depreciación y PAAG"
}, {
    1152,
    "Financiero - Activos fijos > Documentos > Depreciación y PAAG > Adicionar"
}, {
    1151,
    "Financiero - Activos fijos > Documentos > Depreciación y PAAG > Anular"
}, {
    1150,
    "Financiero - Activos fijos > Documentos > Depreciación y PAAG > Aprobar"
}, {
    1149,
    "Financiero - Activos fijos > Documentos > Depreciación y PAAG > Consultar"
}, {
    1148,
    "Financiero - Activos fijos > Documentos > Depreciación y PAAG > Eliminar movimiento"
}, {
    9636,
    "Financiero - Activos fijos > Documentos > Depreciación y PAAG > Permite generar con C.Costos inactivos"
}, {
    1381,
    "Financiero - Activos fijos > Documentos > Depreciación y PAAG > Habilitar impresión"
}, {
    1382,
    "Financiero - Activos fijos > Documentos > Depreciación y PAAG > Imprimir"
}, {
    1146,
    "Financiero - Activos fijos > Documentos > Depreciación y PAAG > Modificar"
}, {
    1358,
    "Financiero - Activos fijos > Documentos > Habilitar impresión"
}, {
    1561,
    "Financiero - Activos fijos > Documentos > Importar saldos iniciales"
}, {
    1359,
    "Financiero - Activos fijos > Documentos > Imprimir"
}, {
    1136,
    "Financiero - Activos fijos > Documentos > Saldos iniciales manuales"
}, {
    1143,
    "Financiero - Activos fijos > Documentos > Saldos iniciales manuales > Adicionar"
}, {
    1142,
    "Financiero - Activos fijos > Documentos > Saldos iniciales manuales > Anular"
}, {
    1141,
    "Financiero - Activos fijos > Documentos > Saldos iniciales manuales > Aprobar"
}, {
    1213,
    "Financiero - Activos fijos > Documentos > Saldos iniciales automáticos"
}, {
    1140,
    "Financiero - Activos fijos > Documentos > Saldos iniciales manuales > Consultar"
}, {
    1139,
    "Financiero - Activos fijos > Documentos > Saldos iniciales manuales > Eliminar movimiento"
}, {
    1137,
    "Financiero - Activos fijos > Documentos > Saldos iniciales manuales > Modificar"
}, {
    1163,
    "Financiero - Activos fijos > Documentos > Traslado"
}, {
    1170,
    "Financiero - Activos fijos > Documentos > Traslado > Adicionar"
}, {
    1169,
    "Financiero - Activos fijos > Documentos > Traslado > Anular"
}, {
    1168,
    "Financiero - Activos fijos > Documentos > Traslado > Aprobar"
}, {
    1167,
    "Financiero - Activos fijos > Documentos > Traslado > Consultar"
}, {
    1166,
    "Financiero - Activos fijos > Documentos > Traslado > Eliminar movimiento"
}, {
    4664,
    "Financiero - Activos fijos > Documentos > Traslado > Importar"
}, {
    1164,
    "Financiero - Activos fijos > Documentos > Traslado > Modificar"
}, {
    1172,
    "Financiero - Activos fijos > Documentos > Avalúo"
}, {
    1179,
    "Financiero - Activos fijos > Documentos > Avalúo > Adicionar"
}, {
    1178,
    "Financiero - Activos fijos > Documentos > Avalúo > Anular"
}, {
    1177,
    "Financiero - Activos fijos > Documentos > Avalúo > Aprobar"
}, {
    1176,
    "Financiero - Activos fijos > Documentos > Avalúo > Consultar"
}, {
    1175,
    "Financiero - Activos fijos > Documentos > Avalúo > Eliminar movimiento"
}, {
    4661,
    "Financiero - Activos fijos > Documentos > Avalúo > Importar"
}, {
    1173,
    "Financiero - Activos fijos > Documentos > Avalúo > Modificar"
}, {
    4444,
    "Financiero - Contabilidad > Procesos periódicos > Apertura cuentas de balance - Peru"
}, {
    2033,
    "Financiero - Contabilidad > CDP"
}, {
    2035,
    "Financiero - Contabilidad > CDP > Adición"
}, {
    2044,
    "Financiero - Contabilidad > CDP > Adición > Adicionar"
}, {
    2046,
    "Financiero - Contabilidad > CDP > Adición > Anular"
}, {
    2047,
    "Financiero - Contabilidad > CDP > Adición > Aprobar"
}, {
    2050,
    "Financiero - Contabilidad > CDP > Adición > Consultar"
}, {
    2049,
    "Financiero - Contabilidad > CDP > Adición > Habilitar impresión"
}, {
    2048,
    "Financiero - Contabilidad > CDP > Adición > Imprimir"
}, {
    2045,
    "Financiero - Contabilidad > CDP > Adición > Modificar"
}, {
    11659,
    "Financiero - Contabilidad > CDP > Adición > Modificar entidades dinámicas doctos anulados"
}, {
    11660,
    "Financiero - Contabilidad > CDP > Adición > Modificar entidades dinámicas doctos aprobados"
}, {
    11687,
    "Financiero - Contabilidad > CDP > Adición > Modificar entidades dinámicas doctos cumplidos"
}, {
    2062,
    "Financiero - Contabilidad > CDP > Consultas"
}, {
    2155,
    "Financiero - Contabilidad > CDP > Consultas > CDP"
}, {
    2154,
    "Financiero - Contabilidad > CDP > Consultas > Saldos"
}, {
    2153,
    "Financiero - Contabilidad > CDP > Consultas > Solicitud"
}, {
    2034,
    "Financiero - Contabilidad > CDP > Generación"
}, {
    2037,
    "Financiero - Contabilidad > CDP > Generación > Adicionar"
}, {
    2039,
    "Financiero - Contabilidad > CDP > Generación > Anular"
}, {
    2040,
    "Financiero - Contabilidad > CDP > Generación > Aprobar"
}, {
    2043,
    "Financiero - Contabilidad > CDP > Generación > Consultar"
}, {
    2042,
    "Financiero - Contabilidad > CDP > Generación > Habilitar impresión"
}, {
    2041,
    "Financiero - Contabilidad > CDP > Generación > Imprimir"
}, {
    2038,
    "Financiero - Contabilidad > CDP > Generación > Modificar"
}, {
    11657,
    "Financiero - Contabilidad > CDP > Generación > Modificar entidades dinámicas doctos anulados"
}, {
    11658,
    "Financiero - Contabilidad > CDP > Generación > Modificar entidades dinámicas doctos aprobados"
}, {
    11686,
    "Financiero - Contabilidad > CDP > Generación > Modificar entidades dinámicas doctos cumplidos"
}, {
    12305,
    "Financiero - Contabilidad > CDP > Generación > Modificar tipo RP en estado Aprobado"
}, {
    2036,
    "Financiero - Contabilidad > CDP > Reducción"
}, {
    2051,
    "Financiero - Contabilidad > CDP > Reducción > Adicionar"
}, {
    2052,
    "Financiero - Contabilidad > CDP > Reducción > Anular"
}, {
    2053,
    "Financiero - Contabilidad > CDP > Reducción > Aprobar"
}, {
    2054,
    "Financiero - Contabilidad > CDP > Reducción > Consultar"
}, {
    2055,
    "Financiero - Contabilidad > CDP > Reducción > Habilitar impresión"
}, {
    2056,
    "Financiero - Contabilidad > CDP > Reducción > Imprimir"
}, {
    2057,
    "Financiero - Contabilidad > CDP > Reducción > Modificar"
}, {
    11661,
    "Financiero - Contabilidad > CDP > Reducción > Modificar entidades dinámicas doctos anulados"
}, {
    11662,
    "Financiero - Contabilidad > CDP > Reducción > Modificar entidades dinámicas doctos aprobados"
}, {
    11688,
    "Financiero - Contabilidad > CDP > Reducción > Modificar entidades dinámicas doctos cumplidos"
}, {
    2087,
    "Financiero - Contabilidad > CDP > Solicitud"
}, {
    2088,
    "Financiero - Contabilidad > CDP > Solicitud > Adicionar"
}, {
    2089,
    "Financiero - Contabilidad > CDP > Solicitud > Anular"
}, {
    2090,
    "Financiero - Contabilidad > CDP > Solicitud > Aprobar"
}, {
    2091,
    "Financiero - Contabilidad > CDP > Solicitud > Consultar"
}, {
    2097,
    "Financiero - Contabilidad > CDP > Solicitud > Generar CDP"
}, {
    2092,
    "Financiero - Contabilidad > CDP > Solicitud > Habilitar impresión"
}, {
    2093,
    "Financiero - Contabilidad > CDP > Solicitud > Imprimir"
}, {
    2094,
    "Financiero - Contabilidad > CDP > Solicitud > Modificar"
}, {
    2095,
    "Financiero - Contabilidad > CDP > Solicitud > Rechazar"
}, {
    11655,
    "Financiero - Contabilidad > CDP > Solicitud > Modificar entidades dinámicas doctos anulados"
}, {
    11656,
    "Financiero - Contabilidad > CDP > Solicitud > Modificar entidades dinámicas doctos aprobados"
}, {
    11685,
    "Financiero - Contabilidad > CDP > Solicitud > Modificar entidades dinámicas doctos en CDP"
}, {
    11684,
    "Financiero - Contabilidad > CDP > Solicitud > Modificar entidades dinámicas doctos rechazados"
}, {
    817,
    "Financiero - Contabilidad > Informes gerenciales > Balance general"
}, {
    819,
    "Financiero - Contabilidad > Informes gerenciales > Capital de trabajo"
}, {
    818,
    "Financiero - Contabilidad > Informes gerenciales > Estados de resultados"
}, {
    820,
    "Financiero - Contabilidad > Informes gerenciales > Flujo de caja libre"
}, {
    931,
    "Financiero - Contabilidad > Informes gerenciales > Informe de bancos"
}, {
    816,
    "Financiero - Contabilidad > Informes gerenciales > Razones financieras"
}, {
    823,
    "Financiero - Contabilidad > Informes gerenciales > Razones financieras > Consultar"
}, {
    824,
    "Financiero - Contabilidad > Informes gerenciales > Razones financieras > Imprimir"
}, {
    815,
    "Financiero - Contabilidad > Informes gerenciales > Configuración rubros"
}, {
    850,
    "Financiero - Contabilidad > Informes gerenciales > Configuración rubros > Adicionar"
}, {
    852,
    "Financiero - Contabilidad > Informes gerenciales > Configuración rubros > Consultar"
}, {
    10673,
    "Financiero - Contabilidad > Informes gerenciales > Configuración rubros > Duplicar"
}, {
    851,
    "Financiero - Contabilidad > Informes gerenciales > Configuración rubros > Eliminar"
}, {
    821,
    "Financiero - Contabilidad > Informes gerenciales > Configuración rubros > Modificar"
}, {
    822,
    "Financiero - Contabilidad > Informes gerenciales > Configuración rubros > Reporte"
}, {
    814,
    "Financiero - Contabilidad > Informes gerenciales"
}, {
    364,
    "Financiero - Contabilidad > Procesos periódicos > Cierre de año"
}, {
    4443,
    "Financiero - Contabilidad > Procesos periódicos > Cierre cuentas de balance - Peru"
}, {
    7070,
    "Financiero - Contabilidad > Procesos periódicos > Cierre de cuentas de resultado periódico"
}, {
    7072,
    "Financiero - Contabilidad > Procesos periódicos > Cierre de cuentas de resultado periódico > Generar"
}, {
    7071,
    "Financiero - Contabilidad > Procesos periódicos > Cierre de cuentas de resultado periódico > Refrescar"
}, {
    4445,
    "Financiero - Contabilidad > Procesos periódicos > Cierre cuentas de resultado - Peru"
}, {
    4446,
    "Financiero - Contabilidad > Procesos periódicos > Cierre cuentas de resultado - Peru > Configurar"
}, {
    4447,
    "Financiero - Contabilidad > Procesos periódicos > Cierre cuentas de resultado - Peru > Generar"
}, {
    363,
    "Financiero - Contabilidad > Procesos periódicos > Cierre cuentas de resultado"
}, {
    368,
    "Financiero - Contabilidad > Procesos periódicos > Cierre cuentas de resultado > Generar"
}, {
    367,
    "Financiero - Contabilidad > Procesos periódicos > Cierre cuentas de resultado > Refrescar"
}, {
    362,
    "Financiero - Contabilidad > Procesos periódicos > Periodos > Cierre de periodo"
}, {
    311,
    "Financiero - Contabilidad > Conciliación bancaria"
}, {
    336,
    "Financiero - Contabilidad > Conciliación bancaria > Adicionar"
}, {
    340,
    "Financiero - Contabilidad > Conciliación bancaria > Aprobar"
}, {
    11431,
    "Financiero - Contabilidad > Conciliación bancaria de tarjetas"
}, {
    11432,
    "Financiero - Contabilidad > Conciliación bancaria de tarjetas > Adicionar"
}, {
    11433,
    "Financiero - Contabilidad > Conciliación bancaria de tarjetas > Aprobar"
}, {
    11434,
    "Financiero - Contabilidad > Conciliación bancaria de tarjetas > Consultar"
}, {
    11435,
    "Financiero - Contabilidad > Conciliación bancaria de tarjetas > Eliminar"
}, {
    11436,
    "Financiero - Contabilidad > Conciliación bancaria de tarjetas > Importar extracto"
}, {
    11437,
    "Financiero - Contabilidad > Conciliación bancaria de tarjetas > Imprimir"
}, {
    11438,
    "Financiero - Contabilidad > Conciliación bancaria de tarjetas > Modificar"
}, {
    11439,
    "Financiero - Contabilidad > Conciliación bancaria de tarjetas > Recalcular"
}, {
    335,
    "Financiero - Contabilidad > Conciliación bancaria > Consultar"
}, {
    1663,
    "Financiero - Contabilidad > Conciliación bancaria > Contabilizar extracto"
}, {
    339,
    "Financiero - Contabilidad > Conciliación bancaria > Eliminar"
}, {
    7993,
    "Maestros > Bancos > Formatos de extractos tarjetas"
}, {
    7994,
    "Maestros > Bancos > Formatos de extractos tarjetas > Adicionar"
}, {
    7996,
    "Maestros > Bancos > Formatos de extractos tarjetas > Eliminar"
}, {
    7995,
    "Maestros > Bancos > Formatos de extractos tarjetas > Modificar"
}, {
    535,
    "Financiero - Contabilidad > Conciliación bancaria > Importar extracto"
}, {
    342,
    "Financiero - Contabilidad > Conciliación bancaria > Imprimir"
}, {
    337,
    "Financiero - Contabilidad > Conciliación bancaria > Modificar"
}, {
    11303,
    "Financiero - Contabilidad > Conciliación bancaria > Permitir generar en elaboración al contabilizar"
}, {
    338,
    "Financiero - Contabilidad > Conciliación bancaria > Recalcular"
}, {
    7973,
    "Financiero - Contabilidad > Consultas > Informes fiscales"
}, {
    7972,
    "Financiero - Contabilidad > Consultas > Informes fiscales > Relación de impuestos"
}, {
    10748,
    "Financiero - Contabilidad > Consultas > Resumen de movimiento contable comparativo"
}, {
    308,
    "Financiero - Contabilidad > Consultas"
}, {
    8404,
    "Financiero - Contabilidad > Consultas > Sumarizados comparativos libros"
}, {
    8466,
    "Financiero - Contabilidad > Consultas > Sumarizados comparativos libros > Balance general"
}, {
    8472,
    "Financiero - Contabilidad > Consultas > Sumarizados comparativos libros > Estado de resultado"
}, {
    8405,
    "Financiero - Contabilidad > Consultas > Sumarizados comparativos libros > Balance de comprobación de saldos"
}, {
    385,
    "Financiero - Contabilidad > Consultas > Auditoria de consecutivos"
}, {
    384,
    "Financiero - Contabilidad > Consultas > Auditoria de documentos"
}, {
    541,
    "Financiero - Contabilidad > Consultas > Auxiliares sin plan"
}, {
    376,
    "Financiero - Contabilidad > Consultas > Centros de costos"
}, {
    378,
    "Financiero - Contabilidad > Consultas > Conceptos de F.E."
}, {
    374,
    "Financiero - Contabilidad > Consultas > Mayores y auxiliares"
}, {
    3758,
    "Financiero - Contabilidad > Consultas > Planilla de documentos"
}, {
    2096,
    "Financiero - Contabilidad > Consultas > Resumen de movimiento contable"
}, {
    2064,
    "Financiero - Contabilidad > Consultas > Rubros de cuenta"
}, {
    544,
    "Financiero - Contabilidad > Consultas > Saldos diferidos"
}, {
    2398,
    "Financiero - Contabilidad > Consultas > Sumarizados"
}, {
    2399,
    "Financiero - Contabilidad > Consultas > Sumarizados > Balance de comprobacion"
}, {
    2400,
    "Financiero - Contabilidad > Consultas > Sumarizados > Balance general"
}, {
    2401,
    "Financiero - Contabilidad > Consultas > Sumarizados > Estado de resultado"
}, {
    2518,
    "Financiero - Contabilidad > Consultas > Sumarizados > Flujo de efectivo"
}, {
    2519,
    "Financiero - Contabilidad > Consultas > Sumarizados > Presupuesto de flujo de efectivo"
}, {
    2457,
    "Financiero - Contabilidad > Consultas > Sumarizados > Presupuesto"
}, {
    375,
    "Financiero - Contabilidad > Consultas > Terceros"
}, {
    7094,
    "Financiero - Contabilidad > Procesos periódicos > Periodos > Creación de periodos anteriores"
}, {
    12802,
    "Financiero - Contabilidad > Procesos periódicos > Periodos > Cierre de periodo > No obligar dif. cambio en fecha hasta del periodo"
}, {
    325,
    "Financiero - Contabilidad > Procesos periódicos > Diferencia en cambio"
}, {
    330,
    "Financiero - Contabilidad > Procesos periódicos > Diferencia en cambio > Generar"
}, {
    329,
    "Financiero - Contabilidad > Procesos periódicos > Diferencia en cambio > Imprimir"
}, {
    12279,
    "Financiero - Contabilidad > Procesos periódicos > Diferencia en cambio > Permite ajustar solo libro 2"
}, {
    327,
    "Financiero - Contabilidad > Procesos periódicos > Diferencia en cambio > Recalcular"
}, {
    328,
    "Financiero - Contabilidad > Procesos periódicos > Diferencia en cambio > Permite generar por un C.O. diferente al del docto"
}, {
    4343,
    "Financiero - Contabilidad > Procesos periódicos > Diferencia en re-expresión"
}, {
    4346,
    "Financiero - Contabilidad > Procesos periódicos > Diferencia en re-expresión > Permite generar por C.O. diferente al del docto"
}, {
    4344,
    "Financiero - Contabilidad > Procesos periódicos > Diferencia en re-expresión > Generar"
}, {
    4345,
    "Financiero - Contabilidad > Procesos periódicos > Diferencia en re-expresión > Imprimir"
}, {
    4347,
    "Financiero - Contabilidad > Procesos periódicos > Diferencia en re-expresión > Recalcular"
}, {
    321,
    "Financiero - Contabilidad > Procesos periódicos > Diferidos"
}, {
    323,
    "Financiero - Contabilidad > Procesos periódicos > Diferidos > Edición > Consultar"
}, {
    543,
    "Financiero - Contabilidad > Procesos periódicos > Diferidos > Consulta de saldos"
}, {
    370,
    "Financiero - Contabilidad > Procesos periódicos > Diferidos > Generación"
}, {
    373,
    "Financiero - Contabilidad > Procesos periódicos > Diferidos > Generación > Generar"
}, {
    372,
    "Financiero - Contabilidad > Procesos periódicos > Diferidos > Generación > Imprimir"
}, {
    324,
    "Financiero - Contabilidad > Procesos periódicos > Diferidos > Edición > Modificar"
}, {
    371,
    "Financiero - Contabilidad > Procesos periódicos > Diferidos > Generación > Permite generar por un C.O. diferente al del docto"
}, {
    322,
    "Financiero - Contabilidad > Procesos periódicos > Diferidos > Edición"
}, {
    1036,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos"
}, {
    1038,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Bases de distribución"
}, {
    1039,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Bases de distribución > Modificar"
}, {
    1040,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Bases de distribución > Reporte"
}, {
    2253,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Bases variables"
}, {
    2254,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Bases variables > Adicionar"
}, {
    2257,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Bases variables > Consulta"
}, {
    2256,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Bases variables > Eliminar"
}, {
    2255,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Bases variables > Modificar"
}, {
    2271,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Consulta movimiento distribución"
}, {
    2079,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Manual"
}, {
    2080,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Manual > Adicionar"
}, {
    2081,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Manual > Anular"
}, {
    2082,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Manual > Aprobar"
}, {
    2083,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Manual > Consultar"
}, {
    2084,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Manual > Habilitar impresión"
}, {
    2085,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Manual > Imprimir"
}, {
    2086,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Manual > Modificar"
}, {
    1037,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Generación"
}, {
    1043,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Generación > Generar"
}, {
    1041,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Generación > Refrescar"
}, {
    1042,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Generación > Reporte"
}, {
    2259,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Proceso aplicación de tarifas"
}, {
    2258,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Proceso distribución"
}, {
    2263,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Proceso aplicación de tarifas > Generar"
}, {
    2262,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Proceso aplicación de tarifas > Refrescar"
}, {
    2261,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Proceso distribución > Generar"
}, {
    2260,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Proceso distribución > Refrescar"
}, {
    2063,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Tarifas por actividad/centro de costo"
}, {
    2148,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de cuentas"
}, {
    2152,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de cuentas > Editar"
}, {
    2149,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de cuentas > Generar"
}, {
    7485,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de cuentas > Permite genera varios doctos en el mismo periodo"
}, {
    2150,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de cuentas > Refrescar"
}, {
    2151,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de cuentas > Reporte"
}, {
    8415,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de impuestos"
}, {
    8416,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de impuestos > Generar"
}, {
    7751,
    "Financiero - Contabilidad > Documentos > No obligar valor impuesto en recaudos"
}, {
    307,
    "Financiero - Contabilidad > Documentos"
}, {
    315,
    "Financiero - Contabilidad > Documentos > Adicionar"
}, {
    318,
    "Financiero - Contabilidad > Documentos > Anular"
}, {
    317,
    "Financiero - Contabilidad > Documentos > Aprobar"
}, {
    3573,
    "Financiero - Contabilidad > Documentos > Permite asientos negativos"
}, {
    7552,
    "Financiero - Contabilidad > Documentos > Capturar multiples libros"
}, {
    2768,
    "Financiero - Contabilidad > Documentos > Cerrar doctos entre compañias sin aprobar"
}, {
    314,
    "Financiero - Contabilidad > Documentos > Consultar"
}, {
    545,
    "Financiero - Contabilidad > Documentos > Eliminar"
}, {
    320,
    "Financiero - Contabilidad > Documentos > Habilitar impresión"
}, {
    319,
    "Financiero - Contabilidad > Documentos > Imprimir"
}, {
    6779,
    "Financiero - Contabilidad > Documentos > Permitir mandatos de diferente C.O."
}, {
    316,
    "Financiero - Contabilidad > Documentos > Modificar"
}, {
    1662,
    "Financiero - Contabilidad > Documentos > Modificar fecha de saldo abierto"
}, {
    4732,
    "Financiero - Contabilidad > Documentos > Modificar notas a doctos aprobados"
}, {
    546,
    "Financiero - Contabilidad > Documentos > Modificar nro cheque"
}, {
    6750,
    "Financiero - Contabilidad > Documentos > Modificar entidades dinámicas docto aprobados"
}, {
    6749,
    "Financiero - Contabilidad > Documentos > Modificar entidades dinámicas docto en elaboración"
}, {
    7091,
    "-No implementado > Permitir modificar valor impuesto en recaudos"
}, {
    4766,
    "Financiero - Contabilidad > Documentos de re-expresion"
}, {
    4767,
    "Financiero - Contabilidad > Documentos de re-expresion > Adicionar"
}, {
    4768,
    "Financiero - Contabilidad > Documentos de re-expresion > Anular"
}, {
    4769,
    "Financiero - Contabilidad > Documentos de re-expresion > Aprobar"
}, {
    4775,
    "Financiero - Contabilidad > Documentos de re-expresion > Permite asientos negativos"
}, {
    7553,
    "Financiero - Contabilidad > Documentos de re-expresion > Capturar multiples libros"
}, {
    4770,
    "Financiero - Contabilidad > Documentos de re-expresion > Consultar"
}, {
    4771,
    "Financiero - Contabilidad > Documentos de re-expresion > Habilitar impresión"
}, {
    4772,
    "Financiero - Contabilidad > Documentos de re-expresion > Imprimir"
}, {
    4773,
    "Financiero - Contabilidad > Documentos de re-expresion > Modificar"
}, {
    7624,
    "Financiero - Contabilidad > Documentos de re-expresion > Modificar entidades dinamicas doctos aprobados"
}, {
    7625,
    "Financiero - Contabilidad > Documentos de re-expresion > Modificar entidades dinamicas docto en elaboración"
}, {
    4774,
    "Financiero - Contabilidad > Documentos de re-expresion > Modificar notas a doctos aprobados"
}, {
    358,
    "Financiero - Contabilidad > Importar y exportar > Exportar"
}, {
    1919,
    "Financiero - Contabilidad > Importar y exportar > Desmarcar transmitidos"
}, {
    1000,
    "Financiero - Contabilidad > Flujo de efectivo > Consulta"
}, {
    1563,
    "Financiero - Contabilidad > Flujo de efectivo > Edición multiple"
}, {
    997,
    "Financiero - Contabilidad > Flujo de efectivo > Plan presupuestal"
}, {
    1001,
    "Financiero - Contabilidad > Flujo de efectivo > Plan presupuestal > Adicionar"
}, {
    1002,
    "Financiero - Contabilidad > Flujo de efectivo > Plan presupuestal > Consultar"
}, {
    1003,
    "Financiero - Contabilidad > Flujo de efectivo > Plan presupuestal > Duplicar"
}, {
    1004,
    "Financiero - Contabilidad > Flujo de efectivo > Plan presupuestal > Eliminar"
}, {
    1006,
    "Financiero - Contabilidad > Flujo de efectivo > Plan presupuestal > Modificar"
}, {
    1005,
    "Financiero - Contabilidad > Flujo de efectivo > Plan presupuestal > Reporte"
}, {
    998,
    "Financiero - Contabilidad > Flujo de efectivo > Presupuesto"
}, {
    1008,
    "Financiero - Contabilidad > Flujo de efectivo > Presupuesto > Consultar"
}, {
    1576,
    "Financiero - Contabilidad > Flujo de efectivo > Presupuesto > Importar"
}, {
    1010,
    "Financiero - Contabilidad > Flujo de efectivo > Presupuesto > Modificar"
}, {
    999,
    "Financiero - Contabilidad > Flujo de efectivo > Reporte"
}, {
    996,
    "Financiero - Contabilidad > Flujo de efectivo"
}, {
    3321,
    "Financiero - Contabilidad > Generación documento contable"
}, {
    357,
    "Financiero - Contabilidad > Importar y exportar > Importar"
}, {
    1664,
    "Financiero - Contabilidad > Importar y exportar > Eliminar lote de importación"
}, {
    313,
    "Financiero - Contabilidad > Importar y exportar"
}, {
    1849,
    "Financiero - Contabilidad > Importar y exportar > Log de importaciones externas"
}, {
    1848,
    "Financiero - Contabilidad > Importar y exportar > Log de importaciones externas > Mantenimiento"
}, {
    1846,
    "Financiero - Contabilidad > Importar y exportar > Monitor de importación"
}, {
    3689,
    "Financiero - Contabilidad > Importar y exportar > Importar > No permitir importaciones parciales"
}, {
    2786,
    "Financiero - Contabilidad > Informes a entidades"
}, {
    326,
    "Financiero - Contabilidad > Procesos periódicos > Inflación"
}, {
    334,
    "Financiero - Contabilidad > Procesos periódicos > Inflación > Generar"
}, {
    333,
    "Financiero - Contabilidad > Procesos periódicos > Inflación > Imprimir"
}, {
    331,
    "Financiero - Contabilidad > Procesos periódicos > Inflación > Recalcular"
}, {
    332,
    "Financiero - Contabilidad > Procesos periódicos > Inflación > Permite generar por un C.O. diferente al del docto"
}, {
    3625,
    "Financiero - Contabilidad > Informes a entidades > Certificado de proveedor"
}, {
    3630,
    "Financiero - Contabilidad > Informes a entidades > Certificado de proveedor > Captura certificados"
}, {
    3631,
    "Financiero - Contabilidad > Informes a entidades > Certificado de proveedor > Captura certificados > Adicionar"
}, {
    3632,
    "Financiero - Contabilidad > Informes a entidades > Certificado de proveedor > Captura certificados > Anular"
}, {
    3633,
    "Financiero - Contabilidad > Informes a entidades > Certificado de proveedor > Captura certificados > Aprobar"
}, {
    3634,
    "Financiero - Contabilidad > Informes a entidades > Certificado de proveedor > Captura certificados > Consultar"
}, {
    3635,
    "Financiero - Contabilidad > Informes a entidades > Certificado de proveedor > Captura certificados > Desaprobar"
}, {
    3636,
    "Financiero - Contabilidad > Informes a entidades > Certificado de proveedor > Captura certificados > Habilitar impresion"
}, {
    3637,
    "Financiero - Contabilidad > Informes a entidades > Certificado de proveedor > Captura certificados > Imprimir"
}, {
    3638,
    "Financiero - Contabilidad > Informes a entidades > Certificado de proveedor > Captura certificados > Modificar"
}, {
    3639,
    "Financiero - Contabilidad > Informes a entidades > Certificado de proveedor > Consultas"
}, {
    3640,
    "Financiero - Contabilidad > Informes a entidades > Certificado de proveedor > Consultas > Certificados"
}, {
    3641,
    "Financiero - Contabilidad > Informes a entidades > Certificado de proveedor > Consultas > Certificados por item"
}, {
    3629,
    "Financiero - Contabilidad > Informes a entidades > Certificado de proveedor > Generacion desde facturas"
}, {
    3642,
    "Financiero - Contabilidad > Informes a entidades > Certificado de proveedor > Impresion"
}, {
    3643,
    "Financiero - Contabilidad > Informes a entidades > Certificado de proveedor > Informacion DIAN (Res. 1756)"
}, {
    3644,
    "Financiero - Contabilidad > Informes a entidades > Certificado de proveedor > Maestros asociados"
}, {
    3626,
    "Financiero - Contabilidad > Informes a entidades > Certificado de proveedor > Maestros asociados > Datos compañias"
}, {
    3628,
    "Financiero - Contabilidad > Informes a entidades > Certificado de proveedor > Maestros asociados > Tipos de identificacion"
}, {
    3627,
    "Financiero - Contabilidad > Informes a entidades > Certificado de proveedor > Maestros asociados > Unidades de medida"
}, {
    2787,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005"
}, {
    2800,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Conceptos"
}, {
    2801,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Conceptos > Adicionar"
}, {
    2802,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Conceptos > Consultar"
}, {
    2803,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Conceptos > Duplicar"
}, {
    2804,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Conceptos > Eliminar"
}, {
    2805,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Conceptos > Modificar"
}, {
    2822,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Conceptos > Reporte"
}, {
    7623,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Consorciados"
}, {
    7627,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Consorciados > Adicionar"
}, {
    2826,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Envios por año"
}, {
    2827,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Envios por año > Adicionar"
}, {
    2828,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Envios por año > Consultar"
}, {
    2829,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Envios por año > Eliminar"
}, {
    2830,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Envios por año > Modificar"
}, {
    2831,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Envios por año > Reportes"
}, {
    2806,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Formato - Concepto"
}, {
    2807,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Formato - Concepto > Adicionar"
}, {
    2808,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Formato - Concepto > Consultar"
}, {
    2809,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Formato - Concepto > Duplicar"
}, {
    2810,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Formato - Concepto > Eliminar"
}, {
    2811,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Formato - Concepto > Modificar"
}, {
    2823,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Formato - Concepto > Reporte"
}, {
    2788,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Formatos"
}, {
    2789,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Formatos > Adicionar"
}, {
    2790,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Formatos > Consultar"
}, {
    2791,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Formatos > Duplicar"
}, {
    2792,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Formatos > Eliminar"
}, {
    2793,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Formatos > Modificar"
}, {
    2824,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Formatos > Reporte"
}, {
    2794,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Grupos"
}, {
    2795,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Grupos > Adicionar"
}, {
    2796,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Grupos > Consultar"
}, {
    2797,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Grupos > Duplicar"
}, {
    2798,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Grupos > Eliminar"
}, {
    2799,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Grupos > Modificar"
}, {
    2825,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Grupos > Reporte"
}, {
    8575,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Información de municipios"
}, {
    8576,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Información de municipios > Adicionar"
}, {
    8577,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Información de municipios > Consultar"
}, {
    8578,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Información de municipios > Eliminar"
}, {
    8579,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Información de municipios > Generar"
}, {
    8580,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Información de municipios > Modificar"
}, {
    2812,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Proceso DIAN Art 631"
}, {
    2813,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Proceso DIAN Art 631 > Adicionar"
}, {
    2814,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Proceso DIAN Art 631 > Consultar"
}, {
    2840,
    "-No implementado > Proceso DDI-007459"
}, {
    2841,
    "-No implementado > Proceso DDI-007459 > Adicionar"
}, {
    2842,
    "-No implementado > Proceso DDI-007459 > Consultar"
}, {
    2843,
    "-No implementado > Proceso DDI-007459 > Eliminar"
}, {
    2844,
    "-No implementado > Proceso DDI-007459 > Generar"
}, {
    2845,
    "-No implementado > Proceso DDI-007459 > Modificar"
}, {
    2815,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Proceso DIAN Art 631 > Eliminar"
}, {
    2816,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Proceso DIAN Art 631 > Generar"
}, {
    2817,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Proceso DIAN Art 631 > Modificar"
}, {
    3310,
    "-No implementado > Reporte SICALI (1137 Y 1138)"
}, {
    1437,
    "Financiero - Contabilidad > Procesos periódicos > Periodos"
}, {
    10515,
    "Financiero - Contabilidad > Procesos periódicos > Periodos > Desactivar peridos"
}, {
    10516,
    "Financiero - Contabilidad > Procesos periódicos > Periodos > Modificar fecha final"
}, {
    3574,
    "Financiero - Contabilidad > Planilla de documentos"
}, {
    3575,
    "Financiero - Contabilidad > Planilla de documentos > Adicionar"
}, {
    3576,
    "Financiero - Contabilidad > Planilla de documentos > Anular"
}, {
    3577,
    "Financiero - Contabilidad > Planilla de documentos > Aprobar"
}, {
    3584,
    "Financiero - Contabilidad > Planilla de documentos > Cerrar"
}, {
    3578,
    "Financiero - Contabilidad > Planilla de documentos > Consultar"
}, {
    3579,
    "Financiero - Contabilidad > Planilla de documentos > Desaprobar"
}, {
    3585,
    "Financiero - Contabilidad > Planilla de documentos > Deshacer"
}, {
    3587,
    "Financiero - Contabilidad > Planilla de documentos > Habilitar impresión"
}, {
    3586,
    "Financiero - Contabilidad > Planilla de documentos > Imprimir"
}, {
    3580,
    "Financiero - Contabilidad > Planilla de documentos > Modificar"
}, {
    3756,
    "Financiero - Contabilidad > Planilla de documentos > Permitir mandatos de diferente C.O."
}, {
    2209,
    "Financiero - Contabilidad > Presupuesto de obra"
}, {
    2232,
    "Financiero - Contabilidad > Presupuesto de obra > Consulta"
}, {
    2235,
    "Financiero - Contabilidad > Presupuesto de obra > Consulta > Cuadro de acumulados"
}, {
    2234,
    "Financiero - Contabilidad > Presupuesto de obra > Consulta > Cuadro de proyecciones"
}, {
    2236,
    "Financiero - Contabilidad > Presupuesto de obra > Consulta > Documentos"
}, {
    2237,
    "Financiero - Contabilidad > Presupuesto de obra > Consulta > Movimientos"
}, {
    2310,
    "Financiero - Contabilidad > Presupuesto de obra > Consulta > Movimiento contable"
}, {
    2233,
    "Financiero - Contabilidad > Presupuesto de obra > Consulta > Presupuesto de obra"
}, {
    2238,
    "Financiero - Contabilidad > Presupuesto de obra > Consulta > Resumen"
}, {
    2240,
    "Financiero - Contabilidad > Presupuesto de obra > Habilitar impresión"
}, {
    2239,
    "Financiero - Contabilidad > Presupuesto de obra > Imprimir documentos"
}, {
    2228,
    "Financiero - Contabilidad > Presupuesto de obra > Presupuesto de obra"
}, {
    2229,
    "Financiero - Contabilidad > Presupuesto de obra > Presupuesto de obra > Adicionar"
}, {
    2231,
    "Financiero - Contabilidad > Presupuesto de obra > Presupuesto de obra > Eliminar"
}, {
    2242,
    "Financiero - Contabilidad > Presupuesto de obra > Presupuesto de obra > Importar"
}, {
    2230,
    "Financiero - Contabilidad > Presupuesto de obra > Presupuesto de obra > Modificar"
}, {
    2210,
    "Financiero - Contabilidad > Presupuesto de obra > Reporte cantidad ejecutada"
}, {
    2212,
    "Financiero - Contabilidad > Presupuesto de obra > Reporte cantidad ejecutada > Adicionar"
}, {
    2213,
    "Financiero - Contabilidad > Presupuesto de obra > Reporte cantidad ejecutada > Anular"
}, {
    2214,
    "Financiero - Contabilidad > Presupuesto de obra > Reporte cantidad ejecutada > Aprobar"
}, {
    2215,
    "Financiero - Contabilidad > Presupuesto de obra > Reporte cantidad ejecutada > Consultar"
}, {
    2216,
    "Financiero - Contabilidad > Presupuesto de obra > Reporte cantidad ejecutada > Eliminar"
}, {
    2219,
    "Financiero - Contabilidad > Presupuesto de obra > Reporte cantidad ejecutada > Modificar"
}, {
    2211,
    "Financiero - Contabilidad > Presupuesto de obra > Reporte cantidad facturada"
}, {
    2220,
    "Financiero - Contabilidad > Presupuesto de obra > Reporte cantidad facturada > Adicionar"
}, {
    2221,
    "Financiero - Contabilidad > Presupuesto de obra > Reporte cantidad facturada > Anular"
}, {
    2222,
    "Financiero - Contabilidad > Presupuesto de obra > Reporte cantidad facturada > Aprobar"
}, {
    2223,
    "Financiero - Contabilidad > Presupuesto de obra > Reporte cantidad facturada > Consultar"
}, {
    2224,
    "Financiero - Contabilidad > Presupuesto de obra > Reporte cantidad facturada > Eliminar"
}, {
    2227,
    "Financiero - Contabilidad > Presupuesto de obra > Reporte cantidad facturada > Modificar"
}, {
    2010,
    "Financiero - Contabilidad > Presupuesto oficial"
}, {
    2019,
    "Financiero - Contabilidad > Presupuesto oficial > Captura"
}, {
    2020,
    "Financiero - Contabilidad > Presupuesto oficial > Captura > Adicionar"
}, {
    2022,
    "Financiero - Contabilidad > Presupuesto oficial > Captura > Eliminar"
}, {
    2021,
    "Financiero - Contabilidad > Presupuesto oficial > Captura > Modificar"
}, {
    2058,
    "Financiero - Contabilidad > Presupuesto oficial > Consultas"
}, {
    2060,
    "Financiero - Contabilidad > Presupuesto oficial > Consultas > Ejecución de egresos"
}, {
    2061,
    "Financiero - Contabilidad > Presupuesto oficial > Consultas > Ejecución de ingresos"
}, {
    2059,
    "Financiero - Contabilidad > Presupuesto oficial > Consultas > Presupuesto"
}, {
    2011,
    "Financiero - Contabilidad > Presupuesto oficial > Control"
}, {
    2012,
    "Financiero - Contabilidad > Presupuesto oficial > Control > Adicionar"
}, {
    2017,
    "Financiero - Contabilidad > Presupuesto oficial > Control > Aprobar"
}, {
    2016,
    "Financiero - Contabilidad > Presupuesto oficial > Control > Consultar"
}, {
    2018,
    "Financiero - Contabilidad > Presupuesto oficial > Control > Desaprobar"
}, {
    2014,
    "Financiero - Contabilidad > Presupuesto oficial > Control > Eliminar"
}, {
    2013,
    "Financiero - Contabilidad > Presupuesto oficial > Control > Modificar"
}, {
    2015,
    "Financiero - Contabilidad > Presupuesto oficial > Control > Reporte"
}, {
    2032,
    "Financiero - Contabilidad > Presupuesto oficial > Importar"
}, {
    12011,
    "Financiero - Contabilidad > Presupuesto oficial > Impresión de documentos"
}, {
    12012,
    "Financiero - Contabilidad > Presupuesto oficial > Impresión de documentos > CDPs"
}, {
    2023,
    "Financiero - Contabilidad > Presupuesto oficial > Movimiento"
}, {
    2028,
    "Financiero - Contabilidad > Presupuesto oficial > Movimiento > Adición - adicionar"
}, {
    2029,
    "Financiero - Contabilidad > Presupuesto oficial > Movimiento > Adición - eliminar"
}, {
    2030,
    "Financiero - Contabilidad > Presupuesto oficial > Movimiento > Consultar"
}, {
    2031,
    "Financiero - Contabilidad > Presupuesto oficial > Movimiento > Eliminar"
}, {
    2026,
    "Financiero - Contabilidad > Presupuesto oficial > Movimiento > Reducción - adicionar"
}, {
    2027,
    "Financiero - Contabilidad > Presupuesto oficial > Movimiento > Reducción - eliminar"
}, {
    2024,
    "Financiero - Contabilidad > Presupuesto oficial > Movimiento > Traslado - adicionar"
}, {
    2025,
    "Financiero - Contabilidad > Presupuesto oficial > Movimiento > Traslado - eliminar"
}, {
    12197,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal"
}, {
    12373,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Consultas"
}, {
    12374,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Consultas > Registro presupuestal"
}, {
    12207,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Documentos"
}, {
    12474,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Documentos > Liberación"
}, {
    12473,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Documentos > Proceso liberación"
}, {
    12208,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Documentos > Registro presupuestal"
}, {
    12209,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Documentos > Registro presupuestal > Adicionar"
}, {
    12210,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Documentos > Registro presupuestal > Anular"
}, {
    12211,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Documentos > Registro presupuestal > Aprobar"
}, {
    12212,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Documentos > Registro presupuestal > Consultar"
}, {
    12216,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Documentos > Registro presupuestal > Modificar entidades dinámicas doctos aprobados"
}, {
    12213,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Documentos > Registro presupuestal > Habilitar impresión"
}, {
    12214,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Documentos > Registro presupuestal > Imprimir"
}, {
    12215,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Documentos > Registro presupuestal > Modificar"
}, {
    12476,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Documentos > Liberación > Anular"
}, {
    12475,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Documentos > Liberación > Consultar"
}, {
    12477,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Documentos > Liberación > Habilitar impresión"
}, {
    12478,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Documentos > Liberación > Imprimir"
}, {
    12479,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Documentos > Liberación > Modificar entidades dinámicas doctos aprobados"
}, {
    12198,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Maestros"
}, {
    12199,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Maestros > Tipos de registro presupuestal"
}, {
    12200,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Maestros > Tipos de registro presupuestal > Adicionar"
}, {
    12201,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Maestros > Tipos de registro presupuestal > Cambiar código"
}, {
    12202,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Maestros > Tipos de registro presupuestal > Consultar"
}, {
    12203,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Maestros > Tipos de registro presupuestal > Duplicar"
}, {
    12204,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Maestros > Tipos de registro presupuestal > Eliminar"
}, {
    12205,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Maestros > Tipos de registro presupuestal > Modificar"
}, {
    12206,
    "Financiero - Contabilidad > Presupuesto oficial > Registro presupuestal > Maestros > Tipos de registro presupuestal > Reporte"
}, {
    7382,
    "Financiero - Contabilidad > Presupuesto oficial > Traslado de vigencia"
}, {
    9515,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero"
}, {
    9598,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Consultas"
}, {
    9599,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Consultas > Instrumentos financieros"
}, {
    9543,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Documentos"
}, {
    9544,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Documentos > Adicionar"
}, {
    9545,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Documentos > Anular"
}, {
    9724,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Documentos > Anular documentos desde factura"
}, {
    9546,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Documentos > Aprobar"
}, {
    9547,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Documentos > Consultar"
}, {
    9551,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Documentos > Modificar entidades dinámicas doctos aprobados"
}, {
    9548,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Documentos > Habilitar impresión"
}, {
    9549,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Documentos > Imprimir"
}, {
    9550,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Documentos > Modificar"
}, {
    9516,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Maestros asociados"
}, {
    9552,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Proceso amortización"
}, {
    9554,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Proceso amortización > Generar"
}, {
    9553,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Proceso amortización > Refrescar"
}, {
    9517,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Maestros asociados > Tasas"
}, {
    9518,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Maestros asociados > Tasas > Adicionar"
}, {
    9520,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Maestros asociados > Tasas > Eliminar"
}, {
    9519,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Maestros asociados > Tasas > Modificar"
}, {
    9521,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Maestros asociados > Tipos"
}, {
    9522,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Maestros asociados > Tipos > Adicionar"
}, {
    9523,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Maestros asociados > Tipos > Consultar"
}, {
    9527,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Maestros asociados > Tipos > Duplicar"
}, {
    9524,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Maestros asociados > Tipos > Eliminar"
}, {
    9525,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Maestros asociados > Tipos > Modificar"
}, {
    9526,
    "Financiero - Contabilidad > Procesos periódicos > Instrumento financiero > Maestros asociados > Tipos > Reporte"
}, {
    345,
    "Financiero - Contabilidad > Presupuesto > Definicion > Presupuesto"
}, {
    353,
    "Financiero - Contabilidad > Presupuesto > Definicion > Presupuesto > Adicionar"
}, {
    352,
    "Financiero - Contabilidad > Presupuesto > Definicion > Presupuesto > Consultar"
}, {
    4799,
    "Financiero - Contabilidad > Presupuesto > Definicion > Presupuesto > Permitir cuentas inactivas"
}, {
    343,
    "Financiero - Contabilidad > Presupuesto > Definicion"
}, {
    355,
    "Financiero - Contabilidad > Presupuesto > Definicion > Presupuesto > Eliminar"
}, {
    7848,
    "Financiero - Contabilidad > Presupuesto > Definicion > Presupuesto > Eliminar por año"
}, {
    346,
    "Financiero - Contabilidad > Presupuesto > Definicion > Generación"
}, {
    1562,
    "Financiero - Contabilidad > Presupuesto > Definicion > Presupuesto > Importar"
}, {
    354,
    "Financiero - Contabilidad > Presupuesto > Definicion > Presupuesto > Modificar"
}, {
    3954,
    "Financiero - Contabilidad > Presupuesto > Definicion > Presupuesto > No obligar C.O en el filtro"
}, {
    3955,
    "Financiero - Contabilidad > Presupuesto > Definicion > Presupuesto > No obligar U.N en el filtro"
}, {
    344,
    "Financiero - Contabilidad > Presupuesto > Definicion > Plan presupuestal"
}, {
    348,
    "Financiero - Contabilidad > Presupuesto > Definicion > Plan presupuestal > Adicionar"
}, {
    347,
    "Financiero - Contabilidad > Presupuesto > Definicion > Plan presupuestal > Consultar"
}, {
    534,
    "Financiero - Contabilidad > Presupuesto > Definicion > Plan presupuestal > Duplicar"
}, {
    350,
    "Financiero - Contabilidad > Presupuesto > Definicion > Plan presupuestal > Eliminar"
}, {
    351,
    "Financiero - Contabilidad > Presupuesto > Definicion > Plan presupuestal > Imprimir"
}, {
    349,
    "Financiero - Contabilidad > Presupuesto > Definicion > Plan presupuestal > Modificar"
}, {
    536,
    "Financiero - Contabilidad > Presupuesto > Reportes"
}, {
    538,
    "Financiero - Contabilidad > Presupuesto > Reportes > Centros de costos"
}, {
    537,
    "Financiero - Contabilidad > Presupuesto > Reportes > Cuentas"
}, {
    312,
    "Financiero - Contabilidad > Presupuesto"
}, {
    7224,
    "Financiero - Contabilidad > Presupuesto > Acumulados"
}, {
    7225,
    "Financiero - Contabilidad > Presupuesto > Acumulados > Cubo de presupuesto"
}, {
    3931,
    "Financiero - Contabilidad > Presupuesto > Definicion > Presupuesto > Permite ver auxiliares bloqueadas"
}, {
    10211,
    "Financiero - Contabilidad > Procesos periódicos > Proceso de descuento financiero por pronto pago"
}, {
    310,
    "Financiero - Contabilidad > Procesos periódicos"
}, {
    391,
    "Financiero - Contabilidad > Reportes > Complementarios"
}, {
    857,
    "Financiero - Contabilidad > Reportes > Complementarios > Adicionar"
}, {
    859,
    "Financiero - Contabilidad > Reportes > Complementarios > Eliminar"
}, {
    858,
    "Financiero - Contabilidad > Reportes > Complementarios > Modificar"
}, {
    861,
    "Financiero - Contabilidad > Reportes > Complementarios > Reporte"
}, {
    8677,
    "Financiero - Contabilidad > Reportes > Ecuador"
}, {
    8678,
    "Financiero - Contabilidad > Reportes > Ecuador > Generación de archivo SRI"
}, {
    8286,
    "Financiero - Contabilidad > Reportes > México"
}, {
    9133,
    "Financiero - Contabilidad > Reportes > México > Consulta Diot"
}, {
    9102,
    "Financiero - Contabilidad > Reportes > México > Contabilidad electronica"
}, {
    8287,
    "Financiero - Contabilidad > Reportes > México > Diot"
}, {
    10438,
    "Financiero - Contabilidad > Reportes > México > Diot > Adicionar detalle"
}, {
    8292,
    "Financiero - Contabilidad > Reportes > México > Diot > Eliminar"
}, {
    10440,
    "Financiero - Contabilidad > Reportes > México > Diot > Eliminar detalle"
}, {
    8288,
    "Financiero - Contabilidad > Reportes > México > Diot > Generar"
}, {
    8289,
    "Financiero - Contabilidad > Reportes > México > Diot > Generar archivo"
}, {
    8290,
    "Financiero - Contabilidad > Reportes > México > Diot > Habilitar generar archivo"
}, {
    8291,
    "Financiero - Contabilidad > Reportes > México > Diot > Modificar"
}, {
    10439,
    "Financiero - Contabilidad > Reportes > México > Diot > Modificar detalle"
}, {
    11258,
    "Financiero - Contabilidad > Reportes > México > Diot > Modificar información encabezado"
}, {
    9529,
    "Financiero - Contabilidad > Reportes > México > Generar IEPS"
}, {
    309,
    "Financiero - Contabilidad > Reportes"
}, {
    1438,
    "Financiero - Contabilidad > Reportes > Sumarizados"
}, {
    7237,
    "Financiero - Contabilidad > Reportes > Venezuela"
}, {
    7238,
    "Financiero - Contabilidad > Reportes > Venezuela > Libros oficiales"
}, {
    7239,
    "Financiero - Contabilidad > Reportes > Venezuela > Libros oficiales > Libro de compras"
}, {
    7241,
    "Financiero - Contabilidad > Reportes > Venezuela > Libros oficiales > Retencion ISLR"
}, {
    7240,
    "Financiero - Contabilidad > Reportes > Venezuela > Libros oficiales > Libro de ventas"
}, {
    7405,
    "Financiero - Contabilidad > Reportes > Venezuela > Númeracion forma libre"
}, {
    396,
    "Financiero - Contabilidad > Reportes > Balance de comprobación > Centros de costos"
}, {
    395,
    "Financiero - Contabilidad > Reportes > Balance de comprobación > Cuentas"
}, {
    388,
    "Financiero - Contabilidad > Reportes > Balance de comprobación"
}, {
    1410,
    "Financiero - Contabilidad > Reportes > Sumarizados > Balance de comprobación"
}, {
    398,
    "Financiero - Contabilidad > Reportes > Balance general > Centros de costos"
}, {
    397,
    "Financiero - Contabilidad > Reportes > Balance general > Cuentas"
}, {
    389,
    "Financiero - Contabilidad > Reportes > Balance general"
}, {
    1411,
    "Financiero - Contabilidad > Reportes > Sumarizados > Balance general"
}, {
    427,
    "Financiero - Contabilidad > Reportes > Informes fiscales > Certificado de retención"
}, {
    400,
    "Financiero - Contabilidad > Reportes > Estado de resultados > Centros de costos"
}, {
    399,
    "Financiero - Contabilidad > Reportes > Estado de resultados > Cuentas"
}, {
    2065,
    "Financiero - Contabilidad > Reportes > Estado de resultados > Rubros de cuenta"
}, {
    390,
    "Financiero - Contabilidad > Reportes > Estado de resultados"
}, {
    1412,
    "Financiero - Contabilidad > Reportes > Sumarizados > Estados de resultados"
}, {
    394,
    "Financiero - Contabilidad > Reportes > Informes fiscales"
}, {
    408,
    "Financiero - Contabilidad > Reportes > Libros auxiliares > Centros de costos"
}, {
    407,
    "Financiero - Contabilidad > Reportes > Libros auxiliares > Cuentas"
}, {
    532,
    "Financiero - Contabilidad > Reportes > Libros auxiliares > Flujo de efectivo"
}, {
    392,
    "Financiero - Contabilidad > Reportes > Libros auxiliares"
}, {
    409,
    "Financiero - Contabilidad > Reportes > Libros auxiliares > Terceros"
}, {
    4406,
    "Financiero - Contabilidad > Reportes > Libros auxiliares > Centros de costos > Presentar movimientos negativos sin signo"
}, {
    4407,
    "Financiero - Contabilidad > Reportes > Libros auxiliares > Cuentas > Presentar movimientos negativos sin signo"
}, {
    4408,
    "Financiero - Contabilidad > Reportes > Libros auxiliares > Terceros > Presentar movimientos negativos sin signo"
}, {
    393,
    "Financiero - Contabilidad > Reportes > Libros oficiales"
}, {
    415,
    "Financiero - Contabilidad > Reportes > Libros oficiales > Libro diario"
}, {
    416,
    "Financiero - Contabilidad > Reportes > Libros oficiales > Comprobación de libro diario"
}, {
    419,
    "Financiero - Contabilidad > Reportes > Libros oficiales > Libro de inventario y balance"
}, {
    417,
    "Financiero - Contabilidad > Reportes > Libros oficiales > Libro mayor"
}, {
    418,
    "Financiero - Contabilidad > Reportes > Libros oficiales > Comprobación de libro mayor"
}, {
    420,
    "Financiero - Contabilidad > Reportes > Libros oficiales > Numeración de páginas"
}, {
    4086,
    "Financiero - Contabilidad > Reportes > Perú"
}, {
    6679,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de activos fijos arrendamiento"
}, {
    6678,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de activos fijos diferencia en cambio"
}, {
    6677,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de activos Fijos Revaluados"
}, {
    8569,
    "Financiero - Contabilidad > Reportes > Perú > Generación archivo embargos telemáticos"
}, {
    9132,
    "Financiero - Contabilidad > Reportes > República Dominicana > Generación archivo formato 606"
}, {
    4087,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales"
}, {
    4093,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de bancos"
}, {
    4090,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de caja"
}, {
    4089,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de compras"
}, {
    6555,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de consignaciones dadas"
}, {
    6554,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de consignaciones recibidas"
}, {
    4088,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de inventario valorizado permanente"
}, {
    4368,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de inventario y balance"
}, {
    4494,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de inventario y balance > Balance de comprobacion"
}, {
    4412,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de inventario y balance > Saldos cuenta 47 - Beneficios de los trabajadores"
}, {
    4369,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de inventario y balance > Saldos de caja y bancos"
}, {
    4380,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de inventario y balance > Saldos cuenta 14 - CxC a accionistas y personal"
}, {
    4379,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de inventario y balance > Saldos cuenta 12 - Clientes"
}, {
    4381,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de inventario y balance > Saldos cuenta 16 - CxC diversas"
}, {
    4462,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de inventario y balance > Saldos cuenta 46 - CxP diversas"
}, {
    4672,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de inventario y balance > Estado de ganacias y perdidas"
}, {
    6681,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de inventario y balance > Ganancias diferidas"
}, {
    4389,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de inventario y balance > Saldos cuenta 34 - Intangibles"
}, {
    6556,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de inventario y balance > Mercancías y producto terminado"
}, {
    4411,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de inventario y balance > Saldos cuenta 42 - Proveedores"
}, {
    4382,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de inventario y balance > Saldos cuenta 19 - Provisión cobranza dudosa"
}, {
    4410,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de inventario y balance > Saldos cuenta 41 - Remuneraciones por pagar"
}, {
    6672,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de inventario y balance > Retenciones de IGV"
}, {
    4409,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de inventario y balance > Saldos cuenta 40 - Tributos por  pagar"
}, {
    6680,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de inventario y balance > Valores"
}, {
    4827,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro diario"
}, {
    4828,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro mayor"
}, {
    4215,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Maestros asociados"
}, {
    4216,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Maestros asociados > Unidades de medida"
}, {
    10180,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de percepciones"
}, {
    6563,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Registro de costos"
}, {
    6565,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Registro de costos > Elemento del costo mensual"
}, {
    6564,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Registro de costos > Estado de costo de producción valorizado anual"
}, {
    4413,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Registro activos fijos - detalle de activos fijos"
}, {
    4091,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de retenciones"
}, {
    4092,
    "Financiero - Contabilidad > Reportes > Perú > Libros oficiales > Libro de ventas"
}, {
    10525,
    "Financiero - Contabilidad > Reportes > Perú > PDB"
}, {
    10527,
    "Financiero - Contabilidad > Reportes > Perú > PDB > DUA Exportador"
}, {
    10528,
    "Financiero - Contabilidad > Reportes > Perú > PDB > DUA Importador"
}, {
    10526,
    "Financiero - Contabilidad > Reportes > Perú > PDB > Exportador"
}, {
    10905,
    "Financiero - Contabilidad > Reportes > Perú > PDB > Exportador compras"
}, {
    10906,
    "Financiero - Contabilidad > Reportes > Perú > PDB > Tipo de cambio"
}, {
    4266,
    "Financiero - Contabilidad > Reportes > Perú > PDTs"
}, {
    4598,
    "Financiero - Contabilidad > Reportes > Perú > PDTs > PDT 3500 Operaciones con terceros"
}, {
    4267,
    "Financiero - Contabilidad > Reportes > Perú > PDTs > PDT 3550 Ventas mensuales"
}, {
    4600,
    "Financiero - Contabilidad > Reportes > Perú > PDTs > PDT 601 Honorarios"
}, {
    4591,
    "Financiero - Contabilidad > Reportes > Perú > PDTs > PDT 626 Régimen de retenciones del IGV"
}, {
    4599,
    "Financiero - Contabilidad > Reportes > Perú > PDTs > PDT 664 Declaración Juramentada"
}, {
    428,
    "Financiero - Contabilidad > Reportes > Informes fiscales > Relación de impuestos"
}, {
    1619,
    "Financiero - Contabilidad > Informes a entidades > Supervalores"
}, {
    1620,
    "Financiero - Contabilidad > Informes a entidades > Supervalores > Generar registro nacional"
}, {
    9836,
    "Financiero - Contabilidad > Reportes > República Dominicana"
}, {
    9837,
    "Financiero - Contabilidad > Reportes > República Dominicana > Generación archivo formato 607"
}, {
    9838,
    "Financiero - Contabilidad > Reportes > República Dominicana > Generación archivo formato 608"
}, {
    9839,
    "Financiero - Contabilidad > Reportes > República Dominicana > Generación archivo formato 609"
}, {
    2433,
    "Costos"
}, {
    2441,
    "Costos > Acumulación de costos"
}, {
    2442,
    "Costos > Acumulación de costos > Generar"
}, {
    2438,
    "Costos > Cambio de costos"
}, {
    2597,
    "Maestros de comercial > Categorias laborales"
}, {
    2598,
    "Maestros de comercial > Categorias laborales > Adicionar"
}, {
    2599,
    "Maestros de comercial > Categorias laborales > Cambiar código"
}, {
    2600,
    "Maestros de comercial > Categorias laborales > Consultar"
}, {
    2621,
    "Maestros de comercial > Categorias laborales > Consultar tarifas"
}, {
    2601,
    "Maestros de comercial > Categorias laborales > Duplicar"
}, {
    2620,
    "Maestros de comercial > Categorias laborales > Editar tarifas"
}, {
    2602,
    "Maestros de comercial > Categorias laborales > Eliminar"
}, {
    2603,
    "Maestros de comercial > Categorias laborales > Modificar"
}, {
    2604,
    "Maestros de comercial > Categorias laborales > Reporte"
}, {
    2443,
    "Costos > Consultas"
}, {
    2472,
    "Costos > Consultas > Costos acumulados"
}, {
    2473,
    "Costos > Consultas > Costos acumulados > Costos por segmento"
}, {
    8898,
    "Costos > Consultas > Balance de OPs - Costos"
}, {
    2468,
    "Costos > Consultas > Componentes directos"
}, {
    2469,
    "Costos > Consultas > Indentado"
}, {
    2445,
    "Costos > Consultas > Items sin costo"
}, {
    2474,
    "Costos > Consultas > Log de procesos"
}, {
    2475,
    "Costos > Consultas > Log de procesos > Eliminar"
}, {
    2444,
    "Costos > Consultas > Matriz de costos"
}, {
    3708,
    "Costos > Consultas > Reporte hoja de costos"
}, {
    8406,
    "Costos > Consultas > Reporte hoja costos por rutas"
}, {
    2439,
    "Costos > Costeo de rutas"
}, {
    2440,
    "Costos > Costeo de rutas > Generar"
}, {
    2434,
    "Costos > Edición de costos"
}, {
    2436,
    "Costos > Edición de costos > Consultar"
}, {
    2435,
    "Costos > Edición de costos > Modificar"
}, {
    2462,
    "Costos > Eliminación"
}, {
    2463,
    "Costos > Eliminación > Generar"
}, {
    2622,
    "Maestros de comercial > Empleados"
}, {
    2623,
    "Maestros de comercial > Empleados > Adicionar"
}, {
    2624,
    "Maestros de comercial > Empleados > Consultar"
}, {
    2625,
    "Maestros de comercial > Empleados > Consultar tarifas"
}, {
    2626,
    "Maestros de comercial > Empleados > Duplicar"
}, {
    2627,
    "Maestros de comercial > Empleados > Editar tarifas"
}, {
    2628,
    "Maestros de comercial > Empleados > Eliminar"
}, {
    2629,
    "Maestros de comercial > Empleados > Modificar"
}, {
    2630,
    "Maestros de comercial > Empleados > Reporte"
}, {
    2631,
    "Maestros de comercial > Labores"
}, {
    2632,
    "Maestros de comercial > Labores > Adicionar"
}, {
    2638,
    "Maestros de comercial > Labores > Cambiar código"
}, {
    2633,
    "Maestros de comercial > Labores > Consultar"
}, {
    2634,
    "Maestros de comercial > Labores > Duplicar"
}, {
    2635,
    "Maestros de comercial > Labores > Eliminar"
}, {
    2636,
    "Maestros de comercial > Labores > Modificar"
}, {
    2637,
    "Maestros de comercial > Labores > Reporte"
}, {
    2437,
    "Costos > Transferencia de costos"
}, {
    2461,
    "Costos > Transferencia de costos > Generar"
}, {
    10680,
    "SiesaFiscal"
}, {
    11209,
    "SiesaFiscal > Colombia"
}, {
    11210,
    "SiesaFiscal > Colombia > Medios magnéticos"
}, {
    11599,
    "SiesaFiscal > Colombia > Medios magnéticos > Información a entidades"
}, {
    11600,
    "SiesaFiscal > Colombia > Medios magnéticos > Información a entidades > Eliminar"
}, {
    11601,
    "SiesaFiscal > Colombia > Medios magnéticos > Información a entidades > Generar"
}, {
    11604,
    "SiesaFiscal > Colombia > Medios magnéticos > Información a entidades > Importar"
}, {
    11603,
    "SiesaFiscal > Colombia > Medios magnéticos > Información a entidades > Reportar automatico"
}, {
    11602,
    "SiesaFiscal > Colombia > Medios magnéticos > Información a entidades > Reportar manual"
}, {
    11211,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados"
}, {
    11222,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Consorciados"
}, {
    11223,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Consorciados > Adicionar"
}, {
    11216,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Equivalencia de terceros"
}, {
    11217,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Equivalencia de terceros > Adicionar"
}, {
    11218,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Equivalencia de terceros > Consultar"
}, {
    11219,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Equivalencia de terceros > Eliminar"
}, {
    11220,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Equivalencia de terceros > Modificar"
}, {
    11221,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Equivalencia de terceros > Reporte"
}, {
    11231,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Formatos"
}, {
    11232,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Formatos > Adicionar"
}, {
    11233,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Formatos > Consultar"
}, {
    11234,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Formatos > Duplicar"
}, {
    11235,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Formatos > Eliminar"
}, {
    11236,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Formatos > Modificar"
}, {
    11237,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Formatos > Reporte"
}, {
    11224,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Grupos formatos"
}, {
    11225,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Grupos formatos > Adicionar"
}, {
    11226,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Grupos formatos > Consultar"
}, {
    11227,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Grupos formatos > Duplicar"
}, {
    11228,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Grupos formatos > Eliminar"
}, {
    11229,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Grupos formatos > Modificar"
}, {
    11230,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Grupos formatos > Reporte"
}, {
    11212,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Tipos de identificación"
}, {
    11213,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Tipos de identificación > Consultar"
}, {
    11214,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Tipos de identificación > Modificar"
}, {
    11215,
    "SiesaFiscal > Colombia > Medios magnéticos > Maestros asociados > Tipos de identificación > Reporte"
}, {
    12257,
    "SiesaFiscal > Colombia > Reportes"
}, {
    12258,
    "SiesaFiscal > Colombia > Reportes > Libro Auxililar"
}, {
    12259,
    "SiesaFiscal > Colombia > Reportes > Libro Auxililar > Cuenta"
}, {
    10681,
    "SiesaFiscal > Peru"
}, {
    10682,
    "SiesaFiscal > Peru > Libros oficiales"
}, {
    10879,
    "SiesaFiscal > Peru > Libros oficiales > Libro caja y bancos"
}, {
    10683,
    "SiesaFiscal > Peru > Libros oficiales > Libro de compras"
}, {
    10778,
    "SiesaFiscal > Peru > Libros oficiales > Libro diario"
}, {
    10878,
    "SiesaFiscal > Peru > Libros oficiales > Libro de inventarios y balances"
}, {
    11105,
    "SiesaFiscal > Peru > Libros oficiales > Libro de inventario permanente"
}, {
    10779,
    "SiesaFiscal > Peru > Libros oficiales > Libro mayor"
}, {
    10684,
    "SiesaFiscal > Peru > Libros oficiales > Libro de ventas"
}, {
    12018,
    "SiesaFiscal > Peru > Libros oficiales > Registro activos fijos"
}, {
    11932,
    "SiesaFiscal > Peru > Libros oficiales > Resgistro de consignaciones"
}, {
    11929,
    "SiesaFiscal > Peru > Libros oficiales > Registros de costos"
}, {
    3744,
    "Generales"
}, {
    7155,
    "Generales > Consultas web"
}, {
    7401,
    "Generales > Consultas web > Permitir crear consultas"
}, {
    7156,
    "Generales > Consultas web > Permitir editar consultas de otros usuarios"
}, {
    8674,
    "Generales > Cubos Web"
}, {
    8675,
    "Generales > Cubos Web > Permitir crear cubos"
}, {
    8676,
    "Generales > Cubos Web > Permitir editar cubos de otros usuarios"
}, {
    8692,
    "Generales > Diseñador de formatos"
}, {
    8693,
    "Generales > Diseñador de formatos > Permitir crear formatos"
}, {
    8694,
    "Generales > Diseñador de formatos > Permitir editar formatos de otros usuarios"
}, {
    3754,
    "Generales > Imprimir formatos adicionales"
}, {
    4442,
    "Generales > No obligar notas del documento"
}, {
    3912,
    "Generales > Recaudos"
}, {
    7849,
    "Generales > Recaudos > No pedir código de seguridad en tarjeta de crédito"
}, {
    3913,
    "Generales > Recaudos > Permitir recaudos iguales"
}, {
    3745,
    "Generales > Sugerir número final al imprimir documentos"
}, {
    4883,
    "Gestión Humana"
}, {
    5913,
    "Gestión Humana > Evaluacion de desempeño"
}, {
    6337,
    "Gestión Humana > Evaluacion de desempeño > Documentos de evaluacion"
}, {
    6339,
    "Gestión Humana > Evaluacion de desempeño > Documentos de evaluacion > Adicionar"
}, {
    6340,
    "Gestión Humana > Evaluacion de desempeño > Documentos de evaluacion > Consultar"
}, {
    6342,
    "Gestión Humana > Evaluacion de desempeño > Documentos de evaluacion > Duplicar"
}, {
    6341,
    "Gestión Humana > Evaluacion de desempeño > Documentos de evaluacion > Eliminar"
}, {
    6343,
    "Gestión Humana > Evaluacion de desempeño > Documentos de evaluacion > Modificar"
}, {
    6344,
    "Gestión Humana > Evaluacion de desempeño > Documentos de evaluacion > Reporte"
}, {
    6338,
    "Gestión Humana > Evaluacion de desempeño > Programacion de Evaluacion"
}, {
    6345,
    "Gestión Humana > Evaluacion de desempeño > Programacion de Evaluacion > Adicionar"
}, {
    6346,
    "Gestión Humana > Evaluacion de desempeño > Programacion de Evaluacion > Consultar"
}, {
    6347,
    "Gestión Humana > Evaluacion de desempeño > Programacion de Evaluacion > Duplicar"
}, {
    6348,
    "Gestión Humana > Evaluacion de desempeño > Programacion de Evaluacion > Eliminar"
}, {
    6349,
    "Gestión Humana > Evaluacion de desempeño > Programacion de Evaluacion > Modificar"
}, {
    6350,
    "Gestión Humana > Evaluacion de desempeño > Programacion de Evaluacion > Reporte"
}, {
    6782,
    "Gestión Humana > Formación y desarrollo"
}, {
    6786,
    "Gestión Humana > Formación y desarrollo > Calificación curso"
}, {
    6790,
    "Gestión Humana > Formación y desarrollo > Calificación curso > Adicionar"
}, {
    6791,
    "Gestión Humana > Formación y desarrollo > Calificación curso > Consultar"
}, {
    6792,
    "Gestión Humana > Formación y desarrollo > Calificación curso > Duplicar"
}, {
    6793,
    "Gestión Humana > Formación y desarrollo > Calificación curso > Eliminar"
}, {
    6794,
    "Gestión Humana > Formación y desarrollo > Calificación curso > Modificar"
}, {
    6795,
    "Gestión Humana > Formación y desarrollo > Calificación curso > Reporte"
}, {
    6789,
    "Gestión Humana > Formación y desarrollo > Documento de capacitación"
}, {
    6796,
    "Gestión Humana > Formación y desarrollo > Documento de capacitación > Adicionar"
}, {
    6797,
    "Gestión Humana > Formación y desarrollo > Documento de capacitación > Consultar"
}, {
    6798,
    "Gestión Humana > Formación y desarrollo > Documento de capacitación > Duplicar"
}, {
    6799,
    "Gestión Humana > Formación y desarrollo > Documento de capacitación > Eliminar"
}, {
    6800,
    "Gestión Humana > Formación y desarrollo > Documento de capacitación > Modificar"
}, {
    6801,
    "Gestión Humana > Formación y desarrollo > Documento de capacitación > Reporte"
}, {
    8506,
    "Gestión Humana > Formación y desarrollo > Reporte"
}, {
    8507,
    "Gestión Humana > Formación y desarrollo > Reporte > Consulta hoja de vida"
}, {
    8512,
    "Gestión Humana > Formación y desarrollo > Reporte > Consulta hoja de vida > Adicionar"
}, {
    8511,
    "Gestión Humana > Formación y desarrollo > Reporte > Consulta hoja de vida por competencias"
}, {
    8515,
    "Gestión Humana > Formación y desarrollo > Reporte > Consulta hoja de vida por competencias > Adicionar"
}, {
    8516,
    "Gestión Humana > Formación y desarrollo > Reporte > Consulta hoja de vida por competencias > Filtro"
}, {
    8517,
    "Gestión Humana > Formación y desarrollo > Reporte > Consulta hoja de vida por competencias > Generar"
}, {
    8509,
    "Gestión Humana > Formación y desarrollo > Reporte > Consulta hoja de vida por conocimiento"
}, {
    8518,
    "Gestión Humana > Formación y desarrollo > Reporte > Consulta hoja de vida por conocimiento > Adicionar"
}, {
    8519,
    "Gestión Humana > Formación y desarrollo > Reporte > Consulta hoja de vida por conocimiento > Filtro"
}, {
    8520,
    "Gestión Humana > Formación y desarrollo > Reporte > Consulta hoja de vida por conocimiento > Generar"
}, {
    8508,
    "Gestión Humana > Formación y desarrollo > Reporte > Consulta Hojas de vida por estudios"
}, {
    8524,
    "Gestión Humana > Formación y desarrollo > Reporte > Consulta Hojas de vida por estudios > Adicionar"
}, {
    8525,
    "Gestión Humana > Formación y desarrollo > Reporte > Consulta Hojas de vida por estudios > Filtro"
}, {
    8526,
    "Gestión Humana > Formación y desarrollo > Reporte > Consulta Hojas de vida por estudios > Generar"
}, {
    8510,
    "Gestión Humana > Formación y desarrollo > Reporte > Consulta hoja de vida por experiencia"
}, {
    8521,
    "Gestión Humana > Formación y desarrollo > Reporte > Consulta hoja de vida por experiencia > Adicionar"
}, {
    8522,
    "Gestión Humana > Formación y desarrollo > Reporte > Consulta hoja de vida por experiencia > Filtro"
}, {
    8523,
    "Gestión Humana > Formación y desarrollo > Reporte > Consulta hoja de vida por experiencia > Generar"
}, {
    8513,
    "Gestión Humana > Formación y desarrollo > Reporte > Consulta hoja de vida > Filtro"
}, {
    8514,
    "Gestión Humana > Formación y desarrollo > Reporte > Consulta hoja de vida > Generar"
}, {
    8502,
    "Gestión Humana > Formación y desarrollo > Consultas"
}, {
    8503,
    "Gestión Humana > Formación y desarrollo > Consultas > Consulta Brechas cargo actual"
}, {
    8527,
    "Gestión Humana > Formación y desarrollo > Consultas > Consulta Brechas cargo actual > Adicionar"
}, {
    8528,
    "Gestión Humana > Formación y desarrollo > Consultas > Consulta Brechas cargo actual > Consultar"
}, {
    8529,
    "Gestión Humana > Formación y desarrollo > Consultas > Consulta Brechas cargo actual > Duplicar"
}, {
    8530,
    "Gestión Humana > Formación y desarrollo > Consultas > Consulta Brechas cargo actual > Eliminar"
}, {
    8531,
    "Gestión Humana > Formación y desarrollo > Consultas > Consulta Brechas cargo actual > Modificar"
}, {
    8532,
    "Gestión Humana > Formación y desarrollo > Consultas > Consulta Brechas cargo actual > Reporte"
}, {
    8504,
    "Gestión Humana > Formación y desarrollo > Consultas > Consulta Historico de cargos"
}, {
    8533,
    "Gestión Humana > Formación y desarrollo > Consultas > Consulta Historico de cargos > Adicionar"
}, {
    8534,
    "Gestión Humana > Formación y desarrollo > Consultas > Consulta Historico de cargos > consultar"
}, {
    8535,
    "Gestión Humana > Formación y desarrollo > Consultas > Consulta Historico de cargos > Duplicar"
}, {
    8536,
    "Gestión Humana > Formación y desarrollo > Consultas > Consulta Historico de cargos > Eliminar"
}, {
    8537,
    "Gestión Humana > Formación y desarrollo > Consultas > Consulta Historico de cargos > Modificar"
}, {
    8538,
    "Gestión Humana > Formación y desarrollo > Consultas > Consulta Historico de cargos > Reporte"
}, {
    8505,
    "Gestión Humana > Formación y desarrollo > Consultas > Consulta proyeccion a otros cargos"
}, {
    8539,
    "Gestión Humana > Formación y desarrollo > Consultas > Consulta proyeccion a otros cargos > Adicionar"
}, {
    8540,
    "Gestión Humana > Formación y desarrollo > Consultas > Consulta proyeccion a otros cargos > Consultar"
}, {
    8541,
    "Gestión Humana > Formación y desarrollo > Consultas > Consulta proyeccion a otros cargos > Duplicar"
}, {
    8542,
    "Gestión Humana > Formación y desarrollo > Consultas > Consulta proyeccion a otros cargos > Eliminar"
}, {
    8543,
    "Gestión Humana > Formación y desarrollo > Consultas > Consulta proyeccion a otros cargos > Modificar"
}, {
    8544,
    "Gestión Humana > Formación y desarrollo > Consultas > Consulta proyeccion a otros cargos > Reporte"
}, {
    6785,
    "Gestión Humana > Formación y desarrollo > Inscripción a curso"
}, {
    6802,
    "Gestión Humana > Formación y desarrollo > Inscripción a curso > Adicionar"
}, {
    6803,
    "Gestión Humana > Formación y desarrollo > Inscripción a curso > Consultar"
}, {
    6804,
    "Gestión Humana > Formación y desarrollo > Inscripción a curso > Duplicar"
}, {
    6805,
    "Gestión Humana > Formación y desarrollo > Inscripción a curso > Eliminar"
}, {
    6806,
    "Gestión Humana > Formación y desarrollo > Inscripción a curso > Modificar"
}, {
    6807,
    "Gestión Humana > Formación y desarrollo > Inscripción a curso > Reporte"
}, {
    6787,
    "Gestión Humana > Formación y desarrollo > Necesidad de curso"
}, {
    6788,
    "Gestión Humana > Formación y desarrollo > Necesidades de capacitación"
}, {
    6814,
    "Gestión Humana > Formación y desarrollo > Necesidades de capacitación > Adicionar"
}, {
    6815,
    "Gestión Humana > Formación y desarrollo > Necesidades de capacitación > Consultar"
}, {
    6816,
    "Gestión Humana > Formación y desarrollo > Necesidades de capacitación > Duplicar"
}, {
    6817,
    "Gestión Humana > Formación y desarrollo > Necesidades de capacitación > Eliminar"
}, {
    6818,
    "Gestión Humana > Formación y desarrollo > Necesidades de capacitación > Modificar"
}, {
    6819,
    "Gestión Humana > Formación y desarrollo > Necesidades de capacitación > Reporte"
}, {
    6808,
    "Gestión Humana > Formación y desarrollo > Necesidad de curso > Adicionar"
}, {
    6809,
    "Gestión Humana > Formación y desarrollo > Necesidad de curso > Consultar"
}, {
    6810,
    "Gestión Humana > Formación y desarrollo > Necesidad de curso > Duplicar"
}, {
    6811,
    "Gestión Humana > Formación y desarrollo > Necesidad de curso > Eliminar"
}, {
    6812,
    "Gestión Humana > Formación y desarrollo > Necesidad de curso > Modificar"
}, {
    6813,
    "Gestión Humana > Formación y desarrollo > Necesidad de curso > Reporte"
}, {
    6784,
    "Gestión Humana > Formación y desarrollo > Programación de cursos"
}, {
    6820,
    "Gestión Humana > Formación y desarrollo > Programación de cursos > Adicionar"
}, {
    6821,
    "Gestión Humana > Formación y desarrollo > Programación de cursos > Consultar"
}, {
    6822,
    "Gestión Humana > Formación y desarrollo > Programación de cursos > Duplicar"
}, {
    6823,
    "Gestión Humana > Formación y desarrollo > Programación de cursos > Eliminar"
}, {
    6824,
    "Gestión Humana > Formación y desarrollo > Programación de cursos > Modificar"
}, {
    6825,
    "Gestión Humana > Formación y desarrollo > Programación de cursos > Reporte"
}, {
    6783,
    "Gestión Humana > Formación y desarrollo > Sitios de capacitación"
}, {
    6826,
    "Gestión Humana > Formación y desarrollo > Sitios de capacitación > Adicionar"
}, {
    6827,
    "Gestión Humana > Formación y desarrollo > Sitios de capacitación > Consultar"
}, {
    6828,
    "Gestión Humana > Formación y desarrollo > Sitios de capacitación > Duplicar"
}, {
    6829,
    "Gestión Humana > Formación y desarrollo > Sitios de capacitación > Eliminar"
}, {
    6830,
    "Gestión Humana > Formación y desarrollo > Sitios de capacitación > Modificar"
}, {
    6831,
    "Gestión Humana > Formación y desarrollo > Sitios de capacitación > Reporte"
}, {
    8487,
    "Gestión Humana > Indicadores Gestion"
}, {
    8489,
    "Gestión Humana > Indicadores Gestion > Cuadro de Mando"
}, {
    8490,
    "Gestión Humana > Indicadores Gestion > Cuadro de Mando > Adicionar"
}, {
    8491,
    "Gestión Humana > Indicadores Gestion > Cuadro de Mando > Consultar"
}, {
    8492,
    "Gestión Humana > Indicadores Gestion > Cuadro de Mando > Duplicar"
}, {
    8493,
    "Gestión Humana > Indicadores Gestion > Cuadro de Mando > Eliminar"
}, {
    8494,
    "Gestión Humana > Indicadores Gestion > Cuadro de Mando > Modificar"
}, {
    8495,
    "Gestión Humana > Indicadores Gestion > Cuadro de Mando > Reporte"
}, {
    8488,
    "Gestión Humana > Indicadores Gestion > Indicadores de Gestion"
}, {
    8496,
    "Gestión Humana > Indicadores Gestion > Indicadores de Gestion > Adicionar"
}, {
    8497,
    "Gestión Humana > Indicadores Gestion > Indicadores de Gestion > Consultar"
}, {
    8498,
    "Gestión Humana > Indicadores Gestion > Indicadores de Gestion > Duplicar"
}, {
    8499,
    "Gestión Humana > Indicadores Gestion > Indicadores de Gestion > Eliminar"
}, {
    8500,
    "Gestión Humana > Indicadores Gestion > Indicadores de Gestion > Modificar"
}, {
    8501,
    "Gestión Humana > Indicadores Gestion > Indicadores de Gestion > Reporte"
}, {
    5911,
    "Gestión Humana > Maestros"
}, {
    5916,
    "Gestión Humana > Maestros > Cargos perfiles"
}, {
    6082,
    "Gestión Humana > Maestros > Cargos perfiles > Cargos"
}, {
    6138,
    "Gestión Humana > Maestros > Cargos perfiles > Cargos > Adicionar"
}, {
    6139,
    "Gestión Humana > Maestros > Cargos perfiles > Cargos > Consultar"
}, {
    6140,
    "Gestión Humana > Maestros > Cargos perfiles > Cargos > Duplicar"
}, {
    6141,
    "Gestión Humana > Maestros > Cargos perfiles > Cargos > Eliminar"
}, {
    6142,
    "Gestión Humana > Maestros > Cargos perfiles > Cargos > Modificar"
}, {
    6143,
    "Gestión Humana > Maestros > Cargos perfiles > Cargos > Reporte"
}, {
    6073,
    "Gestión Humana > Maestros > Cargos perfiles > Competencias"
}, {
    6084,
    "Gestión Humana > Maestros > Cargos perfiles > Competencias > Adicionar"
}, {
    6085,
    "Gestión Humana > Maestros > Cargos perfiles > Competencias > Consultar"
}, {
    6086,
    "Gestión Humana > Maestros > Cargos perfiles > Competencias > Duplicar"
}, {
    6087,
    "Gestión Humana > Maestros > Cargos perfiles > Competencias > Eliminar"
}, {
    6088,
    "Gestión Humana > Maestros > Cargos perfiles > Competencias > Modificar"
}, {
    6089,
    "Gestión Humana > Maestros > Cargos perfiles > Competencias > Reporte"
}, {
    6074,
    "Gestión Humana > Maestros > Cargos perfiles > Experiencia"
}, {
    6090,
    "Gestión Humana > Maestros > Cargos perfiles > Experiencia > Adicionar"
}, {
    6091,
    "Gestión Humana > Maestros > Cargos perfiles > Experiencia > Consultar"
}, {
    6092,
    "Gestión Humana > Maestros > Cargos perfiles > Experiencia > Duplicar"
}, {
    6093,
    "Gestión Humana > Maestros > Cargos perfiles > Experiencia > Eliminar"
}, {
    6094,
    "Gestión Humana > Maestros > Cargos perfiles > Experiencia > Modificar"
}, {
    6095,
    "Gestión Humana > Maestros > Cargos perfiles > Experiencia > Reporte"
}, {
    6075,
    "Gestión Humana > Maestros > Cargos perfiles > Frecuencia contacto"
}, {
    6096,
    "Gestión Humana > Maestros > Cargos perfiles > Frecuencia contacto > Adicionar"
}, {
    6097,
    "Gestión Humana > Maestros > Cargos perfiles > Frecuencia contacto > Consultar"
}, {
    6098,
    "Gestión Humana > Maestros > Cargos perfiles > Frecuencia contacto > Duplicar"
}, {
    6099,
    "Gestión Humana > Maestros > Cargos perfiles > Frecuencia contacto > Eliminar"
}, {
    6100,
    "Gestión Humana > Maestros > Cargos perfiles > Frecuencia contacto > Modificar"
}, {
    6101,
    "Gestión Humana > Maestros > Cargos perfiles > Frecuencia contacto > Reporte"
}, {
    6076,
    "Gestión Humana > Maestros > Cargos perfiles > Funciones"
}, {
    6102,
    "Gestión Humana > Maestros > Cargos perfiles > Funciones > Adicionar"
}, {
    6103,
    "Gestión Humana > Maestros > Cargos perfiles > Funciones > Consultar"
}, {
    6104,
    "Gestión Humana > Maestros > Cargos perfiles > Funciones > Duplicar"
}, {
    6105,
    "Gestión Humana > Maestros > Cargos perfiles > Funciones > Eliminar"
}, {
    6106,
    "Gestión Humana > Maestros > Cargos perfiles > Funciones > Modificar"
}, {
    6107,
    "Gestión Humana > Maestros > Cargos perfiles > Funciones > Reporte"
}, {
    6078,
    "Gestión Humana > Maestros > Cargos perfiles > Indicadores gestion"
}, {
    6114,
    "Gestión Humana > Maestros > Cargos perfiles > Indicadores gestion > Adicionar"
}, {
    6115,
    "Gestión Humana > Maestros > Cargos perfiles > Indicadores gestion > Consultar"
}, {
    6116,
    "Gestión Humana > Maestros > Cargos perfiles > Indicadores gestion > Duplicar"
}, {
    6117,
    "Gestión Humana > Maestros > Cargos perfiles > Indicadores gestion > Eliminar"
}, {
    6118,
    "Gestión Humana > Maestros > Cargos perfiles > Indicadores gestion > Modificar"
}, {
    6119,
    "Gestión Humana > Maestros > Cargos perfiles > Indicadores gestion > Reporte"
}, {
    6079,
    "Gestión Humana > Maestros > Cargos perfiles > Items conocimiento"
}, {
    6120,
    "Gestión Humana > Maestros > Cargos perfiles > Items conocimiento > Adicionar"
}, {
    6121,
    "Gestión Humana > Maestros > Cargos perfiles > Items conocimiento > Consultar"
}, {
    6122,
    "Gestión Humana > Maestros > Cargos perfiles > Items conocimiento > Duplicar"
}, {
    6123,
    "Gestión Humana > Maestros > Cargos perfiles > Items conocimiento > Eliminar"
}, {
    6124,
    "Gestión Humana > Maestros > Cargos perfiles > Items conocimiento > Modificar"
}, {
    6125,
    "Gestión Humana > Maestros > Cargos perfiles > Items conocimiento > Reporte"
}, {
    6077,
    "Gestión Humana > Maestros > Cargos perfiles > Grados de madurez"
}, {
    6108,
    "Gestión Humana > Maestros > Cargos perfiles > Grados de madurez > Adicionar"
}, {
    6109,
    "Gestión Humana > Maestros > Cargos perfiles > Grados de madurez > Consultar"
}, {
    6110,
    "Gestión Humana > Maestros > Cargos perfiles > Grados de madurez > Duplicar"
}, {
    6111,
    "Gestión Humana > Maestros > Cargos perfiles > Grados de madurez > Eliminar"
}, {
    6112,
    "Gestión Humana > Maestros > Cargos perfiles > Grados de madurez > Modificar"
}, {
    6113,
    "Gestión Humana > Maestros > Cargos perfiles > Grados de madurez > Reporte"
}, {
    6080,
    "Gestión Humana > Maestros > Cargos perfiles > Nivel de competencia"
}, {
    6083,
    "Gestión Humana > Maestros > Cargos perfiles > Niveles de cargos"
}, {
    6166,
    "Gestión Humana > Maestros > Cargos perfiles > Niveles de cargos > Adicionar"
}, {
    6167,
    "Gestión Humana > Maestros > Cargos perfiles > Niveles de cargos > Consultar"
}, {
    6168,
    "Gestión Humana > Maestros > Cargos perfiles > Niveles de cargos > Duplicar"
}, {
    6169,
    "Gestión Humana > Maestros > Cargos perfiles > Niveles de cargos > Eliminar"
}, {
    6170,
    "Gestión Humana > Maestros > Cargos perfiles > Niveles de cargos > Modificar"
}, {
    6171,
    "Gestión Humana > Maestros > Cargos perfiles > Niveles de cargos > Reporte"
}, {
    6126,
    "Gestión Humana > Maestros > Cargos perfiles > Nivel de competencia > Adicionar"
}, {
    6127,
    "Gestión Humana > Maestros > Cargos perfiles > Nivel de competencia > Consultar"
}, {
    6128,
    "Gestión Humana > Maestros > Cargos perfiles > Nivel de competencia > Duplicar"
}, {
    6129,
    "Gestión Humana > Maestros > Cargos perfiles > Nivel de competencia > Eliminar"
}, {
    6130,
    "Gestión Humana > Maestros > Cargos perfiles > Nivel de competencia > Modificar"
}, {
    6131,
    "Gestión Humana > Maestros > Cargos perfiles > Nivel de competencia > Reporte"
}, {
    6081,
    "Gestión Humana > Maestros > Cargos perfiles > Tipo contacto"
}, {
    6132,
    "Gestión Humana > Maestros > Cargos perfiles > Tipo contacto > Adicionar"
}, {
    6133,
    "Gestión Humana > Maestros > Cargos perfiles > Tipo contacto > Consultar"
}, {
    6134,
    "Gestión Humana > Maestros > Cargos perfiles > Tipo contacto > Duplicar"
}, {
    6135,
    "Gestión Humana > Maestros > Cargos perfiles > Tipo contacto > Eliminar"
}, {
    6136,
    "Gestión Humana > Maestros > Cargos perfiles > Tipo contacto > Modificar"
}, {
    6137,
    "Gestión Humana > Maestros > Cargos perfiles > Tipo contacto > Reporte"
}, {
    5918,
    "Gestión Humana > Maestros > Evaluacion de desempeño"
}, {
    6323,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Motivos de evaluacion"
}, {
    6325,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Motivos de evaluacion > Adicionar"
}, {
    6326,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Motivos de evaluacion > Consultar"
}, {
    6328,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Motivos de evaluacion > Eliminar"
}, {
    6329,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Motivos de evaluacion > Modificar"
}, {
    6330,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Motivos de evaluacion > Reporte"
}, {
    6327,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Motivos de evaluacion > Duplicar"
}, {
    6324,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Organigramas"
}, {
    6331,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Organigramas > Adicionar"
}, {
    6332,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Organigramas > Consultar"
}, {
    6333,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Organigramas > Duplicar"
}, {
    6334,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Organigramas > Eliminar"
}, {
    6335,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Organigramas > Modificar"
}, {
    6336,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Organigramas > Reporte"
}, {
    8545,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Organigramas analisis"
}, {
    8546,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Organigramas analisis > Adicionar"
}, {
    8547,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Organigramas analisis > Consultar"
}, {
    8548,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Organigramas analisis > Duplicar"
}, {
    8549,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Organigramas analisis > Eliminar"
}, {
    8550,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Organigramas analisis > Modificar"
}, {
    8551,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Organigramas analisis > Reporte"
}, {
    7979,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Preguntas por cargo"
}, {
    7987,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Preguntas por cargo > Adicionar"
}, {
    7988,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Preguntas por cargo > Consultar"
}, {
    7989,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Preguntas por cargo > Duplicar"
}, {
    7990,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Preguntas por cargo > Eliminar"
}, {
    7991,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Preguntas por cargo > Modificar"
}, {
    7992,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Preguntas por cargo > Reporte"
}, {
    7980,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Consulta preguntas"
}, {
    7981,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Consulta preguntas > Adicionar"
}, {
    7982,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Consulta preguntas > Consultar"
}, {
    7983,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Consulta preguntas > Duplicar"
}, {
    7984,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Consulta preguntas > Eliminar"
}, {
    7985,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Consulta preguntas > Modificar"
}, {
    7986,
    "Gestión Humana > Maestros > Evaluacion de desempeño > Consulta preguntas > Reporte"
}, {
    6832,
    "Gestión Humana > Maestros > Formación y desarrollo"
}, {
    6839,
    "Gestión Humana > Maestros > Formación y desarrollo > Clases de necesidad"
}, {
    6841,
    "Gestión Humana > Maestros > Formación y desarrollo > Clases de necesidad > Adicionar"
}, {
    6842,
    "Gestión Humana > Maestros > Formación y desarrollo > Clases de necesidad > Consultar"
}, {
    6843,
    "Gestión Humana > Maestros > Formación y desarrollo > Clases de necesidad > Duplicar"
}, {
    6844,
    "Gestión Humana > Maestros > Formación y desarrollo > Clases de necesidad > Eliminar"
}, {
    6845,
    "Gestión Humana > Maestros > Formación y desarrollo > Clases de necesidad > Modificar"
}, {
    6846,
    "Gestión Humana > Maestros > Formación y desarrollo > Clases de necesidad > Reporte"
}, {
    6837,
    "Gestión Humana > Maestros > Formación y desarrollo > Cursos"
}, {
    6847,
    "Gestión Humana > Maestros > Formación y desarrollo > Cursos > Adicionar"
}, {
    6848,
    "Gestión Humana > Maestros > Formación y desarrollo > Cursos > Consultar"
}, {
    6849,
    "Gestión Humana > Maestros > Formación y desarrollo > Cursos > Duplicar"
}, {
    6850,
    "Gestión Humana > Maestros > Formación y desarrollo > Cursos > Eliminar"
}, {
    6851,
    "Gestión Humana > Maestros > Formación y desarrollo > Cursos > Modificar"
}, {
    6852,
    "Gestión Humana > Maestros > Formación y desarrollo > Cursos > Reporte"
}, {
    6835,
    "Gestión Humana > Maestros > Formación y desarrollo > Sitios- Entidades de capacitación"
}, {
    6871,
    "Gestión Humana > Maestros > Formación y desarrollo > Sitios- Entidades de capacitación > Adicionar"
}, {
    6872,
    "Gestión Humana > Maestros > Formación y desarrollo > Sitios- Entidades de capacitación > Consultar"
}, {
    6873,
    "Gestión Humana > Maestros > Formación y desarrollo > Sitios- Entidades de capacitación > Duplicar"
}, {
    6874,
    "Gestión Humana > Maestros > Formación y desarrollo > Sitios- Entidades de capacitación > Eliminar"
}, {
    6875,
    "Gestión Humana > Maestros > Formación y desarrollo > Sitios- Entidades de capacitación > Modificar"
}, {
    6876,
    "Gestión Humana > Maestros > Formación y desarrollo > Sitios- Entidades de capacitación > Reporte"
}, {
    6838,
    "Gestión Humana > Maestros > Formación y desarrollo > Instructor -Coordinador"
}, {
    6853,
    "Gestión Humana > Maestros > Formación y desarrollo > Instructor -Coordinador > Adicionar"
}, {
    6854,
    "Gestión Humana > Maestros > Formación y desarrollo > Instructor -Coordinador > Consultar"
}, {
    6855,
    "Gestión Humana > Maestros > Formación y desarrollo > Instructor -Coordinador > Duplicar"
}, {
    6856,
    "Gestión Humana > Maestros > Formación y desarrollo > Instructor -Coordinador > Eliminar"
}, {
    6857,
    "Gestión Humana > Maestros > Formación y desarrollo > Instructor -Coordinador > Modificar"
}, {
    6858,
    "Gestión Humana > Maestros > Formación y desarrollo > Instructor -Coordinador > Reporte"
}, {
    6834,
    "Gestión Humana > Maestros > Formación y desarrollo > Motivos de no asistencia"
}, {
    6865,
    "Gestión Humana > Maestros > Formación y desarrollo > Motivos de no asistencia > Adicionar"
}, {
    6866,
    "Gestión Humana > Maestros > Formación y desarrollo > Motivos de no asistencia > Consultar"
}, {
    6867,
    "Gestión Humana > Maestros > Formación y desarrollo > Motivos de no asistencia > Duplicar"
}, {
    6868,
    "Gestión Humana > Maestros > Formación y desarrollo > Motivos de no asistencia > Eliminar"
}, {
    6869,
    "Gestión Humana > Maestros > Formación y desarrollo > Motivos de no asistencia > Modificar"
}, {
    6870,
    "Gestión Humana > Maestros > Formación y desarrollo > Motivos de no asistencia > Reporte"
}, {
    6840,
    "Gestión Humana > Maestros > Formación y desarrollo > Motivos de auxilio"
}, {
    6859,
    "Gestión Humana > Maestros > Formación y desarrollo > Motivos de auxilio > Adicionar"
}, {
    6860,
    "Gestión Humana > Maestros > Formación y desarrollo > Motivos de auxilio > Consultar"
}, {
    6861,
    "Gestión Humana > Maestros > Formación y desarrollo > Motivos de auxilio > Duplicar"
}, {
    6862,
    "Gestión Humana > Maestros > Formación y desarrollo > Motivos de auxilio > Eliminar"
}, {
    6863,
    "Gestión Humana > Maestros > Formación y desarrollo > Motivos de auxilio > Modificar"
}, {
    6864,
    "Gestión Humana > Maestros > Formación y desarrollo > Motivos de auxilio > Reporte"
}, {
    6833,
    "Gestión Humana > Maestros > Formación y desarrollo > Temas cursos"
}, {
    6877,
    "Gestión Humana > Maestros > Formación y desarrollo > Temas cursos > Adicionar"
}, {
    6878,
    "Gestión Humana > Maestros > Formación y desarrollo > Temas cursos > Consultar"
}, {
    6879,
    "Gestión Humana > Maestros > Formación y desarrollo > Temas cursos > Duplicar"
}, {
    6880,
    "Gestión Humana > Maestros > Formación y desarrollo > Temas cursos > Eliminar"
}, {
    6881,
    "Gestión Humana > Maestros > Formación y desarrollo > Temas cursos > Modificar"
}, {
    6882,
    "Gestión Humana > Maestros > Formación y desarrollo > Temas cursos > Reporte"
}, {
    6836,
    "Gestión Humana > Maestros > Formación y desarrollo > Tipos de curso"
}, {
    6883,
    "Gestión Humana > Maestros > Formación y desarrollo > Tipos de curso > Adicionar"
}, {
    6884,
    "Gestión Humana > Maestros > Formación y desarrollo > Tipos de curso > Consultar"
}, {
    6885,
    "Gestión Humana > Maestros > Formación y desarrollo > Tipos de curso > Duplicar"
}, {
    6886,
    "Gestión Humana > Maestros > Formación y desarrollo > Tipos de curso > Eliminar"
}, {
    6887,
    "Gestión Humana > Maestros > Formación y desarrollo > Tipos de curso > Modificar"
}, {
    6888,
    "Gestión Humana > Maestros > Formación y desarrollo > Tipos de curso > Reporte"
}, {
    5914,
    "Gestión Humana > Maestros > Idiomas"
}, {
    5919,
    "Gestión Humana > Maestros > Idiomas > Adicionar"
}, {
    5922,
    "Gestión Humana > Maestros > Idiomas > Consultar"
}, {
    5920,
    "Gestión Humana > Maestros > Idiomas > Duplicar"
}, {
    5924,
    "Gestión Humana > Maestros > Idiomas > Eliminar"
}, {
    5921,
    "Gestión Humana > Maestros > Idiomas > Modificar"
}, {
    5923,
    "Gestión Humana > Maestros > Idiomas > Reporte"
}, {
    5915,
    "Gestión Humana > Maestros > Reclutamiento"
}, {
    5966,
    "Gestión Humana > Maestros > Reclutamiento > Aficiones"
}, {
    6026,
    "Gestión Humana > Maestros > Reclutamiento > Aficiones > Adicionar"
}, {
    6027,
    "Gestión Humana > Maestros > Reclutamiento > Aficiones > Consultar"
}, {
    6028,
    "Gestión Humana > Maestros > Reclutamiento > Aficiones > Duplicar"
}, {
    6029,
    "Gestión Humana > Maestros > Reclutamiento > Aficiones > Eliminar"
}, {
    6030,
    "Gestión Humana > Maestros > Reclutamiento > Aficiones > Modificar"
}, {
    6031,
    "Gestión Humana > Maestros > Reclutamiento > Aficiones > Reporte"
}, {
    5970,
    "Gestión Humana > Maestros > Reclutamiento > Clase social"
}, {
    6178,
    "Gestión Humana > Maestros > Reclutamiento > Clase social > adicionar"
}, {
    6179,
    "Gestión Humana > Maestros > Reclutamiento > Clase social > Consultar"
}, {
    6180,
    "Gestión Humana > Maestros > Reclutamiento > Clase social > Duplicar"
}, {
    6181,
    "Gestión Humana > Maestros > Reclutamiento > Clase social > Eliminar"
}, {
    6182,
    "Gestión Humana > Maestros > Reclutamiento > Clase social > Modificar"
}, {
    6183,
    "Gestión Humana > Maestros > Reclutamiento > Clase social > Reporte"
}, {
    5967,
    "Gestión Humana > Maestros > Reclutamiento > Deportes"
}, {
    6032,
    "Gestión Humana > Maestros > Reclutamiento > Deportes > Adicionar"
}, {
    6033,
    "Gestión Humana > Maestros > Reclutamiento > Deportes > Consultar"
}, {
    6034,
    "Gestión Humana > Maestros > Reclutamiento > Deportes > Duplicar"
}, {
    6035,
    "Gestión Humana > Maestros > Reclutamiento > Deportes > Eliminar"
}, {
    6036,
    "Gestión Humana > Maestros > Reclutamiento > Deportes > Modificar"
}, {
    6037,
    "Gestión Humana > Maestros > Reclutamiento > Deportes > Reporte"
}, {
    5969,
    "Gestión Humana > Maestros > Reclutamiento > Origen Etnico"
}, {
    6172,
    "Gestión Humana > Maestros > Reclutamiento > Origen Etnico > Adicionar"
}, {
    6173,
    "Gestión Humana > Maestros > Reclutamiento > Origen Etnico > Consultar"
}, {
    6174,
    "Gestión Humana > Maestros > Reclutamiento > Origen Etnico > Duplicar"
}, {
    6175,
    "Gestión Humana > Maestros > Reclutamiento > Origen Etnico > Eliminar"
}, {
    6176,
    "Gestión Humana > Maestros > Reclutamiento > Origen Etnico > Modificar"
}, {
    6177,
    "Gestión Humana > Maestros > Reclutamiento > Origen Etnico > Reporte"
}, {
    5971,
    "Gestión Humana > Maestros > Reclutamiento > Fuentes de reclutamiento"
}, {
    6268,
    "Gestión Humana > Maestros > Reclutamiento > Fuentes de reclutamiento > Adicionar"
}, {
    6269,
    "Gestión Humana > Maestros > Reclutamiento > Fuentes de reclutamiento > Consultar"
}, {
    6270,
    "Gestión Humana > Maestros > Reclutamiento > Fuentes de reclutamiento > Duplicar"
}, {
    6271,
    "Gestión Humana > Maestros > Reclutamiento > Fuentes de reclutamiento > Eliminar"
}, {
    6272,
    "Gestión Humana > Maestros > Reclutamiento > Fuentes de reclutamiento > Modificar"
}, {
    6273,
    "Gestión Humana > Maestros > Reclutamiento > Fuentes de reclutamiento > Reporte"
}, {
    5957,
    "Gestión Humana > Maestros > Reclutamiento > Idiomas"
}, {
    5972,
    "Gestión Humana > Maestros > Reclutamiento > Idiomas > Adicionar"
}, {
    5973,
    "Gestión Humana > Maestros > Reclutamiento > Idiomas > Consultar"
}, {
    5974,
    "Gestión Humana > Maestros > Reclutamiento > Idiomas > Duplicar"
}, {
    5975,
    "Gestión Humana > Maestros > Reclutamiento > Idiomas > Eliminar"
}, {
    5976,
    "Gestión Humana > Maestros > Reclutamiento > Idiomas > Modificar"
}, {
    5977,
    "Gestión Humana > Maestros > Reclutamiento > Idiomas > Reporte"
}, {
    5996,
    "Gestión Humana > Maestros > Reclutamiento > Motivos Retiro > Adicionar"
}, {
    5997,
    "Gestión Humana > Maestros > Reclutamiento > Motivos Retiro > Consultar"
}, {
    5998,
    "Gestión Humana > Maestros > Reclutamiento > Motivos Retiro > Duplicar"
}, {
    5999,
    "Gestión Humana > Maestros > Reclutamiento > Motivos Retiro > Eliminar"
}, {
    6000,
    "Gestión Humana > Maestros > Reclutamiento > Motivos Retiro > Modificar"
}, {
    6001,
    "Gestión Humana > Maestros > Reclutamiento > Motivos Retiro > Reporte"
}, {
    5961,
    "Gestión Humana > Maestros > Reclutamiento > Motivos Retiro"
}, {
    5958,
    "Gestión Humana > Maestros > Reclutamiento > Nivel Academico"
}, {
    5978,
    "Gestión Humana > Maestros > Reclutamiento > Nivel Academico > Adicionar"
}, {
    5980,
    "Gestión Humana > Maestros > Reclutamiento > Nivel Academico > Consultar"
}, {
    5979,
    "Gestión Humana > Maestros > Reclutamiento > Nivel Academico > Duplicar"
}, {
    5981,
    "Gestión Humana > Maestros > Reclutamiento > Nivel Academico > Eliminar"
}, {
    5982,
    "Gestión Humana > Maestros > Reclutamiento > Nivel Academico > Modificar"
}, {
    5983,
    "Gestión Humana > Maestros > Reclutamiento > Nivel Academico > Reporte"
}, {
    5965,
    "Gestión Humana > Maestros > Reclutamiento > Ocupaciones"
}, {
    6020,
    "Gestión Humana > Maestros > Reclutamiento > Ocupaciones > Adicionar"
}, {
    6021,
    "Gestión Humana > Maestros > Reclutamiento > Ocupaciones > Consultar"
}, {
    6022,
    "Gestión Humana > Maestros > Reclutamiento > Ocupaciones > Duplicar"
}, {
    6023,
    "Gestión Humana > Maestros > Reclutamiento > Ocupaciones > Eliminar"
}, {
    6024,
    "Gestión Humana > Maestros > Reclutamiento > Ocupaciones > Modificar"
}, {
    6025,
    "Gestión Humana > Maestros > Reclutamiento > Ocupaciones > Reporte"
}, {
    5964,
    "Gestión Humana > Maestros > Reclutamiento > Parentescos"
}, {
    6014,
    "Gestión Humana > Maestros > Reclutamiento > Parentescos > Adicionar"
}, {
    6015,
    "Gestión Humana > Maestros > Reclutamiento > Parentescos > Consultar"
}, {
    6016,
    "Gestión Humana > Maestros > Reclutamiento > Parentescos > Duplicar"
}, {
    6017,
    "Gestión Humana > Maestros > Reclutamiento > Parentescos > Eliminar"
}, {
    6018,
    "Gestión Humana > Maestros > Reclutamiento > Parentescos > Modificar"
}, {
    6019,
    "Gestión Humana > Maestros > Reclutamiento > Parentescos > Reporte"
}, {
    5959,
    "Gestión Humana > Maestros > Reclutamiento > Profesiones"
}, {
    5984,
    "Gestión Humana > Maestros > Reclutamiento > Profesiones > Adicionar"
}, {
    5985,
    "Gestión Humana > Maestros > Reclutamiento > Profesiones > Consultar"
}, {
    5986,
    "Gestión Humana > Maestros > Reclutamiento > Profesiones > Duplicar"
}, {
    5987,
    "Gestión Humana > Maestros > Reclutamiento > Profesiones > Eliminar"
}, {
    5988,
    "Gestión Humana > Maestros > Reclutamiento > Profesiones > Modificar"
}, {
    5989,
    "Gestión Humana > Maestros > Reclutamiento > Profesiones > Reporte"
}, {
    5968,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos"
}, {
    6055,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Formacion Academica > Adicionar"
}, {
    6056,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Formacion Academica > Consultar"
}, {
    6057,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Formacion Academica > Duplicar"
}, {
    6058,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Formacion Academica > Eliminar"
}, {
    6059,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Formacion Academica > Modificar"
}, {
    6060,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Formacion Academica > Reporte"
}, {
    6039,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Activos y pasivos"
}, {
    6049,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Activos y pasivos > Adicionar"
}, {
    6050,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Activos y pasivos > Consultar"
}, {
    6051,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Activos y pasivos > Duplicar"
}, {
    6052,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Activos y pasivos > Eliminar"
}, {
    6053,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Activos y pasivos > Modificar"
}, {
    6054,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Activos y pasivos > Reporte"
}, {
    6038,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Datos Basicos y perfil"
}, {
    6043,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Datos Basicos y perfil > Adicionar"
}, {
    6044,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Datos Basicos y perfil > Consultar"
}, {
    6045,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Datos Basicos y perfil > Duplicar"
}, {
    6046,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Datos Basicos y perfil > Eliminar"
}, {
    6047,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Datos Basicos y perfil > Modificar"
}, {
    6048,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Datos Basicos y perfil > Reporte"
}, {
    6061,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Experiencia laboral > Adicionar"
}, {
    6062,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Experiencia laboral > Consultar"
}, {
    6063,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Experiencia laboral > Duplicar"
}, {
    6064,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Experiencia laboral > Eliminar"
}, {
    6041,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Experiencia laboral"
}, {
    6065,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Experiencia laboral > Modificar"
}, {
    6066,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Experiencia laboral > Reporte"
}, {
    6040,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Formacion Academica"
}, {
    6042,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Informacion personal y familiar"
}, {
    6067,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Informacion personal y familiar > Adicionar"
}, {
    6068,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Informacion personal y familiar > Consultar"
}, {
    6069,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Informacion personal y familiar > Duplicar"
}, {
    6070,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Informacion personal y familiar > Eliminar"
}, {
    6071,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Informacion personal y familiar > Modificar"
}, {
    6072,
    "Gestión Humana > Maestros > Reclutamiento > Prospectos > Informacion personal y familiar > Reporte"
}, {
    5990,
    "Gestión Humana > Maestros > Reclutamiento > Tarjetas Credito > Adicionar"
}, {
    5991,
    "Gestión Humana > Maestros > Reclutamiento > Tarjetas Credito > Consultar"
}, {
    5960,
    "Gestión Humana > Maestros > Reclutamiento > Tarjetas Credito"
}, {
    5992,
    "Gestión Humana > Maestros > Reclutamiento > Tarjetas Credito > Duplicar"
}, {
    5993,
    "Gestión Humana > Maestros > Reclutamiento > Tarjetas Credito > Eliminar"
}, {
    5994,
    "Gestión Humana > Maestros > Reclutamiento > Tarjetas Credito > Modificar"
}, {
    5995,
    "Gestión Humana > Maestros > Reclutamiento > Tarjetas Credito > Reporte"
}, {
    5962,
    "Gestión Humana > Maestros > Reclutamiento > Tipos de Vehiculo"
}, {
    5963,
    "Gestión Humana > Maestros > Reclutamiento > Tipos de Vivienda"
}, {
    6002,
    "Gestión Humana > Maestros > Reclutamiento > Tipos de Vehiculo > Adicionar"
}, {
    6003,
    "Gestión Humana > Maestros > Reclutamiento > Tipos de Vehiculo > Consultar"
}, {
    6004,
    "Gestión Humana > Maestros > Reclutamiento > Tipos de Vehiculo > Duplicar"
}, {
    6005,
    "Gestión Humana > Maestros > Reclutamiento > Tipos de Vehiculo > Eliminar"
}, {
    6006,
    "Gestión Humana > Maestros > Reclutamiento > Tipos de Vehiculo > Modificar"
}, {
    6007,
    "Gestión Humana > Maestros > Reclutamiento > Tipos de Vehiculo > Reporte"
}, {
    6008,
    "Gestión Humana > Maestros > Reclutamiento > Tipos de Vivienda > Adicionar"
}, {
    6009,
    "Gestión Humana > Maestros > Reclutamiento > Tipos de Vivienda > Consultar"
}, {
    6010,
    "Gestión Humana > Maestros > Reclutamiento > Tipos de Vivienda > Duplicar"
}, {
    6011,
    "Gestión Humana > Maestros > Reclutamiento > Tipos de Vivienda > Eliminar"
}, {
    6012,
    "Gestión Humana > Maestros > Reclutamiento > Tipos de Vivienda > Modificar"
}, {
    6013,
    "Gestión Humana > Maestros > Reclutamiento > Tipos de Vivienda > Reporte"
}, {
    6208,
    "Gestión Humana > Maestros > Selección y Contratación > Pruebas por Cargo"
}, {
    6232,
    "Gestión Humana > Maestros > Selección y Contratación > Pruebas por Cargo > Adicionar"
}, {
    6233,
    "Gestión Humana > Maestros > Selección y Contratación > Pruebas por Cargo > Consultar"
}, {
    6234,
    "Gestión Humana > Maestros > Selección y Contratación > Pruebas por Cargo > Duplicar"
}, {
    6235,
    "Gestión Humana > Maestros > Selección y Contratación > Pruebas por Cargo > Eliminar"
}, {
    6236,
    "Gestión Humana > Maestros > Selección y Contratación > Pruebas por Cargo > Modificar"
}, {
    6237,
    "Gestión Humana > Maestros > Selección y Contratación > Pruebas por Cargo > Reporte"
}, {
    5917,
    "Gestión Humana > Maestros > Selección y Contratación"
}, {
    6211,
    "Gestión Humana > Maestros > Selección y Contratación > Gastos Asociados"
}, {
    6250,
    "Gestión Humana > Maestros > Selección y Contratación > Gastos Asociados > Adicionar"
}, {
    6252,
    "Gestión Humana > Maestros > Selección y Contratación > Gastos Asociados > Duplicar"
}, {
    6253,
    "Gestión Humana > Maestros > Selección y Contratación > Gastos Asociados > Eliminar"
}, {
    6254,
    "Gestión Humana > Maestros > Selección y Contratación > Gastos Asociados > Modificar"
}, {
    6255,
    "Gestión Humana > Maestros > Selección y Contratación > Gastos Asociados > Reporte"
}, {
    6251,
    "Gestión Humana > Maestros > Selección y Contratación > Gastos Asociados > Consultar"
}, {
    6209,
    "Gestión Humana > Maestros > Selección y Contratación > Motivos de No eleccion"
}, {
    6238,
    "Gestión Humana > Maestros > Selección y Contratación > Motivos de No eleccion > Adicionar"
}, {
    6239,
    "Gestión Humana > Maestros > Selección y Contratación > Motivos de No eleccion > Consultar"
}, {
    6240,
    "Gestión Humana > Maestros > Selección y Contratación > Motivos de No eleccion > Duplicar"
}, {
    6241,
    "Gestión Humana > Maestros > Selección y Contratación > Motivos de No eleccion > Eliminar"
}, {
    6242,
    "Gestión Humana > Maestros > Selección y Contratación > Motivos de No eleccion > Modificar"
}, {
    6243,
    "Gestión Humana > Maestros > Selección y Contratación > Motivos de No eleccion > Reporte"
}, {
    6207,
    "Gestión Humana > Maestros > Selección y Contratación > Pruebas"
}, {
    6226,
    "Gestión Humana > Maestros > Selección y Contratación > Pruebas > Adicionar"
}, {
    6227,
    "Gestión Humana > Maestros > Selección y Contratación > Pruebas > Consultar"
}, {
    6228,
    "Gestión Humana > Maestros > Selección y Contratación > Pruebas > Duplicar"
}, {
    6229,
    "Gestión Humana > Maestros > Selección y Contratación > Pruebas > Eliminar"
}, {
    6230,
    "Gestión Humana > Maestros > Selección y Contratación > Pruebas > Modificar"
}, {
    6231,
    "Gestión Humana > Maestros > Selección y Contratación > Pruebas > Reporte"
}, {
    6210,
    "Gestión Humana > Maestros > Selección y Contratación > Recursos"
}, {
    6244,
    "Gestión Humana > Maestros > Selección y Contratación > Recursos > Adicionar"
}, {
    6245,
    "Gestión Humana > Maestros > Selección y Contratación > Recursos > Consultar"
}, {
    6246,
    "Gestión Humana > Maestros > Selección y Contratación > Recursos > Duplicar"
}, {
    6247,
    "Gestión Humana > Maestros > Selección y Contratación > Recursos > Eliminar"
}, {
    6248,
    "Gestión Humana > Maestros > Selección y Contratación > Recursos > Modificar"
}, {
    6249,
    "Gestión Humana > Maestros > Selección y Contratación > Recursos > Reporte"
}, {
    6213,
    "Gestión Humana > Maestros > Selección y Contratación > Sitios"
}, {
    6262,
    "Gestión Humana > Maestros > Selección y Contratación > Sitios > Adicionar"
}, {
    6263,
    "Gestión Humana > Maestros > Selección y Contratación > Sitios > Consultar"
}, {
    6264,
    "Gestión Humana > Maestros > Selección y Contratación > Sitios > Duplicar"
}, {
    6265,
    "Gestión Humana > Maestros > Selección y Contratación > Sitios > Eliminar"
}, {
    6266,
    "Gestión Humana > Maestros > Selección y Contratación > Sitios > Modificar"
}, {
    6267,
    "Gestión Humana > Maestros > Selección y Contratación > Sitios > Reporte"
}, {
    6206,
    "Gestión Humana > Maestros > Selección y Contratación > Temas"
}, {
    6220,
    "Gestión Humana > Maestros > Selección y Contratación > Temas > Adicionar"
}, {
    6221,
    "Gestión Humana > Maestros > Selección y Contratación > Temas > Consultar"
}, {
    6222,
    "Gestión Humana > Maestros > Selección y Contratación > Temas > Duplicar"
}, {
    6223,
    "Gestión Humana > Maestros > Selección y Contratación > Temas > Eliminar"
}, {
    6224,
    "Gestión Humana > Maestros > Selección y Contratación > Temas > Modificar"
}, {
    6225,
    "Gestión Humana > Maestros > Selección y Contratación > Temas > Reporte"
}, {
    6205,
    "Gestión Humana > Maestros > Selección y Contratación > Estados de seleccion"
}, {
    6214,
    "Gestión Humana > Maestros > Selección y Contratación > Estados de seleccion > Adicionar"
}, {
    6215,
    "Gestión Humana > Maestros > Selección y Contratación > Estados de seleccion > Consultar"
}, {
    6216,
    "Gestión Humana > Maestros > Selección y Contratación > Estados de seleccion > Duplicar"
}, {
    6217,
    "Gestión Humana > Maestros > Selección y Contratación > Estados de seleccion > Eliminar"
}, {
    6218,
    "Gestión Humana > Maestros > Selección y Contratación > Estados de seleccion > Modificar"
}, {
    6219,
    "Gestión Humana > Maestros > Selección y Contratación > Estados de seleccion > Reporte"
}, {
    6212,
    "Gestión Humana > Maestros > Selección y Contratación > Motivos de Requisicion"
}, {
    6256,
    "Gestión Humana > Maestros > Selección y Contratación > Motivos de Requisicion > Adicionar"
}, {
    6257,
    "Gestión Humana > Maestros > Selección y Contratación > Motivos de Requisicion > Consultar"
}, {
    6258,
    "Gestión Humana > Maestros > Selección y Contratación > Motivos de Requisicion > Duplicar"
}, {
    6259,
    "Gestión Humana > Maestros > Selección y Contratación > Motivos de Requisicion > Eliminar"
}, {
    6260,
    "Gestión Humana > Maestros > Selección y Contratación > Motivos de Requisicion > Modificar"
}, {
    6261,
    "Gestión Humana > Maestros > Selección y Contratación > Motivos de Requisicion > Reporte"
}, {
    5912,
    "Gestión Humana > Selección y contratacion"
}, {
    8039,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Calificacion de evaluacion"
}, {
    8040,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Calificacion de evaluacion > Adicionar"
}, {
    8041,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Calificacion de evaluacion > Consultar"
}, {
    8042,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Calificacion de evaluacion > Duplicar"
}, {
    8043,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Calificacion de evaluacion > Eliminar"
}, {
    8044,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Calificacion de evaluacion > Modificar"
}, {
    8045,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Calificacion de evaluacion > Reporte"
}, {
    6274,
    "Gestión Humana > Selección y contratacion > Requisicion de personal"
}, {
    6276,
    "Gestión Humana > Selección y contratacion > Requisicion de personal > Requisicion de personal"
}, {
    6278,
    "Gestión Humana > Selección y contratacion > Requisicion de personal > Requisicion de personal > Adicionar"
}, {
    6279,
    "Gestión Humana > Selección y contratacion > Requisicion de personal > Requisicion de personal > Consultar"
}, {
    6280,
    "Gestión Humana > Selección y contratacion > Requisicion de personal > Requisicion de personal > Duplicar"
}, {
    6281,
    "Gestión Humana > Selección y contratacion > Requisicion de personal > Requisicion de personal > Eliminar"
}, {
    6282,
    "Gestión Humana > Selección y contratacion > Requisicion de personal > Requisicion de personal > Modificar"
}, {
    6283,
    "Gestión Humana > Selección y contratacion > Requisicion de personal > Requisicion de personal > Reporte"
}, {
    6277,
    "Gestión Humana > Selección y contratacion > Requisicion de personal > Autorizacion de requisiciones"
}, {
    6284,
    "Gestión Humana > Selección y contratacion > Requisicion de personal > Autorizacion de requisiciones > Adicionar"
}, {
    6285,
    "Gestión Humana > Selección y contratacion > Requisicion de personal > Autorizacion de requisiciones > Consultar"
}, {
    6286,
    "Gestión Humana > Selección y contratacion > Requisicion de personal > Autorizacion de requisiciones > Duplicar"
}, {
    6287,
    "Gestión Humana > Selección y contratacion > Requisicion de personal > Autorizacion de requisiciones > Eliminar"
}, {
    6288,
    "Gestión Humana > Selección y contratacion > Requisicion de personal > Autorizacion de requisiciones > Modificar"
}, {
    6289,
    "Gestión Humana > Selección y contratacion > Requisicion de personal > Autorizacion de requisiciones > Reporte"
}, {
    6275,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion"
}, {
    6290,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Proceso de busqueda"
}, {
    6294,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Proceso de busqueda > Adicionar"
}, {
    6295,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Proceso de busqueda > Consultar"
}, {
    6296,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Proceso de busqueda > Duplicar"
}, {
    6297,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Proceso de busqueda > Eliminar"
}, {
    6298,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Proceso de busqueda > Modificar"
}, {
    6299,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Proceso de busqueda > Reporte"
}, {
    6293,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Contratacion"
}, {
    6312,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Contratacion > Adicionar"
}, {
    6313,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Contratacion > Consultar"
}, {
    6314,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Contratacion > Duplicar"
}, {
    6315,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Contratacion > Eliminar"
}, {
    6316,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Contratacion > Modificar"
}, {
    6317,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Contratacion > Reporte"
}, {
    6291,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Programacion de pruebas"
}, {
    6300,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Programacion de pruebas > Adicionar"
}, {
    6301,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Programacion de pruebas > Consultar"
}, {
    6302,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Programacion de pruebas > Duplicar"
}, {
    6303,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Programacion de pruebas > Eliminar"
}, {
    6304,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Programacion de pruebas > Modificar"
}, {
    6305,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Programacion de pruebas > Reporte"
}, {
    6292,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Evaluacion y seguimiento"
}, {
    6306,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Evaluacion y seguimiento > Adicionar"
}, {
    6307,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Evaluacion y seguimiento > Consultar"
}, {
    6308,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Evaluacion y seguimiento > Duplicar"
}, {
    6309,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Evaluacion y seguimiento > Eliminar"
}, {
    6310,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Evaluacion y seguimiento > Modificar"
}, {
    6311,
    "Gestión Humana > Selección y contratacion > Seleccion y contratacion > Evaluacion y seguimiento > Reporte"
}, {
    7486,
    "Horarios"
}, {
    7522,
    "Horarios > Asignacion_Turnos"
}, {
    7523,
    "Horarios > Asignacion_Turnos > Adicionar"
}, {
    7524,
    "Horarios > Asignacion_Turnos > Consultar"
}, {
    7525,
    "Horarios > Asignacion_Turnos > Duplicar"
}, {
    7526,
    "Horarios > Asignacion_Turnos > Eliminar"
}, {
    7527,
    "Horarios > Asignacion_Turnos > Modificar"
}, {
    7528,
    "Horarios > Asignacion_Turnos > Reporte"
}, {
    7501,
    "Horarios > Jornadas"
}, {
    7502,
    "Horarios > Jornadas > Adicionar"
}, {
    7503,
    "Horarios > Jornadas > Consultar"
}, {
    7504,
    "Horarios > Jornadas > Duplicar"
}, {
    7505,
    "Horarios > Jornadas > Eliminar"
}, {
    7506,
    "Horarios > Jornadas > Modificar"
}, {
    7507,
    "Horarios > Jornadas > Reporte"
}, {
    7494,
    "Horarios > Parametros_Liquidacion"
}, {
    7495,
    "Horarios > Parametros_Liquidacion > Adicionar"
}, {
    7496,
    "Horarios > Parametros_Liquidacion > Consultar"
}, {
    7497,
    "Horarios > Parametros_Liquidacion > Duplicar"
}, {
    7498,
    "Horarios > Parametros_Liquidacion > Eliminar"
}, {
    7499,
    "Horarios > Parametros_Liquidacion > Modificar"
}, {
    7500,
    "Horarios > Parametros_Liquidacion > Reporte"
}, {
    7487,
    "Horarios > Parametros_liq_comp"
}, {
    7488,
    "Horarios > Parametros_liq_comp > Adicionar"
}, {
    7489,
    "Horarios > Parametros_liq_comp > Consultar"
}, {
    7490,
    "Horarios > Parametros_liq_comp > Duplicar"
}, {
    7491,
    "Horarios > Parametros_liq_comp > Eliminar"
}, {
    7492,
    "Horarios > Parametros_liq_comp > Modificar"
}, {
    7493,
    "Horarios > Parametros_liq_comp > Reporte"
}, {
    7508,
    "Horarios > Turnos"
}, {
    7509,
    "Horarios > Turnos > Adicionar"
}, {
    7510,
    "Horarios > Turnos > Consultar"
}, {
    7511,
    "Horarios > Turnos > Duplicar"
}, {
    7512,
    "Horarios > Turnos > Eliminar"
}, {
    8012,
    "Horarios > Turnos_especiales_orden"
}, {
    8014,
    "Horarios > Turnos_especiales_orden > Adicionar"
}, {
    8015,
    "Horarios > Turnos_especiales_orden > Consultar"
}, {
    8016,
    "Horarios > Turnos_especiales_orden > Duplicar"
}, {
    8017,
    "Horarios > Turnos_especiales_orden > Eliminar"
}, {
    8018,
    "Horarios > Turnos_especiales_orden > Modificar"
}, {
    8019,
    "Horarios > Turnos_especiales_orden > Reporte"
}, {
    8013,
    "Horarios > Turnos_especiales_param"
}, {
    8021,
    "Horarios > Turnos_especiales_param > Consultar"
}, {
    8020,
    "Horarios > Turnos_especiales_param > Adicionar"
}, {
    8022,
    "Horarios > Turnos_especiales_param > Duplicar"
}, {
    8023,
    "Horarios > Turnos_especiales_param > Eliminar"
}, {
    8024,
    "Horarios > Turnos_especiales_param > Modificar"
}, {
    8025,
    "Horarios > Turnos_especiales_param > Reporte"
}, {
    7513,
    "Horarios > Turnos > Modificar"
}, {
    7514,
    "Horarios > Turnos > Reporte"
}, {
    7515,
    "Horarios > Turnos_Variables"
}, {
    7516,
    "Horarios > Turnos_Variables > Adicionar"
}, {
    7517,
    "Horarios > Turnos_Variables > Consultar"
}, {
    7518,
    "Horarios > Turnos_Variables > Duplicar"
}, {
    7519,
    "Horarios > Turnos_Variables > Eliminar"
}, {
    7520,
    "Horarios > Turnos_Variables > Modificar"
}, {
    7521,
    "Horarios > Turnos_Variables > Reporte"
}, {
    1214,
    "Comercial - Inventarios"
}, {
    7187,
    "Comercial - Inventarios > Presupuesto"
}, {
    10946,
    "Comercial - Inventarios > Presupuesto > Aprobación"
}, {
    7198,
    "Comercial - Inventarios > Presupuesto > Apropiación"
}, {
    7199,
    "Comercial - Inventarios > Presupuesto > Apropiación > Adicionar"
}, {
    7201,
    "Comercial - Inventarios > Presupuesto > Apropiación > Eliminar"
}, {
    7200,
    "Comercial - Inventarios > Presupuesto > Apropiación > Modificar"
}, {
    7214,
    "Comercial - Inventarios > Presupuesto > Consultas"
}, {
    7215,
    "Comercial - Inventarios > Presupuesto > Consultas > Presupuestos controlados"
}, {
    7216,
    "Comercial - Inventarios > Presupuesto > Consultas > Presupuestos no controlados"
}, {
    9618,
    "Comercial - Inventarios > Presupuesto > Consultas > Presupuesto controlado ejecución"
}, {
    9617,
    "Comercial - Inventarios > Presupuesto > Consultas > Presupuesto controlado movimiento"
}, {
    7188,
    "Comercial - Inventarios > Presupuesto > Control presupuestal"
}, {
    7189,
    "Comercial - Inventarios > Presupuesto > Control presupuestal > Adicionar"
}, {
    7195,
    "Comercial - Inventarios > Presupuesto > Control presupuestal > Aprobar"
}, {
    7197,
    "Comercial - Inventarios > Presupuesto > Control presupuestal > Cerrar"
}, {
    7192,
    "Comercial - Inventarios > Presupuesto > Control presupuestal > Consultar"
}, {
    7196,
    "Comercial - Inventarios > Presupuesto > Control presupuestal > Desaprobar"
}, {
    7193,
    "Comercial - Inventarios > Presupuesto > Control presupuestal > Duplicar"
}, {
    7191,
    "Comercial - Inventarios > Presupuesto > Control presupuestal > Eliminar"
}, {
    7190,
    "Comercial - Inventarios > Presupuesto > Control presupuestal > Modificar"
}, {
    8381,
    "Comercial - Inventarios > Presupuesto > Control presupuestal > Permitir adicionar responsables con ppto aprobado"
}, {
    7194,
    "Comercial - Inventarios > Presupuesto > Control presupuestal > Reporte"
}, {
    9620,
    "Comercial - Inventarios > Presupuesto > Consultas > Presupuesto no controlado ejecución"
}, {
    9619,
    "Comercial - Inventarios > Presupuesto > Consultas > Presupuesto no controlado movimiento"
}, {
    7202,
    "Comercial - Inventarios > Presupuesto > Traslados, adiciones y reducciones"
}, {
    7203,
    "Comercial - Inventarios > Presupuesto > Traslados, adiciones y reducciones > Adiciones - Adicionar"
}, {
    7205,
    "Comercial - Inventarios > Presupuesto > Traslados, adiciones y reducciones > Adiciones - Eliminar"
}, {
    7204,
    "Comercial - Inventarios > Presupuesto > Traslados, adiciones y reducciones > Adiciones - Modificar"
}, {
    7213,
    "Comercial - Inventarios > Presupuesto > Traslados, adiciones y reducciones > Eliminar"
}, {
    7209,
    "Comercial - Inventarios > Presupuesto > Traslados, adiciones y reducciones > Reducciones - Adicionar"
}, {
    7211,
    "Comercial - Inventarios > Presupuesto > Traslados, adiciones y reducciones > Reducciones - Eliminar"
}, {
    7210,
    "Comercial - Inventarios > Presupuesto > Traslados, adiciones y reducciones > Reducciones - Modificar"
}, {
    7212,
    "Comercial - Inventarios > Presupuesto > Traslados, adiciones y reducciones > Reporte"
}, {
    7206,
    "Comercial - Inventarios > Presupuesto > Traslados, adiciones y reducciones > Traslados - Adicionar"
}, {
    7208,
    "Comercial - Inventarios > Presupuesto > Traslados, adiciones y reducciones > Traslados - Eliminar"
}, {
    7207,
    "Comercial - Inventarios > Presupuesto > Traslados, adiciones y reducciones > Traslados - Modificar"
}, {
    3414,
    "Comercial - Inventarios > Acumulados"
}, {
    3713,
    "Comercial - Inventarios > Acumulados > Cubo de existencias por bodega"
}, {
    4252,
    "Comercial - Inventarios > Acumulados > Cubo de existencias por bodega sumarizado"
}, {
    3714,
    "Comercial - Inventarios > Acumulados > Cubo de existencias por instalación"
}, {
    4253,
    "Comercial - Inventarios > Acumulados > Cubo de existencias por instalación sumarizado"
}, {
    3415,
    "Comercial - Inventarios > Acumulados > Cubo de Inventarios"
}, {
    4254,
    "Comercial - Inventarios > Acumulados > Cubo de inventarios sumarizado"
}, {
    2243,
    "Comercial - Inventarios > Ajustes por inflación"
}, {
    2252,
    "Comercial - Inventarios > Ajustes por inflación > Anular"
}, {
    2245,
    "Comercial - Inventarios > Ajustes por inflación > Consultas"
}, {
    2248,
    "Comercial - Inventarios > Ajustes por inflación > Consultas > Movimiento"
}, {
    2249,
    "Comercial - Inventarios > Ajustes por inflación > Consultas > Resumen"
}, {
    2247,
    "Comercial - Inventarios > Ajustes por inflación > Consultas > Saldos"
}, {
    2244,
    "Comercial - Inventarios > Ajustes por inflación > Generación"
}, {
    2246,
    "Comercial - Inventarios > Ajustes por inflación > Saldos iniciales"
}, {
    2251,
    "Comercial - Inventarios > Ajustes por inflación > Saldos iniciales > Edición"
}, {
    2250,
    "Comercial - Inventarios > Ajustes por inflación > Saldos iniciales > Generación"
}, {
    1413,
    "Comercial - Inventarios > Consultas y reportes"
}, {
    10670,
    "Comercial - Inventarios > Consultas y reportes > Consulta ajustes NCIF"
}, {
    4007,
    "Comercial - Inventarios > Consultas y reportes > Analisis de existencias por bodega"
}, {
    4010,
    "Comercial - Inventarios > Consultas y reportes > Analisis de existencias por instalación"
}, {
    2309,
    "Comercial - Inventarios > Consultas y reportes > Analisis de transferencias"
}, {
    1507,
    "Comercial - Inventarios > Consultas y reportes > Auditoria"
}, {
    12092,
    "Comercial - Inventarios > Consultas y reportes > Auditoría de transacciones"
}, {
    7063,
    "Comercial - Inventarios > Consultas y reportes > Balance de inventarios por ubicación"
}, {
    1417,
    "Comercial - Inventarios > Consultas y reportes > Balance de inventario por bodega"
}, {
    2432,
    "Comercial - Inventarios > Consultas y reportes > Balance de inventario por instalación"
}, {
    11304,
    "Comercial - Inventarios > Consultas y reportes > Balance de inventario por lote"
}, {
    1415,
    "Comercial - Inventarios > Consultas y reportes > Existencias columnarias por bodega"
}, {
    10877,
    "Comercial - Inventarios > Consultas y reportes > Compromisos por ubicación, lote y seriales"
}, {
    10876,
    "Comercial - Inventarios > Consultas y reportes > Compromisos por ítem"
}, {
    10615,
    "Comercial - Inventarios > Consultas y reportes > Entidades de documentos"
}, {
    1414,
    "Comercial - Inventarios > Consultas y reportes > Existencias a la fecha"
}, {
    3468,
    "Comercial - Inventarios > Consultas y reportes > Existencias a un corte"
}, {
    4009,
    "Comercial - Inventarios > Consultas y reportes > Existencias a un corte por instalación"
}, {
    4008,
    "Comercial - Inventarios > Consultas y reportes > Existencias a la fecha por instalación"
}, {
    1530,
    "Comercial - Inventarios > Consultas y reportes > Existencias por lote"
}, {
    3050,
    "Comercial - Inventarios > Consultas y reportes > Existencias de seriales"
}, {
    4448,
    "Comercial - Inventarios > Consultas y reportes > Existencias de seriales a un corte"
}, {
    4694,
    "Comercial - Inventarios > Consultas y reportes > Inventario por edades"
}, {
    8086,
    "Comercial - Inventarios > Consultas y reportes > Inventario de forecast"
}, {
    4235,
    "Comercial - Inventarios > Consultas y reportes > Movimientos de inventario"
}, {
    3288,
    "Comercial - Inventarios > Consultas y reportes > Reporte de kárdex por instalación"
}, {
    3534,
    "Comercial - Inventarios > Consultas y reportes > Reporte de kárdex por bodega"
}, {
    3362,
    "Comercial - Inventarios > Consultas y reportes > Requisiciones internas"
}, {
    6361,
    "Comercial - Inventarios > Consultas y reportes > Requisiciones internas por ítem"
}, {
    11337,
    "Comercial - Inventarios > Consultas y reportes > Requisiciones internas > Modificar notas"
}, {
    12564,
    "Comercial - Inventarios > Consultas y reportes > Requisiciones internas > Modificar notas > Permitir modificar número de la OC"
}, {
    11338,
    "Comercial - Inventarios > Consultas y reportes > Requisiciones internas > Modificar notas > Permitir modificar referencia"
}, {
    1418,
    "Comercial - Inventarios > Consultas y reportes > Resumen de transacciones"
}, {
    10663,
    "Comercial - Inventarios > Consultas y reportes > Resumen de inventarios contable"
}, {
    10178,
    "Comercial - Inventarios > Consultas y reportes > Resumen de transancciones por segmento"
}, {
    6362,
    "Comercial - Inventarios > Consultas y reportes > Resumen de requisiones internas"
}, {
    3278,
    "Comercial - Inventarios > Consultas y reportes > Seguimiento de documentos"
}, {
    2848,
    "Comercial - Inventarios > Consultas y reportes > Simulacion de ensambles"
}, {
    2280,
    "Comercial - Inventarios > Consultas y reportes > Transferencia en tránsito"
}, {
    1416,
    "Comercial - Inventarios > Ver costos"
}, {
    2944,
    "Comercial - Inventarios > Ver precios de venta"
}, {
    1378,
    "Comercial - Inventarios > Conteo cíclico"
}, {
    1379,
    "Comercial - Inventarios > Conteo cíclico > Recalcular rotación"
}, {
    1380,
    "Comercial - Inventarios > Conteo cíclico > Reporte"
}, {
    1215,
    "Comercial - Inventarios > Documentos"
}, {
    7968,
    "Comercial - Inventarios > Documentos > Actualizar movimientos grabados al adicionar"
}, {
    1219,
    "Comercial - Inventarios > Documentos > Ajuste"
}, {
    1252,
    "Comercial - Inventarios > Documentos > Ajuste > Adicionar"
}, {
    4676,
    "Comercial - Inventarios > Documentos > Ajuste > Permitir ajustes en valor cuando no hay existencia"
}, {
    1253,
    "Comercial - Inventarios > Documentos > Ajuste > Anular"
}, {
    1251,
    "Comercial - Inventarios > Documentos > Ajuste > Aprobar"
}, {
    1254,
    "Comercial - Inventarios > Documentos > Ajuste > Consultar"
}, {
    1369,
    "Comercial - Inventarios > Documentos > Ajuste conteo cíclico"
}, {
    1370,
    "Comercial - Inventarios > Documentos > Ajuste conteo cíclico > Adicionar"
}, {
    1371,
    "Comercial - Inventarios > Documentos > Ajuste conteo cíclico > Anular"
}, {
    1372,
    "Comercial - Inventarios > Documentos > Ajuste conteo cíclico > Aprobar"
}, {
    8815,
    "Comercial - Inventarios > Documentos > Ajuste conteo cíclico > Asumir costo estándar para items sin costo"
}, {
    1373,
    "Comercial - Inventarios > Documentos > Ajuste conteo cíclico > Consultar"
}, {
    1376,
    "Comercial - Inventarios > Documentos > Ajuste conteo cíclico > Eliminar movimiento"
}, {
    1377,
    "Comercial - Inventarios > Documentos > Ajuste conteo cíclico > Modificar"
}, {
    4607,
    "Comercial - Inventarios > Documentos > Ajuste conteo cíclico > Modificar entidades dinámicas en doctos aprobados"
}, {
    8914,
    "Comercial - Inventarios > Documentos > Ajuste conteo cíclico > Permitir ítem sin costo"
}, {
    1258,
    "Comercial - Inventarios > Documentos > Ajuste > Eliminar movimiento"
}, {
    8147,
    "Comercial - Inventarios > Documentos > Ajustes al estándar"
}, {
    10791,
    "Comercial - Inventarios > Documentos > Ajustes al estándar > Permitir seleccionar el tipo de costo"
}, {
    1220,
    "Comercial - Inventarios > Documentos > Ajuste físico"
}, {
    1260,
    "Comercial - Inventarios > Documentos > Ajuste físico > Adicionar"
}, {
    4393,
    "Comercial - Inventarios > Documentos > Ajuste físico > Permitir adicionar movimientos al importar conteos"
}, {
    3485,
    "Comercial - Inventarios > Documentos > Ajuste físico > Permite adicionar conteos si existe el siguiente"
}, {
    1261,
    "Comercial - Inventarios > Documentos > Ajuste físico > Anular"
}, {
    1259,
    "Comercial - Inventarios > Documentos > Ajuste físico > Aprobar"
}, {
    4875,
    "Comercial - Inventarios > Documentos > Ajuste físico > Asumir costos estándar para ítem sin costo"
}, {
    1262,
    "Comercial - Inventarios > Documentos > Ajuste físico > Consultar"
}, {
    1266,
    "Comercial - Inventarios > Documentos > Ajuste físico > Eliminar movimiento"
}, {
    4876,
    "Comercial - Inventarios > Documentos > Ajuste físico > Permitir ítem sin costo"
}, {
    1263,
    "Comercial - Inventarios > Documentos > Ajuste físico > Modificar"
}, {
    3484,
    "Comercial - Inventarios > Documentos > Ajuste físico > Permite modificar conteos anteriores"
}, {
    4608,
    "Comercial - Inventarios > Documentos > Ajuste físico > Modificar entidades dinámicas en doctos aprobados"
}, {
    3486,
    "Comercial - Inventarios > Documentos > Ajuste físico > Permite adicionar varios items en el mismo conteo"
}, {
    1255,
    "Comercial - Inventarios > Documentos > Ajuste > Modificar"
}, {
    4606,
    "Comercial - Inventarios > Documentos > Ajuste > Modificar entidades dinámicas en doctos aprobados"
}, {
    8324,
    "Comercial - Inventarios > Documentos > Ajustes NCIF"
}, {
    8325,
    "-No implementado > Automático"
}, {
    8341,
    "-No implementado > Consultas ajustes niif"
}, {
    8326,
    "-No implementado > Directos"
}, {
    8327,
    "-No implementado > Directos > Adicionar"
}, {
    8328,
    "-No implementado > Directos > Anular"
}, {
    8329,
    "-No implementado > Directos > Aprobar"
}, {
    8330,
    "-No implementado > Directos > Consultar"
}, {
    8333,
    "-No implementado > Movimiento"
}, {
    8331,
    "-No implementado > Directos > Eliminar movimiento"
}, {
    8332,
    "-No implementado > Directos > Modificar"
}, {
    8421,
    "-No implementado > Documento ajuste VNR"
}, {
    8422,
    "-No implementado > Documento ajuste VNR > Anular"
}, {
    8420,
    "Comercial - Inventarios > Documentos > Ajustes NCIF > Proceso ajuste VNR"
}, {
    12220,
    "Comercial - Inventarios > Documentos > Ajuste > Permitir transacciones de diferentes CO"
}, {
    7870,
    "Comercial - Inventarios > Documentos > Ajuste automático"
}, {
    8750,
    "Comercial - Inventarios > Documentos > Proceso de descuento financiero por pronto pago"
}, {
    1225,
    "Comercial - Inventarios > Documentos > Desensamble"
}, {
    1300,
    "Comercial - Inventarios > Documentos > Desensamble > Adicionar"
}, {
    1301,
    "Comercial - Inventarios > Documentos > Desensamble > Anular"
}, {
    1299,
    "Comercial - Inventarios > Documentos > Desensamble > Aprobar"
}, {
    1302,
    "Comercial - Inventarios > Documentos > Desensamble > Consultar"
}, {
    1306,
    "Comercial - Inventarios > Documentos > Desensamble > Eliminar movimiento"
}, {
    1305,
    "Comercial - Inventarios > Documentos > Desensamble > Habilitar impresión"
}, {
    1304,
    "Comercial - Inventarios > Documentos > Desensamble > Imprimir"
}, {
    1303,
    "Comercial - Inventarios > Documentos > Desensamble > Modificar"
}, {
    10825,
    "Comercial - Inventarios > Documentos > Desensamble > Modificar componentes"
}, {
    4609,
    "Comercial - Inventarios > Documentos > Desensamble > Modificar entidades dinámicas en doctos aprobados"
}, {
    1217,
    "Comercial - Inventarios > Documentos > Entradas"
}, {
    1236,
    "Comercial - Inventarios > Documentos > Entradas > Adicionar"
}, {
    1237,
    "Comercial - Inventarios > Documentos > Entradas > Anular"
}, {
    1235,
    "Comercial - Inventarios > Documentos > Entradas > Aprobar"
}, {
    11638,
    "Comercial - Inventarios > Documentos > Entradas > Presentar cantidad y costo en la unidad adicional"
}, {
    11034,
    "Comercial - Inventarios > Documentos > Entradas > Permitir capturar costos por segmentos"
}, {
    1238,
    "Comercial - Inventarios > Documentos > Entradas > Consultar"
}, {
    1242,
    "Comercial - Inventarios > Documentos > Entradas > Eliminar movimiento"
}, {
    10186,
    "Comercial - Inventarios > Documentos > Entradas > Exigir costo estándar para producto terminado"
}, {
    1239,
    "Comercial - Inventarios > Documentos > Entradas > Modificar"
}, {
    4610,
    "Comercial - Inventarios > Documentos > Entradas > Modificar entidades dinámicas en doctos aprobados"
}, {
    7950,
    "Comercial - Inventarios > Documentos > Entradas > Permitir capturar costo"
}, {
    8355,
    "Comercial - Inventarios > Documentos > Entradas > Presentar costos de la transacción"
}, {
    2452,
    "Comercial - Inventarios > Documentos > Entradas > Sobrecosto mayor valor"
}, {
    3100,
    "Comercial - Inventarios > Documentos > Entradas > Sugerir costo estandar para producto terminado"
}, {
    12217,
    "Comercial - Inventarios > Documentos > Entradas > Permitir transacciones de diferentes CO"
}, {
    7803,
    "Comercial - Inventarios > Documentos > Entradas desde salidas"
}, {
    8884,
    "Comercial - Inventarios > Documentos > Entradas desde salidas > Presentar costos de la transacción"
}, {
    10895,
    "Comercial - Inventarios > Documentos > Generales"
}, {
    10896,
    "Comercial - Inventarios > Documentos > Generales > Asumir la cantidad adicional al comprometer"
}, {
    1509,
    "Comercial - Inventarios > Documentos > Habilitar impresión"
}, {
    1510,
    "Comercial - Inventarios > Documentos > Imprimir"
}, {
    1322,
    "Comercial - Inventarios > Documentos > Inventario fisico"
}, {
    1332,
    "Comercial - Inventarios > Documentos > Inventario fisico > Anular"
}, {
    8969,
    "Comercial - Inventarios > Documentos > Inventario fisico > Apagar por defecto indicador de controla conteos"
}, {
    8968,
    "Comercial - Inventarios > Documentos > Inventario fisico > Apagar por defecto indicador de controla etiquetas"
}, {
    7402,
    "Comercial - Inventarios > Documentos > Inventario fisico - captura múltiple"
}, {
    8573,
    "Comercial - Inventarios > Documentos > Inventario fisico > Captura sección"
}, {
    1324,
    "Comercial - Inventarios > Documentos > Inventario fisico > Cargar"
}, {
    1325,
    "Comercial - Inventarios > Documentos > Inventario fisico > Cerrar"
}, {
    1362,
    "Comercial - Inventarios > Documentos > Inventario fisico > Consulta análisis de diferencias"
}, {
    6499,
    "Comercial - Inventarios > Documentos > Inventario fisico > Consulta análisis de diferencia pdtes de ajustes"
}, {
    1361,
    "Comercial - Inventarios > Documentos > Inventario fisico > Consulta conteo"
}, {
    1363,
    "Comercial - Inventarios > Documentos > Inventario fisico - conteo > Consulta movimiento"
}, {
    1333,
    "Comercial - Inventarios > Documentos > Inventario fisico - conteo"
}, {
    1334,
    "Comercial - Inventarios > Documentos > Inventario fisico - conteo > Adicionar"
}, {
    1338,
    "Comercial - Inventarios > Documentos > Inventario fisico - conteo > Automático"
}, {
    7875,
    "Comercial - Inventarios > Documentos > Inventario fisico - conteo > Capturar cantidad en código de barras automático"
}, {
    1336,
    "Comercial - Inventarios > Documentos > Inventario fisico - conteo > Eliminar"
}, {
    2431,
    "Comercial - Inventarios > Documentos > Inventario fisico - conteo > Imprimir"
}, {
    1335,
    "Comercial - Inventarios > Documentos > Inventario fisico - conteo > Modificar"
}, {
    1337,
    "Comercial - Inventarios > Documentos > Inventario fisico - conteo > Supervisor"
}, {
    6777,
    "Comercial - Inventarios > Documentos > Inventario fisico > Crear etiqueta al adicionar un item al cargue"
}, {
    1327,
    "Comercial - Inventarios > Documentos > Inventario fisico > Deshacer cargue"
}, {
    1328,
    "Comercial - Inventarios > Documentos > Inventario fisico > Deshacer cierre"
}, {
    6739,
    "Comercial - Inventarios > Documentos > Inventario fisico > Duplicar etiquetas"
}, {
    8970,
    "Comercial - Inventarios > Documentos > Inventario fisico > Elegir x defecto indicador de ítems sin existencia"
}, {
    1329,
    "Comercial - Inventarios > Documentos > Inventario fisico > Etiquetas"
}, {
    1326,
    "Comercial - Inventarios > Documentos > Inventario fisico > Generar ajuste"
}, {
    1330,
    "Comercial - Inventarios > Documentos > Inventario fisico > Imprimir"
}, {
    11201,
    "Comercial - Inventarios > Documentos > Inventario fisico > Permitir recargar las existencias"
}, {
    1331,
    "Comercial - Inventarios > Documentos > Inventario fisico > Salvar"
}, {
    1323,
    "Comercial - Inventarios > Documentos > Inventario fisico > Seleccionar"
}, {
    4605,
    "Comercial - Inventarios > Documentos > No validar equiv. si la bodega no maneja costos"
}, {
    1226,
    "Comercial - Inventarios > Documentos > Procesos /Ensambles"
}, {
    1308,
    "Comercial - Inventarios > Documentos > Procesos /Ensambles > Generales > Adicionar"
}, {
    1309,
    "Comercial - Inventarios > Documentos > Procesos /Ensambles > Generales > Anular"
}, {
    1307,
    "Comercial - Inventarios > Documentos > Procesos /Ensambles > Generales > Aprobar"
}, {
    1310,
    "Comercial - Inventarios > Documentos > Procesos /Ensambles > Generales > Consultar"
}, {
    2847,
    "Comercial - Inventarios > Documentos > Procesos /Ensambles > Generales > Edita cantidades requeridas"
}, {
    1314,
    "Comercial - Inventarios > Documentos > Procesos /Ensambles > Generales > Eliminar movimiento"
}, {
    6524,
    "Comercial - Inventarios > Documentos > Procesos /Ensambles > Generales"
}, {
    6522,
    "Comercial - Inventarios > Documentos > Procesos /Ensambles > Manual y automático"
}, {
    6900,
    "Comercial - Inventarios > Documentos > Procesos /Ensambles > Manual y automático > Validar los ítems que tiene la fórmula del Kit"
}, {
    6894,
    "Comercial - Inventarios > Documentos > Procesos /Ensambles > Manual y automático > Permite procesos manuales"
}, {
    1311,
    "Comercial - Inventarios > Documentos > Procesos /Ensambles > Generales > Modificar"
}, {
    4611,
    "Comercial - Inventarios > Documentos > Procesos /Ensambles > Generales > Modificar entidades dinámicas en doctos aprobados"
}, {
    7608,
    "Comercial - Inventarios > Documentos > Procesos /Ensambles > Generales > Permitir transacciones de diferentes CO"
}, {
    6523,
    "Comercial - Inventarios > Documentos > Procesos /Ensambles > Reclasificación de extensiones"
}, {
    2456,
    "Comercial - Inventarios > Documentos > Procesos /Ensambles > Generales > Sobrecosto mayor valor"
}, {
    1216,
    "Comercial - Inventarios > Documentos > Saldos iniciales"
}, {
    1228,
    "Comercial - Inventarios > Documentos > Saldos iniciales > Adicionar"
}, {
    1229,
    "Comercial - Inventarios > Documentos > Saldos iniciales > Anular"
}, {
    1227,
    "Comercial - Inventarios > Documentos > Saldos iniciales > Aprobar"
}, {
    1230,
    "Comercial - Inventarios > Documentos > Saldos iniciales > Consultar"
}, {
    1234,
    "Comercial - Inventarios > Documentos > Saldos iniciales > Eliminar movimiento"
}, {
    1231,
    "Comercial - Inventarios > Documentos > Saldos iniciales > Modificar"
}, {
    4612,
    "Comercial - Inventarios > Documentos > Saldos iniciales > Modificar entidades dinámicas en doctos aprobados"
}, {
    12219,
    "Comercial - Inventarios > Documentos > Saldos iniciales > Permitir transacciones de diferentes CO"
}, {
    1218,
    "Comercial - Inventarios > Documentos > Salidas"
}, {
    1244,
    "Comercial - Inventarios > Documentos > Salidas > Adicionar"
}, {
    1245,
    "Comercial - Inventarios > Documentos > Salidas > Anular"
}, {
    1243,
    "Comercial - Inventarios > Documentos > Salidas > Aprobar"
}, {
    1246,
    "Comercial - Inventarios > Documentos > Salidas > Consultar"
}, {
    8883,
    "Comercial - Inventarios > Documentos > Salidas > Presentar costos de la transacción"
}, {
    1250,
    "Comercial - Inventarios > Documentos > Salidas > Eliminar movimiento"
}, {
    1247,
    "Comercial - Inventarios > Documentos > Salidas > Modificar"
}, {
    4613,
    "Comercial - Inventarios > Documentos > Salidas > Modificar entidades dinámicas en doctos aprobados"
}, {
    12218,
    "Comercial - Inventarios > Documentos > Salidas > Permitir transacciones de diferentes CO"
}, {
    2264,
    "Comercial - Inventarios > Documentos > Transferencia devolución tránsito"
}, {
    2265,
    "Comercial - Inventarios > Documentos > Transferencia devolución tránsito > Adicionar"
}, {
    2266,
    "Comercial - Inventarios > Documentos > Transferencia devolución tránsito > Anular"
}, {
    2267,
    "Comercial - Inventarios > Documentos > Transferencia devolución tránsito > Aprobar"
}, {
    7801,
    "Comercial - Inventarios > Documentos > Transferencia devolución tránsito > Capturar cantidad en código de barras automático"
}, {
    2268,
    "Comercial - Inventarios > Documentos > Transferencia devolución tránsito > Consultar"
}, {
    8671,
    "Comercial - Inventarios > Documentos > Transferencia devolución tránsito > Presentar costos de la transacción"
}, {
    2269,
    "Comercial - Inventarios > Documentos > Transferencia devolución tránsito > Eliminar movimiento"
}, {
    11111,
    "Comercial - Inventarios > Documentos > Transferencia devolución tránsito > Generar automático"
}, {
    2270,
    "Comercial - Inventarios > Documentos > Transferencia devolución tránsito > Modificar"
}, {
    4615,
    "Comercial - Inventarios > Documentos > Transferencia devolución tránsito > Modificar entidades dinámicas en doctos aprobados"
}, {
    2455,
    "Comercial - Inventarios > Documentos > Transferencia devolución tránsito > Sobrecosto mayor valor"
}, {
    8646,
    "Comercial - Inventarios > Documentos > Transferencia devolución tránsito > Validar maestros por usuarios -bodegas de entradas"
}, {
    8647,
    "Comercial - Inventarios > Documentos > Transferencia devolución tránsito > Validar maestros por usuarios -bodegas de salida"
}, {
    1223,
    "Comercial - Inventarios > Documentos > Transferencia"
}, {
    1284,
    "Comercial - Inventarios > Documentos > Transferencia > Adicionar"
}, {
    1285,
    "Comercial - Inventarios > Documentos > Transferencia > Anular"
}, {
    1283,
    "Comercial - Inventarios > Documentos > Transferencia > Aprobar"
}, {
    7559,
    "Comercial - Inventarios > Documentos > Transferencia > Validar maestros por usuarios - bodegas de entrada"
}, {
    7560,
    "Comercial - Inventarios > Documentos > Transferencia > Validar maestros por usuarios - bodegas de salida"
}, {
    7874,
    "Comercial - Inventarios > Documentos > Transferencia > Capturar cantidad en código de barras automático"
}, {
    11262,
    "Comercial - Inventarios > Documentos > Transferencia > Captura orden de producción al adicionar"
}, {
    1286,
    "Comercial - Inventarios > Documentos > Transferencia > Consultar"
}, {
    6760,
    "Comercial - Inventarios > Documentos > Transferencia > Consolidar automáticamente después de aprobar"
}, {
    8882,
    "Comercial - Inventarios > Documentos > Transferencia > Presentar costos de la transacción"
}, {
    1290,
    "Comercial - Inventarios > Documentos > Transferencia > Eliminar movimiento"
}, {
    1287,
    "Comercial - Inventarios > Documentos > Transferencia > Modificar"
}, {
    4614,
    "Comercial - Inventarios > Documentos > Transferencia > Modificar entidades dinámicas en doctos aprobados"
}, {
    7607,
    "Comercial - Inventarios > Documentos > Transferencia > Permitir transacciones de diferentes CO"
}, {
    2453,
    "Comercial - Inventarios > Documentos > Transferencia > Sobrecosto mayor valor"
}, {
    9732,
    "Comercial - Inventarios > Documentos > Transferencia > Sugerir Lote"
}, {
    9731,
    "Comercial - Inventarios > Documentos > Transferencia > Sugerir ubicación de entrada"
}, {
    9730,
    "Comercial - Inventarios > Documentos > Transferencia > Sugerir ubicación de salida"
}, {
    10875,
    "Comercial - Inventarios > Documentos > Transferencia > Evitar transferir un lote 2 veces en el documento"
}, {
    1222,
    "Comercial - Inventarios > Documentos > Transferencia entrada tránsito"
}, {
    1276,
    "Comercial - Inventarios > Documentos > Transferencia entrada tránsito > Adicionar"
}, {
    1277,
    "Comercial - Inventarios > Documentos > Transferencia entrada tránsito > Anular"
}, {
    1275,
    "Comercial - Inventarios > Documentos > Transferencia entrada tránsito > Aprobar"
}, {
    7799,
    "Comercial - Inventarios > Documentos > Transferencia entrada tránsito > Capturar cantidad en código de barras automático"
}, {
    1278,
    "Comercial - Inventarios > Documentos > Transferencia entrada tránsito > Consultar"
}, {
    8672,
    "Comercial - Inventarios > Documentos > Transferencia entrada tránsito > Presentar costos de la transacción"
}, {
    1282,
    "Comercial - Inventarios > Documentos > Transferencia entrada tránsito > Eliminar movimiento"
}, {
    12246,
    "Comercial - Inventarios > Documentos > Transferencia entrada tránsito > Permitir generar desensamble"
}, {
    11112,
    "Comercial - Inventarios > Documentos > Transferencia entrada tránsito > Generar automático"
}, {
    1279,
    "Comercial - Inventarios > Documentos > Transferencia entrada tránsito > Modificar"
}, {
    4616,
    "Comercial - Inventarios > Documentos > Transferencia entrada tránsito > Modificar entidades dinámicas en doctos aprobados"
}, {
    10066,
    "Comercial - Inventarios > Documentos > Transferencia entrada tránsito > Traer las notas desde salida transito"
}, {
    2454,
    "Comercial - Inventarios > Documentos > Transferencia entrada tránsito > Sobrecosto mayor valor"
}, {
    8709,
    "Comercial - Inventarios > Documentos > Transferencia entrada tránsito > Siempre sugerir ubic default de bodega de entrada"
}, {
    1221,
    "Comercial - Inventarios > Documentos > Transferencia salida tránsito"
}, {
    1268,
    "Comercial - Inventarios > Documentos > Transferencia salida tránsito > Generales > Adicionar"
}, {
    1269,
    "Comercial - Inventarios > Documentos > Transferencia salida tránsito > Generales > Anular"
}, {
    1267,
    "Comercial - Inventarios > Documentos > Transferencia salida tránsito > Generales > Aprobar"
}, {
    7561,
    "Comercial - Inventarios > Documentos > Transferencia salida tránsito > Generales > Validar maestros por usuarios - bodegas de entrada"
}, {
    7562,
    "Comercial - Inventarios > Documentos > Transferencia salida tránsito > Generales > Validar maestros por usuarios - bodegas de salida"
}, {
    7800,
    "Comercial - Inventarios > Documentos > Transferencia salida tránsito > Generales > Capturar cantidad en código de barras automático"
}, {
    1270,
    "Comercial - Inventarios > Documentos > Transferencia salida tránsito > Generales > Consultar"
}, {
    8673,
    "Comercial - Inventarios > Documentos > Transferencia salida tránsito > Generales > Presentar costos de la transacción"
}, {
    1274,
    "Comercial - Inventarios > Documentos > Transferencia salida tránsito > Generales > Eliminar movimiento"
}, {
    8697,
    "Comercial - Inventarios > Documentos > Transferencia salida tránsito > Generales"
}, {
    12221,
    "-No implementado > Permitir transacciones de diferentes CO"
}, {
    8698,
    "Comercial - Inventarios > Documentos > Transferencia salida tránsito > Generación desde entrada"
}, {
    1271,
    "Comercial - Inventarios > Documentos > Transferencia salida tránsito > Generales > Modificar"
}, {
    4617,
    "Comercial - Inventarios > Documentos > Transferencia salida tránsito > Generales > Modificar entidades dinámicas en doctos aprobados"
}, {
    9729,
    "Comercial - Inventarios > Documentos > Transferencia salida tránsito > Generales > Sugerir Lote"
}, {
    9728,
    "Comercial - Inventarios > Documentos > Transferencia salida tránsito > Generales > Sugerir ubicación de entrada"
}, {
    9727,
    "Comercial - Inventarios > Documentos > Transferencia salida tránsito > Generales > Sugerir ubicación de salida"
}, {
    1419,
    "Comercial - Inventarios > Parametros de control"
}, {
    1424,
    "Comercial - Inventarios > Parametros de control > Cantidad a pedir"
}, {
    1420,
    "Comercial - Inventarios > Parametros de control > Edición"
}, {
    1426,
    "Comercial - Inventarios > Parametros de control > Inventario inactivo"
}, {
    1425,
    "Comercial - Inventarios > Parametros de control > Análisis de máximos y mínimos"
}, {
    7149,
    "Comercial - Inventarios > Parametros de control > Productos por agotarse"
}, {
    8893,
    "Comercial - Inventarios > Parametros de control > Productos agotados a la fecha"
}, {
    1423,
    "Comercial - Inventarios > Parametros de control > Recalcular ABC rotación costos"
}, {
    10844,
    "Comercial - Inventarios > Parametros de control > Recalcular consumo promedio"
}, {
    1422,
    "Comercial - Inventarios > Parametros de control > Recalcular máximos, mínimos y punto de pedido"
}, {
    1421,
    "Comercial - Inventarios > Parametros de control > Recalcular tiempo de reposición y otros"
}, {
    3369,
    "Comercial - Inventarios > Parametros de control > Rotación y edad del inventario"
}, {
    10947,
    "Comercial - Inventarios > Presupuesto de obra"
}, {
    10949,
    "Comercial - Inventarios > Presupuesto de obra > Actividades"
}, {
    10951,
    "Comercial - Inventarios > Presupuesto de obra > Actividades > Adiciones y reducciones"
}, {
    10983,
    "Comercial - Inventarios > Presupuesto de obra > Actividades > Adiciones y reducciones > Adiciones - Adicionar"
}, {
    10984,
    "Comercial - Inventarios > Presupuesto de obra > Actividades > Adiciones y reducciones > Adiciones - Eliminar"
}, {
    10985,
    "Comercial - Inventarios > Presupuesto de obra > Actividades > Adiciones y reducciones > Adiciones - Modificar"
}, {
    10986,
    "Comercial - Inventarios > Presupuesto de obra > Actividades > Adiciones y reducciones > Reducciones - Adicionar"
}, {
    10987,
    "Comercial - Inventarios > Presupuesto de obra > Actividades > Adiciones y reducciones > Reducciones - Eliminar"
}, {
    10988,
    "Comercial - Inventarios > Presupuesto de obra > Actividades > Adiciones y reducciones > Reducciones -Modificar"
}, {
    11099,
    "Comercial - Inventarios > Presupuesto de obra > Actividades > Adiciones y reducciones > Cambio de fechas - Adicionar"
}, {
    11100,
    "Comercial - Inventarios > Presupuesto de obra > Actividades > Adiciones y reducciones > Cambio de fechas - Modificar"
}, {
    10953,
    "Comercial - Inventarios > Presupuesto de obra > Actividades > Aprobación"
}, {
    10950,
    "Comercial - Inventarios > Presupuesto de obra > Actividades > Apropiación"
}, {
    11029,
    "Comercial - Inventarios > Presupuesto de obra > Actividades > Apropiación > Adicionar"
}, {
    11030,
    "Comercial - Inventarios > Presupuesto de obra > Actividades > Apropiación > Eliminar"
}, {
    11031,
    "Comercial - Inventarios > Presupuesto de obra > Actividades > Apropiación > Modificar"
}, {
    10952,
    "Comercial - Inventarios > Presupuesto de obra > Actividades > Saldo inicial"
}, {
    10992,
    "Comercial - Inventarios > Presupuesto de obra > Actividades > Saldo inicial > Adicionar"
}, {
    10993,
    "Comercial - Inventarios > Presupuesto de obra > Actividades > Saldo inicial > Eliminar"
}, {
    10994,
    "Comercial - Inventarios > Presupuesto de obra > Actividades > Saldo inicial > Modificar"
}, {
    10960,
    "Comercial - Inventarios > Presupuesto de obra > Avances de actividad"
}, {
    10961,
    "Comercial - Inventarios > Presupuesto de obra > Avances de actividad > Acta de obra"
}, {
    10995,
    "Comercial - Inventarios > Presupuesto de obra > Avances de actividad > Acta de obra > Adicionar"
}, {
    10996,
    "Comercial - Inventarios > Presupuesto de obra > Avances de actividad > Acta de obra > Anular"
}, {
    10997,
    "Comercial - Inventarios > Presupuesto de obra > Avances de actividad > Acta de obra > Aprobar"
}, {
    10998,
    "Comercial - Inventarios > Presupuesto de obra > Avances de actividad > Acta de obra > Consultar"
}, {
    10999,
    "Comercial - Inventarios > Presupuesto de obra > Avances de actividad > Acta de obra > Eliminar movimiento"
}, {
    11000,
    "Comercial - Inventarios > Presupuesto de obra > Avances de actividad > Acta de obra > Modificar"
}, {
    10979,
    "Comercial - Inventarios > Presupuesto de obra > Avances de actividad > Habilitar impresión"
}, {
    10962,
    "Comercial - Inventarios > Presupuesto de obra > Avances de actividad > Impresión"
}, {
    10963,
    "Comercial - Inventarios > Presupuesto de obra > Consultas"
}, {
    10964,
    "Comercial - Inventarios > Presupuesto de obra > Consultas > Actividades"
}, {
    10966,
    "Comercial - Inventarios > Presupuesto de obra > Consultas > Actividades - avance"
}, {
    10965,
    "Comercial - Inventarios > Presupuesto de obra > Consultas > Actividades - movimiento"
}, {
    10967,
    "Comercial - Inventarios > Presupuesto de obra > Consultas > Ítems de obra"
}, {
    10969,
    "Comercial - Inventarios > Presupuesto de obra > Consultas > Ítems de obra - ejecutado"
}, {
    10968,
    "Comercial - Inventarios > Presupuesto de obra > Consultas > Ítems de obra - movimiento ppto"
}, {
    10948,
    "Comercial - Inventarios > Presupuesto de obra > Control presupuesto"
}, {
    10954,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra"
}, {
    10956,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Adiciones y reducciones"
}, {
    11001,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Adiciones y reducciones > Adiciones - Adicionar"
}, {
    11002,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Adiciones y reducciones > Adiciones - Eliminar"
}, {
    11003,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Adiciones y reducciones > Adiciones -Modificar"
}, {
    11113,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Adiciones y reducciones > Eliminar"
}, {
    11004,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Adiciones y reducciones > Reducciones - Adicionar"
}, {
    11005,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Adiciones y reducciones > Reducciones - Eliminar"
}, {
    11006,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Adiciones y reducciones > Reducciones - Modificar"
}, {
    11114,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Adiciones y reducciones > Reporte"
}, {
    10959,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Aprobación"
}, {
    10955,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Apropiación"
}, {
    11007,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Apropiación > Adicionar"
}, {
    11008,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Apropiación > Eliminar"
}, {
    11009,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Apropiación > Modificar"
}, {
    10957,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Saldo inicial ejecutado de compras"
}, {
    11010,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Saldo inicial ejecutado de compras > Adicionar"
}, {
    11011,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Saldo inicial ejecutado de compras > Eliminar"
}, {
    11012,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Saldo inicial ejecutado de compras > Modificar"
}, {
    10958,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Saldo inicial ejecutado de consumos"
}, {
    11013,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Saldo inicial ejecutado de consumos > Adicionar"
}, {
    11014,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Saldo inicial ejecutado de consumos > Eliminar"
}, {
    11015,
    "Comercial - Inventarios > Presupuesto de obra > Ítems de obra > Saldo inicial ejecutado de consumos > Modificar"
}, {
    3323,
    "Comercial - Inventarios > Requisiciones internas"
}, {
    6496,
    "Comercial - Inventarios > Requisiciones internas > Aprobar requisiciones internas"
}, {
    10982,
    "Comercial - Inventarios > Requisiciones internas > Asignar cargue"
}, {
    9608,
    "Comercial - Inventarios > Requisiciones internas > Calcular la cantidad adicional al modificar"
}, {
    9194,
    "Comercial - Inventarios > Requisiciones internas > Captura cantidad en código de barras automático"
}, {
    4800,
    "Comercial - Inventarios > Requisiciones internas > Comprometer documentos"
}, {
    6513,
    "Comercial - Inventarios > Requisiciones internas > Dar por cumplidas requisiciones internas"
}, {
    3581,
    "Comercial - Inventarios > Requisiciones internas > Generar consumos"
}, {
    3582,
    "Comercial - Inventarios > Requisiciones internas > Generar transferencias"
}, {
    4837,
    "Comercial - Inventarios > Requisiciones internas > Generar requisiciones desde OP"
}, {
    3583,
    "Comercial - Inventarios > Requisiciones internas > Generar transito salida"
}, {
    9609,
    "Comercial - Inventarios > Requisiciones internas > Grabar referencia en descripción del movto"
}, {
    3325,
    "Comercial - Inventarios > Requisiciones internas > Habilitar impresión"
}, {
    3324,
    "Comercial - Inventarios > Requisiciones internas > Imprimir"
}, {
    3709,
    "Comercial - Inventarios > Requisiciones internas > Importar EDI"
}, {
    11036,
    "Comercial - Inventarios > Requisiciones internas > Importar EDI > Consulta de movimiento"
}, {
    3711,
    "Comercial - Inventarios > Requisiciones internas > Importar EDI > Eliminar lote de importación"
}, {
    3710,
    "Comercial - Inventarios > Requisiciones internas > Importar EDI > Importar"
}, {
    3712,
    "Comercial - Inventarios > Requisiciones internas > Importar EDI > Log de importación"
}, {
    10790,
    "Comercial - Inventarios > Requisiciones internas > Validar maestros por usuario del movto al aprobar"
}, {
    3326,
    "Comercial - Inventarios > Requisiciones internas > Por consumir"
}, {
    3327,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Adicionar"
}, {
    3328,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Anular"
}, {
    3329,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Aprobar"
}, {
    10765,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Calcular la unidad adicional automáticamente"
}, {
    6755,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Permitir modificar cantidades en doctos. aprobados"
}, {
    8725,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > No almacenar cantidades parciales al aprob y comp"
}, {
    3331,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Comprometer"
}, {
    4733,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Comprometer parciales"
}, {
    12148,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Comprometer automáticamente adic al aprobar"
}, {
    3332,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Comprometer automáticamente después de aprobar"
}, {
    11330,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Comprometer - bloquear manuales"
}, {
    11329,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Comprometer - bloquear parciales"
}, {
    3330,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Consultar"
}, {
    3333,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Dar por cumplido"
}, {
    3363,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Desaprobar"
}, {
    8554,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Descomprometer"
}, {
    3336,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Eliminar movimiento"
}, {
    4390,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Permitir equivalentes en compromisos"
}, {
    3337,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Generar consumo"
}, {
    6766,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Permitir adicionar ítems en doctos aprobados"
}, {
    3335,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Modificar"
}, {
    4792,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Modificar entidades dinámicas en doctos aprobados"
}, {
    4793,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Modificar entidades dinámicas docto en elaboración"
}, {
    7748,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Presentar cantidad disponible"
}, {
    3488,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Restringir captura al comprometer ítem con lotes"
}, {
    12382,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Restringir captura UM adicional"
}, {
    3334,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Reversar cumplido"
}, {
    10023,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Sugerir el último centro de costos capturado"
}, {
    11341,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Sugerir el último centro de operación capturado"
}, {
    11342,
    "Comercial - Inventarios > Requisiciones internas > Por consumir > Sugerir el último proyecto capturado"
}, {
    3338,
    "Comercial - Inventarios > Requisiciones internas > Por transferir"
}, {
    3339,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Adicionar"
}, {
    3340,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Anular"
}, {
    3341,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Aprobar"
}, {
    10766,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Calcular la unidad adicional automáticamente"
}, {
    6756,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Permitir modificar cantidades en doctos. aprobados"
}, {
    8726,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > No almacenar cantidades parciales al aprob y comp"
}, {
    3343,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Comprometer"
}, {
    4734,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Comprometer parciales"
}, {
    3344,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Comprometer automáticamente después de aprobar"
}, {
    11332,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Comprometer - bloquear manuales"
}, {
    11331,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Comprometer - bloquear parciales"
}, {
    3342,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Consultar"
}, {
    3345,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Dar por cumplido"
}, {
    3364,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Desaprobar"
}, {
    8555,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Descomprometer"
}, {
    3348,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Eliminar movimiento"
}, {
    4391,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Permitir equivalentes en compromisos"
}, {
    6543,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Generar desde ordenes planeadas"
}, {
    3349,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Generar transferencia"
}, {
    11028,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Generar transferencia > Presentar resumen por ítem al generar transf"
}, {
    6767,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Permitir adicionar ítems en doctos aprobados"
}, {
    3347,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Modificar"
}, {
    4795,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Modificar entidades dinámicas en doctos aprobados"
}, {
    4794,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Modificar entidades dinámicas docto en elaboración"
}, {
    7749,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Presentar cantidad disponible"
}, {
    12383,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Restringir captura UM adicional"
}, {
    3346,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Reversar cumplido"
}, {
    10024,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Sugerir el último centro de costos capturado"
}, {
    11343,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Sugerir el último centro de operación capturado"
}, {
    11344,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Sugerir el último proyecto capturado"
}, {
    3990,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Validar maestros por usuario - bodega entrada"
}, {
    3991,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Validar maestros por usuario - bodega salida"
}, {
    12149,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Comprometer automáticamente adic al aprobar"
}, {
    3489,
    "Comercial - Inventarios > Requisiciones internas > Por transferir > Restringir captura al comprometer ítem con lotes"
}, {
    3350,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito"
}, {
    3351,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Adicionar"
}, {
    3352,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Anular"
}, {
    3353,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Aprobar"
}, {
    10767,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Calcular la unidad adicional automáticamente"
}, {
    6757,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Permitir modificar cantidades en doctos. aprobados"
}, {
    8727,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > No almacenar cantidades parciales al aprob y comp"
}, {
    3354,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Comprometer"
}, {
    4735,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Comprometer parciales"
}, {
    3355,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Comprometer automáticamente después de aprobar"
}, {
    11334,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Comprometer - bloquear manuales"
}, {
    11333,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Comprometer - bloquear parciales"
}, {
    3356,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Consultar"
}, {
    3357,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Dar por cumplido"
}, {
    3365,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Desaprobar"
}, {
    8556,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Descomprometer"
}, {
    3358,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Eliminar movimiento"
}, {
    4392,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Permitir equivalentes en compromisos"
}, {
    3359,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Generar transferencia transito"
}, {
    6768,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Permitir adicionar ítems en doctos aprobados"
}, {
    3360,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Modificar"
}, {
    4797,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Modificar entidades dinámicas en doctos aprobados"
}, {
    4796,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Modificar entidades dinámicas docto en elaboración"
}, {
    7750,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Presentar cantidad disponible"
}, {
    12384,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Restringir captura UM adicional"
}, {
    3361,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Reversar cumplido"
}, {
    11345,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Sugerir el último centro de operación capturado"
}, {
    11346,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Sugerir el último proyecto capturado"
}, {
    10025,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Sugerir el último centro de costos capturado"
}, {
    3987,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Validar C.O. de la bodega de entrada"
}, {
    3988,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Validar maestros por usuario - bodega entrada"
}, {
    3989,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Validar maestros por usuario - bodega salida"
}, {
    12150,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Comprometer automáticamente adic al aprobar"
}, {
    3490,
    "Comercial - Inventarios > Requisiciones internas > Por transferir transito > Restringir captura al comprometer ítem por lotes"
}, {
    10903,
    "Comercial - Inventarios > Requisiciones internas > Validar número de orden de compra para consig dada"
}, {
    3667,
    "Comercial - Inventarios > Verificación de despachos"
}, {
    3675,
    "Comercial - Inventarios > Verificación de despachos > Análisis de auditoria"
}, {
    9130,
    "Comercial - Inventarios > Verificación de despachos > Capturar cantidad en código de barras"
}, {
    3674,
    "Comercial - Inventarios > Verificación de despachos > Consulta"
}, {
    3668,
    "Comercial - Inventarios > Verificación de despachos > Documentos"
}, {
    3669,
    "Comercial - Inventarios > Verificación de despachos > Documentos > Aprobar descuadres"
}, {
    3672,
    "Comercial - Inventarios > Verificación de despachos > Documentos > Permitir captura manual"
}, {
    3673,
    "Comercial - Inventarios > Verificación de despachos > Documentos > Permitir códigos de barras manuales"
}, {
    3670,
    "Comercial - Inventarios > Verificación de despachos > Documentos > Eliminar verificación"
}, {
    3671,
    "Comercial - Inventarios > Verificación de despachos > Documentos > Limpiar verificación"
}, {
    3677,
    "Comercial - Inventarios > Verificación de despachos > Resumen de movimiento y novedades"
}, {
    4941,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Anticipos de Cesantias"
}, {
    5225,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Anticipos de Cesantias > Adicionar"
}, {
    5226,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Anticipos de Cesantias > Filtro"
}, {
    5227,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Anticipos de Cesantias > Generar"
}, {
    4950,
    "Nomina > Liquidacion de Nomina > Liquidacion General - Parametros"
}, {
    5272,
    "Nomina > Liquidacion de Nomina > Liquidacion General - Parametros > Adicionar"
}, {
    5273,
    "Nomina > Liquidacion de Nomina > Liquidacion General - Parametros > Consultar"
}, {
    5274,
    "Nomina > Liquidacion de Nomina > Liquidacion General - Parametros > Duplicar"
}, {
    5275,
    "Nomina > Liquidacion de Nomina > Liquidacion General - Parametros > Eliminar"
}, {
    5276,
    "Nomina > Liquidacion de Nomina > Liquidacion General - Parametros > Modificar"
}, {
    4951,
    "Nomina > Liquidacion de Nomina > Liquidacion General - Proceso"
}, {
    5278,
    "Nomina > Liquidacion de Nomina > Liquidacion General - Proceso > Adicionar"
}, {
    5279,
    "Nomina > Liquidacion de Nomina > Liquidacion General - Proceso > Filtro"
}, {
    5280,
    "Nomina > Liquidacion de Nomina > Liquidacion General - Proceso > Generar"
}, {
    5277,
    "Nomina > Liquidacion de Nomina > Liquidacion General - Parametros > Reporte"
}, {
    8247,
    "Nomina > Liquidacion de Nomina > Liquidacion General - Proceso Selectivo"
}, {
    8248,
    "Nomina > Liquidacion de Nomina > Liquidacion General - Proceso Selectivo > Adicionar"
}, {
    8249,
    "Nomina > Liquidacion de Nomina > Liquidacion General - Proceso Selectivo > Filtro"
}, {
    8250,
    "Nomina > Liquidacion de Nomina > Liquidacion General - Proceso Selectivo > Generar"
}, {
    5218,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Preliquidacion > Adicionar"
}, {
    5221,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Preliquidacion > Consultar"
}, {
    5222,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Preliquidacion > Duplicar"
}, {
    5223,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Preliquidacion > Eliminar"
}, {
    5219,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Preliquidacion > Filtro"
}, {
    5220,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Preliquidacion > Generar"
}, {
    5224,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Preliquidacion > Modificar"
}, {
    4940,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Preliquidacion"
}, {
    4952,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Liquidacion"
}, {
    5281,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Liquidacion > Adicionar"
}, {
    5284,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Liquidacion > Consultar"
}, {
    5285,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Liquidacion > Duplicar"
}, {
    5286,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Liquidacion > Eliminar"
}, {
    5282,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Liquidacion > Filtro"
}, {
    5283,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Liquidacion > Generar"
}, {
    5287,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Liquidacion > Modificar"
}, {
    4953,
    "Nomina > Liquidacion de Nomina > Procesos Adicionales"
}, {
    5288,
    "Nomina > Liquidacion de Nomina > Procesos Adicionales > Adicionar"
}, {
    5291,
    "Nomina > Liquidacion de Nomina > Procesos Adicionales > Anticipo de Nomima - Estandar"
}, {
    5782,
    "Nomina > Liquidacion de Nomina > Procesos Adicionales > Anticipo de Nomima - Estandar > Procesar"
}, {
    5783,
    "Nomina > Liquidacion de Nomina > Procesos Adicionales > Anticipo de Nomima - Estandar > Adicionar"
}, {
    5784,
    "Nomina > Liquidacion de Nomina > Procesos Adicionales > Anticipo de Nomima - Estandar > Filtro"
}, {
    5289,
    "Nomina > Liquidacion de Nomina > Procesos Adicionales > Filtro"
}, {
    5290,
    "Nomina > Liquidacion de Nomina > Procesos Adicionales > Generar"
}, {
    5265,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Ajuste al Basico y Ajuste al Minimo"
}, {
    5346,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Ajuste al Basico y Ajuste al Minimo > Adicionar"
}, {
    5347,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Ajuste al Basico y Ajuste al Minimo > Filtro"
}, {
    5348,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Ajuste al Basico y Ajuste al Minimo > Generar"
}, {
    4949,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas"
}, {
    5264,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Auxilio de Transporte"
}, {
    5343,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Auxilio de Transporte > Adcionar"
}, {
    5344,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Auxilio de Transporte > Filtro"
}, {
    5345,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Auxilio de Transporte > Generar"
}, {
    5270,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Copia Transacciones entre Documentos"
}, {
    5361,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Copia Transacciones entre Documentos > Adicionar"
}, {
    5362,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Copia Transacciones entre Documentos > Generar"
}, {
    5266,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Cuotas y Prestamos"
}, {
    5349,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Cuotas y Prestamos > Adicionar"
}, {
    5350,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Cuotas y Prestamos > Filtro"
}, {
    5351,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Cuotas y Prestamos > Generar"
}, {
    5263,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Dominicales"
}, {
    5340,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Dominicales > Adicionar"
}, {
    5341,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Dominicales > Filtro"
}, {
    5342,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Dominicales > Generar"
}, {
    5252,
    "Nomina > Liquidacion de Nomina > Transacciones Via Interfase > Generacion Interfase"
}, {
    4948,
    "Nomina > Liquidacion de Nomina > Transacciones Manuales"
}, {
    5256,
    "Nomina > Liquidacion de Nomina > Transacciones Manuales > Adicionar"
}, {
    5255,
    "Nomina > Liquidacion de Nomina > Transacciones Manuales > Aprobar"
}, {
    5257,
    "Nomina > Liquidacion de Nomina > Transacciones Manuales > Consultar"
}, {
    5258,
    "Nomina > Liquidacion de Nomina > Transacciones Manuales > Duplicar"
}, {
    5259,
    "Nomina > Liquidacion de Nomina > Transacciones Manuales > Eliminar"
}, {
    8196,
    "Nomina > Liquidacion de Nomina > Transacciones Manuales > Modificar transacciones via interfase"
}, {
    5260,
    "Nomina > Liquidacion de Nomina > Transacciones Manuales > Modificar"
}, {
    5261,
    "Nomina > Liquidacion de Nomina > Transacciones Manuales > Reporte"
}, {
    5253,
    "Nomina > Liquidacion de Nomina > Transacciones Via Interfase > Recepcion via archivo"
}, {
    7436,
    "Nomina > Liquidacion de Nomina > Transacciones Via Interfase > Recepcion via archivo > Adicionar"
}, {
    7437,
    "Nomina > Liquidacion de Nomina > Transacciones Via Interfase > Recepcion via archivo > Filtro"
}, {
    7438,
    "Nomina > Liquidacion de Nomina > Transacciones Via Interfase > Recepcion via archivo > Importar"
}, {
    5267,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Retefuente y Seguridad Social"
}, {
    5352,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Retefuente y Seguridad Social > Adicionar"
}, {
    5353,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Retefuente y Seguridad Social > Filtro"
}, {
    5354,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Retefuente y Seguridad Social > Generar"
}, {
    5271,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Retiro de Transacciones"
}, {
    5363,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Retiro de Transacciones > Adicionar"
}, {
    5364,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Retiro de Transacciones > Generar"
}, {
    5269,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Retroactividad"
}, {
    5358,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Retroactividad > Adicionar"
}, {
    5359,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Retroactividad > Filtro"
}, {
    5360,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Retroactividad > Generar"
}, {
    5268,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Saldo en Rojo y Ajuste a Pesos"
}, {
    5355,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Saldo en Rojo y Ajuste a Pesos > Adicionar"
}, {
    5356,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Saldo en Rojo y Ajuste a Pesos > Filtro"
}, {
    5357,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Saldo en Rojo y Ajuste a Pesos > Generar"
}, {
    5254,
    "Nomina > Liquidacion de Nomina > Transacciones Via Interfase > Novedades de Subsidio Monetario"
}, {
    5336,
    "Nomina > Liquidacion de Nomina > Transacciones Via Interfase > Novedades de Subsidio Monetario > Adicionar"
}, {
    5335,
    "Nomina > Liquidacion de Nomina > Transacciones Via Interfase > Novedades de Subsidio Monetario > Filtro"
}, {
    5334,
    "Nomina > Liquidacion de Nomina > Transacciones Via Interfase > Novedades de Subsidio Monetario > Importar"
}, {
    5262,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Tiempos Basicos"
}, {
    1,
    "Maestros"
}, {
    1028,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Actividades"
}, {
    2832,
    "Maestros > Terceros > Actividades economicas"
}, {
    2833,
    "Maestros > Terceros > Actividades economicas > Adicionar"
}, {
    2834,
    "Maestros > Terceros > Actividades economicas > Consultar"
}, {
    2835,
    "Maestros > Terceros > Actividades economicas > Duplicar"
}, {
    2836,
    "Maestros > Terceros > Actividades economicas > Eliminar"
}, {
    2837,
    "Maestros > Terceros > Actividades economicas > Modificar"
}, {
    2838,
    "Maestros > Terceros > Actividades economicas > Reporte"
}, {
    1029,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Actividades > Adicionar"
}, {
    1030,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Actividades > Cambiar código"
}, {
    1031,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Actividades > Consultar"
}, {
    1032,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Actividades > Duplicar"
}, {
    1033,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Actividades > Eliminar"
}, {
    1034,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Actividades > Modificar"
}, {
    1035,
    "Financiero - Contabilidad > Procesos periódicos > Distribución de costos > Actividades > Reporte"
}, {
    1060,
    "Financiero - Activos fijos > Maestros"
}, {
    1061,
    "Financiero - Activos fijos > Maestros > Activos fijos > Adicionar"
}, {
    1434,
    "Financiero - Activos fijos > Maestros > Activos fijos"
}, {
    7847,
    "Financiero - Activos fijos > Maestros > Activos fijos > Capturar costo adq libro2"
}, {
    7949,
    "Financiero - Activos fijos > Maestros > Activos fijos > Capturar tasa de reexpresión libro2"
}, {
    10769,
    "Financiero - Activos fijos > Maestros > Activos fijos > No obligar información adq y depreciación Libro 1"
}, {
    10770,
    "Financiero - Activos fijos > Maestros > Activos fijos > No obligar información adq y depreciación Libro 2"
}, {
    10772,
    "Financiero - Activos fijos > Maestros > Activos fijos > No obligar información de criterios"
}, {
    10775,
    "Financiero - Activos fijos > Maestros > Activos fijos > No obligar información de entidades"
}, {
    10773,
    "Financiero - Activos fijos > Maestros > Activos fijos > No obligar información de foto"
}, {
    10768,
    "Financiero - Activos fijos > Maestros > Activos fijos > No obligar información de generales"
}, {
    10774,
    "Financiero - Activos fijos > Maestros > Activos fijos > No obligar información de notas"
}, {
    10771,
    "Financiero - Activos fijos > Maestros > Activos fijos > No obligar información otros datos"
}, {
    10899,
    "Financiero - Activos fijos > Maestros > Automatización de documentos"
}, {
    1062,
    "Financiero - Activos fijos > Maestros > Activos fijos > Cambiar codigo"
}, {
    1063,
    "Financiero - Activos fijos > Maestros > Activos fijos > Consultar"
}, {
    1064,
    "Financiero - Activos fijos > Maestros > Activos fijos > Duplicar"
}, {
    1065,
    "Financiero - Activos fijos > Maestros > Activos fijos > Eliminar"
}, {
    1560,
    "Financiero - Activos fijos > Maestros > Activos fijos > Importar"
}, {
    1066,
    "Financiero - Activos fijos > Maestros > Activos fijos > Modificar"
}, {
    4404,
    "Financiero - Activos fijos > Maestros > Activos fijos > Modificar unidades de producción"
}, {
    1067,
    "Financiero - Activos fijos > Maestros > Activos fijos > Reporte"
}, {
    1132,
    "Financiero - Activos fijos > Documentos > Unidades"
}, {
    1133,
    "Financiero - Activos fijos > Documentos > Unidades > Editar"
}, {
    4403,
    "Financiero - Activos fijos > Documentos > Unidades > Importar"
}, {
    1134,
    "Financiero - Activos fijos > Documentos > Unidades > Reporte"
}, {
    7942,
    "Financiero - Cuentas por pagar > Automatización de documentos"
}, {
    11561,
    "Maestros > Automatización de recalculo de impuestos"
}, {
    4744,
    "Maestros de comercial > Automatizacion de apropiación"
}, {
    4745,
    "Maestros de comercial > Automatizacion de apropiación > Adicionar"
}, {
    4746,
    "Maestros de comercial > Automatizacion de apropiación > Consultar"
}, {
    4747,
    "Maestros de comercial > Automatizacion de apropiación > Duplicar"
}, {
    4748,
    "Maestros de comercial > Automatizacion de apropiación > Eliminar"
}, {
    4749,
    "Maestros de comercial > Automatizacion de apropiación > Modificar"
}, {
    4750,
    "Maestros de comercial > Automatizacion de apropiación > Reporte"
}, {
    37,
    "Maestros > Bancos > Bancos"
}, {
    241,
    "Maestros > Bancos > Bancos > Adicionar"
}, {
    240,
    "Maestros > Bancos > Bancos > Consultar"
}, {
    242,
    "Maestros > Bancos > Bancos > Duplicar"
}, {
    244,
    "Maestros > Bancos > Bancos > Eliminar"
}, {
    9139,
    "Maestros > Bancos > Extractos equivalentes C.O."
}, {
    9140,
    "Maestros > Bancos > Extractos equivalentes C.O. > Adicionar"
}, {
    9142,
    "Maestros > Bancos > Extractos equivalentes C.O. > Eliminar"
}, {
    9141,
    "Maestros > Bancos > Extractos equivalentes C.O. > Modificar"
}, {
    243,
    "Maestros > Bancos > Bancos > Modificar"
}, {
    245,
    "Maestros > Bancos > Bancos > Reporte"
}, {
    34,
    "Maestros > Bancos"
}, {
    46,
    "Maestros > Países, deptos, ciudades y barrios > Barrios"
}, {
    289,
    "Maestros > Países, deptos, ciudades y barrios > Barrios > Adicionar"
}, {
    288,
    "Maestros > Países, deptos, ciudades y barrios > Barrios > Consultar"
}, {
    290,
    "Maestros > Países, deptos, ciudades y barrios > Barrios > Duplicar"
}, {
    292,
    "Maestros > Países, deptos, ciudades y barrios > Barrios > Eliminar"
}, {
    291,
    "Maestros > Países, deptos, ciudades y barrios > Barrios > Modificar"
}, {
    293,
    "Maestros > Países, deptos, ciudades y barrios > Barrios > Reporte"
}, {
    4214,
    "Maestros > Países, deptos, ciudades y barrios > Barrios > Unificar barrios"
}, {
    876,
    "Maestros de comercial > Bodegas"
}, {
    877,
    "Maestros de comercial > Bodegas > Adicionar"
}, {
    1044,
    "Maestros de comercial > Bodegas > Cambiar código"
}, {
    878,
    "Maestros de comercial > Bodegas > Consultar"
}, {
    879,
    "Maestros de comercial > Bodegas > Duplicar"
}, {
    880,
    "Maestros de comercial > Bodegas > Eliminar"
}, {
    881,
    "Maestros de comercial > Bodegas > Modificar"
}, {
    882,
    "Maestros de comercial > Bodegas > Reporte"
}, {
    32,
    "Maestros > Cajas"
}, {
    213,
    "Maestros > Cajas > Adicionar"
}, {
    212,
    "Maestros > Cajas > Consultar"
}, {
    214,
    "Maestros > Cajas > Duplicar"
}, {
    216,
    "Maestros > Cajas > Eliminar"
}, {
    215,
    "Maestros > Cajas > Modificar"
}, {
    217,
    "Maestros > Cajas > Reporte"
}, {
    4549,
    "Maestros de comercial > Calendario compras"
}, {
    4550,
    "Maestros de comercial > Calendario compras > Adicionar"
}, {
    4551,
    "Maestros de comercial > Calendario compras > Consultar"
}, {
    4552,
    "Maestros de comercial > Calendario compras > Eliminar"
}, {
    4553,
    "Maestros de comercial > Calendario compras > Modificar"
}, {
    4554,
    "Maestros de comercial > Calendario compras > Reporte"
}, {
    1779,
    "Maestros de comercial > Cargue"
}, {
    1780,
    "Maestros de comercial > Cargue > Adicionar"
}, {
    1781,
    "Maestros de comercial > Cargue > Consultar"
}, {
    1782,
    "Maestros de comercial > Cargue > Duplicar"
}, {
    1783,
    "Maestros de comercial > Cargue > Eliminar"
}, {
    1784,
    "Maestros de comercial > Cargue > Modificar"
}, {
    1785,
    "Maestros de comercial > Cargue > Reporte"
}, {
    17,
    "Maestros > Centros de costos > Centros de costos > Centros de Costos"
}, {
    122,
    "Maestros > Centros de costos > Centros de costos > Centros de Costos > Adicionar"
}, {
    127,
    "Maestros > Centros de costos > Centros de costos > Centros de Costos > Cambiar código"
}, {
    9995,
    "Maestros > Centros de costos > Centros de costos > Centros de Costos > Permitir cambiar Grupo C.Costo"
}, {
    2382,
    "Maestros > Centros de costos > Centros de costos > Cierre"
}, {
    121,
    "Maestros > Centros de costos > Centros de costos > Centros de Costos > Consultar"
}, {
    123,
    "Maestros > Centros de costos > Centros de costos > Centros de Costos > Duplicar"
}, {
    125,
    "Maestros > Centros de costos > Centros de costos > Centros de Costos > Eliminar"
}, {
    19,
    "Maestros > Centros de costos > Centros de costos > Estructura"
}, {
    302,
    "Maestros > Centros de costos > Centros de costos > Estructura > Modificar"
}, {
    303,
    "Maestros > Centros de costos > Centros de costos > Estructura > Reporte"
}, {
    18,
    "Maestros > Centros de costos > Centros de costos > Mayores"
}, {
    130,
    "Maestros > Centros de costos > Centros de costos > Mayores > Adicionar"
}, {
    129,
    "Maestros > Centros de costos > Centros de costos > Mayores > Consultar"
}, {
    131,
    "Maestros > Centros de costos > Centros de costos > Mayores > Duplicar"
}, {
    133,
    "Maestros > Centros de costos > Centros de costos > Mayores > Eliminar"
}, {
    132,
    "Maestros > Centros de costos > Centros de costos > Mayores > Modificar"
}, {
    134,
    "Maestros > Centros de costos > Centros de costos > Mayores > Reporte"
}, {
    124,
    "Maestros > Centros de costos > Centros de costos > Centros de Costos > Modificar"
}, {
    126,
    "Maestros > Centros de costos > Centros de costos > Centros de Costos > Reporte"
}, {
    16,
    "Maestros > Centros de costos > Centros de costos"
}, {
    26,
    "Maestros > Centros de operación"
}, {
    172,
    "Maestros > Centros de operación > Adicionar"
}, {
    171,
    "Maestros > Centros de operación > Consultar"
}, {
    173,
    "Maestros > Centros de operación > Duplicar"
}, {
    175,
    "Maestros > Centros de operación > Eliminar"
}, {
    174,
    "Maestros > Centros de operación > Modificar"
}, {
    176,
    "Maestros > Centros de operación > Reporte"
}, {
    1436,
    "Maestros > Compañias"
}, {
    4414,
    "Maestros > Compañias > Configuracón de registros adicionales"
}, {
    4415,
    "Maestros > Compañias > Configuracón de registros adicionales > Adicionar"
}, {
    4416,
    "Maestros > Compañias > Configuracón de registros adicionales > Consultar"
}, {
    4417,
    "Maestros > Compañias > Configuracón de registros adicionales > Eliminar"
}, {
    4418,
    "Maestros > Compañias > Configuracón de registros adicionales > Modificar"
}, {
    4419,
    "Maestros > Compañias > Configuracón de registros adicionales > Reporte"
}, {
    2728,
    "Maestros > Compañias > Configuración movimientos entre compañias"
}, {
    2729,
    "Maestros > Compañias > Configuración movimientos entre compañias > Adicionar"
}, {
    2730,
    "Maestros > Compañias > Configuración movimientos entre compañias > Consultar"
}, {
    2731,
    "Maestros > Compañias > Configuración movimientos entre compañias > Eliminar"
}, {
    2732,
    "Maestros > Compañias > Configuración movimientos entre compañias > Modificar"
}, {
    2733,
    "Maestros > Compañias > Configuración movimientos entre compañias > Reporte"
}, {
    45,
    "Maestros > Países, deptos, ciudades y barrios > Ciudades"
}, {
    282,
    "Maestros > Países, deptos, ciudades y barrios > Ciudades > Adicionar"
}, {
    281,
    "Maestros > Países, deptos, ciudades y barrios > Ciudades > Consultar"
}, {
    283,
    "Maestros > Países, deptos, ciudades y barrios > Ciudades > Duplicar"
}, {
    285,
    "Maestros > Países, deptos, ciudades y barrios > Ciudades > Eliminar"
}, {
    284,
    "Maestros > Países, deptos, ciudades y barrios > Ciudades > Modificar"
}, {
    286,
    "Maestros > Países, deptos, ciudades y barrios > Ciudades > Reporte"
}, {
    711,
    "Maestros > Impuestos y retenciones > Clases de impuestos"
}, {
    716,
    "Maestros > Impuestos y retenciones > Clases de impuestos > Adicionar"
}, {
    719,
    "Maestros > Impuestos y retenciones > Clases de impuestos > Consultar"
}, {
    718,
    "Maestros > Impuestos y retenciones > Clases de impuestos > Duplicar"
}, {
    720,
    "Maestros > Impuestos y retenciones > Clases de impuestos > Eliminar"
}, {
    717,
    "Maestros > Impuestos y retenciones > Clases de impuestos > Modificar"
}, {
    721,
    "Maestros > Impuestos y retenciones > Clases de impuestos > Reporte"
}, {
    7,
    "Maestros > Terceros > Clases Proveedores"
}, {
    79,
    "Maestros > Terceros > Clases Proveedores > Adicionar"
}, {
    78,
    "Maestros > Terceros > Clases Proveedores > Consultar"
}, {
    80,
    "Maestros > Terceros > Clases Proveedores > Duplicar"
}, {
    82,
    "Maestros > Terceros > Clases Proveedores > Eliminar"
}, {
    81,
    "Maestros > Terceros > Clases Proveedores > Modificar"
}, {
    83,
    "Maestros > Terceros > Clases Proveedores > Reporte"
}, {
    713,
    "Maestros > Impuestos y retenciones > Clases de retención"
}, {
    728,
    "Maestros > Impuestos y retenciones > Clases de retención > Adicionar"
}, {
    733,
    "Maestros > Impuestos y retenciones > Clases de retención > Consultar"
}, {
    731,
    "Maestros > Impuestos y retenciones > Clases de retención > Duplicar"
}, {
    730,
    "Maestros > Impuestos y retenciones > Clases de retención > Eliminar"
}, {
    729,
    "Maestros > Impuestos y retenciones > Clases de retención > Modificar"
}, {
    732,
    "Maestros > Impuestos y retenciones > Clases de retención > Reporte"
}, {
    1621,
    "Maestros de comercial > Clientes ocasionales"
}, {
    1622,
    "Maestros de comercial > Clientes ocasionales > Adicionar"
}, {
    1623,
    "Maestros de comercial > Clientes ocasionales > Consultar"
}, {
    1624,
    "Maestros de comercial > Clientes ocasionales > Duplicar"
}, {
    1625,
    "Maestros de comercial > Clientes ocasionales > Eliminar"
}, {
    1626,
    "Maestros de comercial > Clientes ocasionales > Modificar"
}, {
    10868,
    "Maestros de comercial > Clientes ocasionales > Modificar > Modificar identificación"
}, {
    1627,
    "Maestros de comercial > Clientes ocasionales > Reporte"
}, {
    8199,
    "Maestros de comercial > Clientes ocasionales > Unificar"
}, {
    1433,
    "Maestros de comercial"
}, {
    10921,
    "Maestros de comercial > Áreas de trabajo"
}, {
    10922,
    "Maestros de comercial > Áreas de trabajo > Adicionar"
}, {
    10923,
    "Maestros de comercial > Áreas de trabajo > Consultar"
}, {
    10924,
    "Maestros de comercial > Áreas de trabajo > Duplicar"
}, {
    10925,
    "Maestros de comercial > Áreas de trabajo > Eliminar"
}, {
    10926,
    "Maestros de comercial > Áreas de trabajo > Modificar"
}, {
    10927,
    "Maestros de comercial > Áreas de trabajo > Reporte"
}, {
    7353,
    "Maestros de comercial > Asignación ruta de calidad"
}, {
    8148,
    "Maestros de comercial > Automatización de anticipos"
}, {
    8149,
    "Maestros de comercial > Automatización de anticipos > Adicionar"
}, {
    8150,
    "Maestros de comercial > Automatización de anticipos > Consultar"
}, {
    8151,
    "Maestros de comercial > Automatización de anticipos > Duplicar"
}, {
    8152,
    "Maestros de comercial > Automatización de anticipos > Eliminar"
}, {
    8153,
    "Maestros de comercial > Automatización de anticipos > Modificar"
}, {
    8154,
    "Maestros de comercial > Automatización de anticipos > Reporte"
}, {
    8402,
    "Maestros de comercial > Automatización de aprobación entradas"
}, {
    10693,
    "Maestros de comercial > Automatización de mensajes de documentos"
}, {
    10694,
    "Maestros de comercial > Automatización de mensajes de documentos > Adicionar"
}, {
    10695,
    "Maestros de comercial > Automatización de mensajes de documentos > Consultar"
}, {
    10696,
    "Maestros de comercial > Automatización de mensajes de documentos > Duplicar"
}, {
    10697,
    "Maestros de comercial > Automatización de mensajes de documentos > Eliminar"
}, {
    10698,
    "Maestros de comercial > Automatización de mensajes de documentos > Modificar"
}, {
    10699,
    "Maestros de comercial > Automatización de mensajes de documentos > Reportes"
}, {
    7628,
    "Maestros de comercial > Cambio de precios"
}, {
    8334,
    "Maestros de comercial > Captura VNR"
}, {
    8335,
    "Maestros de comercial > Captura VNR > Adicionar"
}, {
    8336,
    "Maestros de comercial > Captura VNR > Consultar"
}, {
    8337,
    "Maestros de comercial > Captura VNR > Duplicar"
}, {
    8338,
    "Maestros de comercial > Captura VNR > Eliminar"
}, {
    8339,
    "Maestros de comercial > Captura VNR > Modificar"
}, {
    8340,
    "Maestros de comercial > Captura VNR > Reporte"
}, {
    12445,
    "Maestros de comercial > Causales de control de proyectos"
}, {
    12446,
    "Maestros de comercial > Causales de control de proyectos > Adicionar"
}, {
    12447,
    "Maestros de comercial > Causales de control de proyectos > Consultar"
}, {
    12448,
    "Maestros de comercial > Causales de control de proyectos > Eliminar"
}, {
    12449,
    "Maestros de comercial > Causales de control de proyectos > Modificar"
}, {
    12450,
    "Maestros de comercial > Causales de control de proyectos > Reporte"
}, {
    3992,
    "Maestros de comercial > Causales de devolución"
}, {
    3993,
    "Maestros de comercial > Causales de devolución > Adicionar"
}, {
    3994,
    "Maestros de comercial > Causales de devolución > Consultar"
}, {
    3995,
    "Maestros de comercial > Causales de devolución > Duplicar"
}, {
    3996,
    "Maestros de comercial > Causales de devolución > Eliminar"
}, {
    3997,
    "Maestros de comercial > Causales de devolución > Modificar"
}, {
    3998,
    "Maestros de comercial > Causales de devolución > Reporte"
}, {
    7354,
    "Maestros de comercial > Clases de solicitud"
}, {
    7367,
    "Maestros de comercial > Clases de solicitud > Adicionar"
}, {
    7368,
    "Maestros de comercial > Clases de solicitud > Consultar"
}, {
    7369,
    "Maestros de comercial > Clases de solicitud > Duplicar"
}, {
    7370,
    "Maestros de comercial > Clases de solicitud > Eliminar"
}, {
    7371,
    "Maestros de comercial > Clases de solicitud > Modificar"
}, {
    7372,
    "Maestros de comercial > Clases de solicitud > Reporte"
}, {
    7355,
    "Maestros de comercial > Clasificaciones de calidad"
}, {
    7361,
    "Maestros de comercial > Clasificaciones de calidad > Adicionar"
}, {
    7362,
    "Maestros de comercial > Clasificaciones de calidad > Consultar"
}, {
    7363,
    "Maestros de comercial > Clasificaciones de calidad > Duplicar"
}, {
    7364,
    "Maestros de comercial > Clasificaciones de calidad > Eliminar"
}, {
    7365,
    "Maestros de comercial > Clasificaciones de calidad > Modificar"
}, {
    7366,
    "Maestros de comercial > Clasificaciones de calidad > Reporte"
}, {
    7760,
    "Maestros de comercial > Clasificación de items"
}, {
    9773,
    "Maestros de comercial > Clasificación proveedor ítem"
}, {
    9774,
    "Maestros de comercial > Clasificación proveedor ítem > Adicionar"
}, {
    9775,
    "Maestros de comercial > Clasificación proveedor ítem > Consultar"
}, {
    9776,
    "Maestros de comercial > Clasificación proveedor ítem > Duplicar"
}, {
    9777,
    "Maestros de comercial > Clasificación proveedor ítem > Eliminar"
}, {
    9778,
    "Maestros de comercial > Clasificación proveedor ítem > Modificar"
}, {
    9779,
    "Maestros de comercial > Clasificación proveedor ítem > Reporte"
}, {
    11049,
    "Maestros de comercial > Clientes por unidad de negocio"
}, {
    11086,
    "Maestros de comercial > Clientes por unidad de negocio > Adicionar"
}, {
    11087,
    "Maestros de comercial > Clientes por unidad de negocio > Consultar"
}, {
    11088,
    "Maestros de comercial > Clientes por unidad de negocio > Duplicar"
}, {
    11089,
    "Maestros de comercial > Clientes por unidad de negocio > Eliminar"
}, {
    11090,
    "Maestros de comercial > Clientes por unidad de negocio > Modificar"
}, {
    11091,
    "Maestros de comercial > Clientes por unidad de negocio > Reporte"
}, {
    9738,
    "Maestros de comercial > Código de muestra"
}, {
    9739,
    "Maestros de comercial > Código de muestra > Adicionar"
}, {
    9740,
    "Maestros de comercial > Código de muestra > Consultar"
}, {
    9741,
    "Maestros de comercial > Código de muestra > Duplicar"
}, {
    9742,
    "Maestros de comercial > Código de muestra > Eliminar"
}, {
    9743,
    "Maestros de comercial > Código de muestra > Modificar"
}, {
    9744,
    "Maestros de comercial > Código de muestra > Reporte"
}, {
    7288,
    "Maestros de comercial > Competencias"
}, {
    7289,
    "Maestros de comercial > Competencias > Adicionar"
}, {
    7290,
    "Maestros de comercial > Competencias > Consultar"
}, {
    7291,
    "Maestros de comercial > Competencias > Duplicar"
}, {
    7292,
    "Maestros de comercial > Competencias > Eliminar"
}, {
    7293,
    "Maestros de comercial > Competencias > Modificar"
}, {
    7294,
    "Maestros de comercial > Competencias > Reporte"
}, {
    10796,
    "Maestros de comercial > Condiciones de pago por producto"
}, {
    10797,
    "Maestros de comercial > Condiciones de pago por producto > Adicionar"
}, {
    10798,
    "Maestros de comercial > Condiciones de pago por producto > Consultar"
}, {
    10799,
    "Maestros de comercial > Condiciones de pago por producto > Duplicar"
}, {
    10800,
    "Maestros de comercial > Condiciones de pago por producto > Eliminar"
}, {
    10801,
    "Maestros de comercial > Condiciones de pago por producto > Modificar"
}, {
    10802,
    "Maestros de comercial > Condiciones de pago por producto > Reporte"
}, {
    3235,
    "Maestros de comercial > Configuración de códigos de barras"
}, {
    3236,
    "Maestros de comercial > Configuración de códigos de barras > Adicionar"
}, {
    3240,
    "Maestros de comercial > Configuración de códigos de barras > Consultar"
}, {
    3239,
    "Maestros de comercial > Configuración de códigos de barras > Duplicar"
}, {
    3238,
    "Maestros de comercial > Configuración de códigos de barras > Eliminar"
}, {
    3237,
    "Maestros de comercial > Configuración de códigos de barras > Modificar"
}, {
    3241,
    "Maestros de comercial > Configuración de códigos de barras > Reporte"
}, {
    3681,
    "Maestros de comercial > Configuración de Lotes"
}, {
    3682,
    "Maestros de comercial > Configuración de Lotes > Adicionar"
}, {
    3683,
    "Maestros de comercial > Configuración de Lotes > Consultar"
}, {
    3684,
    "Maestros de comercial > Configuración de Lotes > Duplicar"
}, {
    3685,
    "Maestros de comercial > Configuración de Lotes > Eliminar"
}, {
    3686,
    "Maestros de comercial > Configuración de Lotes > Modificar"
}, {
    3687,
    "Maestros de comercial > Configuración de Lotes > Reporte"
}, {
    3160,
    "Maestros de comercial > Configuración de seriales"
}, {
    3161,
    "Maestros de comercial > Configuración de seriales > Adicionar"
}, {
    3162,
    "Maestros de comercial > Configuración de seriales > Consultar"
}, {
    3163,
    "Maestros de comercial > Configuración de seriales > Duplicar"
}, {
    3164,
    "Maestros de comercial > Configuración de seriales > Eliminar"
}, {
    3165,
    "Maestros de comercial > Configuración de seriales > Modificar"
}, {
    3166,
    "Maestros de comercial > Configuración de seriales > Reporte"
}, {
    10901,
    "Maestros de comercial > Consultas"
}, {
    10902,
    "Maestros de comercial > Consultas > Entidades de maestros"
}, {
    3102,
    "Maestros de comercial > Eliminar vigencias de precios"
}, {
    3137,
    "Maestros de comercial > Fechas"
}, {
    3155,
    "Maestros de comercial > Fechas > Doctos compras"
}, {
    3157,
    "Maestros de comercial > Fechas > Doctos inventarios"
}, {
    3138,
    "Maestros de comercial > Fechas > Doctos inventarios > Activar fecha"
}, {
    3140,
    "Maestros de comercial > Fechas > Doctos inventarios > Cerrar fecha"
}, {
    3156,
    "Maestros de comercial > Fechas > Doctos ventas"
}, {
    3139,
    "Maestros de comercial > Fechas > Doctos ventas > Activar fecha"
}, {
    3141,
    "Maestros de comercial > Fechas > Doctos ventas > Cerrar fecha"
}, {
    2700,
    "Maestros de comercial > Fletes"
}, {
    2706,
    "Maestros de comercial > Fletes > Servicios"
}, {
    2707,
    "Maestros de comercial > Fletes > Servicios > Adicionar"
}, {
    2708,
    "Maestros de comercial > Fletes > Servicios > Consultar"
}, {
    2709,
    "Maestros de comercial > Fletes > Servicios > Eliminar"
}, {
    2710,
    "Maestros de comercial > Fletes > Servicios > Modificar"
}, {
    2701,
    "Maestros de comercial > Fletes > Tarifas"
}, {
    2702,
    "Maestros de comercial > Fletes > Tarifas > Adicionar"
}, {
    2703,
    "Maestros de comercial > Fletes > Tarifas > Consultar"
}, {
    2704,
    "Maestros de comercial > Fletes > Tarifas > Eliminar"
}, {
    2705,
    "Maestros de comercial > Fletes > Tarifas > Modificar"
}, {
    8453,
    "Maestros de comercial > Generar lista de precios"
}, {
    8368,
    "Maestros de comercial > Grupos de plan de ítems"
}, {
    8369,
    "Maestros de comercial > Grupos de plan de ítems > Adicionar"
}, {
    8370,
    "Maestros de comercial > Grupos de plan de ítems > Consultar"
}, {
    8371,
    "Maestros de comercial > Grupos de plan de ítems > Duplicar"
}, {
    8372,
    "Maestros de comercial > Grupos de plan de ítems > Eliminar"
}, {
    8373,
    "Maestros de comercial > Grupos de plan de ítems > Modificar"
}, {
    8374,
    "Maestros de comercial > Grupos de plan de ítems > Reporte"
}, {
    8140,
    "Maestros de comercial > Grupo de instalaciones"
}, {
    8141,
    "Maestros de comercial > Grupo de instalaciones > Adicionar"
}, {
    8142,
    "Maestros de comercial > Grupo de instalaciones > Consultar"
}, {
    8143,
    "Maestros de comercial > Grupo de instalaciones > Duplicar"
}, {
    8144,
    "Maestros de comercial > Grupo de instalaciones > Eliminar"
}, {
    8145,
    "Maestros de comercial > Grupo de instalaciones > Modificar"
}, {
    8146,
    "Maestros de comercial > Grupo de instalaciones > Reporte"
}, {
    11347,
    "Maestros de comercial > Importaciones"
}, {
    11582,
    "-No implementado > Importaciones"
}, {
    11362,
    "Maestros de comercial > Importaciones > Conceptos"
}, {
    11363,
    "Maestros de comercial > Importaciones > Conceptos > Adicionar"
}, {
    11364,
    "Maestros de comercial > Importaciones > Conceptos > Consultar"
}, {
    11365,
    "Maestros de comercial > Importaciones > Conceptos > Duplicar"
}, {
    11366,
    "Maestros de comercial > Importaciones > Conceptos > Eliminar"
}, {
    11367,
    "Maestros de comercial > Importaciones > Conceptos > Modificar"
}, {
    11368,
    "Maestros de comercial > Importaciones > Conceptos > Reporte"
}, {
    11355,
    "Maestros de comercial > Importaciones > Incoterms"
}, {
    11356,
    "Maestros de comercial > Importaciones > Incoterms > Adicionar"
}, {
    11357,
    "Maestros de comercial > Importaciones > Incoterms > Consultar"
}, {
    11358,
    "Maestros de comercial > Importaciones > Incoterms > Duplicar"
}, {
    11359,
    "Maestros de comercial > Importaciones > Incoterms > Eliminar"
}, {
    11360,
    "Maestros de comercial > Importaciones > Incoterms > Modificar"
}, {
    11361,
    "Maestros de comercial > Importaciones > Incoterms > Reporte"
}, {
    11583,
    "Maestros de comercial > Importaciones > Origenes y destinos"
}, {
    11584,
    "Maestros de comercial > Importaciones > Origenes y destinos > Adicionar"
}, {
    11585,
    "Maestros de comercial > Importaciones > Origenes y destinos > Consultar"
}, {
    11586,
    "Maestros de comercial > Importaciones > Origenes y destinos > Duplicar"
}, {
    11587,
    "Maestros de comercial > Importaciones > Origenes y destinos > Eliminar"
}, {
    11588,
    "Maestros de comercial > Importaciones > Origenes y destinos > Modificar"
}, {
    11589,
    "Maestros de comercial > Importaciones > Origenes y destinos > Reporte"
}, {
    11348,
    "Maestros de comercial > Importaciones > Plantillas"
}, {
    11349,
    "Maestros de comercial > Importaciones > Plantillas > Adicionar"
}, {
    11350,
    "Maestros de comercial > Importaciones > Plantillas > Consultar"
}, {
    11351,
    "Maestros de comercial > Importaciones > Plantillas > Duplicar"
}, {
    11352,
    "Maestros de comercial > Importaciones > Plantillas > Eliminar"
}, {
    11353,
    "Maestros de comercial > Importaciones > Plantillas > Modificar"
}, {
    11354,
    "Maestros de comercial > Importaciones > Plantillas > Reporte"
}, {
    11590,
    "Maestros de comercial > Importaciones > Vias"
}, {
    11591,
    "Maestros de comercial > Importaciones > Vias > Adicionar"
}, {
    11592,
    "Maestros de comercial > Importaciones > Vias > Consultar"
}, {
    11593,
    "Maestros de comercial > Importaciones > Vias > Duplicar"
}, {
    11594,
    "Maestros de comercial > Importaciones > Vias > Eliminar"
}, {
    11595,
    "Maestros de comercial > Importaciones > Vias > Modificar"
}, {
    11596,
    "Maestros de comercial > Importaciones > Vias > Reporte"
}, {
    6552,
    "Maestros de comercial > Inactivar precios"
}, {
    7600,
    "Maestros de comercial > Items tara"
}, {
    7601,
    "Maestros de comercial > Items tara > Adicionar"
}, {
    7602,
    "Maestros de comercial > Items tara > Consultar"
}, {
    7603,
    "Maestros de comercial > Items tara > Duplicar"
}, {
    7604,
    "Maestros de comercial > Items tara > Eliminar"
}, {
    7605,
    "Maestros de comercial > Items tara > Reporte"
}, {
    9129,
    "Maestros de comercial > Item bloqueados por documento"
}, {
    9171,
    "Maestros de comercial > Item bloqueados por documento > Adicionar"
}, {
    9172,
    "Maestros de comercial > Item bloqueados por documento > Consultar"
}, {
    9173,
    "Maestros de comercial > Item bloqueados por documento > Duplicar"
}, {
    9174,
    "Maestros de comercial > Item bloqueados por documento > Eliminar"
}, {
    9175,
    "Maestros de comercial > Item bloqueados por documento > Modificar"
}, {
    9176,
    "Maestros de comercial > Item bloqueados por documento > Reporte"
}, {
    8899,
    "Maestros de comercial > Item de restricción"
}, {
    8900,
    "Maestros de comercial > Item de restricción > Adicionar"
}, {
    8910,
    "Maestros de comercial > Item de restricción > Cambiar código"
}, {
    8901,
    "Maestros de comercial > Item de restricción > Consultar"
}, {
    8902,
    "Maestros de comercial > Item de restricción > Duplicar"
}, {
    8903,
    "Maestros de comercial > Item de restricción > Eliminar"
}, {
    8904,
    "Maestros de comercial > Item de restricción > Modificar"
}, {
    8905,
    "Maestros de comercial > Item de restricción > Reporte"
}, {
    7579,
    "Maestros de comercial > Kits - Usos por ítem"
}, {
    9177,
    "Maestros de comercial > Liquidación AGL y HI"
}, {
    9181,
    "Maestros de comercial > Liquidación AGL y HI > Items para AGL y HI"
}, {
    9182,
    "Maestros de comercial > Liquidación AGL y HI > Items para AGL y HI > Adicionar"
}, {
    9183,
    "Maestros de comercial > Liquidación AGL y HI > Items para AGL y HI > Consultar"
}, {
    9184,
    "Maestros de comercial > Liquidación AGL y HI > Items para AGL y HI > Duplicar"
}, {
    9185,
    "Maestros de comercial > Liquidación AGL y HI > Items para AGL y HI > Eliminar"
}, {
    9186,
    "Maestros de comercial > Liquidación AGL y HI > Items para AGL y HI > Modificar"
}, {
    9187,
    "Maestros de comercial > Liquidación AGL y HI > Items para AGL y HI > Reporte"
}, {
    8006,
    "Maestros de comercial > Liquidación de fletes para planilla de cuadre"
}, {
    2914,
    "Maestros de comercial > Listas de fletes"
}, {
    2915,
    "Maestros de comercial > Listas de fletes > Adicionar"
}, {
    2916,
    "Maestros de comercial > Listas de fletes > Consultar"
}, {
    2917,
    "Maestros de comercial > Listas de fletes > Duplicar"
}, {
    2918,
    "Maestros de comercial > Listas de fletes > Eliminar"
}, {
    2919,
    "Maestros de comercial > Listas de fletes > Modificar"
}, {
    2920,
    "Maestros de comercial > Listas de fletes > Reporte"
}, {
    10938,
    "Maestros de comercial > Otros motivos de inventarios"
}, {
    10939,
    "Maestros de comercial > Otros motivos de inventarios > Adicionar"
}, {
    10940,
    "Maestros de comercial > Otros motivos de inventarios > Consultar"
}, {
    10941,
    "Maestros de comercial > Otros motivos de inventarios > Eliminar"
}, {
    10942,
    "Maestros de comercial > Otros motivos de inventarios > Modificar"
}, {
    10943,
    "Maestros de comercial > Otros motivos de inventarios > Reporte"
}, {
    7307,
    "Maestros de comercial > Motivos rechazo"
}, {
    7308,
    "Maestros de comercial > Motivos rechazo > Adicionar"
}, {
    7309,
    "Maestros de comercial > Motivos rechazo > Consultar"
}, {
    7310,
    "Maestros de comercial > Motivos rechazo > Duplicar"
}, {
    7311,
    "Maestros de comercial > Motivos rechazo > Eliminar"
}, {
    7312,
    "Maestros de comercial > Motivos rechazo > Modificar"
}, {
    7313,
    "Maestros de comercial > Motivos rechazo > Reporte"
}, {
    9745,
    "Maestros de comercial > Nivel de inspección proveedor"
}, {
    9746,
    "Maestros de comercial > Nivel de inspección proveedor > Adicionar"
}, {
    9747,
    "Maestros de comercial > Nivel de inspección proveedor > Consultar"
}, {
    9748,
    "Maestros de comercial > Nivel de inspección proveedor > Duplicar"
}, {
    9749,
    "Maestros de comercial > Nivel de inspección proveedor > Eliminar"
}, {
    9750,
    "Maestros de comercial > Nivel de inspección proveedor > Modificar"
}, {
    9751,
    "Maestros de comercial > Nivel de inspección proveedor > Reporte"
}, {
    9752,
    "Maestros de comercial > Nivel de aseguramiento de calidad - AQL"
}, {
    9753,
    "Maestros de comercial > Nivel de aseguramiento de calidad - AQL > Adicionar"
}, {
    9754,
    "Maestros de comercial > Nivel de aseguramiento de calidad - AQL > Consultar"
}, {
    9755,
    "Maestros de comercial > Nivel de aseguramiento de calidad - AQL > Duplicar"
}, {
    9756,
    "Maestros de comercial > Nivel de aseguramiento de calidad - AQL > Eliminar"
}, {
    9757,
    "Maestros de comercial > Nivel de aseguramiento de calidad - AQL > Modificar"
}, {
    9758,
    "Maestros de comercial > Nivel de aseguramiento de calidad - AQL > Reporte"
}, {
    7302,
    "Maestros de comercial > Otros motivos de calidad"
}, {
    7303,
    "Maestros de comercial > Otros motivos de calidad > Adicionar"
}, {
    7304,
    "Maestros de comercial > Otros motivos de calidad > Consultar"
}, {
    12316,
    "Maestros de comercial > Otros motivos de control de proyectos"
}, {
    12317,
    "Maestros de comercial > Otros motivos de control de proyectos > Adicionar"
}, {
    12318,
    "Maestros de comercial > Otros motivos de control de proyectos > Consultar"
}, {
    12319,
    "Maestros de comercial > Otros motivos de control de proyectos > Eliminar"
}, {
    12320,
    "Maestros de comercial > Otros motivos de control de proyectos > Modificar"
}, {
    12321,
    "Maestros de comercial > Otros motivos de control de proyectos > Reporte"
}, {
    7305,
    "Maestros de comercial > Otros motivos de calidad > Eliminar"
}, {
    7387,
    "Maestros de comercial > Otros motivos de calidad > Modificar"
}, {
    7306,
    "Maestros de comercial > Otros motivos de calidad > Reporte"
}, {
    3052,
    "Maestros de comercial > Parametros EDI"
}, {
    3053,
    "Maestros de comercial > Parametros EDI > Adicionar"
}, {
    3054,
    "Maestros de comercial > Parametros EDI > Consultar"
}, {
    3055,
    "Maestros de comercial > Parametros EDI > Duplicar"
}, {
    3056,
    "Maestros de comercial > Parametros EDI > Eliminar"
}, {
    3057,
    "Maestros de comercial > Parametros EDI > Modificar"
}, {
    3058,
    "Maestros de comercial > Parametros EDI > Reporte"
}, {
    11741,
    "Maestros de comercial > Parámetros por estación"
}, {
    11742,
    "Maestros de comercial > Parámetros por estación > Adicionar"
}, {
    11743,
    "Maestros de comercial > Parámetros por estación > Consultar"
}, {
    11744,
    "Maestros de comercial > Parámetros por estación > Duplicar"
}, {
    11745,
    "Maestros de comercial > Parámetros por estación > Eliminar"
}, {
    11746,
    "Maestros de comercial > Parámetros por estación > Modificar"
}, {
    11747,
    "Maestros de comercial > Parámetros por estación > Reporte"
}, {
    8782,
    "Maestros de comercial > Parámetros de importación EDI"
}, {
    8783,
    "Maestros de comercial > Parámetros de importación EDI > Adicionar"
}, {
    8784,
    "Maestros de comercial > Parámetros de importación EDI > Consultar"
}, {
    8785,
    "Maestros de comercial > Parámetros de importación EDI > Duplicar"
}, {
    8786,
    "Maestros de comercial > Parámetros de importación EDI > Eliminar"
}, {
    8787,
    "Maestros de comercial > Parámetros de importación EDI > Modificar"
}, {
    8788,
    "Maestros de comercial > Parámetros de importación EDI > Reporte"
}, {
    7295,
    "Maestros de comercial > Perfiles"
}, {
    7296,
    "Maestros de comercial > Perfiles > Adicionar"
}, {
    7297,
    "Maestros de comercial > Perfiles > Consultar"
}, {
    7298,
    "Maestros de comercial > Perfiles > Duplicar"
}, {
    7299,
    "Maestros de comercial > Perfiles > Eliminar"
}, {
    7300,
    "Maestros de comercial > Perfiles > Modificar"
}, {
    7301,
    "Maestros de comercial > Perfiles > Reporte"
}, {
    7757,
    "Maestros de comercial > Portafolios por item"
}, {
    3101,
    "Maestros de comercial > Precios de venta por ítem"
}, {
    3762,
    "Maestros de comercial > Precios de venta por ítem > Adicionar"
}, {
    3763,
    "Maestros de comercial > Precios de venta por ítem > Consultar"
}, {
    3764,
    "Maestros de comercial > Precios de venta por ítem > Eliminar"
}, {
    3765,
    "Maestros de comercial > Precios de venta por ítem > Modificar"
}, {
    3477,
    "Maestros de comercial > Prefijos"
}, {
    3478,
    "Maestros de comercial > Prefijos > Adicionar"
}, {
    3479,
    "Maestros de comercial > Prefijos > Consultar"
}, {
    3480,
    "Maestros de comercial > Prefijos > Duplicar"
}, {
    3481,
    "Maestros de comercial > Prefijos > Eliminar"
}, {
    3482,
    "Maestros de comercial > Prefijos > Modificar"
}, {
    3483,
    "Maestros de comercial > Prefijos > Reporte"
}, {
    8188,
    "Maestros de comercial > Productos controlados"
}, {
    8189,
    "Maestros de comercial > Productos controlados > Adicionar"
}, {
    8190,
    "Maestros de comercial > Productos controlados > Consultar"
}, {
    8191,
    "Maestros de comercial > Productos controlados > Duplicar"
}, {
    8192,
    "Maestros de comercial > Productos controlados > Eliminar"
}, {
    8193,
    "Maestros de comercial > Productos controlados > Modificar"
}, {
    8194,
    "Maestros de comercial > Productos controlados > Reporte"
}, {
    12181,
    "Maestros de comercial > Proyecto maestro"
}, {
    12182,
    "Maestros de comercial > Proyecto maestro > Adicionar"
}, {
    12183,
    "Maestros de comercial > Proyecto maestro > Consultar"
}, {
    12184,
    "Maestros de comercial > Proyecto maestro > Duplicar"
}, {
    12185,
    "Maestros de comercial > Proyecto maestro > Eliminar"
}, {
    12186,
    "Maestros de comercial > Proyecto maestro > Modificar"
}, {
    12187,
    "Maestros de comercial > Proyecto maestro > Reporte"
}, {
    11734,
    "Maestros de comercial > Régimen de venta"
}, {
    11735,
    "Maestros de comercial > Régimen de venta > Adicionar"
}, {
    11736,
    "Maestros de comercial > Régimen de venta > Consultar"
}, {
    11737,
    "Maestros de comercial > Régimen de venta > Duplicar"
}, {
    11738,
    "Maestros de comercial > Régimen de venta > Eliminar"
}, {
    11739,
    "Maestros de comercial > Régimen de venta > Modificar"
}, {
    11740,
    "Maestros de comercial > Régimen de venta > Reporte"
}, {
    7356,
    "Maestros de comercial > Reporte de competencias"
}, {
    7383,
    "Maestros de comercial > Reporte de competencias > Adicionar"
}, {
    7385,
    "Maestros de comercial > Reporte de competencias > Eliminar"
}, {
    7386,
    "Maestros de comercial > Reporte de competencias > Imprimir"
}, {
    7384,
    "Maestros de comercial > Reporte de competencias > Modificar"
}, {
    11083,
    "Maestros de comercial > Restricciones de ventas"
}, {
    11092,
    "Maestros de comercial > Restricciones de ventas > Adicionar"
}, {
    11093,
    "Maestros de comercial > Restricciones de ventas > Consultar"
}, {
    11094,
    "Maestros de comercial > Restricciones de ventas > Duplicar"
}, {
    11095,
    "Maestros de comercial > Restricciones de ventas > Eliminar"
}, {
    11096,
    "Maestros de comercial > Restricciones de ventas > Modificar"
}, {
    11097,
    "Maestros de comercial > Restricciones de ventas > Reporte"
}, {
    7281,
    "Maestros de comercial > Rutas de calidad"
}, {
    7282,
    "Maestros de comercial > Rutas de calidad > Adicionar"
}, {
    7283,
    "Maestros de comercial > Rutas de calidad > Consular"
}, {
    7284,
    "Maestros de comercial > Rutas de calidad > Duplicar"
}, {
    7285,
    "Maestros de comercial > Rutas de calidad > Eliminar"
}, {
    7286,
    "Maestros de comercial > Rutas de calidad > Modificar"
}, {
    7287,
    "Maestros de comercial > Rutas de calidad > Reporte"
}, {
    7122,
    "Maestros de comercial > Rutas de visitas"
}, {
    7123,
    "Maestros de comercial > Rutas de visitas > Adicionar"
}, {
    7129,
    "Maestros de comercial > Rutas de visitas > Cambiar código"
}, {
    7124,
    "Maestros de comercial > Rutas de visitas > Consultar"
}, {
    7125,
    "Maestros de comercial > Rutas de visitas > Duplicar"
}, {
    7126,
    "Maestros de comercial > Rutas de visitas > Eliminar"
}, {
    7127,
    "Maestros de comercial > Rutas de visitas > Modificar"
}, {
    7128,
    "Maestros de comercial > Rutas de visitas > Reporte"
}, {
    2671,
    "Maestros de comercial > Seguimiento"
}, {
    2713,
    "Maestros de comercial > Seguimiento > Compras"
}, {
    2672,
    "Maestros de comercial > Seguimiento > Compras > Adicionar"
}, {
    2673,
    "Maestros de comercial > Seguimiento > Compras > Consultar"
}, {
    2674,
    "Maestros de comercial > Seguimiento > Compras > Duplicar"
}, {
    2675,
    "Maestros de comercial > Seguimiento > Compras > Eliminar"
}, {
    2676,
    "Maestros de comercial > Seguimiento > Compras > Modificar"
}, {
    2677,
    "Maestros de comercial > Seguimiento > Compras > Reporte"
}, {
    3271,
    "Maestros de comercial > Seguimiento > Inventarios"
}, {
    3272,
    "Maestros de comercial > Seguimiento > Inventarios > Adicionar"
}, {
    3273,
    "Maestros de comercial > Seguimiento > Inventarios > Consultar"
}, {
    3274,
    "Maestros de comercial > Seguimiento > Inventarios > Duplicar"
}, {
    3275,
    "Maestros de comercial > Seguimiento > Inventarios > Eliminar"
}, {
    3276,
    "Maestros de comercial > Seguimiento > Inventarios > Modificar"
}, {
    3277,
    "Maestros de comercial > Seguimiento > Inventarios > Reporte"
}, {
    2714,
    "Maestros de comercial > Seguimiento > Ventas"
}, {
    2715,
    "Maestros de comercial > Seguimiento > Ventas > Adicionar"
}, {
    2716,
    "Maestros de comercial > Seguimiento > Ventas > Consultar"
}, {
    2717,
    "Maestros de comercial > Seguimiento > Ventas > Duplicar"
}, {
    2718,
    "Maestros de comercial > Seguimiento > Ventas > Eliminar"
}, {
    2719,
    "Maestros de comercial > Seguimiento > Ventas > Modificar"
}, {
    2720,
    "Maestros de comercial > Seguimiento > Ventas > Reporte"
}, {
    9766,
    "Maestros de comercial > Tabla maestra de inspección"
}, {
    9767,
    "Maestros de comercial > Tabla maestra de inspección > Adicionar"
}, {
    9768,
    "Maestros de comercial > Tabla maestra de inspección > Consultar"
}, {
    9769,
    "Maestros de comercial > Tabla maestra de inspección > Duplicar"
}, {
    9770,
    "Maestros de comercial > Tabla maestra de inspección > Eliminar"
}, {
    9771,
    "Maestros de comercial > Tabla maestra de inspección > Modificar"
}, {
    9772,
    "Maestros de comercial > Tabla maestra de inspección > Reporte"
}, {
    9759,
    "Maestros de comercial > Tamaño muestra de lote"
}, {
    9760,
    "Maestros de comercial > Tamaño muestra de lote > Adicionar"
}, {
    9761,
    "Maestros de comercial > Tamaño muestra de lote > Consultar"
}, {
    9765,
    "Maestros de comercial > Tamaño muestra de lote > Duplicar"
}, {
    9762,
    "Maestros de comercial > Tamaño muestra de lote > Eliminar"
}, {
    9763,
    "Maestros de comercial > Tamaño muestra de lote > Modificar"
}, {
    9764,
    "Maestros de comercial > Tamaño muestra de lote > Reporte"
}, {
    12151,
    "-No implementado > Tipos de identificación"
}, {
    12152,
    "-No implementado > Tipos de identificación > Adicionar"
}, {
    12153,
    "-No implementado > Tipos de identificación > Consultar"
}, {
    12154,
    "-No implementado > Tipos de identificación > Duplicar"
}, {
    12155,
    "-No implementado > Tipos de identificación > Eliminar"
}, {
    12156,
    "-No implementado > Tipos de identificación > Modificar"
}, {
    12157,
    "-No implementado > Tipos de identificación > Reporte"
}, {
    11727,
    "Maestros de comercial > Tipo venta"
}, {
    11728,
    "Maestros de comercial > Tipo venta > Adicionar"
}, {
    11729,
    "Maestros de comercial > Tipo venta > Consultar"
}, {
    11730,
    "Maestros de comercial > Tipo venta > Duplicar"
}, {
    11731,
    "Maestros de comercial > Tipo venta > Eliminar"
}, {
    11732,
    "Maestros de comercial > Tipo venta > Modificar"
}, {
    11733,
    "Maestros de comercial > Tipo venta > Reporte"
}, {
    3088,
    "Maestros de comercial > Transferencia de precios"
}, {
    11895,
    "Maestros de comercial > Turnos"
}, {
    11896,
    "Maestros de comercial > Turnos > Apertura"
}, {
    11897,
    "Maestros de comercial > Turnos > Cierre"
}, {
    7133,
    "Maestros de comercial > Ubicaciones"
}, {
    7134,
    "Maestros de comercial > Ubicaciones > Criterios de clasificación de ubicaciones"
}, {
    7135,
    "Maestros de comercial > Ubicaciones > Criterios de clasificación de ubicaciones > Mayores"
}, {
    7137,
    "Maestros de comercial > Ubicaciones > Criterios de clasificación de ubicaciones > Mayores > Adicionar"
}, {
    7138,
    "Maestros de comercial > Ubicaciones > Criterios de clasificación de ubicaciones > Mayores > Consultar"
}, {
    7139,
    "Maestros de comercial > Ubicaciones > Criterios de clasificación de ubicaciones > Mayores > Duplicar"
}, {
    7140,
    "Maestros de comercial > Ubicaciones > Criterios de clasificación de ubicaciones > Mayores > Eliminar"
}, {
    7141,
    "Maestros de comercial > Ubicaciones > Criterios de clasificación de ubicaciones > Mayores > Modificar"
}, {
    7142,
    "Maestros de comercial > Ubicaciones > Criterios de clasificación de ubicaciones > Mayores > Reporte"
}, {
    7136,
    "Maestros de comercial > Ubicaciones > Criterios de clasificación de ubicaciones > Planes"
}, {
    7143,
    "Maestros de comercial > Ubicaciones > Criterios de clasificación de ubicaciones > Planes > Adicionar"
}, {
    7144,
    "Maestros de comercial > Ubicaciones > Criterios de clasificación de ubicaciones > Planes > Consultar"
}, {
    7145,
    "Maestros de comercial > Ubicaciones > Criterios de clasificación de ubicaciones > Planes > Duplicar"
}, {
    7146,
    "Maestros de comercial > Ubicaciones > Criterios de clasificación de ubicaciones > Planes > Eliminar"
}, {
    7147,
    "Maestros de comercial > Ubicaciones > Criterios de clasificación de ubicaciones > Planes > Modificar"
}, {
    7148,
    "Maestros de comercial > Ubicaciones > Criterios de clasificación de ubicaciones > Planes > Reporte"
}, {
    7480,
    "Maestros de comercial > Usuario tercero"
}, {
    7481,
    "Maestros de comercial > Usuario tercero > Usuario"
}, {
    1351,
    "Maestros de comercial > Códigos de barras"
}, {
    1352,
    "Maestros de comercial > Códigos de barras > Adicionar"
}, {
    1356,
    "Maestros de comercial > Códigos de barras > Consultar"
}, {
    1355,
    "Maestros de comercial > Códigos de barras > Duplicar"
}, {
    1354,
    "Maestros de comercial > Códigos de barras > Eliminar"
}, {
    3242,
    "Maestros de comercial > Códigos de barras > Generar"
}, {
    4232,
    "Maestros de comercial > Códigos de barras > Generar códigos para ítem con unidad adicional"
}, {
    8398,
    "Maestros de comercial > Códigos de barras > Impresión código de barras"
}, {
    1353,
    "Maestros de comercial > Códigos de barras > Modificar"
}, {
    1357,
    "Maestros de comercial > Códigos de barras > Reporte"
}, {
    2,
    "Maestros > Compañias > Compañías"
}, {
    50,
    "Maestros > Compañias > Compañías > Adicionar"
}, {
    49,
    "Maestros > Compañias > Compañías > Consultar"
}, {
    53,
    "Maestros > Compañias > Compañías > Eliminar"
}, {
    52,
    "Maestros > Compañias > Compañías > Modificar"
}, {
    54,
    "Maestros > Compañias > Compañías > Reporte"
}, {
    6947,
    "Maestros > Conceptos de pagos"
}, {
    6948,
    "Maestros > Conceptos de pagos > Adicionar"
}, {
    6949,
    "Maestros > Conceptos de pagos > Consultar"
}, {
    6950,
    "Maestros > Conceptos de pagos > Duplicar"
}, {
    6951,
    "Maestros > Conceptos de pagos > Eliminar"
}, {
    6952,
    "Maestros > Conceptos de pagos > Modificar"
}, {
    6953,
    "Maestros > Conceptos de pagos > Reporte"
}, {
    30,
    "Maestros > Condiciones de pago"
}, {
    199,
    "Maestros > Condiciones de pago > Adicionar"
}, {
    198,
    "Maestros > Condiciones de pago > Consultar"
}, {
    200,
    "Maestros > Condiciones de pago > Duplicar"
}, {
    202,
    "Maestros > Condiciones de pago > Eliminar"
}, {
    201,
    "Maestros > Condiciones de pago > Modificar"
}, {
    203,
    "Maestros > Condiciones de pago > Reporte"
}, {
    15,
    "Maestros > Centros de costos"
}, {
    1364,
    "Comercial - Compras > Cotizaciones"
}, {
    1365,
    "Comercial - Compras > Cotizaciones > Adicionar"
}, {
    1367,
    "Comercial - Compras > Cotizaciones > Consultar"
}, {
    4620,
    "Comercial - Compras > Cotizaciones con convenios"
}, {
    4621,
    "Comercial - Compras > Cotizaciones con convenios > Adicionar"
}, {
    4622,
    "Comercial - Compras > Cotizaciones con convenios > Consultar"
}, {
    7594,
    "Comercial - Compras > Cotizaciones con convenios > Duplicar"
}, {
    4623,
    "Comercial - Compras > Cotizaciones con convenios > Eliminar"
}, {
    4624,
    "Comercial - Compras > Cotizaciones con convenios > Modificar"
}, {
    7581,
    "Comercial - Compras > Cotizaciones > Duplicar"
}, {
    1366,
    "Comercial - Compras > Cotizaciones > Eliminar"
}, {
    1368,
    "Comercial - Compras > Cotizaciones > Modificar"
}, {
    8648,
    "Comercial - Compras > Cotizaciones > Permitir modificar fecha de inactivación"
}, {
    8924,
    "-No implementado > Validar que el ítem no este inactivo"
}, {
    1045,
    "Financiero - Activos fijos > Maestros > Criterios de activos fijos"
}, {
    1046,
    "Financiero - Activos fijos > Maestros > Criterios de activos fijos > Mayores"
}, {
    1048,
    "Financiero - Activos fijos > Maestros > Criterios de activos fijos > Mayores > Adicionar"
}, {
    1049,
    "Financiero - Activos fijos > Maestros > Criterios de activos fijos > Mayores > Consultar"
}, {
    1050,
    "Financiero - Activos fijos > Maestros > Criterios de activos fijos > Mayores > Duplicar"
}, {
    1051,
    "Financiero - Activos fijos > Maestros > Criterios de activos fijos > Mayores > Eliminar"
}, {
    1052,
    "Financiero - Activos fijos > Maestros > Criterios de activos fijos > Mayores > Modificar"
}, {
    1053,
    "Financiero - Activos fijos > Maestros > Criterios de activos fijos > Mayores > Reporte"
}, {
    1047,
    "Financiero - Activos fijos > Maestros > Criterios de activos fijos > Plan"
}, {
    1054,
    "Financiero - Activos fijos > Maestros > Criterios de activos fijos > Plan > Adicionar"
}, {
    1055,
    "Financiero - Activos fijos > Maestros > Criterios de activos fijos > Plan > Consultar"
}, {
    1056,
    "Financiero - Activos fijos > Maestros > Criterios de activos fijos > Plan > Duplicar"
}, {
    1057,
    "Financiero - Activos fijos > Maestros > Criterios de activos fijos > Plan > Eliminar"
}, {
    1058,
    "Financiero - Activos fijos > Maestros > Criterios de activos fijos > Plan > Modificar"
}, {
    1059,
    "Financiero - Activos fijos > Maestros > Criterios de activos fijos > Plan > Reporte"
}, {
    9,
    "Maestros > Terceros > Criterios Clasificación Clientes > Mayores"
}, {
    86,
    "Maestros > Terceros > Criterios Clasificación Clientes > Mayores > Adicionar"
}, {
    85,
    "Maestros > Terceros > Criterios Clasificación Clientes > Mayores > Consultar"
}, {
    87,
    "Maestros > Terceros > Criterios Clasificación Clientes > Mayores > Duplicar"
}, {
    89,
    "Maestros > Terceros > Criterios Clasificación Clientes > Mayores > Eliminar"
}, {
    88,
    "Maestros > Terceros > Criterios Clasificación Clientes > Mayores > Modificar"
}, {
    90,
    "Maestros > Terceros > Criterios Clasificación Clientes > Mayores > Reporte"
}, {
    10,
    "Maestros > Terceros > Criterios Clasificación Clientes > Plan"
}, {
    93,
    "Maestros > Terceros > Criterios Clasificación Clientes > Plan > Adicionar"
}, {
    92,
    "Maestros > Terceros > Criterios Clasificación Clientes > Plan > Consultar"
}, {
    94,
    "Maestros > Terceros > Criterios Clasificación Clientes > Plan > Duplicar"
}, {
    96,
    "Maestros > Terceros > Criterios Clasificación Clientes > Plan > Eliminar"
}, {
    95,
    "Maestros > Terceros > Criterios Clasificación Clientes > Plan > Modificar"
}, {
    97,
    "Maestros > Terceros > Criterios Clasificación Clientes > Plan > Reporte"
}, {
    2412,
    "Maestros > Terceros > Criterios Clasificación Proveedores > Mayores"
}, {
    2413,
    "Maestros > Terceros > Criterios Clasificación Proveedores > Mayores > Adicionar"
}, {
    2414,
    "Maestros > Terceros > Criterios Clasificación Proveedores > Mayores > Consultar"
}, {
    2415,
    "Maestros > Terceros > Criterios Clasificación Proveedores > Mayores > Duplicar"
}, {
    2416,
    "Maestros > Terceros > Criterios Clasificación Proveedores > Mayores > Eliminar"
}, {
    2417,
    "Maestros > Terceros > Criterios Clasificación Proveedores > Mayores > Modificar"
}, {
    2418,
    "Maestros > Terceros > Criterios Clasificación Proveedores > Mayores > Reporte"
}, {
    2419,
    "Maestros > Terceros > Criterios Clasificación Proveedores > Plan"
}, {
    2420,
    "Maestros > Terceros > Criterios Clasificación Proveedores > Plan > Adicionar"
}, {
    2421,
    "Maestros > Terceros > Criterios Clasificación Proveedores > Plan > Consultar"
}, {
    2422,
    "Maestros > Terceros > Criterios Clasificación Proveedores > Plan > Duplicar"
}, {
    2423,
    "Maestros > Terceros > Criterios Clasificación Proveedores > Plan > Eliminar"
}, {
    2424,
    "Maestros > Terceros > Criterios Clasificación Proveedores > Plan > Modificar"
}, {
    2425,
    "Maestros > Terceros > Criterios Clasificación Proveedores > Plan > Reporte"
}, {
    2411,
    "Maestros > Terceros > Criterios Clasificación Proveedores"
}, {
    8,
    "Maestros > Terceros > Criterios Clasificación Clientes"
}, {
    662,
    "Maestros de comercial > Criterios de clasificación de items"
}, {
    671,
    "Maestros de comercial > Criterios de clasificación de items > Mayores"
}, {
    674,
    "Maestros de comercial > Criterios de clasificación de items > Mayores > Adicionar"
}, {
    673,
    "Maestros de comercial > Criterios de clasificación de items > Mayores > Consultar"
}, {
    675,
    "Maestros de comercial > Criterios de clasificación de items > Mayores > Duplicar"
}, {
    677,
    "Maestros de comercial > Criterios de clasificación de items > Mayores > Eliminar"
}, {
    676,
    "Maestros de comercial > Criterios de clasificación de items > Mayores > Modificar"
}, {
    678,
    "Maestros de comercial > Criterios de clasificación de items > Mayores > Reporte"
}, {
    672,
    "Maestros de comercial > Criterios de clasificación de items > Plan"
}, {
    679,
    "Maestros de comercial > Criterios de clasificación de items > Plan > Adicionar"
}, {
    680,
    "Maestros de comercial > Criterios de clasificación de items > Plan > Consultar"
}, {
    681,
    "Maestros de comercial > Criterios de clasificación de items > Plan > Duplicar"
}, {
    683,
    "Maestros de comercial > Criterios de clasificación de items > Plan > Eliminar"
}, {
    682,
    "Maestros de comercial > Criterios de clasificación de items > Plan > Modificar"
}, {
    684,
    "Maestros de comercial > Criterios de clasificación de items > Plan > Reporte"
}, {
    12,
    "Maestros > Cuentas > Auxiliares"
}, {
    100,
    "Maestros > Cuentas > Auxiliares > Adicionar"
}, {
    105,
    "Maestros > Cuentas > Auxiliares > Cambiar código"
}, {
    9994,
    "Maestros > Cuentas > Auxiliares > Permitir cambiar Grupo C.Costo"
}, {
    99,
    "Maestros > Cuentas > Auxiliares > Consultar"
}, {
    101,
    "Maestros > Cuentas > Auxiliares > Duplicar"
}, {
    103,
    "Maestros > Cuentas > Auxiliares > Eliminar"
}, {
    102,
    "Maestros > Cuentas > Auxiliares > Modificar"
}, {
    104,
    "Maestros > Cuentas > Auxiliares > Reporte"
}, {
    35,
    "Maestros > Bancos > Cuentas bancarias"
}, {
    227,
    "Maestros > Bancos > Cuentas bancarias > Adicionar"
}, {
    226,
    "Maestros > Bancos > Cuentas bancarias > Consultar"
}, {
    228,
    "Maestros > Bancos > Cuentas bancarias > Duplicar"
}, {
    230,
    "Maestros > Bancos > Cuentas bancarias > Eliminar"
}, {
    229,
    "Maestros > Bancos > Cuentas bancarias > Modificar"
}, {
    7235,
    "Maestros > Bancos > Cuentas bancarias > Modificar datos encripción"
}, {
    231,
    "Maestros > Bancos > Cuentas bancarias > Reporte"
}, {
    13,
    "Maestros > Cuentas > Mayores"
}, {
    108,
    "Maestros > Cuentas > Mayores > Adicionar"
}, {
    107,
    "Maestros > Cuentas > Mayores > Consultar"
}, {
    109,
    "Maestros > Cuentas > Mayores > Duplicar"
}, {
    111,
    "Maestros > Cuentas > Mayores > Eliminar"
}, {
    110,
    "Maestros > Cuentas > Mayores > Modificar"
}, {
    112,
    "Maestros > Cuentas > Mayores > Reporte"
}, {
    14,
    "Maestros > Cuentas > Planes"
}, {
    115,
    "Maestros > Cuentas > Planes > Adicionar"
}, {
    114,
    "Maestros > Cuentas > Planes > Consultar"
}, {
    116,
    "Maestros > Cuentas > Planes > Duplicar"
}, {
    118,
    "Maestros > Cuentas > Planes > Eliminar"
}, {
    117,
    "Maestros > Cuentas > Planes > Modificar"
}, {
    119,
    "Maestros > Cuentas > Planes > Reporte"
}, {
    11,
    "Maestros > Cuentas"
}, {
    4032,
    "Maestros > Denominaciones"
}, {
    4033,
    "Maestros > Denominaciones > Adicionar"
}, {
    4034,
    "Maestros > Denominaciones > Consultar"
}, {
    4035,
    "Maestros > Denominaciones > Duplicar"
}, {
    4036,
    "Maestros > Denominaciones > Eliminar"
}, {
    4037,
    "Maestros > Denominaciones > Modificar"
}, {
    4038,
    "Maestros > Denominaciones > Reporte"
}, {
    44,
    "Maestros > Países, deptos, ciudades y barrios > Departamentos"
}, {
    275,
    "Maestros > Países, deptos, ciudades y barrios > Departamentos > Adicionar"
}, {
    274,
    "Maestros > Países, deptos, ciudades y barrios > Departamentos > Consultar"
}, {
    276,
    "Maestros > Países, deptos, ciudades y barrios > Departamentos > Duplicar"
}, {
    278,
    "Maestros > Países, deptos, ciudades y barrios > Departamentos > Eliminar"
}, {
    277,
    "Maestros > Países, deptos, ciudades y barrios > Departamentos > Modificar"
}, {
    279,
    "Maestros > Países, deptos, ciudades y barrios > Departamentos > Reporte"
}, {
    571,
    "Maestros de comercial > Descripcion técnica"
}, {
    579,
    "Maestros de comercial > Descripcion técnica > Adicionar"
}, {
    580,
    "Maestros de comercial > Descripcion técnica > Consultar"
}, {
    581,
    "Maestros de comercial > Descripcion técnica > Duplicar"
}, {
    583,
    "Maestros de comercial > Descripcion técnica > Eliminar"
}, {
    582,
    "Maestros de comercial > Descripcion técnica > Modificar"
}, {
    584,
    "Maestros de comercial > Descripcion técnica > Reporte"
}, {
    7338,
    "Maestros > Direcciones"
}, {
    7339,
    "Maestros > Direcciones > Codificación"
}, {
    7340,
    "Maestros > Direcciones > Codificación > Adicionar"
}, {
    7341,
    "Maestros > Direcciones > Codificación > Consultar"
}, {
    7342,
    "Maestros > Direcciones > Codificación > Duplicar"
}, {
    7343,
    "Maestros > Direcciones > Codificación > Eliminar"
}, {
    7344,
    "Maestros > Direcciones > Codificación > Modificar"
}, {
    7345,
    "Maestros > Direcciones > Codificación > Reporte"
}, {
    7346,
    "Maestros > Direcciones > Configuración"
}, {
    7347,
    "Maestros > Direcciones > Configuración > Adicionar"
}, {
    7348,
    "Maestros > Direcciones > Configuración > Consultar"
}, {
    7349,
    "Maestros > Direcciones > Configuración > Duplicar"
}, {
    7350,
    "Maestros > Direcciones > Configuración > Eliminar"
}, {
    7351,
    "Maestros > Direcciones > Configuración > Modificar"
}, {
    7352,
    "Maestros > Direcciones > Configuración > Reporte"
}, {
    39,
    "Maestros > Documentos"
}, {
    4237,
    "Maestros de comercial > Descuentos en compras"
}, {
    4238,
    "Maestros de comercial > Descuentos en compras > Adicionar"
}, {
    4239,
    "Maestros de comercial > Descuentos en compras > Consultar"
}, {
    4240,
    "Maestros de comercial > Descuentos en compras > Duplicar"
}, {
    4241,
    "Maestros de comercial > Descuentos en compras > Eliminar"
}, {
    4242,
    "Maestros de comercial > Descuentos en compras > Modificar"
}, {
    4243,
    "Maestros de comercial > Descuentos en compras > Reporte"
}, {
    1546,
    "Maestros de comercial > Descuentos por pronto pago"
}, {
    1547,
    "Maestros de comercial > Descuentos por pronto pago > Adicionar"
}, {
    1548,
    "Maestros de comercial > Descuentos por pronto pago > Cambiar código"
}, {
    1549,
    "Maestros de comercial > Descuentos por pronto pago > Consultar"
}, {
    1550,
    "Maestros de comercial > Descuentos por pronto pago > Duplicar"
}, {
    1551,
    "Maestros de comercial > Descuentos por pronto pago > Eliminar"
}, {
    1552,
    "Maestros de comercial > Descuentos por pronto pago > Modificar"
}, {
    1553,
    "Maestros de comercial > Descuentos por pronto pago > Reporte"
}, {
    747,
    "Maestros de comercial > Extensiones1"
}, {
    755,
    "Maestros de comercial > Extensiones1 > Adicionar"
}, {
    754,
    "Maestros de comercial > Extensiones1 > Consultar"
}, {
    756,
    "Maestros de comercial > Extensiones1 > Duplicar"
}, {
    758,
    "Maestros de comercial > Extensiones1 > Eliminar"
}, {
    7742,
    "Maestros de comercial > Extensiones1 > Exigir confirmación al cambiar el detalle"
}, {
    757,
    "Maestros de comercial > Extensiones1 > Modificar"
}, {
    759,
    "Maestros de comercial > Extensiones1 > Reporte"
}, {
    748,
    "Maestros de comercial > Extensiones2"
}, {
    761,
    "Maestros de comercial > Extensiones2 > Adicionar"
}, {
    849,
    "Maestros de comercial > Extensiones2 > Consultar"
}, {
    762,
    "Maestros de comercial > Extensiones2 > Duplicar"
}, {
    764,
    "Maestros de comercial > Extensiones2 > Eliminar"
}, {
    7743,
    "Maestros de comercial > Extensiones2 > Exigir confirmación al cambiar el detalle"
}, {
    763,
    "Maestros de comercial > Extensiones2 > Modificar"
}, {
    765,
    "Maestros de comercial > Extensiones2 > Reporte"
}, {
    9164,
    "Maestros de comercial > Liquidación AGL y HI > Factores de AGL y HI"
}, {
    9165,
    "Maestros de comercial > Liquidación AGL y HI > Factores de AGL y HI > Adicionar"
}, {
    9166,
    "Maestros de comercial > Liquidación AGL y HI > Factores de AGL y HI > Consultar"
}, {
    9167,
    "Maestros de comercial > Liquidación AGL y HI > Factores de AGL y HI > Duplicar"
}, {
    9168,
    "Maestros de comercial > Liquidación AGL y HI > Factores de AGL y HI > Eliminar"
}, {
    9169,
    "Maestros de comercial > Liquidación AGL y HI > Factores de AGL y HI > Modificar"
}, {
    9170,
    "Maestros de comercial > Liquidación AGL y HI > Factores de AGL y HI > Reporte"
}, {
    40,
    "Maestros > Documentos > Familias"
}, {
    254,
    "Maestros > Documentos > Familias > Adicionar"
}, {
    253,
    "Maestros > Documentos > Familias > Consultar"
}, {
    255,
    "Maestros > Documentos > Familias > Duplicar"
}, {
    257,
    "Maestros > Documentos > Familias > Eliminar"
}, {
    256,
    "Maestros > Documentos > Familias > Modificar"
}, {
    258,
    "Maestros > Documentos > Familias > Reporte"
}, {
    993,
    "Maestros > Fechas"
}, {
    995,
    "Maestros de comercial > Fechas > Doctos compras > Activar fecha"
}, {
    1920,
    "Maestros > Fechas > Doctos contabilidad > Activar fecha"
}, {
    3150,
    "Maestros > Fechas > Doctos activos fijos"
}, {
    3148,
    "Maestros > Fechas > Doctos activos fijos > Activar fecha"
}, {
    3149,
    "Maestros > Fechas > Doctos activos fijos > Cerrar fecha"
}, {
    994,
    "Maestros de comercial > Fechas > Doctos compras > Cerrar fecha"
}, {
    1921,
    "Maestros > Fechas > Doctos contabilidad > Cerrar fecha"
}, {
    3153,
    "Maestros > Fechas > Doctos contabilidad"
}, {
    3154,
    "Maestros > Fechas > Consulta calendario"
}, {
    3151,
    "Maestros > Fechas > Doctos cuentas por cobrar /venta servicios"
}, {
    3133,
    "Maestros > Fechas > Doctos cuentas por cobrar /venta servicios > Activar fecha"
}, {
    3135,
    "Maestros > Fechas > Doctos cuentas por cobrar /venta servicios > Cerrar fecha"
}, {
    3152,
    "Maestros > Fechas > Doctos cuentas por pagar /compra servicios"
}, {
    3134,
    "Maestros > Fechas > Doctos cuentas por pagar /compra servicios > Activar fecha"
}, {
    3136,
    "Maestros > Fechas > Doctos cuentas por pagar /compra servicios > Cerrar fecha"
}, {
    1011,
    "Maestros > Fechas > Consulta calendario > Modificar dias festivos"
}, {
    977,
    "Maestros > Flujo de efectivo > Conceptos"
}, {
    986,
    "Maestros > Flujo de efectivo > Conceptos > Adicionar"
}, {
    992,
    "Maestros > Flujo de efectivo > Conceptos > Cambiar código"
}, {
    987,
    "Maestros > Flujo de efectivo > Conceptos > Consultar"
}, {
    988,
    "Maestros > Flujo de efectivo > Conceptos > Duplicar"
}, {
    989,
    "Maestros > Flujo de efectivo > Conceptos > Eliminar"
}, {
    990,
    "Maestros > Flujo de efectivo > Conceptos > Modificar"
}, {
    991,
    "Maestros > Flujo de efectivo > Conceptos > Reporte"
}, {
    975,
    "Maestros > Flujo de efectivo > Estructura"
}, {
    979,
    "Maestros > Flujo de efectivo > Estructura > Modificar"
}, {
    978,
    "Maestros > Flujo de efectivo > Estructura > Reporte"
}, {
    976,
    "Maestros > Flujo de efectivo > Mayores"
}, {
    980,
    "Maestros > Flujo de efectivo > Mayores > Adicionar"
}, {
    981,
    "Maestros > Flujo de efectivo > Mayores > Consultar"
}, {
    982,
    "Maestros > Flujo de efectivo > Mayores > Duplicar"
}, {
    983,
    "Maestros > Flujo de efectivo > Mayores > Eliminar"
}, {
    984,
    "Maestros > Flujo de efectivo > Mayores > Modificar"
}, {
    985,
    "Maestros > Flujo de efectivo > Mayores > Reporte"
}, {
    974,
    "Maestros > Flujo de efectivo"
}, {
    47,
    "Maestros > Firmas"
}, {
    296,
    "Maestros > Firmas > Adicionar"
}, {
    295,
    "Maestros > Firmas > Consultar"
}, {
    297,
    "Maestros > Firmas > Duplicar"
}, {
    299,
    "Maestros > Firmas > Eliminar"
}, {
    298,
    "Maestros > Firmas > Modificar"
}, {
    300,
    "Maestros > Firmas > Reporte"
}, {
    38,
    "Maestros > Bancos > Formatos de extracto"
}, {
    248,
    "Maestros > Bancos > Formatos de extracto > Adicionar"
}, {
    247,
    "Maestros > Bancos > Formatos de extracto > Consultar"
}, {
    249,
    "Maestros > Bancos > Formatos de extracto > Duplicar"
}, {
    251,
    "Maestros > Bancos > Formatos de extracto > Eliminar"
}, {
    250,
    "Maestros > Bancos > Formatos de extracto > Modificar"
}, {
    4454,
    "Maestros de comercial > Frecuencia de promociones"
}, {
    4455,
    "Maestros de comercial > Frecuencia de promociones > Adicionar"
}, {
    4456,
    "Maestros de comercial > Frecuencia de promociones > Cambiar código"
}, {
    4457,
    "Maestros de comercial > Frecuencia de promociones > Consultar"
}, {
    4458,
    "Maestros de comercial > Frecuencia de promociones > Duplicar"
}, {
    4459,
    "Maestros de comercial > Frecuencia de promociones > Eliminar"
}, {
    4460,
    "Maestros de comercial > Frecuencia de promociones > Modificar"
}, {
    4461,
    "Maestros de comercial > Frecuencia de promociones > Reporte"
}, {
    1125,
    "Maestros > Funcionarios"
}, {
    1126,
    "Maestros > Funcionarios > Adicionar"
}, {
    1127,
    "Maestros > Funcionarios > Consultar"
}, {
    1128,
    "Maestros > Funcionarios > Duplicar"
}, {
    1129,
    "Maestros > Funcionarios > Eliminar"
}, {
    1130,
    "Maestros > Funcionarios > Modificar"
}, {
    1131,
    "Maestros > Funcionarios > Reporte"
}, {
    2605,
    "Maestros > Grupos de centros de operación"
}, {
    4861,
    "Maestros > Grupos de condiciones de pago"
}, {
    4862,
    "Maestros > Grupos de condiciones de pago > Adicionar"
}, {
    4863,
    "Maestros > Grupos de condiciones de pago > Consultar"
}, {
    4864,
    "Maestros > Grupos de condiciones de pago > Duplicar"
}, {
    4865,
    "Maestros > Grupos de condiciones de pago > Eliminar"
}, {
    4866,
    "Maestros > Grupos de condiciones de pago > Modificar"
}, {
    4867,
    "Maestros > Grupos de condiciones de pago > Reporte"
}, {
    779,
    "Maestros > Centros de costos > Grupos de centros de costos"
}, {
    782,
    "Maestros > Centros de costos > Grupos de centros de costos > Adicionar"
}, {
    781,
    "Maestros > Centros de costos > Grupos de centros de costos > Consultar"
}, {
    780,
    "Maestros > Centros de costos > Grupos de centros de costos > Duplicar"
}, {
    784,
    "Maestros > Centros de costos > Grupos de centros de costos > Eliminar"
}, {
    783,
    "Maestros > Centros de costos > Grupos de centros de costos > Modificar"
}, {
    785,
    "Maestros > Centros de costos > Grupos de centros de costos > Reporte"
}, {
    2606,
    "Maestros > Grupos de centros de operación > Adicionar"
}, {
    2607,
    "Maestros > Grupos de centros de operación > Consultar"
}, {
    2608,
    "Maestros > Grupos de centros de operación > Duplicar"
}, {
    2609,
    "Maestros > Grupos de centros de operación > Eliminar"
}, {
    2610,
    "Maestros > Grupos de centros de operación > Modificar"
}, {
    2611,
    "Maestros > Grupos de centros de operación > Reporte"
}, {
    807,
    "Maestros > Grupos impositivos"
}, {
    808,
    "Maestros > Grupos impositivos > Adicionar"
}, {
    809,
    "Maestros > Grupos impositivos > Consultar"
}, {
    810,
    "Maestros > Grupos impositivos > Duplicar"
}, {
    812,
    "Maestros > Grupos impositivos > Eliminar"
}, {
    811,
    "Maestros > Grupos impositivos > Modificar"
}, {
    813,
    "Maestros > Grupos impositivos > Reporte"
}, {
    2612,
    "Maestros > Grupos de unidades de negocio"
}, {
    2613,
    "Maestros > Grupos de unidades de negocio > Adicionar"
}, {
    2614,
    "Maestros > Grupos de unidades de negocio > Consultar"
}, {
    2615,
    "Maestros > Grupos de unidades de negocio > Duplicar"
}, {
    2616,
    "Maestros > Grupos de unidades de negocio > Eliminar"
}, {
    2617,
    "Maestros > Grupos de unidades de negocio > Modificar"
}, {
    2618,
    "Maestros > Grupos de unidades de negocio > Reporte"
}, {
    895,
    "Maestros de comercial > Grupos de bodegas"
}, {
    896,
    "Maestros de comercial > Grupos de bodegas > Adicionar"
}, {
    897,
    "Maestros de comercial > Grupos de bodegas > Consultar"
}, {
    898,
    "Maestros de comercial > Grupos de bodegas > Duplicar"
}, {
    899,
    "Maestros de comercial > Grupos de bodegas > Eliminar"
}, {
    900,
    "Maestros de comercial > Grupos de bodegas > Modificar"
}, {
    901,
    "Maestros de comercial > Grupos de bodegas > Reporte"
}, {
    1403,
    "Maestros > Compañias > Grupos de compañías"
}, {
    1404,
    "Maestros > Compañias > Grupos de compañías > Adicionar"
}, {
    1405,
    "Maestros > Compañias > Grupos de compañías > Consultar"
}, {
    1406,
    "Maestros > Compañias > Grupos de compañías > Duplicar"
}, {
    1407,
    "Maestros > Compañias > Grupos de compañías > Eliminar"
}, {
    1408,
    "Maestros > Compañias > Grupos de compañías > Modificar"
}, {
    1409,
    "Maestros > Compañias > Grupos de compañías > Reporte"
}, {
    1531,
    "Maestros de comercial > Grupos de descuentos"
}, {
    1532,
    "Maestros de comercial > Grupos de descuentos > Adicionar"
}, {
    1533,
    "Maestros de comercial > Grupos de descuentos > Consultar"
}, {
    1534,
    "Maestros de comercial > Grupos de descuentos > Duplicar"
}, {
    1535,
    "Maestros de comercial > Grupos de descuentos > Eliminar"
}, {
    1536,
    "Maestros de comercial > Grupos de descuentos > Modificar"
}, {
    1537,
    "Maestros de comercial > Grupos de descuentos > Reporte"
}, {
    2281,
    "Maestros de comercial > Grupo de motivos de compra"
}, {
    2283,
    "Maestros de comercial > Grupo de motivos de inventario"
}, {
    2302,
    "Maestros de comercial > Grupo de motivos de manufactura"
}, {
    4350,
    "Maestros de comercial > Grupo de motivos de POS central"
}, {
    2282,
    "Maestros de comercial > Grupo de motivos de venta"
}, {
    715,
    "Maestros > Compañias > Configuración de impuestos"
}, {
    740,
    "Maestros > Compañias > Configuración de impuestos > Adicionar"
}, {
    741,
    "Maestros > Compañias > Configuración de impuestos > Consultar"
}, {
    743,
    "Maestros > Compañias > Configuración de impuestos > Duplicar"
}, {
    744,
    "Maestros > Compañias > Configuración de impuestos > Eliminar"
}, {
    742,
    "Maestros > Compañias > Configuración de impuestos > Modificar"
}, {
    745,
    "Maestros > Compañias > Configuración de impuestos > Reporte"
}, {
    710,
    "Maestros > Impuestos y retenciones"
}, {
    1205,
    "Maestros de comercial > Instalaciones"
}, {
    1206,
    "Maestros de comercial > Instalaciones > Adicionar"
}, {
    1207,
    "Maestros de comercial > Instalaciones > Consultar"
}, {
    1208,
    "Maestros de comercial > Instalaciones > Duplicar"
}, {
    1209,
    "Maestros de comercial > Instalaciones > Eliminar"
}, {
    1210,
    "Maestros de comercial > Instalaciones > Modificar"
}, {
    1211,
    "Maestros de comercial > Instalaciones > Reporte"
}, {
    750,
    "Maestros de comercial > Items"
}, {
    773,
    "Maestros de comercial > Items > Adicionar"
}, {
    778,
    "Maestros de comercial > Items > Cambiar código"
}, {
    7951,
    "Maestros de comercial > Items > Cambiar la referencia principal"
}, {
    772,
    "Maestros de comercial > Items > Consultar"
}, {
    3371,
    "Maestros de comercial > Items > Consulta monitor"
}, {
    774,
    "Maestros de comercial > Items > Duplicar"
}, {
    8356,
    "Maestros de comercial > Items > Duplicar instalación"
}, {
    8652,
    "Maestros de comercial > Items > Duplicar > Solicitar nuevas descripciones"
}, {
    776,
    "Maestros de comercial > Items > Eliminar"
}, {
    775,
    "Maestros de comercial > Items > Modificar"
}, {
    3227,
    "Maestros de comercial > Items > Modificar costos"
}, {
    3679,
    "Maestros de comercial > Items > Modificar grupo impositivo"
}, {
    3680,
    "Maestros de comercial > Items > Modificar tipo de inventario"
}, {
    8440,
    "Maestros de comercial > Items > Modificar parámetros"
}, {
    8444,
    "Maestros de comercial > Items > Modificar parámetros > Criterios"
}, {
    8445,
    "Maestros de comercial > Items > Modificar parámetros > Descripciones técnicas"
}, {
    8447,
    "Maestros de comercial > Items > Modificar parámetros > Equivalentes"
}, {
    8448,
    "Maestros de comercial > Items > Modificar parámetros > Fotos"
}, {
    8441,
    "Maestros de comercial > Items > Modificar parámetros > Generales"
}, {
    8443,
    "Maestros de comercial > Items > Modificar parámetros > Parámetros"
}, {
    8449,
    "Maestros de comercial > Items > Modificar parámetros > Posición arancelaria"
}, {
    8446,
    "Maestros de comercial > Items > Modificar parámetros > Referencias alternas"
}, {
    8442,
    "Maestros de comercial > Items > Modificar parámetros > Unidades de medidas"
}, {
    3038,
    "Maestros de comercial > Items monitor"
}, {
    3041,
    "Maestros de comercial > Items monitor > Compras"
}, {
    3047,
    "Maestros de comercial > Items monitor > Inventarios"
}, {
    3046,
    "Maestros de comercial > Items monitor > Manufactura"
}, {
    10524,
    "Maestros de comercial > Items monitor > Planeación"
}, {
    3045,
    "Maestros de comercial > Items monitor > Ventas"
}, {
    11635,
    "Maestros de comercial > Items > Obligar bodega asignación"
}, {
    12262,
    "Maestros de comercial > Items > Permitir factores de peso/volumen en servicios"
}, {
    4476,
    "Maestros de comercial > Items con protocolo"
}, {
    4477,
    "Maestros de comercial > Items con protocolo > Adicionar"
}, {
    4478,
    "Maestros de comercial > Items con protocolo > Consultar"
}, {
    4479,
    "Maestros de comercial > Items con protocolo > Duplicar"
}, {
    4480,
    "Maestros de comercial > Items con protocolo > Eliminar"
}, {
    4481,
    "Maestros de comercial > Items con protocolo > Modificar"
}, {
    4482,
    "Maestros de comercial > Items con protocolo > Reporte"
}, {
    777,
    "Maestros de comercial > Items > Reporte"
}, {
    1427,
    "Maestros de comercial > Items > Sobrecostos"
}, {
    9157,
    "-No implementado > Item para AGL y HI"
}, {
    9158,
    "-No implementado > Item para AGL y HI > Adicionar"
}, {
    9159,
    "-No implementado > Item para AGL y HI > Consultar"
}, {
    9160,
    "-No implementado > Item para AGL y HI > Duplicar"
}, {
    9161,
    "-No implementado > Item para AGL y HI > Eliminar"
}, {
    9162,
    "-No implementado > Item para AGL y HI > Modificar"
}, {
    9163,
    "-No implementado > Item para AGL y HI > Reporte"
}, {
    2273,
    "Maestros de comercial > Kits"
}, {
    2274,
    "Maestros de comercial > Kits > Adicionar"
}, {
    2275,
    "Maestros de comercial > Kits > Consultar"
}, {
    2276,
    "Maestros de comercial > Kits > Duplicar"
}, {
    2277,
    "Maestros de comercial > Kits > Eliminar"
}, {
    2278,
    "Maestros de comercial > Kits > Modificar"
}, {
    2279,
    "Maestros de comercial > Kits > Reporte"
}, {
    749,
    "Maestros de comercial > Listas de precios"
}, {
    767,
    "Maestros de comercial > Listas de precios > Adicionar"
}, {
    766,
    "Maestros de comercial > Listas de precios > Consultar"
}, {
    768,
    "Maestros de comercial > Listas de precios > Duplicar"
}, {
    770,
    "Maestros de comercial > Listas de precios > Eliminar"
}, {
    2241,
    "Maestros de comercial > Listas de precios > Importar"
}, {
    769,
    "Maestros de comercial > Listas de precios > Modificar"
}, {
    771,
    "Maestros de comercial > Listas de precios > Reporte"
}, {
    2348,
    "Maestros de comercial > Listas de precios unomovil"
}, {
    9713,
    "Maestros > Listas restrictivas"
}, {
    9714,
    "Maestros > Listas restrictivas > Maestros asociados"
}, {
    9716,
    "Maestros > Listas restrictivas > Maestros asociados > Listas"
}, {
    9717,
    "Maestros > Listas restrictivas > Maestros asociados > Listas > Adicionar"
}, {
    9718,
    "Maestros > Listas restrictivas > Maestros asociados > Listas > Consultar"
}, {
    9719,
    "Maestros > Listas restrictivas > Maestros asociados > Listas > Duplicar"
}, {
    9720,
    "Maestros > Listas restrictivas > Maestros asociados > Listas > Eliminar"
}, {
    9737,
    "-No implementado > Eliminar fechas"
}, {
    9721,
    "Maestros > Listas restrictivas > Maestros asociados > Listas > Modificar"
}, {
    9722,
    "Maestros > Listas restrictivas > Maestros asociados > Listas > Reporte"
}, {
    9715,
    "Maestros > Listas restrictivas > Consultas"
}, {
    9723,
    "Maestros > Listas restrictivas > Consultas > Listas restrictivas"
}, {
    712,
    "Maestros > Impuestos y retenciones > Llaves de impuestos"
}, {
    722,
    "Maestros > Impuestos y retenciones > Llaves de impuestos > Adicionar"
}, {
    723,
    "Maestros > Impuestos y retenciones > Llaves de impuestos > Consultar"
}, {
    726,
    "Maestros > Impuestos y retenciones > Llaves de impuestos > Duplicar"
}, {
    725,
    "Maestros > Impuestos y retenciones > Llaves de impuestos > Eliminar"
}, {
    724,
    "Maestros > Impuestos y retenciones > Llaves de impuestos > Modificar"
}, {
    727,
    "Maestros > Impuestos y retenciones > Llaves de impuestos > Reporte"
}, {
    714,
    "Maestros > Impuestos y retenciones > Llaves de retención"
}, {
    734,
    "Maestros > Impuestos y retenciones > Llaves de retención > Adicionar"
}, {
    735,
    "Maestros > Impuestos y retenciones > Llaves de retención > Consultar"
}, {
    736,
    "Maestros > Impuestos y retenciones > Llaves de retención > Duplicar"
}, {
    738,
    "Maestros > Impuestos y retenciones > Llaves de retención > Eliminar"
}, {
    737,
    "Maestros > Impuestos y retenciones > Llaves de retención > Modificar"
}, {
    739,
    "Maestros > Impuestos y retenciones > Llaves de retención > Reporte"
}, {
    1315,
    "Maestros de comercial > Lotes"
}, {
    1316,
    "Maestros de comercial > Lotes > Adicionar"
}, {
    1317,
    "Maestros de comercial > Lotes > Eliminar"
}, {
    3392,
    "Maestros de comercial > Lotes > Inactivación"
}, {
    4039,
    "Maestros de comercial > Lotes > Asignar lote automático con fecha actual"
}, {
    1318,
    "Maestros de comercial > Lotes > Modificar"
}, {
    3552,
    "Maestros > Contratos de mandato"
}, {
    3553,
    "Maestros > Contratos de mandato > Adicionar"
}, {
    3554,
    "Maestros > Contratos de mandato > Consultar"
}, {
    3555,
    "Maestros > Contratos de mandato > Duplicar"
}, {
    3556,
    "Maestros > Contratos de mandato > Eliminar"
}, {
    3557,
    "Maestros > Contratos de mandato > Modificar"
}, {
    3732,
    "Maestros > Contratos de mandato > Permitir mandatos sin C.O."
}, {
    3558,
    "Maestros > Contratos de mandato > Reporte"
}, {
    2169,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005"
}, {
    2172,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Conceptos"
}, {
    2179,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Conceptos > Adicionar"
}, {
    2170,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Concepto Auxiliar"
}, {
    2185,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Concepto Auxiliar > Adicionar"
}, {
    2187,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Concepto Auxiliar > Eliminar"
}, {
    2186,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Concepto Auxiliar > Modificar"
}, {
    2180,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Conceptos > Consultar"
}, {
    2181,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Conceptos > Duplicar"
}, {
    2182,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Conceptos > Eliminar"
}, {
    2183,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Conceptos > Modificar"
}, {
    2184,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Conceptos > Reporte"
}, {
    2196,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Equivalencia terceros"
}, {
    2197,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Equivalencia terceros > Adicionar"
}, {
    2198,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Equivalencia terceros > Consultar"
}, {
    2199,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Equivalencia terceros > Eliminar"
}, {
    2200,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Equivalencia terceros > Modificar"
}, {
    2201,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Equivalencia terceros > Reporte"
}, {
    2171,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Grupos"
}, {
    2173,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Grupos > Adicionar"
}, {
    2174,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Grupos > Consultar"
}, {
    2175,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Grupos > Duplicar"
}, {
    2176,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Grupos > Eliminar"
}, {
    2177,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Grupos > Modificar"
}, {
    2178,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Grupos > Reporte"
}, {
    2188,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Proceso"
}, {
    2189,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Proceso > Adicionar"
}, {
    2192,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Proceso > Consultar"
}, {
    2191,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Proceso > Eliminar"
}, {
    2194,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Proceso > Generar"
}, {
    2190,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Proceso > Modificar"
}, {
    2193,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos antes de 2005 > Proceso > Reporte"
}, {
    2202,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Tipos identificación"
}, {
    2203,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Tipos identificación > Adicionar"
}, {
    2204,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Tipos identificación > Consultar"
}, {
    2205,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Tipos identificación > Duplicar"
}, {
    2206,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Tipos identificación > Eliminar"
}, {
    2207,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Tipos identificación > Modificar"
}, {
    2208,
    "Financiero - Contabilidad > Informes a entidades > Medios magnéticos desde 2005 > Tipos identificación > Reporte"
}, {
    31,
    "Maestros > Medios de pago"
}, {
    206,
    "Maestros > Medios de pago > Adicionar"
}, {
    205,
    "Maestros > Medios de pago > Consultar"
}, {
    207,
    "Maestros > Medios de pago > Duplicar"
}, {
    209,
    "Maestros > Medios de pago > Eliminar"
}, {
    208,
    "Maestros > Medios de pago > Modificar"
}, {
    210,
    "Maestros > Medios de pago > Reporte"
}, {
    2333,
    "Maestros de comercial > Mensajes"
}, {
    2334,
    "Maestros de comercial > Mensajes > Adicionar"
}, {
    2336,
    "Maestros de comercial > Mensajes > Eliminar"
}, {
    2335,
    "Maestros de comercial > Mensajes > Modificar"
}, {
    1952,
    "Maestros de manufactura"
}, {
    11160,
    "Maestros de manufactura > Adicionar materias primas y materiales"
}, {
    4645,
    "Maestros de manufactura > Bodegas equivalentes de entrega"
}, {
    4646,
    "Maestros de manufactura > Bodegas equivalentes de entrega > Adicionar"
}, {
    4647,
    "Maestros de manufactura > Bodegas equivalentes de entrega > Consultar"
}, {
    4648,
    "Maestros de manufactura > Bodegas equivalentes de entrega > Eliminar"
}, {
    4649,
    "Maestros de manufactura > Bodegas equivalentes de entrega > Reporte"
}, {
    4521,
    "Maestros de manufactura > Causales de inconsistencias"
}, {
    4522,
    "Maestros de manufactura > Causales de inconsistencias > Adicionar"
}, {
    4523,
    "Maestros de manufactura > Causales de inconsistencias > Consultar"
}, {
    4525,
    "Maestros de manufactura > Causales de inconsistencias > Duplicar"
}, {
    4524,
    "Maestros de manufactura > Causales de inconsistencias > Eliminar"
}, {
    4526,
    "Maestros de manufactura > Causales de inconsistencias > Modificar"
}, {
    4527,
    "Maestros de manufactura > Causales de inconsistencias > Reporte"
}, {
    1993,
    "Maestros de manufactura > Centros de trabajo"
}, {
    1994,
    "Maestros de manufactura > Centros de trabajo > Adicionar"
}, {
    2008,
    "Maestros de manufactura > Centros de trabajo > Cambiar código"
}, {
    1995,
    "Maestros de manufactura > Centros de trabajo > Consultar"
}, {
    2640,
    "Maestros de manufactura > Centros de trabajo > Consultar tarifas"
}, {
    1996,
    "Maestros de manufactura > Centros de trabajo > Duplicar"
}, {
    2639,
    "Maestros de manufactura > Centros de trabajo > Editar tarifas"
}, {
    1997,
    "Maestros de manufactura > Centros de trabajo > Eliminar"
}, {
    1998,
    "Maestros de manufactura > Centros de trabajo > Modificar"
}, {
    1999,
    "Maestros de manufactura > Centros de trabajo > Reporte"
}, {
    2357,
    "Maestros de manufactura > Consultas"
}, {
    2466,
    "Maestros de manufactura > Consultas > Componentes directos"
}, {
    10805,
    "Maestros de manufactura > Consultas > Explosión de materias primas"
}, {
    2467,
    "Maestros de manufactura > Consultas > Indentado"
}, {
    10804,
    "Maestros de manufactura > Consultas > Log de cambios de cantidad"
}, {
    6498,
    "Maestros de manufactura > Consultas > Operaciones por item"
}, {
    3559,
    "Maestros de manufactura > Consultas > Simulación"
}, {
    10051,
    "Maestros de manufactura > Consultas > Simulación colectiva"
}, {
    10052,
    "Maestros de manufactura > Consultas > Simulación colectiva > Captura"
}, {
    10053,
    "Maestros de manufactura > Consultas > Simulación colectiva > Ejecución"
}, {
    10054,
    "Maestros de manufactura > Consultas > Simulación colectiva > Captura > Adicionar"
}, {
    10055,
    "Maestros de manufactura > Consultas > Simulación colectiva > Captura > Anular"
}, {
    10056,
    "Maestros de manufactura > Consultas > Simulación colectiva > Captura > Aprobar"
}, {
    10057,
    "Maestros de manufactura > Consultas > Simulación colectiva > Captura > Consultar"
}, {
    10060,
    "Maestros de manufactura > Consultas > Simulación colectiva > Captura > Modificar"
}, {
    10058,
    "Maestros de manufactura > Consultas > Simulación colectiva > Captura > Desaprobar"
}, {
    10059,
    "Maestros de manufactura > Consultas > Simulación colectiva > Captura > Eliminar movimiento"
}, {
    2358,
    "Maestros de manufactura > Consultas > Items manufacturados"
}, {
    2360,
    "Maestros de manufactura > Consultas > Items obsoletos"
}, {
    2359,
    "Maestros de manufactura > Consultas > Materias primas y materiales"
}, {
    2361,
    "Maestros de manufactura > Consultas > Usos por item"
}, {
    3142,
    "Maestros de manufactura > Fechas"
}, {
    3158,
    "Maestros de manufactura > Fechas > Doctos manufactura"
}, {
    3143,
    "Maestros de manufactura > Fechas > Doctos manufactura > Activar fecha"
}, {
    3144,
    "Maestros de manufactura > Fechas > Doctos manufactura > Cerrar fecha"
}, {
    1972,
    "Costos > Grupos de costos"
}, {
    1973,
    "Costos > Grupos de costos > Adicionar"
}, {
    1974,
    "Costos > Grupos de costos > Consultar"
}, {
    1975,
    "Costos > Grupos de costos > Duplicar"
}, {
    1976,
    "Costos > Grupos de costos > Eliminar"
}, {
    1977,
    "Costos > Grupos de costos > Modificar"
}, {
    1978,
    "Costos > Grupos de costos > Reporte"
}, {
    2098,
    "Maestros de manufactura > Lista de materiales"
}, {
    2099,
    "Maestros de manufactura > Lista de materiales > Adicionar"
}, {
    3446,
    "Maestros de manufactura > Lista de materiales > Cambiar materias primas y materiales"
}, {
    2100,
    "Maestros de manufactura > Lista de materiales > Consultar"
}, {
    2101,
    "Maestros de manufactura > Lista de materiales > Duplicar"
}, {
    4859,
    "Maestros de manufactura > Lista de materiales > Duplicar parcialmente"
}, {
    2102,
    "Maestros de manufactura > Lista de materiales > Eliminar"
}, {
    6495,
    "Maestros de manufactura > Lista de materiales > Eliminar materias primas y materiales"
}, {
    2103,
    "Maestros de manufactura > Lista de materiales > Modificar"
}, {
    4829,
    "Maestros de manufactura > Lista de materiales > Mostrar jerarquia"
}, {
    2105,
    "Maestros de manufactura > Lista de materiales > Nivelar"
}, {
    2104,
    "Maestros de manufactura > Lista de materiales > Reporte"
}, {
    2000,
    "Maestros de manufactura > Maquinas"
}, {
    2001,
    "Maestros de manufactura > Maquinas > Adicionar"
}, {
    2009,
    "Maestros de manufactura > Maquinas > Cambiar código"
}, {
    2002,
    "Maestros de manufactura > Maquinas > Consultar"
}, {
    2003,
    "Maestros de manufactura > Maquinas > Duplicar"
}, {
    2004,
    "Maestros de manufactura > Maquinas > Eliminar"
}, {
    2005,
    "Maestros de manufactura > Maquinas > Modificar"
}, {
    2006,
    "Maestros de manufactura > Maquinas > Reporte"
}, {
    1953,
    "Maestros de manufactura > Métodos"
}, {
    1955,
    "Maestros de manufactura > Métodos > Adicionar"
}, {
    1956,
    "Maestros de manufactura > Métodos > Consultar"
}, {
    1957,
    "Maestros de manufactura > Métodos > Duplicar"
}, {
    1958,
    "Maestros de manufactura > Métodos > Eliminar"
}, {
    1959,
    "Maestros de manufactura > Métodos > Modificar"
}, {
    1960,
    "Maestros de manufactura > Métodos > Reporte"
}, {
    2313,
    "Maestros de manufactura > Periodos MRP"
}, {
    2314,
    "Maestros de manufactura > Periodos MRP > Adicionar"
}, {
    2315,
    "Maestros de manufactura > Periodos MRP > Consultar"
}, {
    2316,
    "Maestros de manufactura > Periodos MRP > Duplicar"
}, {
    2317,
    "Maestros de manufactura > Periodos MRP > Eliminar"
}, {
    2318,
    "Maestros de manufactura > Periodos MRP > Modificar"
}, {
    2319,
    "Maestros de manufactura > Periodos MRP > Reporte"
}, {
    4202,
    "Maestros de manufactura > Piezas"
}, {
    4203,
    "Maestros de manufactura > Piezas > Adicionar"
}, {
    4204,
    "Maestros de manufactura > Piezas > Cambiar código"
}, {
    4205,
    "Maestros de manufactura > Piezas > Consultar"
}, {
    4206,
    "Maestros de manufactura > Piezas > Duplicar"
}, {
    4207,
    "Maestros de manufactura > Piezas > Eliminar"
}, {
    4208,
    "Maestros de manufactura > Piezas > Modificar"
}, {
    4209,
    "Maestros de manufactura > Piezas > Reporte"
}, {
    2066,
    "Maestros de manufactura > Rutas"
}, {
    2067,
    "Maestros de manufactura > Rutas > Adicionar"
}, {
    2068,
    "Maestros de manufactura > Rutas > Consultar"
}, {
    2069,
    "Maestros de manufactura > Rutas > Duplicar"
}, {
    2070,
    "Maestros de manufactura > Rutas > Eliminar"
}, {
    2071,
    "Maestros de manufactura > Rutas > Modificar"
}, {
    2073,
    "Maestros de manufactura > Rutas - operación"
}, {
    2074,
    "Maestros de manufactura > Rutas - operación > Adicionar"
}, {
    2075,
    "Maestros de manufactura > Rutas - operación > Consultar"
}, {
    2076,
    "Maestros de manufactura > Rutas - operación > Eliminar"
}, {
    2077,
    "Maestros de manufactura > Rutas - operación > Modificar"
}, {
    2078,
    "Maestros de manufactura > Rutas - operación > Reporte"
}, {
    2072,
    "Maestros de manufactura > Rutas > Reporte"
}, {
    3524,
    "Maestros de manufactura > Seguimiento"
}, {
    1979,
    "Costos > Segmentos de costos"
}, {
    1980,
    "Costos > Segmentos de costos > Adicionar"
}, {
    1981,
    "Costos > Segmentos de costos > Consultar"
}, {
    1982,
    "Costos > Segmentos de costos > Duplicar"
}, {
    1983,
    "Costos > Segmentos de costos > Eliminar"
}, {
    1984,
    "Costos > Segmentos de costos > Modificar"
}, {
    1985,
    "Costos > Segmentos de costos > Reporte"
}, {
    3525,
    "Maestros de manufactura > Seguimiento > Control de piso"
}, {
    3526,
    "Maestros de manufactura > Seguimiento > Control de piso > Adicionar"
}, {
    3527,
    "Maestros de manufactura > Seguimiento > Control de piso > Consultar"
}, {
    3528,
    "Maestros de manufactura > Seguimiento > Control de piso > Duplicar"
}, {
    3529,
    "Maestros de manufactura > Seguimiento > Control de piso > Eliminar"
}, {
    3530,
    "Maestros de manufactura > Seguimiento > Control de piso > Modificar"
}, {
    3531,
    "Maestros de manufactura > Seguimiento > Control de piso > Reporte"
}, {
    11886,
    "Maestros de manufactura > Tabla de muestreo"
}, {
    11887,
    "Maestros de manufactura > Tabla de muestreo > Adicionar"
}, {
    11888,
    "Maestros de manufactura > Tabla de muestreo > Consultar"
}, {
    11889,
    "Maestros de manufactura > Tabla de muestreo > Duplicar"
}, {
    11890,
    "Maestros de manufactura > Tabla de muestreo > Eliminar"
}, {
    11891,
    "Maestros de manufactura > Tabla de muestreo > Modificar"
}, {
    11892,
    "Maestros de manufactura > Tabla de muestreo > Reporte"
}, {
    33,
    "Maestros > Monedas"
}, {
    220,
    "Maestros > Monedas > Adicionar"
}, {
    219,
    "Maestros > Monedas > Consultar"
}, {
    221,
    "Maestros > Monedas > Duplicar"
}, {
    223,
    "Maestros > Monedas > Eliminar"
}, {
    222,
    "Maestros > Monedas > Modificar"
}, {
    224,
    "Maestros > Monedas > Reporte"
}, {
    1807,
    "Maestros > Motivos de activos fijos"
}, {
    1808,
    "Maestros > Motivos de activos fijos > Adicionar"
}, {
    1809,
    "Maestros > Motivos de activos fijos > Consultar"
}, {
    1810,
    "Maestros > Motivos de activos fijos > Eliminar"
}, {
    1811,
    "Maestros > Motivos de activos fijos > Modificar"
}, {
    1812,
    "Maestros > Motivos de activos fijos > Reporte"
}, {
    6421,
    "Maestros > Terceros > Motivos de bloqueo"
}, {
    6500,
    "Maestros > Terceros > Motivos de bloqueo > Adicionar"
}, {
    6501,
    "Maestros > Terceros > Motivos de bloqueo > Consultar"
}, {
    6502,
    "Maestros > Terceros > Motivos de bloqueo > Duplicar"
}, {
    6503,
    "Maestros > Terceros > Motivos de bloqueo > Eliminar"
}, {
    6504,
    "Maestros > Terceros > Motivos de bloqueo > Modificar"
}, {
    6505,
    "Maestros > Terceros > Motivos de bloqueo > Reporte"
}, {
    1813,
    "Maestros de comercial > Motivos de compra"
}, {
    1814,
    "Maestros de comercial > Motivos de compra > Adicionar"
}, {
    1815,
    "Maestros de comercial > Motivos de compra > Consultar"
}, {
    1816,
    "Maestros de comercial > Motivos de compra > Eliminar"
}, {
    1817,
    "Maestros de comercial > Motivos de compra > Modificar"
}, {
    1818,
    "Maestros de comercial > Motivos de compra > Reporte"
}, {
    862,
    "Maestros > Motivos de compra de servicios"
}, {
    863,
    "Maestros > Motivos de compra de servicios > Adicionar"
}, {
    865,
    "Maestros > Motivos de compra de servicios > Consultar"
}, {
    864,
    "Maestros > Motivos de compra de servicios > Eliminar"
}, {
    868,
    "Maestros > Motivos de compra de servicios > Modificar"
}, {
    867,
    "Maestros > Motivos de compra de servicios > Reporte"
}, {
    12019,
    "Maestros > Motivos de contabilidad"
}, {
    12020,
    "Maestros > Motivos de contabilidad > Adicionar"
}, {
    12021,
    "Maestros > Motivos de contabilidad > Consultar"
}, {
    12022,
    "Maestros > Motivos de contabilidad > Eliminar"
}, {
    12023,
    "Maestros > Motivos de contabilidad > Modificar"
}, {
    12024,
    "Maestros > Motivos de contabilidad > Reporte"
}, {
    8473,
    "Maestros > Motivos de CXC"
}, {
    8474,
    "Maestros > Motivos de CXC > Adicionar"
}, {
    8475,
    "Maestros > Motivos de CXC > Consultar"
}, {
    8476,
    "Maestros > Motivos de CXC > Eliminar"
}, {
    8477,
    "Maestros > Motivos de CXC > Modificar"
}, {
    8478,
    "Maestros > Motivos de CXC > Reporte"
}, {
    8479,
    "Maestros > Motivos de CXP"
}, {
    8480,
    "Maestros > Motivos de CXP > Adicionar"
}, {
    8481,
    "Maestros > Motivos de CXP > Consultar"
}, {
    8482,
    "Maestros > Motivos de CXP > Eliminar"
}, {
    8483,
    "Maestros > Motivos de CXP > Modificar"
}, {
    8484,
    "Maestros > Motivos de CXP > Reporte"
}, {
    1825,
    "Maestros de comercial > Motivos de inventario"
}, {
    1826,
    "Maestros de comercial > Motivos de inventario > Adicionar"
}, {
    1827,
    "Maestros de comercial > Motivos de inventario > Consultar"
}, {
    1828,
    "Maestros de comercial > Motivos de inventario > Eliminar"
}, {
    1829,
    "Maestros de comercial > Motivos de inventario > Modificar"
}, {
    1830,
    "Maestros de comercial > Motivos de inventario > Reporte"
}, {
    1831,
    "Maestros de comercial > Motivos de manufactura"
}, {
    1832,
    "Maestros de comercial > Motivos de manufactura > Adicionar"
}, {
    1833,
    "Maestros de comercial > Motivos de manufactura > Consultar"
}, {
    1834,
    "Maestros de comercial > Motivos de manufactura > Eliminar"
}, {
    1835,
    "Maestros de comercial > Motivos de manufactura > Modificar"
}, {
    1836,
    "Maestros de comercial > Motivos de manufactura > Reporte"
}, {
    4217,
    "Maestros de comercial > Motivos de POS central"
}, {
    4218,
    "Maestros de comercial > Motivos de POS central > Adicionar"
}, {
    4219,
    "Maestros de comercial > Motivos de POS central > Consultar"
}, {
    4220,
    "Maestros de comercial > Motivos de POS central > Eliminar"
}, {
    4221,
    "Maestros de comercial > Motivos de POS central > Modificar"
}, {
    4222,
    "Maestros de comercial > Motivos de POS central > Reporte"
}, {
    1819,
    "Maestros de comercial > Motivos de venta"
}, {
    1820,
    "Maestros de comercial > Motivos de venta > Adicionar"
}, {
    1821,
    "Maestros de comercial > Motivos de venta > Consultar"
}, {
    1822,
    "Maestros de comercial > Motivos de venta > Eliminar"
}, {
    1823,
    "Maestros de comercial > Motivos de venta > Modificar"
}, {
    1824,
    "Maestros de comercial > Motivos de venta > Reporte"
}, {
    1801,
    "Maestros > Motivos de venta de servicios"
}, {
    1802,
    "Maestros > Motivos de venta de servicios > Adicionar"
}, {
    1803,
    "Maestros > Motivos de venta de servicios > Consultar"
}, {
    1804,
    "Maestros > Motivos de venta de servicios > Eliminar"
}, {
    1805,
    "Maestros > Motivos de venta de servicios > Modificar"
}, {
    1806,
    "Maestros > Motivos de venta de servicios > Reporte"
}, {
    4628,
    "Maestros de comercial > Otros motivos de compra"
}, {
    4629,
    "Maestros de comercial > Otros motivos de compra > Adicionar"
}, {
    4630,
    "Maestros de comercial > Otros motivos de compra > Consultar"
}, {
    4631,
    "Maestros de comercial > Otros motivos de compra > Eliminar"
}, {
    4651,
    "Maestros de comercial > Otros motivos de compra > Modificar"
}, {
    4632,
    "Maestros de comercial > Otros motivos de compra > Reporte"
}, {
    4633,
    "Maestros de comercial > Otros motivos de venta"
}, {
    4634,
    "Maestros de comercial > Otros motivos de venta > Adicionar"
}, {
    4635,
    "Maestros de comercial > Otros motivos de venta > Consultar"
}, {
    4636,
    "Maestros de comercial > Otros motivos de venta > Eliminar"
}, {
    4652,
    "Maestros de comercial > Otros motivos de venta > Modificar"
}, {
    4637,
    "Maestros de comercial > Otros motivos de venta > Reporte"
}, {
    1212,
    "Maestros > Tabla PAAG"
}, {
    43,
    "Maestros > Países, deptos, ciudades y barrios > Países"
}, {
    268,
    "Maestros > Países, deptos, ciudades y barrios > Países > Adicionar"
}, {
    267,
    "Maestros > Países, deptos, ciudades y barrios > Países > Consultar"
}, {
    42,
    "Maestros > Países, deptos, ciudades y barrios"
}, {
    269,
    "Maestros > Países, deptos, ciudades y barrios > Países > Duplicar"
}, {
    271,
    "Maestros > Países, deptos, ciudades y barrios > Países > Eliminar"
}, {
    270,
    "Maestros > Países, deptos, ciudades y barrios > Países > Modificar"
}, {
    272,
    "Maestros > Países, deptos, ciudades y barrios > Países > Reporte"
}, {
    3921,
    "Maestros de comercial > Paquetes"
}, {
    3922,
    "Maestros de comercial > Paquetes > Adicionar"
}, {
    3923,
    "Maestros de comercial > Paquetes > Consultar"
}, {
    3924,
    "Maestros de comercial > Paquetes > Duplicar"
}, {
    3925,
    "Maestros de comercial > Paquetes > Eliminar"
}, {
    3926,
    "Maestros de comercial > Paquetes > Modificar"
}, {
    3927,
    "Maestros de comercial > Paquetes > Reporte"
}, {
    746,
    "Maestros de comercial > Parámetros comerciales"
}, {
    751,
    "Maestros de comercial > Parámetros comerciales > Consultar"
}, {
    752,
    "Maestros de comercial > Parámetros comerciales > Modificar"
}, {
    753,
    "Maestros de comercial > Parámetros comerciales > Reporte"
}, {
    7563,
    "Maestros > Parámetros generales"
}, {
    7565,
    "Maestros > Parámetros generales > Consultar"
}, {
    7564,
    "Maestros > Parámetros generales > Modificar"
}, {
    4868,
    "Maestros de comercial > Parametros de aprobación"
}, {
    4869,
    "Maestros de comercial > Parametros de aprobación > Adicionar"
}, {
    4870,
    "Maestros de comercial > Parametros de aprobación > Consultar"
}, {
    4871,
    "Maestros de comercial > Parametros de aprobación > Duplicar"
}, {
    4872,
    "Maestros de comercial > Parametros de aprobación > Eliminar"
}, {
    4873,
    "Maestros de comercial > Parametros de aprobación > Modificar"
}, {
    4874,
    "Maestros de comercial > Parametros de aprobación > Reporte"
}, {
    4830,
    "Maestros > Documentos > Parámetros de certificación fiscal"
}, {
    4831,
    "Maestros > Documentos > Parámetros de certificación fiscal > Adicionar"
}, {
    4832,
    "Maestros > Documentos > Parámetros de certificación fiscal > Consultar"
}, {
    4833,
    "Maestros > Documentos > Parámetros de certificación fiscal > Duplicar"
}, {
    4834,
    "Maestros > Documentos > Parámetros de certificación fiscal > Eliminar"
}, {
    4835,
    "Maestros > Documentos > Parámetros de certificación fiscal > Modificar"
}, {
    4836,
    "Maestros > Documentos > Parámetros de certificación fiscal > Reporte"
}, {
    2337,
    "Maestros de comercial > Parámetros Vendedores Unomovil"
}, {
    2338,
    "Maestros de comercial > Parámetros Vendedores Unomovil > Adicionar"
}, {
    2339,
    "Maestros de comercial > Parámetros Vendedores Unomovil > Consultar"
}, {
    2340,
    "Maestros de comercial > Parámetros Vendedores Unomovil > Duplicar"
}, {
    2341,
    "Maestros de comercial > Parámetros Vendedores Unomovil > Eliminar"
}, {
    2342,
    "Maestros de comercial > Parámetros Vendedores Unomovil > Modificar"
}, {
    2343,
    "Maestros de comercial > Parámetros Vendedores Unomovil > Reporte"
}, {
    3,
    "Financiero - Contabilidad > Procesos periódicos > Periodos > Períodos"
}, {
    57,
    "Financiero - Contabilidad > Procesos periódicos > Periodos > Períodos > Adicionar"
}, {
    56,
    "Financiero - Contabilidad > Procesos periódicos > Periodos > Períodos > Consultar"
}, {
    60,
    "Financiero - Contabilidad > Procesos periódicos > Periodos > Períodos > Eliminar"
}, {
    59,
    "Financiero - Contabilidad > Procesos periódicos > Periodos > Períodos > Modificar"
}, {
    61,
    "Financiero - Contabilidad > Procesos periódicos > Periodos > Períodos > Imprimir"
}, {
    6954,
    "Maestros > Plantillas de pago"
}, {
    6955,
    "Maestros > Plantillas de pago > Adicionar"
}, {
    6956,
    "Maestros > Plantillas de pago > Consultar"
}, {
    6957,
    "Maestros > Plantillas de pago > Dupliar"
}, {
    6958,
    "Maestros > Plantillas de pago > Eliminar"
}, {
    6959,
    "Maestros > Plantillas de pago > Modificar"
}, {
    6960,
    "Maestros > Plantillas de pago > Reporte"
}, {
    2326,
    "Maestros de comercial > Portafolio"
}, {
    2327,
    "Maestros de comercial > Portafolio > Adicionar"
}, {
    12594,
    "Maestros de comercial > Portafolio asignar clientes"
}, {
    12595,
    "Maestros de comercial > Portafolio cambiar estado"
}, {
    2328,
    "Maestros de comercial > Portafolio > Consultar"
}, {
    6357,
    "Maestros de comercial > Portafolio > Permitir consultar log"
}, {
    2329,
    "Maestros de comercial > Portafolio > Duplicar"
}, {
    2330,
    "Maestros de comercial > Portafolio > Eliminar"
}, {
    2331,
    "Maestros de comercial > Portafolio > Modificar"
}, {
    2332,
    "Maestros de comercial > Portafolio > Reporte"
}, {
    664,
    "Maestros de comercial > Posiciones arancelarias"
}, {
    666,
    "Maestros de comercial > Posiciones arancelarias > Adicionar"
}, {
    665,
    "Maestros de comercial > Posiciones arancelarias > Consultar"
}, {
    667,
    "Maestros de comercial > Posiciones arancelarias > Duplicar"
}, {
    669,
    "Maestros de comercial > Posiciones arancelarias > Eliminar"
}, {
    668,
    "Maestros de comercial > Posiciones arancelarias > Modificar"
}, {
    670,
    "Maestros de comercial > Posiciones arancelarias > Reporte"
}, {
    4469,
    "Maestros de comercial > Precios de trazabilidad"
}, {
    4470,
    "Maestros de comercial > Precios de trazabilidad > Adicionar"
}, {
    4471,
    "Maestros de comercial > Precios de trazabilidad > Consultar"
}, {
    4472,
    "Maestros de comercial > Precios de trazabilidad > Duplicar"
}, {
    4473,
    "Maestros de comercial > Precios de trazabilidad > Eliminar"
}, {
    4474,
    "Maestros de comercial > Precios de trazabilidad > Modificar"
}, {
    4493,
    "Maestros de comercial > Precios de trazabilidad > Reporte"
}, {
    1538,
    "Maestros de comercial > Descuentos y promociones"
}, {
    1539,
    "Maestros de comercial > Descuentos y promociones > Adicionar"
}, {
    1545,
    "Maestros de comercial > Descuentos y promociones > Cambiar código"
}, {
    3393,
    "Maestros de comercial > Descuentos y promociones > Consulta descuentos y promociones"
}, {
    1540,
    "Maestros de comercial > Descuentos y promociones > Consultar"
}, {
    4822,
    "Maestros de comercial > Descuentos y promociones > Consultar liquidación"
}, {
    1541,
    "Maestros de comercial > Descuentos y promociones > Duplicar"
}, {
    1542,
    "Maestros de comercial > Descuentos y promociones > Eliminar"
}, {
    3497,
    "Maestros de comercial > Descuentos y promociones > Manejar listas de precios"
}, {
    3499,
    "Maestros de comercial > Descuentos y promociones > Manejar liquidacion de servicios"
}, {
    1543,
    "Maestros de comercial > Descuentos y promociones > Modificar"
}, {
    1544,
    "Maestros de comercial > Descuentos y promociones > Reporte"
}, {
    3207,
    "Maestros > Pronto Pago"
}, {
    3208,
    "Maestros > Pronto Pago > Adicionar"
}, {
    3209,
    "Maestros > Pronto Pago > Cambiar código"
}, {
    3210,
    "Maestros > Pronto Pago > Consultar"
}, {
    3211,
    "Maestros > Pronto Pago > Duplicar"
}, {
    3212,
    "Maestros > Pronto Pago > Eliminar"
}, {
    3213,
    "Maestros > Pronto Pago > Modificar"
}, {
    3214,
    "Maestros > Pronto Pago > Reporte"
}, {
    1344,
    "Maestros de comercial > Proyectos"
}, {
    1345,
    "Maestros de comercial > Proyectos > Adicionar"
}, {
    12589,
    "Maestros de comercial > Proyectos > Cambiar de fechas"
}, {
    12188,
    "Comercial - Control de proyectos > Gestión de proyectos > Centro de operación"
}, {
    12189,
    "Comercial - Control de proyectos > Gestión de proyectos > Centro de operación > Adicionar"
}, {
    12190,
    "Comercial - Control de proyectos > Gestión de proyectos > Centro de operación > Eliminar"
}, {
    12191,
    "Comercial - Control de proyectos > Gestión de proyectos > Centro de operación > Modificar"
}, {
    1346,
    "Maestros de comercial > Proyectos > Consultar"
}, {
    1347,
    "Maestros de comercial > Proyectos > Duplicar"
}, {
    1348,
    "Maestros de comercial > Proyectos > Eliminar"
}, {
    1349,
    "Maestros de comercial > Proyectos > Modificar"
}, {
    1350,
    "Maestros de comercial > Proyectos > Reporte"
}, {
    12192,
    "Comercial - Control de proyectos > Gestión de proyectos > Responsables"
}, {
    12193,
    "Comercial - Control de proyectos > Gestión de proyectos > Responsables > Adicionar"
}, {
    12194,
    "Comercial - Control de proyectos > Gestión de proyectos > Responsables > Eliminar"
}, {
    12195,
    "Comercial - Control de proyectos > Gestión de proyectos > Responsables > Modificar"
}, {
    25,
    "Maestros > Regionales"
}, {
    165,
    "Maestros > Regionales > Adicionar"
}, {
    164,
    "Maestros > Regionales > Consultar"
}, {
    166,
    "Maestros > Regionales > Duplicar"
}, {
    168,
    "Maestros > Regionales > Eliminar"
}, {
    167,
    "Maestros > Regionales > Modificar"
}, {
    169,
    "Maestros > Regionales > Reporte"
}, {
    11194,
    "Maestros > Terceros > Replicar tercero en otras compañías"
}, {
    10828,
    "Maestros > Resoluciones Guatemala"
}, {
    10835,
    "Maestros > Resoluciones Guatemala > Activar"
}, {
    10829,
    "Maestros > Resoluciones Guatemala > Adicionar"
}, {
    10830,
    "Maestros > Resoluciones Guatemala > Consultar"
}, {
    10831,
    "Maestros > Resoluciones Guatemala > Duplicar"
}, {
    10832,
    "Maestros > Resoluciones Guatemala > Eliminar"
}, {
    10833,
    "Maestros > Resoluciones Guatemala > Modificar"
}, {
    10834,
    "Maestros > Resoluciones Guatemala > Reporte"
}, {
    1929,
    "Maestros > Rubros presupuestales"
}, {
    1944,
    "Maestros > Rubros presupuestales > Auxiliares"
}, {
    1945,
    "Maestros > Rubros presupuestales > Auxiliares > Adicionar"
}, {
    1946,
    "Maestros > Rubros presupuestales > Auxiliares > Cambiar código"
}, {
    1947,
    "Maestros > Rubros presupuestales > Auxiliares > Consultar"
}, {
    1948,
    "Maestros > Rubros presupuestales > Auxiliares > Duplicar"
}, {
    1949,
    "Maestros > Rubros presupuestales > Auxiliares > Eliminar"
}, {
    1950,
    "Maestros > Rubros presupuestales > Auxiliares > Modificar"
}, {
    1951,
    "Maestros > Rubros presupuestales > Auxiliares > Reporte"
}, {
    1930,
    "Maestros > Rubros presupuestales > Mayores"
}, {
    1932,
    "Maestros > Rubros presupuestales > Mayores > Adicionar"
}, {
    1933,
    "Maestros > Rubros presupuestales > Mayores > Consultar"
}, {
    1934,
    "Maestros > Rubros presupuestales > Mayores > Duplicar"
}, {
    1935,
    "Maestros > Rubros presupuestales > Mayores > Eliminar"
}, {
    1936,
    "Maestros > Rubros presupuestales > Mayores > Modificar"
}, {
    1937,
    "Maestros > Rubros presupuestales > Mayores > Reporte"
}, {
    1931,
    "Maestros > Rubros presupuestales > Planes"
}, {
    1938,
    "Maestros > Rubros presupuestales > Planes > Adicionar"
}, {
    1939,
    "Maestros > Rubros presupuestales > Planes > Consultar"
}, {
    1940,
    "Maestros > Rubros presupuestales > Planes > Duplicar"
}, {
    1941,
    "Maestros > Rubros presupuestales > Planes > Eliminar"
}, {
    1942,
    "Maestros > Rubros presupuestales > Planes > Modificar"
}, {
    1943,
    "Maestros > Rubros presupuestales > Planes > Reporte"
}, {
    3172,
    "Maestros > Seguimiento"
}, {
    3173,
    "Maestros > Seguimiento > Cuentas por cobrar"
}, {
    3175,
    "Maestros > Seguimiento > Cuentas por cobrar > Adicionar"
}, {
    3176,
    "Maestros > Seguimiento > Cuentas por cobrar > Consultar"
}, {
    3177,
    "Maestros > Seguimiento > Cuentas por cobrar > Duplicar"
}, {
    3178,
    "Maestros > Seguimiento > Cuentas por cobrar > Eliminar"
}, {
    3179,
    "Maestros > Seguimiento > Cuentas por cobrar > Modificar"
}, {
    3180,
    "Maestros > Seguimiento > Cuentas por cobrar > Reporte"
}, {
    3174,
    "Maestros > Seguimiento > Cuentas por pagar"
}, {
    3181,
    "Maestros > Seguimiento > Cuentas por pagar > Adicionar"
}, {
    3182,
    "Maestros > Seguimiento > Cuentas por pagar > Consultar"
}, {
    3183,
    "Maestros > Seguimiento > Cuentas por pagar > Duplicar"
}, {
    3184,
    "Maestros > Seguimiento > Cuentas por pagar > Eliminar"
}, {
    3185,
    "Maestros > Seguimiento > Cuentas por pagar > Modificar"
}, {
    3186,
    "Maestros > Seguimiento > Cuentas por pagar > Reporte"
}, {
    2937,
    "Maestros de comercial > Seriales"
}, {
    2938,
    "Maestros de comercial > Seriales > Adicionar"
}, {
    10026,
    "Maestros de comercial > Seriales > Permitir cambiar el próximo consecutivo"
}, {
    3696,
    "Maestros de comercial > Seriales > Conservar el ítem al salvar"
}, {
    2939,
    "Maestros de comercial > Seriales > Consultar"
}, {
    2940,
    "Maestros de comercial > Seriales > Eliminar"
}, {
    2941,
    "Maestros de comercial > Seriales > Modificar"
}, {
    3694,
    "Maestros de comercial > Seriales > Múltiples"
}, {
    2942,
    "Maestros de comercial > Seriales > Reporte"
}, {
    3697,
    "Maestros de comercial > Seriales > Seguimiento"
}, {
    3698,
    "Maestros de comercial > Seriales > Seguimiento > Consulta"
}, {
    3699,
    "Maestros de comercial > Seriales > Seguimiento > Eventos"
}, {
    3700,
    "Maestros de comercial > Seriales > Seguimiento > Eventos > Adicionar"
}, {
    3701,
    "Maestros de comercial > Seriales > Seguimiento > Eventos > Consultar"
}, {
    3702,
    "Maestros de comercial > Seriales > Seguimiento > Eventos > Duplicar"
}, {
    3703,
    "Maestros de comercial > Seriales > Seguimiento > Eventos > Eliminar"
}, {
    3704,
    "Maestros de comercial > Seriales > Seguimiento > Eventos > Modificar"
}, {
    3705,
    "Maestros de comercial > Seriales > Seguimiento > Eventos > Reporte"
}, {
    967,
    "Maestros > Servicios"
}, {
    968,
    "Maestros > Servicios > Adicionar"
}, {
    969,
    "Maestros > Servicios > Consultar"
}, {
    970,
    "Maestros > Servicios > Duplicar"
}, {
    971,
    "Maestros > Servicios > Eliminar"
}, {
    972,
    "Maestros > Servicios > Modificar"
}, {
    973,
    "Maestros > Servicios > Reporte"
}, {
    2619,
    "Maestros > Servicios intereses por mora"
}, {
    1579,
    "Maestros > Supervalores"
}, {
    1668,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria"
}, {
    1734,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Cartera castigada"
}, {
    1735,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Cartera castigada > Adicionar"
}, {
    1738,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Cartera castigada > Consultar"
}, {
    1737,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Cartera castigada > Eliminar"
}, {
    1741,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Cartera castigada > Generar"
}, {
    1740,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Cartera castigada > Limpiar"
}, {
    1736,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Cartera castigada > Modificar"
}, {
    1739,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Cartera castigada > Reporte"
}, {
    1684,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > CIIU"
}, {
    1696,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > CIIU > Adicionar"
}, {
    1697,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > CIIU > Consultar"
}, {
    1698,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > CIIU > Duplicar"
}, {
    1699,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > CIIU > Eliminar"
}, {
    1714,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > CIIU > Modificar"
}, {
    1700,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > CIIU > Reporte"
}, {
    1726,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Composición accionaria"
}, {
    1727,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Composición accionaria > Adicionar"
}, {
    1730,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Composición accionaria > Consultar"
}, {
    1729,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Composición accionaria > Eliminar"
}, {
    1733,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Composición accionaria > Generar"
}, {
    1732,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Composición accionaria > Limpiar"
}, {
    1728,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Composición accionaria > Modificar"
}, {
    1731,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Composición accionaria > Reporte"
}, {
    1718,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Contabilidad"
}, {
    1719,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Contabilidad > Adicionar"
}, {
    1721,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Contabilidad > Consultar"
}, {
    1722,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Contabilidad > Eliminar"
}, {
    1724,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Contabilidad > Generar"
}, {
    1725,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Contabilidad > Limpiar"
}, {
    1720,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Contabilidad > Modificar"
}, {
    1723,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Contabilidad > Reporte"
}, {
    1685,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Entidades"
}, {
    1691,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Entidades > Adicionar"
}, {
    1692,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Entidades > Consultar"
}, {
    1693,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Entidades > Duplicar"
}, {
    1694,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Entidades > Eliminar"
}, {
    1715,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Entidades > Modificar"
}, {
    1695,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Entidades > Reporte"
}, {
    1742,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Evaluación de cartera"
}, {
    1743,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Evaluación de cartera > Adicionar"
}, {
    1745,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Evaluación de cartera > Consultar"
}, {
    1746,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Evaluación de cartera > Eliminar"
}, {
    1747,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Evaluación de cartera > Generar"
}, {
    1748,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Evaluación de cartera > Limpiar"
}, {
    1744,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Evaluación de cartera > Modificar"
}, {
    1749,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Evaluación de cartera > Reporte"
}, {
    1707,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Fideicomisos"
}, {
    1708,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Fideicomisos > Adicionar"
}, {
    1709,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Fideicomisos > Consultar"
}, {
    1710,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Fideicomisos > Duplicar"
}, {
    1711,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Fideicomisos > Eliminar"
}, {
    1712,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Fideicomisos > Modificar"
}, {
    1713,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Fideicomisos > Reporte"
}, {
    1669,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Formatos"
}, {
    1670,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Estructuras de formatos"
}, {
    1677,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Estructuras de formatos > Adicionar"
}, {
    1678,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Estructuras de formatos > Consultar"
}, {
    1680,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Estructuras de formatos > Eliminar"
}, {
    1681,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Estructuras de formatos > Modificar"
}, {
    1671,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Formatos > Adicionar"
}, {
    1672,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Formatos > Consultar"
}, {
    1673,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Formatos > Duplicar"
}, {
    1674,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Formatos > Eliminar"
}, {
    1675,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Formatos > Modificar"
}, {
    1676,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Formatos > Reporte"
}, {
    1683,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Naciones"
}, {
    1686,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Naciones > Adicionar"
}, {
    1687,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Naciones > Consultar"
}, {
    1688,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Naciones > Duplicar"
}, {
    1689,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Naciones > Eliminar"
}, {
    1717,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Naciones > Modificar"
}, {
    1690,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Naciones > Reporte"
}, {
    1701,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Terceros"
}, {
    1702,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Terceros > Adicionar"
}, {
    1703,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Terceros > Consultar"
}, {
    1704,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Terceros > Duplicar"
}, {
    1705,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Terceros > Eliminar"
}, {
    1716,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Terceros > Modificar"
}, {
    1706,
    "Financiero - Contabilidad > Informes a entidades > Superbancaria > Terceros > Reporte"
}, {
    1595,
    "Maestros > Supervalores > Formatos"
}, {
    1596,
    "Maestros > Supervalores > Formatos > Adicionar"
}, {
    1597,
    "Maestros > Supervalores > Formatos > Consultar"
}, {
    1610,
    "Maestros > Supervalores > Datos de formatos"
}, {
    1611,
    "Maestros > Supervalores > Datos de formatos > Adicionar"
}, {
    1616,
    "Maestros > Supervalores > Datos de formatos > Consultar"
}, {
    1613,
    "Maestros > Supervalores > Datos de formatos > Duplicar"
}, {
    1614,
    "Maestros > Supervalores > Datos de formatos > Eliminar"
}, {
    1612,
    "Maestros > Supervalores > Datos de formatos > Modificar"
}, {
    1615,
    "Maestros > Supervalores > Datos de formatos > Reporte"
}, {
    1598,
    "Maestros > Supervalores > Formatos > Duplicar"
}, {
    1599,
    "Maestros > Supervalores > Formatos > Eliminar"
}, {
    1602,
    "Maestros > Supervalores > Estructuras de formatos"
}, {
    1603,
    "Maestros > Supervalores > Estructuras de formatos > Adicionar"
}, {
    1604,
    "Maestros > Supervalores > Estructuras de formatos > Consultar"
}, {
    1605,
    "Maestros > Supervalores > Estructuras de formatos > Duplicar"
}, {
    1606,
    "Maestros > Supervalores > Estructuras de formatos > Eliminar"
}, {
    1607,
    "Maestros > Supervalores > Estructuras de formatos > Modificar"
}, {
    1608,
    "Maestros > Supervalores > Estructuras de formatos > Reporte"
}, {
    1600,
    "Maestros > Supervalores > Formatos > Modificar"
}, {
    1601,
    "Maestros > Supervalores > Formatos > Reporte"
}, {
    1580,
    "Maestros > Supervalores > Nacionalidades"
}, {
    1582,
    "Maestros > Supervalores > Nacionalidades > Adicionar"
}, {
    1583,
    "Maestros > Supervalores > Nacionalidades > Consultar"
}, {
    1584,
    "Maestros > Supervalores > Nacionalidades > Duplicar"
}, {
    1585,
    "Maestros > Supervalores > Nacionalidades > Eliminar"
}, {
    1586,
    "Maestros > Supervalores > Nacionalidades > Modificar"
}, {
    1587,
    "Maestros > Supervalores > Nacionalidades > Reporte"
}, {
    1581,
    "Maestros > Supervalores > Terceros"
}, {
    1588,
    "Maestros > Supervalores > Terceros > Adicionar"
}, {
    1589,
    "Maestros > Supervalores > Terceros > Consultar"
}, {
    1590,
    "Maestros > Supervalores > Terceros > Duplicar"
}, {
    1591,
    "Maestros > Supervalores > Terceros > Eliminar"
}, {
    1592,
    "Maestros > Supervalores > Terceros > Modificar"
}, {
    1593,
    "Maestros > Supervalores > Terceros > Reporte"
}, {
    2587,
    "Maestros de comercial > Sustitutos"
}, {
    2588,
    "Maestros de comercial > Sustitutos > Adicionar"
}, {
    2589,
    "Maestros de comercial > Sustitutos > Consultar"
}, {
    2590,
    "Maestros de comercial > Sustitutos > Duplicar"
}, {
    2591,
    "Maestros de comercial > Sustitutos > Eliminar"
}, {
    2592,
    "Maestros de comercial > Sustitutos > Modificar"
}, {
    2593,
    "Maestros de comercial > Sustitutos > Reporte"
}, {
    2585,
    "Maestros > Tasas intereses por mora"
}, {
    5,
    "Maestros > Terceros > Terceros"
}, {
    64,
    "Maestros > Terceros > Terceros > Adicionar"
}, {
    69,
    "Maestros > Terceros > Terceros > Cambiar código"
}, {
    2642,
    "Maestros > Terceros > Terceros > Clientes"
}, {
    3469,
    "Maestros > Terceros > Terceros > Clientes > Análisis de clientes"
}, {
    12457,
    "Maestros > Terceros > Terceros > Clientes > Duplicar puntos de envíos"
}, {
    8035,
    "Maestros > Terceros > Terceros > Clientes > Modificar entidades dinámicas"
}, {
    10671,
    "Maestros > Terceros > Terceros > Clientes > Modificar parámetros de criterios"
}, {
    8450,
    "Maestros > Terceros > Terceros > Clientes > Modificar vendedor en puntos de envío"
}, {
    7150,
    "Maestros > Terceros > Terceros > Clientes > No obligar cobrador"
}, {
    8713,
    "Maestros > Terceros > Terceros > Clientes > No obligar condición de pago"
}, {
    8714,
    "Maestros > Terceros > Terceros > Clientes > No obligar cupo crédito"
}, {
    11606,
    "Maestros > Terceros > Terceros > Clientes > No obligar entidad dinámica"
}, {
    7948,
    "Maestros > Terceros > Terceros > Clientes > No obligar vendedor"
}, {
    11325,
    "Maestros > Terceros > Terceros > Clientes > Duplicar parámetros impuestos y retenciones"
}, {
    3224,
    "Maestros > Terceros > Terceros > Clientes > No obligar informacion de contactos"
}, {
    2685,
    "Maestros > Terceros > Terceros > Clientes > Adicionar"
}, {
    2686,
    "Maestros > Terceros > Terceros > Clientes > Consultar"
}, {
    2687,
    "Maestros > Terceros > Terceros > Clientes > Duplicar"
}, {
    2688,
    "Maestros > Terceros > Terceros > Clientes > Eliminar"
}, {
    2689,
    "Maestros > Terceros > Terceros > Clientes > Modificar"
}, {
    3616,
    "Maestros > Terceros > Terceros > Clientes > Modificar estado"
}, {
    1558,
    "Maestros > Terceros > Terceros > Clientes > Modificar parámetros de credito"
}, {
    2644,
    "Maestros > Terceros > Terceros > Clientes > Modificar parámetros de impuestos y retenciones"
}, {
    1559,
    "Maestros > Terceros > Terceros > Clientes > Modificar parámetros de ventas"
}, {
    3614,
    "Maestros > Terceros > Terceros > Clientes > No obligar configuración de impuesto y retenciones"
}, {
    4668,
    "Maestros > Terceros > Terceros > Clientes > Puntos de envio"
}, {
    4669,
    "Maestros > Terceros > Terceros > Clientes > Puntos de envio > Adicionar"
}, {
    4671,
    "Maestros > Terceros > Terceros > Clientes > Puntos de envio > Eliminar"
}, {
    4670,
    "Maestros > Terceros > Terceros > Clientes > Puntos de envio > Modificar"
}, {
    2690,
    "Maestros > Terceros > Terceros > Clientes > Reporte"
}, {
    63,
    "Maestros > Terceros > Terceros > Consultar"
}, {
    65,
    "Maestros > Terceros > Terceros > Duplicar"
}, {
    67,
    "Maestros > Terceros > Terceros > Eliminar"
}, {
    4686,
    "Maestros > Terceros a excluir"
}, {
    4687,
    "Maestros > Terceros a excluir > Adicionar"
}, {
    4688,
    "Maestros > Terceros a excluir > Consultar"
}, {
    4689,
    "Maestros > Terceros a excluir > Duplicar"
}, {
    4690,
    "Maestros > Terceros a excluir > Eliminar"
}, {
    4691,
    "Maestros > Terceros a excluir > Modificar"
}, {
    4692,
    "Maestros > Terceros a excluir > Reporte"
}, {
    66,
    "Maestros > Terceros > Terceros > Modificar"
}, {
    8034,
    "Maestros > Terceros > Terceros > Modificar entidades dinámicas"
}, {
    3456,
    "Maestros > Terceros > Terceros > No obligar CIIU"
}, {
    11605,
    "Maestros > Terceros > Terceros > No obligar entidad dinámica"
}, {
    3223,
    "Maestros > Terceros > Terceros > No obligar informacion del contacto"
}, {
    4685,
    "Maestros > Terceros > Terceros > No validar terceros a excluir"
}, {
    2643,
    "Maestros > Terceros > Terceros > Proveedores"
}, {
    3938,
    "Maestros > Terceros > Terceros > Proveedores > Analisis de proveedor"
}, {
    4402,
    "Maestros > Terceros > Terceros > Proveedores > Modificar valores por defecto en pago electronico"
}, {
    8036,
    "Maestros > Terceros > Terceros > Proveedores > Modificar entidades dinámicas"
}, {
    10869,
    "Maestros > Terceros > Terceros > Proveedores > Modificar parámetros de compras"
}, {
    3225,
    "Maestros > Terceros > Terceros > Proveedores > No obligar informacion de contactos"
}, {
    2679,
    "Maestros > Terceros > Terceros > Proveedores > Adicionar"
}, {
    2680,
    "Maestros > Terceros > Terceros > Proveedores > Consultar"
}, {
    2681,
    "Maestros > Terceros > Terceros > Proveedores > Duplicar"
}, {
    2682,
    "Maestros > Terceros > Terceros > Proveedores > Eliminar"
}, {
    2683,
    "Maestros > Terceros > Terceros > Proveedores > Modificar"
}, {
    3617,
    "Maestros > Terceros > Terceros > Proveedores > Modificar estado"
}, {
    10872,
    "-No implementado > Modificar parámetros de compras"
}, {
    2678,
    "Maestros > Terceros > Terceros > Proveedores > Modificar parametros de credito"
}, {
    2645,
    "Maestros > Terceros > Terceros > Proveedores > Modificar parámetros de impuestos y retenciones"
}, {
    2646,
    "Maestros > Terceros > Terceros > Proveedores > Modificar parámetros de pagos"
}, {
    11607,
    "Maestros > Terceros > Terceros > Proveedores > No obligar entidad dinámica"
}, {
    3615,
    "Maestros > Terceros > Terceros > Proveedores > No obligar configuración de impuesto y retenciones"
}, {
    11326,
    "Maestros > Terceros > Terceros > Proveedores > Duplicar parámetros impuestos y retenciones"
}, {
    2684,
    "Maestros > Terceros > Terceros > Proveedores > Reporte"
}, {
    68,
    "Maestros > Terceros > Terceros > Reporte"
}, {
    4,
    "Maestros > Terceros"
}, {
    1665,
    "Maestros > Terceros > Terceros > Unificar terceros"
}, {
    1666,
    "Maestros > Terceros > Terceros > Unificar clientes"
}, {
    1667,
    "Maestros > Terceros > Terceros > Unificar proveedores"
}, {
    11203,
    "Maestros > Terceros > Tercero plantilla"
}, {
    4542,
    "Maestros > Tipos de calendario"
}, {
    4543,
    "Maestros > Tipos de calendario > Adicionar"
}, {
    4544,
    "Maestros > Tipos de calendario > Consultar"
}, {
    4545,
    "Maestros > Tipos de calendario > Duplicar"
}, {
    4546,
    "Maestros > Tipos de calendario > Eliminar"
}, {
    4547,
    "Maestros > Tipos de calendario > Modificar"
}, {
    4548,
    "Maestros > Tipos de calendario > Reporte"
}, {
    4333,
    "Maestros > Tipos de cambio"
}, {
    4334,
    "Maestros > Tipos de cambio > Adicionar"
}, {
    4340,
    "Maestros > Tipos de cambio por clase"
}, {
    4341,
    "Maestros > Tipos de cambio por clase > Modificar"
}, {
    4342,
    "Maestros > Tipos de cambio por clase > Reporte"
}, {
    4335,
    "Maestros > Tipos de cambio > Consultar"
}, {
    4336,
    "Maestros > Tipos de cambio > Duplicar"
}, {
    4337,
    "Maestros > Tipos de cambio > Eliminar"
}, {
    4338,
    "Maestros > Tipos de cambio > Modificar"
}, {
    4339,
    "Maestros > Tipos de cambio > Reporte"
}, {
    3649,
    "Maestros de comercial > Tipos de documentos de verificación"
}, {
    3650,
    "Maestros de comercial > Tipos de documentos de verificación > Inventarios"
}, {
    3651,
    "Maestros de comercial > Tipos de documentos de verificación > Ventas"
}, {
    41,
    "Maestros > Documentos > Tipos"
}, {
    261,
    "Maestros > Documentos > Tipos > Adicionar"
}, {
    260,
    "Maestros > Documentos > Tipos > Consultar"
}, {
    262,
    "Maestros > Documentos > Tipos > Duplicar"
}, {
    264,
    "Maestros > Documentos > Tipos > Eliminar"
}, {
    263,
    "Maestros > Documentos > Tipos > Modificar"
}, {
    265,
    "Maestros > Documentos > Tipos > Reporte"
}, {
    6,
    "Maestros > Terceros > Tipos identificación"
}, {
    72,
    "Maestros > Terceros > Tipos identificación > Adicionar"
}, {
    71,
    "Maestros > Terceros > Tipos identificación > Consultar"
}, {
    73,
    "Maestros > Terceros > Tipos identificación > Duplicar"
}, {
    75,
    "Maestros > Terceros > Tipos identificación > Eliminar"
}, {
    74,
    "Maestros > Terceros > Tipos identificación > Modificar"
}, {
    76,
    "Maestros > Terceros > Tipos identificación > Reporte"
}, {
    4713,
    "Maestros de comercial > Tipos de vehiculo"
}, {
    4714,
    "Maestros de comercial > Tipos de vehiculo > Adicionar"
}, {
    4715,
    "Maestros de comercial > Tipos de vehiculo > Consultar"
}, {
    4716,
    "Maestros de comercial > Tipos de vehiculo > Duplicar"
}, {
    4717,
    "Maestros de comercial > Tipos de vehiculo > Eliminar"
}, {
    4718,
    "Maestros de comercial > Tipos de vehiculo > Modificar"
}, {
    4719,
    "Maestros de comercial > Tipos de vehiculo > Reporte"
}, {
    953,
    "Maestros > Terceros > Tipo cliente"
}, {
    955,
    "Maestros > Terceros > Tipo cliente > Adicionar"
}, {
    957,
    "Maestros > Terceros > Tipo cliente > Consultar"
}, {
    958,
    "Maestros > Terceros > Tipo cliente > Duplicar"
}, {
    960,
    "Maestros > Terceros > Tipo cliente > Eliminar"
}, {
    956,
    "Maestros > Terceros > Tipo cliente > Modificar"
}, {
    959,
    "Maestros > Terceros > Tipo cliente > Reporte"
}, {
    869,
    "Maestros > Tipos de inventario/servicio"
}, {
    870,
    "Maestros > Tipos de inventario/servicio > Adicionar"
}, {
    871,
    "Maestros > Tipos de inventario/servicio > Consultar"
}, {
    6486,
    "Maestros > Tipos de inventario/servicio > Consulta tipos de inventario"
}, {
    872,
    "Maestros > Tipos de inventario/servicio > Duplicar"
}, {
    873,
    "Maestros > Tipos de inventario/servicio > Eliminar"
}, {
    874,
    "Maestros > Tipos de inventario/servicio > Modificar"
}, {
    875,
    "Maestros > Tipos de inventario/servicio > Reporte"
}, {
    954,
    "Maestros > Terceros > Tipo proveedor"
}, {
    961,
    "Maestros > Terceros > Tipo proveedor > Adicionar"
}, {
    964,
    "Maestros > Terceros > Tipo proveedor > Consultar"
}, {
    965,
    "Maestros > Terceros > Tipo proveedor > Duplicar"
}, {
    963,
    "Maestros > Terceros > Tipo proveedor > Eliminar"
}, {
    962,
    "Maestros > Terceros > Tipo proveedor > Modificar"
}, {
    966,
    "Maestros > Terceros > Tipo proveedor > Reporte"
}, {
    36,
    "Maestros > Bancos > Transacciones bancarias"
}, {
    234,
    "Maestros > Bancos > Transacciones bancarias > Adicionar"
}, {
    233,
    "Maestros > Bancos > Transacciones bancarias > Consultar"
}, {
    235,
    "Maestros > Bancos > Transacciones bancarias > Duplicar"
}, {
    237,
    "Maestros > Bancos > Transacciones bancarias > Eliminar"
}, {
    236,
    "Maestros > Bancos > Transacciones bancarias > Modificar"
}, {
    238,
    "Maestros > Bancos > Transacciones bancarias > Reporte"
}, {
    903,
    "Maestros de comercial > Ubicaciones > Ubicaciones > Estructura"
}, {
    909,
    "Maestros de comercial > Ubicaciones > Ubicaciones > Estructura > Consultar"
}, {
    908,
    "Maestros de comercial > Ubicaciones > Ubicaciones > Estructura > Duplicar"
}, {
    907,
    "Maestros de comercial > Ubicaciones > Ubicaciones > Estructura > Eliminar"
}, {
    906,
    "Maestros de comercial > Ubicaciones > Ubicaciones > Estructura > Modificar"
}, {
    910,
    "Maestros de comercial > Ubicaciones > Ubicaciones > Estructura > Reporte"
}, {
    904,
    "Maestros de comercial > Ubicaciones > Ubicaciones > Mayores"
}, {
    911,
    "Maestros de comercial > Ubicaciones > Ubicaciones > Mayores > Adicionar"
}, {
    916,
    "Maestros de comercial > Ubicaciones > Ubicaciones > Mayores > Consultar"
}, {
    914,
    "Maestros de comercial > Ubicaciones > Ubicaciones > Mayores > Duplicar"
}, {
    913,
    "Maestros de comercial > Ubicaciones > Ubicaciones > Mayores > Eliminar"
}, {
    912,
    "Maestros de comercial > Ubicaciones > Ubicaciones > Mayores > Modificar"
}, {
    915,
    "Maestros de comercial > Ubicaciones > Ubicaciones > Mayores > Reporte"
}, {
    902,
    "Maestros de comercial > Ubicaciones > Ubicaciones"
}, {
    905,
    "Maestros de comercial > Ubicaciones > Ubicaciones > Ubicaciones"
}, {
    917,
    "Maestros de comercial > Ubicaciones > Ubicaciones > Ubicaciones > Adicionar"
}, {
    921,
    "Maestros de comercial > Ubicaciones > Ubicaciones > Ubicaciones > Consultar"
}, {
    920,
    "Maestros de comercial > Ubicaciones > Ubicaciones > Ubicaciones > Duplicar"
}, {
    919,
    "Maestros de comercial > Ubicaciones > Ubicaciones > Ubicaciones > Eliminar"
}, {
    918,
    "Maestros de comercial > Ubicaciones > Ubicaciones > Ubicaciones > Modificar"
}, {
    922,
    "Maestros de comercial > Ubicaciones > Ubicaciones > Ubicaciones > Reporte"
}, {
    572,
    "Maestros de comercial > Unidades de medida"
}, {
    574,
    "Maestros de comercial > Unidades de medida > Adicionar"
}, {
    573,
    "Maestros de comercial > Unidades de medida > Consultar"
}, {
    575,
    "Maestros de comercial > Unidades de medida > Duplicar"
}, {
    577,
    "Maestros de comercial > Unidades de medida > Eliminar"
}, {
    576,
    "Maestros de comercial > Unidades de medida > Modificar"
}, {
    578,
    "Maestros de comercial > Unidades de medida > Reporte"
}, {
    27,
    "Maestros > Unidades de negocio"
}, {
    179,
    "Maestros > Unidades de negocio > Adicionar"
}, {
    178,
    "Maestros > Unidades de negocio > Consultar"
}, {
    180,
    "Maestros > Unidades de negocio > Duplicar"
}, {
    182,
    "Maestros > Unidades de negocio > Eliminar"
}, {
    181,
    "Maestros > Unidades de negocio > Modificar"
}, {
    183,
    "Maestros > Unidades de negocio > Reporte"
}, {
    2106,
    "Maestros de comercial > Vehículos"
}, {
    2107,
    "Maestros de comercial > Vehículos > Adicionar"
}, {
    2108,
    "Maestros de comercial > Vehículos > Consultar"
}, {
    2109,
    "Maestros de comercial > Vehículos > Duplicar"
}, {
    2110,
    "Maestros de comercial > Vehículos > Eliminar"
}, {
    2111,
    "Maestros de comercial > Vehículos > Modificar"
}, {
    4667,
    "Maestros de comercial > Vehículos > Modificar desde la informacion del transportador"
}, {
    2112,
    "Maestros de comercial > Vehículos > Reporte"
}, {
    29,
    "Maestros > Terceros > Vendedores"
}, {
    192,
    "Maestros > Terceros > Vendedores > Adicionar"
}, {
    191,
    "Maestros > Terceros > Vendedores > Consultar"
}, {
    193,
    "Maestros > Terceros > Vendedores > Duplicar"
}, {
    195,
    "Maestros > Terceros > Vendedores > Eliminar"
}, {
    194,
    "Maestros > Terceros > Vendedores > Modificar"
}, {
    196,
    "Maestros > Terceros > Vendedores > Reporte"
}, {
    4880,
    "Mantenimiento Preventivo"
}, {
    2490,
    "Manufactura - Control de piso"
}, {
    2551,
    "Manufactura - Control de piso > Cierre de orden de producción"
}, {
    2552,
    "Manufactura - Control de piso > Cierre de orden de producción > Adicionar"
}, {
    2553,
    "Manufactura - Control de piso > Cierre de orden de producción > Anular"
}, {
    2554,
    "Manufactura - Control de piso > Cierre de orden de producción > Aprobar"
}, {
    2555,
    "Manufactura - Control de piso > Cierre de orden de producción > Consultar"
}, {
    2556,
    "Manufactura - Control de piso > Cierre de orden de producción > Eliminar movimiento"
}, {
    2557,
    "Manufactura - Control de piso > Cierre de orden de producción > Modificar"
}, {
    7858,
    "Manufactura - Control de piso > Cierre de orden de producción > Modificar entidades dinámicas en doctos aprobados"
}, {
    2491,
    "Manufactura - Control de piso > Clases de O.P."
}, {
    2492,
    "Manufactura - Control de piso > Clases de O.P. > Adicionar"
}, {
    2493,
    "Manufactura - Control de piso > Clases de O.P. > Consultar"
}, {
    2497,
    "Manufactura - Control de piso > Clases de O.P. > Duplicar"
}, {
    2494,
    "Manufactura - Control de piso > Clases de O.P. > Eliminar"
}, {
    2495,
    "Manufactura - Control de piso > Clases de O.P. > Modificar"
}, {
    2496,
    "Manufactura - Control de piso > Clases de O.P. > Reporte"
}, {
    2581,
    "Manufactura - Control de piso > Consultas"
}, {
    3678,
    "Manufactura - Control de piso > Consultas > Análisis de costos"
}, {
    6566,
    "Manufactura - Control de piso > Consultas > Análisis de costos por OP"
}, {
    4534,
    "Manufactura - Control de piso > Consultas > Análisis de inconsistencias consumos TEP"
}, {
    3409,
    "Manufactura - Control de piso > Consultas > Análisis de tiempos y costos"
}, {
    6358,
    "Manufactura - Control de piso > Consultas > Balance de comprobación de OPs"
}, {
    2668,
    "Manufactura - Control de piso > Consultas > Componentes por O.P.s"
}, {
    2667,
    "Manufactura - Control de piso > Consultas > Componentes pendientes por consumir"
}, {
    2582,
    "Manufactura - Control de piso > Consultas > Documentos de produccion"
}, {
    8568,
    "Manufactura - Control de piso > Consultas > Documento de producción por ítem"
}, {
    11971,
    "Manufactura - Control de piso > Consultas > Documento de producción - Contabilización"
}, {
    11905,
    "Manufactura - Control de piso > Consultas > Entidades de muestreo en TEP"
}, {
    4575,
    "Manufactura - Control de piso > Consultas > Inconsistencias de consumos TEP"
}, {
    4856,
    "Manufactura - Control de piso > Consultas > Operaciones por O.P.s"
}, {
    7609,
    "Manufactura - Control de piso > Consultas > Ordenes de producción"
}, {
    2584,
    "Manufactura - Control de piso > Consultas > Ordenes de producción por ítem"
}, {
    4857,
    "Manufactura - Control de piso > Consultas > Piezas por O.P.s"
}, {
    2669,
    "Manufactura - Control de piso > Consultas > Resumen se compromisos"
}, {
    3370,
    "Manufactura - Control de piso > Consultas > Resumen de componentes pendientes"
}, {
    2583,
    "Manufactura - Control de piso > Consultas > Resumen de transacciones"
}, {
    8390,
    "Manufactura - Control de piso > Consultas > Resumen por transacciones por serial"
}, {
    2820,
    "Manufactura - Control de piso > Consultas > Resumen de transacciones T.E.P."
}, {
    3532,
    "Manufactura - Control de piso > Consultas > Seguimiento de documentos"
}, {
    2522,
    "Manufactura - Control de piso > Consumos de componentes"
}, {
    2523,
    "Manufactura - Control de piso > Consumos de componentes > Adicionar"
}, {
    2524,
    "Manufactura - Control de piso > Consumos de componentes > Anular"
}, {
    2525,
    "Manufactura - Control de piso > Consumos de componentes > Aprobar"
}, {
    11372,
    "Manufactura - Control de piso > Consumos de componentes > Permitir comprometer por cantidad con exceso"
}, {
    2526,
    "Manufactura - Control de piso > Consumos de componentes > Consultar"
}, {
    2527,
    "Manufactura - Control de piso > Consumos de componentes > Eliminar movimiento"
}, {
    2528,
    "Manufactura - Control de piso > Consumos de componentes > Modificar"
}, {
    4577,
    "Manufactura - Control de piso > Consumos de componentes > Recalcular la cantidad en unidad adicional"
}, {
    10614,
    "Manufactura - Control de piso > Consumos desde compromisos > Por defecto no cerrar la pantalla al comprometer"
}, {
    10613,
    "Manufactura - Control de piso > Consumos desde compromisos > Por defecto seleccionar comprometer por cantidad"
}, {
    10867,
    "Manufactura - Control de piso > Consumos desde compromisos > Por defecto No seleccionar comprometer seriales"
}, {
    2670,
    "Manufactura - Control de piso > Consumos desde compromisos"
}, {
    9824,
    "Manufactura - Control de piso > Consumos desde seriales"
}, {
    10101,
    "Manufactura - Control de piso > Consumos desde seriales > Generar con OP desde pedido"
}, {
    7744,
    "Manufactura - Control de piso > Consultas > Ordenes de producción por ítem > Permitir cambiar fechas de los componentes"
}, {
    8273,
    "Manufactura - Control de piso > Dar orden de producción por cumplida"
}, {
    2529,
    "Manufactura - Control de piso > Devoluciones de componentes"
}, {
    2530,
    "Manufactura - Control de piso > Devoluciones de componentes > Adicionar"
}, {
    2531,
    "Manufactura - Control de piso > Devoluciones de componentes > Anular"
}, {
    2532,
    "Manufactura - Control de piso > Devoluciones de componentes > Aprobar"
}, {
    2533,
    "Manufactura - Control de piso > Devoluciones de componentes > Consultar"
}, {
    2534,
    "Manufactura - Control de piso > Devoluciones de componentes > Eliminar movimiento"
}, {
    2535,
    "Manufactura - Control de piso > Devoluciones de componentes > Modificar"
}, {
    4578,
    "Manufactura - Control de piso > Devoluciones de componentes > Recalcular la cantidad en unidad adicional"
}, {
    7116,
    "-No implementado > Controlar que no supere la cantidad consumida"
}, {
    2544,
    "Manufactura - Control de piso > Devoluciones a producción"
}, {
    2545,
    "Manufactura - Control de piso > Devoluciones a producción > Adicionar"
}, {
    2546,
    "Manufactura - Control de piso > Devoluciones a producción > Anular"
}, {
    2547,
    "Manufactura - Control de piso > Devoluciones a producción > Aprobar"
}, {
    2548,
    "Manufactura - Control de piso > Devoluciones a producción > Consultar"
}, {
    2549,
    "Manufactura - Control de piso > Devoluciones a producción > Eliminar movimiento"
}, {
    2550,
    "Manufactura - Control de piso > Devoluciones a producción > Modificar"
}, {
    7859,
    "Manufactura - Control de piso > Devoluciones a producción > Modificar entidades dinámicas en doctos aprobados"
}, {
    2536,
    "Manufactura - Control de piso > Entregas de producción"
}, {
    2537,
    "Manufactura - Control de piso > Entregas de producción > Adicionar"
}, {
    2543,
    "Manufactura - Control de piso > Entregas de producción > Adicionar otros items"
}, {
    4789,
    "Manufactura - Control de piso > Entregas de producción > Solo afectar cantidad a despachar en posdeducción"
}, {
    2538,
    "Manufactura - Control de piso > Entregas de producción > Anular"
}, {
    2539,
    "Manufactura - Control de piso > Entregas de producción > Aprobar"
}, {
    4574,
    "Manufactura - Control de piso > Entregas de producción automáticas"
}, {
    8967,
    "Manufactura - Control de piso > Entregas de producción > Obligar captura de máquina en posdeducción"
}, {
    3693,
    "Manufactura - Control de piso > Entregas de producción > Comprometer automáticamente con lote de ítem OP-1"
}, {
    3613,
    "Manufactura - Control de piso > Entregas de producción > Confirmar entregas mayores a última operación"
}, {
    2540,
    "Manufactura - Control de piso > Entregas de producción > Consultar"
}, {
    2541,
    "Manufactura - Control de piso > Entregas de producción > Eliminar movimiento"
}, {
    4169,
    "Manufactura - Control de piso > Entregas de producción > Permitir entregar seriales en estado no disponible"
}, {
    3692,
    "Manufactura - Control de piso > Entregas de producción > Consumos y/o TEP automáticos en posdeducción"
}, {
    7467,
    "Manufactura - Control de piso > Entregas de producción > Permitir ingresar mayor cantidad de la OP"
}, {
    2542,
    "Manufactura - Control de piso > Entregas de producción > Modificar"
}, {
    11557,
    "Manufactura - Control de piso > Entregas de producción > Sugerir el número de la OP como lote"
}, {
    7403,
    "Manufactura - Control de piso > Entregas de producción > Ordenar la selección del item OP por nivel"
}, {
    8298,
    "Manufactura - Control de piso > Entregas de producción de seriales"
}, {
    3513,
    "Manufactura - Control de piso > Entregas de producción > Validar cantidades consumidas"
}, {
    10027,
    "Manufactura - Control de piso > Entregas de producción > Validar el lote de entrega contra el del consumo"
}, {
    12147,
    "Manufactura - Control de piso > Entregas de producción > Comprometer automáticamente con lote de entrega-2"
}, {
    7850,
    "Manufactura - Control de piso > Entregas de producción > Modificar entidades dinámicas en doctos aprobados"
}, {
    8653,
    "Manufactura - Control de piso > Entregas de producción de seriales > Generar con OP desde pedido"
}, {
    8271,
    "Manufactura - Control de piso > Entregas de producción > Sugerir la última ubicación capturada"
}, {
    12041,
    "Manufactura - Control de piso > Entregas de producción > Validar cantidades consumidas > Solo cantidades exactas en ítems críticos"
}, {
    4200,
    "Manufactura - Control de piso > Generales"
}, {
    9878,
    "Manufactura - Control de piso > Generales > Compromete manual según bodega por usuario"
}, {
    9879,
    "Manufactura - Control de piso > Generales > Genera consumo según bodega por usuario"
}, {
    8887,
    "Manufactura - Control de piso > Generales > En reporte de TEP considerar el rendimiento"
}, {
    4201,
    "Manufactura - Control de piso > Generales > Restringir captura al comprometer item lote"
}, {
    4791,
    "Manufactura - Control de piso > Generales > Sobrepasar la cantidad pendiente al comprometer"
}, {
    2565,
    "Manufactura - Control de piso > Habilitar impresión de documentos > Habilitar impresión de consumos y devoluciones"
}, {
    2569,
    "Manufactura - Control de piso > Habilitar impresión de documentos"
}, {
    2735,
    "Manufactura - Control de piso > Habilitar impresión de documentos > Habilitar impresión de T.E.P."
}, {
    2566,
    "Manufactura - Control de piso > Habilitar impresión de documentos > Habilitar impresión de entegras y devoluciones"
}, {
    2570,
    "Manufactura - Control de piso > Imprimir documentos"
}, {
    2734,
    "Manufactura - Control de piso > Imprimir documentos > Imprimir T.E.P."
}, {
    4536,
    "Manufactura - Control de piso > Liberar inconsistencias consumos TEP"
}, {
    4539,
    "Manufactura - Control de piso > Liberar inconsistencias consumos TEP > Anulación"
}, {
    4537,
    "Manufactura - Control de piso > Liberar inconsistencias consumos TEP > Consumos"
}, {
    4538,
    "Manufactura - Control de piso > Liberar inconsistencias consumos TEP > Modificación"
}, {
    2693,
    "Manufactura - Control de piso > Motivos T.E.P."
}, {
    2694,
    "Manufactura - Control de piso > Motivos T.E.P. > Adicionar"
}, {
    2695,
    "Manufactura - Control de piso > Motivos T.E.P. > Consultar"
}, {
    2696,
    "Manufactura - Control de piso > Motivos T.E.P. > Duplicar"
}, {
    2697,
    "Manufactura - Control de piso > Motivos T.E.P. > Eliminar"
}, {
    2698,
    "Manufactura - Control de piso > Motivos T.E.P. > Modificar"
}, {
    2699,
    "Manufactura - Control de piso > Motivos T.E.P. > Reporte"
}, {
    2499,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción"
}, {
    2500,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Adicionar"
}, {
    2511,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Adicionar componentes"
}, {
    2514,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Adicionar operaciones"
}, {
    2505,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Anular"
}, {
    2503,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Aprobar"
}, {
    8308,
    "Manufactura - Control de piso > Ordenes de producción > Cambiar cantidades"
}, {
    2508,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Comprometer"
}, {
    2521,
    "Manufactura - Control de piso > Ordenes de producción > Comprometer"
}, {
    4813,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Comprometer parciales"
}, {
    11336,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Comprometer - bloquear manuales"
}, {
    11335,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Comprometer - bloquear parciales"
}, {
    2502,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Consultar"
}, {
    2509,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Cumplir"
}, {
    2504,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Desaprobar"
}, {
    8553,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Descomprometer"
}, {
    8650,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Duplicar"
}, {
    2513,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Eliminar componentes"
}, {
    2516,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Eliminar operaciones"
}, {
    2571,
    "Manufactura - Control de piso > Ordenes de producción > Generar desde ordenes planeadas"
}, {
    4780,
    "Manufactura - Control de piso > Ordenes de producción > Generar desde ordenes planeadas > Permitir seleccionar MPS"
}, {
    4781,
    "Manufactura - Control de piso > Ordenes de producción > Generar desde ordenes planeadas > Permitir seleccionar MRP"
}, {
    4779,
    "Manufactura - Control de piso > Ordenes de producción > Generar desde ordenes planeadas > Permitir seleccionar tipo de orden en firme"
}, {
    4778,
    "Manufactura - Control de piso > Ordenes de producción > Generar desde ordenes planeadas > Permitir seleccionar tipo de orden planeada"
}, {
    4858,
    "Manufactura - Control de piso > Ordenes de producción > Generar desde pedidos"
}, {
    6553,
    "Manufactura - Control de piso > Ordenes de producción > Generar desde pedidos > Generar utilizando las fechas del pedido"
}, {
    11161,
    "Manufactura - Control de piso > Ordenes de producción > Generar desde pedidos > Seleccionar opción de asumir bodega asignación"
}, {
    2507,
    "Manufactura - Control de piso > Habilitar impresión de documentos > Habilitar impresión de O.P´s"
}, {
    2567,
    "Manufactura - Control de piso > Imprimir documentos > Imprimir consumos y devoluciones"
}, {
    2568,
    "Manufactura - Control de piso > Imprimir documentos > Imprimir entregas y devoluciones"
}, {
    2506,
    "Manufactura - Control de piso > Imprimir documentos > Imprimir O.P´s"
}, {
    2520,
    "Manufactura - Control de piso > Ordenes de producción"
}, {
    11048,
    "Manufactura - Control de piso > Ordenes de producción > Saldos iniciales"
}, {
    2501,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Modificar"
}, {
    2512,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Modificar componentes"
}, {
    2515,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Modificar operaciones"
}, {
    3622,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Modificar O.P. padre"
}, {
    4812,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Modificar referencias"
}, {
    4604,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Modificar entidades dinamicas en doctos aprobados"
}, {
    7153,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Modificar indicador de controla secuencia"
}, {
    3533,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Modificar ítems"
}, {
    12263,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Modificar operaciones - secuencias"
}, {
    4790,
    "Manufactura - Control de piso > Ordenes de producción > No almacenar cantidades parciales al comprometer"
}, {
    7595,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Permitir desaprobar con O.P. padre"
}, {
    2510,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Reversar cumplido"
}, {
    12265,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Sugerir en componentes última bodega"
}, {
    12264,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Sugerir en componentes último ítem OP"
}, {
    11711,
    "Manufactura - Control de piso > Ordenes de producción > Ordenes de producción > Validar costo estándar de componentes al aprobar"
}, {
    2558,
    "Manufactura - Control de piso > Rechazos de producción"
}, {
    2559,
    "Manufactura - Control de piso > Rechazos de producción > Adicionar"
}, {
    2560,
    "Manufactura - Control de piso > Rechazos de producción > Anular"
}, {
    2561,
    "Manufactura - Control de piso > Rechazos de producción > Aprobar"
}, {
    2562,
    "Manufactura - Control de piso > Rechazos de producción > Consultar"
}, {
    2563,
    "Manufactura - Control de piso > Rechazos de producción > Eliminar movimiento"
}, {
    2564,
    "Manufactura - Control de piso > Rechazos de producción > Modificar"
}, {
    7860,
    "Manufactura - Control de piso > Rechazos de producción > Modificar entidades dinámicas en doctos aprobados"
}, {
    2759,
    "Manufactura - Control de piso > T.E.P. ajustes"
}, {
    2760,
    "Manufactura - Control de piso > T.E.P. ajustes > Adicionar"
}, {
    2761,
    "Manufactura - Control de piso > T.E.P. ajustes > Anular"
}, {
    2762,
    "Manufactura - Control de piso > T.E.P. ajustes > Aprobar"
}, {
    2763,
    "Manufactura - Control de piso > T.E.P. ajustes > Consultar"
}, {
    2764,
    "Manufactura - Control de piso > T.E.P. ajustes > Eliminar movimiento"
}, {
    2765,
    "Manufactura - Control de piso > T.E.P. ajustes > Modificar"
}, {
    4814,
    "Manufactura - Control de piso > T.E.P. ajustes > Modificar entidades dinámicas en doctos. aprobados"
}, {
    4815,
    "Manufactura - Control de piso > T.E.P. ajustes > Modificar entidades dinámicas en docto elaboración"
}, {
    2748,
    "Manufactura - Control de piso > T.E.P. por centro de trabajo"
}, {
    2749,
    "Manufactura - Control de piso > T.E.P. por centro de trabajo > Adicionar"
}, {
    2750,
    "Manufactura - Control de piso > T.E.P. por centro de trabajo > Anular"
}, {
    2751,
    "Manufactura - Control de piso > T.E.P. por centro de trabajo > Aprobar"
}, {
    2769,
    "Manufactura - Control de piso > T.E.P. por centro de trabajo > Capturar ajuste cantidad"
}, {
    2752,
    "Manufactura - Control de piso > T.E.P. por centro de trabajo > Captura horas alistamiento"
}, {
    2753,
    "Manufactura - Control de piso > T.E.P. por centro de trabajo > Captura horas ejecucion"
}, {
    2754,
    "Manufactura - Control de piso > T.E.P. por centro de trabajo > Captura horas indirectas"
}, {
    2771,
    "Manufactura - Control de piso > T.E.P. por centro de trabajo > Capturar horas maquina"
}, {
    2755,
    "Manufactura - Control de piso > T.E.P. por centro de trabajo > Captura tiempo muerto"
}, {
    3611,
    "Manufactura - Control de piso > T.E.P. por centro de trabajo > Confirmar consumos automaticos"
}, {
    2756,
    "Manufactura - Control de piso > T.E.P. por centro de trabajo > Consultar"
}, {
    2757,
    "Manufactura - Control de piso > T.E.P. por centro de trabajo > Eliminar movimiento"
}, {
    2758,
    "Manufactura - Control de piso > T.E.P. por centro de trabajo > Modificar"
}, {
    4817,
    "Manufactura - Control de piso > T.E.P. por centro de trabajo > Modificar entidades dinámicas en doctos. aprobados"
}, {
    4816,
    "Manufactura - Control de piso > T.E.P. por centro de trabajo > Modificar entidades dinámicas en docto elaboración"
}, {
    6771,
    "Manufactura - Control de piso > T.E.P. por centro de trabajo > Sugerir tiempo estándar de la oper segun la canti."
}, {
    2736,
    "Manufactura - Control de piso > T.E.P. por empleado"
}, {
    2737,
    "Manufactura - Control de piso > T.E.P. por empleado > Adicionar"
}, {
    2741,
    "Manufactura - Control de piso > T.E.P. por empleado > Anular"
}, {
    2740,
    "Manufactura - Control de piso > T.E.P. por empleado > Aprobar"
}, {
    2770,
    "Manufactura - Control de piso > T.E.P. por empleado > Capturar ajuste cantidad"
}, {
    2745,
    "Manufactura - Control de piso > T.E.P. por empleado > Capturar horas alistamiento"
}, {
    2743,
    "Manufactura - Control de piso > T.E.P. por empleado > Capturar horas ejecución"
}, {
    2747,
    "Manufactura - Control de piso > T.E.P. por empleado > Capturar horas indirectas"
}, {
    2744,
    "Manufactura - Control de piso > T.E.P. por empleado > Capturar horas maquina"
}, {
    2746,
    "Manufactura - Control de piso > T.E.P. por empleado > Capturar tiempo muerto"
}, {
    3612,
    "Manufactura - Control de piso > T.E.P. por empleado > Confirmar consumos automaticos"
}, {
    2742,
    "Manufactura - Control de piso > T.E.P. por empleado > Consultar"
}, {
    2739,
    "Manufactura - Control de piso > T.E.P. por empleado > Eliminar movimiento"
}, {
    2738,
    "Manufactura - Control de piso > T.E.P. por empleado > Modificar"
}, {
    4819,
    "Manufactura - Control de piso > T.E.P. por empleado > Modificar entidades dinámicas en doctos. aprobados"
}, {
    4818,
    "Manufactura - Control de piso > T.E.P. por empleado > Modificar entidades dinámicas en docto elaboración"
}, {
    6772,
    "Manufactura - Control de piso > T.E.P. por empleado > Sugerir tiempo estándar de la oper segun la canti."
}, {
    8895,
    "Manufactura - Control de piso > Trabajo en proceso"
}, {
    11147,
    "Manufactura - Control de piso > Trabajo en proceso > Captura de fallas"
}, {
    11148,
    "Manufactura - Control de piso > Trabajo en proceso > Captura de fallas > Adicionar"
}, {
    11149,
    "Manufactura - Control de piso > Trabajo en proceso > Captura de fallas > Eliminar"
}, {
    11150,
    "Manufactura - Control de piso > Trabajo en proceso > Captura de fallas > Modificar"
}, {
    11131,
    "Manufactura - Control de piso > Trabajo en proceso > Clases de fallas"
}, {
    11132,
    "Manufactura - Control de piso > Trabajo en proceso > Clases de fallas > Adicionar"
}, {
    11133,
    "Manufactura - Control de piso > Trabajo en proceso > Clases de fallas > Consultar"
}, {
    11134,
    "Manufactura - Control de piso > Trabajo en proceso > Clases de fallas > Duplicar"
}, {
    11135,
    "Manufactura - Control de piso > Trabajo en proceso > Clases de fallas > Eliminar"
}, {
    11136,
    "Manufactura - Control de piso > Trabajo en proceso > Clases de fallas > Modificar"
}, {
    11137,
    "Manufactura - Control de piso > Trabajo en proceso > Clases de fallas > Reporte"
}, {
    11164,
    "Manufactura - Control de piso > Trabajo en proceso > Consulta de fallas"
}, {
    8896,
    "Manufactura - Control de piso > Trabajo en proceso > Generación de múltiple de TEP"
}, {
    11124,
    "Manufactura - Control de piso > Trabajo en proceso > Orígenes de fallas"
}, {
    11125,
    "Manufactura - Control de piso > Trabajo en proceso > Orígenes de fallas > Adicionar"
}, {
    11126,
    "Manufactura - Control de piso > Trabajo en proceso > Orígenes de fallas > Consultar"
}, {
    11127,
    "Manufactura - Control de piso > Trabajo en proceso > Orígenes de fallas > Duplicar"
}, {
    11128,
    "Manufactura - Control de piso > Trabajo en proceso > Orígenes de fallas > Eliminar"
}, {
    11129,
    "Manufactura - Control de piso > Trabajo en proceso > Orígenes de fallas > Modificar"
}, {
    11130,
    "Manufactura - Control de piso > Trabajo en proceso > Orígenes de fallas > Reporte"
}, {
    12055,
    "Manufactura - Control de piso > Trabajo en proceso > Sugiere cant. completa en rutas de una operación"
}, {
    11117,
    "Manufactura - Control de piso > Trabajo en proceso > Tipos de fallas"
}, {
    11118,
    "Manufactura - Control de piso > Trabajo en proceso > Tipos de fallas > Adicionar"
}, {
    11119,
    "Manufactura - Control de piso > Trabajo en proceso > Tipos de fallas > Consultar"
}, {
    11120,
    "Manufactura - Control de piso > Trabajo en proceso > Tipos de fallas > Duplicar"
}, {
    11121,
    "Manufactura - Control de piso > Trabajo en proceso > Tipos de fallas > Eliminar"
}, {
    11122,
    "Manufactura - Control de piso > Trabajo en proceso > Tipos de fallas > Modificar"
}, {
    11123,
    "Manufactura - Control de piso > Trabajo en proceso > Tipos de fallas > Reporte"
}, {
    2312,
    "Planeación (MRP II)"
}, {
    8567,
    "Maestros de comercial > Asignar parámetros de planeación"
}, {
    2384,
    "Planeación (MRP II) > Calendario de planta"
}, {
    2385,
    "Planeación (MRP II) > Calendario de planta > Adicionar"
}, {
    2386,
    "Planeación (MRP II) > Calendario de planta > Consultar"
}, {
    2387,
    "Planeación (MRP II) > Calendario de planta > Eliminar"
}, {
    2388,
    "Planeación (MRP II) > Calendario de planta > Modificar"
}, {
    2389,
    "Planeación (MRP II) > Calendario de planta > Reporte"
}, {
    2402,
    "Planeación (MRP II) > Capacidad"
}, {
    2403,
    "Planeación (MRP II) > Capacidad > Aproximada"
}, {
    2405,
    "Planeación (MRP II) > Capacidad > Aproximada > Consultar"
}, {
    2404,
    "Planeación (MRP II) > Capacidad > Aproximada > Generacion"
}, {
    2406,
    "Planeación (MRP II) > Capacidad > Aproximada > Resumen"
}, {
    2407,
    "Planeación (MRP II) > Capacidad > Detallada"
}, {
    10887,
    "Planeación (MRP II) > Cambiar fechas"
}, {
    2409,
    "Planeación (MRP II) > Capacidad > Detallada > Consultar"
}, {
    2408,
    "Planeación (MRP II) > Capacidad > Detallada > Generacion"
}, {
    2410,
    "Planeación (MRP II) > Capacidad > Detallada > Resumen"
}, {
    2478,
    "Planeación (MRP II) > Capacidad > Log de procesos"
}, {
    2479,
    "Planeación (MRP II) > Capacidad > Log de procesos > Eliminar"
}, {
    2692,
    "Planeación (MRP II) > Confirmar /Desconfirmar"
}, {
    2364,
    "Planeación (MRP II) > Consultas"
}, {
    2476,
    "Planeación (MRP II) > Consultas > Log de procesos"
}, {
    2477,
    "Planeación (MRP II) > Consultas > Log de procesos > Eliminar"
}, {
    2366,
    "Planeación (MRP II) > Consultas > Mensajes de acción"
}, {
    2369,
    "Planeación (MRP II) > Consultas > Ordenes lanzables"
}, {
    2368,
    "Planeación (MRP II) > Consultas > Ordenes planeadas"
}, {
    2691,
    "Planeación (MRP II) > Editar ordenes planeadas"
}, {
    9490,
    "Planeación (MRP II) > Generar pronósticos"
}, {
    10192,
    "Planeación (MRP II) > Generar pronósticos desde presupuesto"
}, {
    9491,
    "Planeación (MRP II) > Generar stock de seguridad"
}, {
    2391,
    "Planeación (MRP II) > Lista de recursos"
}, {
    2392,
    "Planeación (MRP II) > Lista de recursos > Adicionar"
}, {
    2395,
    "Planeación (MRP II) > Lista de recursos > Consultar"
}, {
    2394,
    "Planeación (MRP II) > Lista de recursos > Eliminar"
}, {
    2397,
    "Planeación (MRP II) > Lista de recursos > Generacion"
}, {
    2393,
    "Planeación (MRP II) > Lista de recursos > Modificar"
}, {
    2396,
    "Planeación (MRP II) > Lista de recursos > Reporte"
}, {
    2375,
    "Planeación (MRP II) > Monitor de planeación"
}, {
    2377,
    "Planeación (MRP II) > Monitor de planeación > Ordenes planeadas"
}, {
    2378,
    "Planeación (MRP II) > Monitor de planeación > Ordenes planeadas > Adicionar"
}, {
    4678,
    "Planeación (MRP II) > Monitor de planeación > Ordenes planeadas > Adicionar Múltiples"
}, {
    4680,
    "Planeación (MRP II) > Monitor de planeación > Ordenes planeadas > Permitir cambiar la cantidad"
}, {
    4681,
    "Planeación (MRP II) > Monitor de planeación > Ordenes planeadas > Permitir cambiar las fechas"
}, {
    4679,
    "Planeación (MRP II) > Monitor de planeación > Ordenes planeadas > Permitir cambiar tipo"
}, {
    2381,
    "Planeación (MRP II) > Monitor de planeación > Ordenes planeadas > Consultar"
}, {
    2380,
    "Planeación (MRP II) > Monitor de planeación > Ordenes planeadas > Eliminar"
}, {
    2379,
    "Planeación (MRP II) > Monitor de planeación > Ordenes planeadas > Modificar"
}, {
    2346,
    "Planeación (MRP II) > MPS Generación"
}, {
    3215,
    "Planeación (MRP II) > MPS Generación bajo pedido"
}, {
    12010,
    "Planeación (MRP II) > MPS Generación bajo pedido > Validar lista de materiales"
}, {
    7566,
    "Planeación (MRP II) > MPS Generación colectiva"
}, {
    8407,
    "Planeación (MRP II) > MPS Generación > Validar lista de materiales"
}, {
    8408,
    "-No implementado > Validar lista de materiales"
}, {
    2362,
    "Planeación (MRP II) > MRP Generación"
}, {
    7567,
    "Planeación (MRP II) > MRP Generación colectiva"
}, {
    2371,
    "Planeación (MRP II) > Parámetros de planeación"
}, {
    9493,
    "Planeación (MRP II) > Programación por semana"
}, {
    9494,
    "Planeación (MRP II) > Programación por semana > Adicionar"
}, {
    9495,
    "Planeación (MRP II) > Programación por semana > Consultar"
}, {
    9496,
    "Planeación (MRP II) > Programación por semana > Duplicar"
}, {
    9497,
    "Planeación (MRP II) > Programación por semana > Eliminar"
}, {
    9498,
    "Planeación (MRP II) > Programación por semana > Modificar"
}, {
    9499,
    "Planeación (MRP II) > Programación por semana > Reporte"
}, {
    2320,
    "Planeación (MRP II) > Pronósticos"
}, {
    2321,
    "Planeación (MRP II) > Pronósticos > Adicionar"
}, {
    2323,
    "Planeación (MRP II) > Pronósticos > Consultar"
}, {
    2325,
    "Planeación (MRP II) > Pronósticos > Eliminar"
}, {
    6769,
    "Planeación (MRP II) > Pronósticos > Eliminar múltiples"
}, {
    10691,
    "Planeación (MRP II) > Pronósticos > Inactivar múltiples"
}, {
    2322,
    "Planeación (MRP II) > Pronósticos > Modificar"
}, {
    2324,
    "Planeación (MRP II) > Pronósticos > Reporte"
}, {
    9500,
    "Planeación (MRP II) > Semanas"
}, {
    9501,
    "Planeación (MRP II) > Semanas > Adicionar"
}, {
    9502,
    "Planeación (MRP II) > Semanas > Consultar"
}, {
    9503,
    "Planeación (MRP II) > Semanas > Duplicar"
}, {
    9504,
    "Planeación (MRP II) > Semanas > Eliminar"
}, {
    9505,
    "Planeación (MRP II) > Semanas > Modificar"
}, {
    9506,
    "Planeación (MRP II) > Semanas > Reporte"
}, {
    9492,
    "Planeación (MRP II) > Sugerido de compras"
}, {
    9507,
    "Planeación (MRP II) > Tipos de semana"
}, {
    9508,
    "Planeación (MRP II) > Tipos de semana > Adicionar"
}, {
    9509,
    "Planeación (MRP II) > Tipos de semana > Consultar"
}, {
    9510,
    "Planeación (MRP II) > Tipos de semana > Duplicar"
}, {
    9511,
    "Planeación (MRP II) > Tipos de semana > Eliminar"
}, {
    9512,
    "Planeación (MRP II) > Tipos de semana > Modificar"
}, {
    9513,
    "Planeación (MRP II) > Tipos de semana > Reporte"
}, {
    11162,
    "-No implementado > Seleccionar opción de asumir bodega asignación"
}, {
    5707,
    "Mantenimiento Preventivo > Maestros > Asociacion de planes de mantenimiento"
}, {
    5726,
    "Mantenimiento Preventivo > Maestros > Asociacion de planes de mantenimiento > Asociacion a equipos"
}, {
    5730,
    "Mantenimiento Preventivo > Maestros > Asociacion de planes de mantenimiento > Asociacion a equipos - Grilla"
}, {
    5727,
    "Mantenimiento Preventivo > Maestros > Asociacion de planes de mantenimiento > Asociacion a localidades"
}, {
    5731,
    "Mantenimiento Preventivo > Maestros > Asociacion de planes de mantenimiento > Asociacion a localidades - Grilla"
}, {
    6931,
    "Mantenimiento Preventivo > Maestros > Operarios y categorias > Categorias"
}, {
    6932,
    "Mantenimiento Preventivo > Maestros > Operarios y categorias > Categorias > Adicionar"
}, {
    6933,
    "Mantenimiento Preventivo > Maestros > Operarios y categorias > Categorias > Consultar"
}, {
    6934,
    "Mantenimiento Preventivo > Maestros > Operarios y categorias > Categorias > Duplicar"
}, {
    6935,
    "Mantenimiento Preventivo > Maestros > Operarios y categorias > Categorias > Eliminar"
}, {
    6936,
    "Mantenimiento Preventivo > Maestros > Operarios y categorias > Categorias > Modificar"
}, {
    6937,
    "Mantenimiento Preventivo > Maestros > Operarios y categorias > Categorias > Reporte"
}, {
    5715,
    "Mantenimiento Preventivo > Maestros > Causales de Fallas"
}, {
    5776,
    "Mantenimiento Preventivo > Maestros > Causales de Fallas > Adicionar"
}, {
    5777,
    "Mantenimiento Preventivo > Maestros > Causales de Fallas > Consultar"
}, {
    5778,
    "Mantenimiento Preventivo > Maestros > Causales de Fallas > Duplicar"
}, {
    5779,
    "Mantenimiento Preventivo > Maestros > Causales de Fallas > Eliminar"
}, {
    5780,
    "Mantenimiento Preventivo > Maestros > Causales de Fallas > Modificar"
}, {
    5781,
    "Mantenimiento Preventivo > Maestros > Causales de Fallas > Reporte"
}, {
    5713,
    "Mantenimiento Preventivo > Maestros > Clases de Actividades"
}, {
    5764,
    "Mantenimiento Preventivo > Maestros > Clases de Actividades > Adicionar"
}, {
    5765,
    "Mantenimiento Preventivo > Maestros > Clases de Actividades > Consultar"
}, {
    5766,
    "Mantenimiento Preventivo > Maestros > Clases de Actividades > Duplicar"
}, {
    5767,
    "Mantenimiento Preventivo > Maestros > Clases de Actividades > Eliminar"
}, {
    5768,
    "Mantenimiento Preventivo > Maestros > Clases de Actividades > Modificar"
}, {
    5769,
    "Mantenimiento Preventivo > Maestros > Clases de Actividades > Reporte"
}, {
    5710,
    "Mantenimiento Preventivo > Maestros > Clases de Equipos"
}, {
    5744,
    "Mantenimiento Preventivo > Maestros > Clases de Equipos > Adicionar"
}, {
    5745,
    "Mantenimiento Preventivo > Maestros > Clases de Equipos > Consultar"
}, {
    5746,
    "Mantenimiento Preventivo > Maestros > Clases de Equipos > Duplicar"
}, {
    5747,
    "Mantenimiento Preventivo > Maestros > Clases de Equipos > Eliminar"
}, {
    5748,
    "Mantenimiento Preventivo > Maestros > Clases de Equipos > Modificar"
}, {
    5749,
    "Mantenimiento Preventivo > Maestros > Clases de Equipos > Reporte"
}, {
    8391,
    "Mantenimiento Preventivo > Maestros > Descripciones tecnicas"
}, {
    8392,
    "Mantenimiento Preventivo > Maestros > Descripciones tecnicas > Adicionar"
}, {
    8393,
    "Mantenimiento Preventivo > Maestros > Descripciones tecnicas > Consultar"
}, {
    8394,
    "Mantenimiento Preventivo > Maestros > Descripciones tecnicas > Duplicar"
}, {
    8395,
    "Mantenimiento Preventivo > Maestros > Descripciones tecnicas > Eliminar"
}, {
    8396,
    "Mantenimiento Preventivo > Maestros > Descripciones tecnicas > Modificar"
}, {
    8397,
    "Mantenimiento Preventivo > Maestros > Descripciones tecnicas > Reporte"
}, {
    5712,
    "Mantenimiento Preventivo > Maestros > Equipos"
}, {
    5762,
    "Mantenimiento Preventivo > Maestros > Equipos > Actividades - Grilla"
}, {
    5756,
    "Mantenimiento Preventivo > Maestros > Equipos > Adicionar"
}, {
    6506,
    "Mantenimiento Preventivo > Maestros > Equipos > Consulta de equipos"
}, {
    5757,
    "Mantenimiento Preventivo > Maestros > Equipos > Consultar"
}, {
    6507,
    "Mantenimiento Preventivo > Maestros > Equipos > Consulta de equipos > Adicionar"
}, {
    6770,
    "Mantenimiento Preventivo > Maestros > Equipos > Consulta de equipos > Bitacora del equipo - Gruilla"
}, {
    6508,
    "Mantenimiento Preventivo > Maestros > Equipos > Consulta de equipos > Modificar"
}, {
    5758,
    "Mantenimiento Preventivo > Maestros > Equipos > Duplicar"
}, {
    5759,
    "Mantenimiento Preventivo > Maestros > Equipos > Eliminar"
}, {
    5760,
    "Mantenimiento Preventivo > Maestros > Equipos > Modificar"
}, {
    5761,
    "Mantenimiento Preventivo > Maestros > Equipos > Reporte"
}, {
    5763,
    "Mantenimiento Preventivo > Maestros > Equipos > Repuestos - Grilla"
}, {
    6195,
    "Mantenimiento Preventivo > Maestros > Equipos > Repuestos - Grilla > Adicionar"
}, {
    6197,
    "Mantenimiento Preventivo > Maestros > Equipos > Repuestos - Grilla > Duplicar"
}, {
    6198,
    "Mantenimiento Preventivo > Maestros > Equipos > Repuestos - Grilla > Eliminar"
}, {
    6196,
    "Mantenimiento Preventivo > Maestros > Equipos > Repuestos - Grilla > Modificar"
}, {
    6409,
    "Mantenimiento Preventivo > Informes > Informes estadisticos"
}, {
    6410,
    "Mantenimiento Preventivo > Informes > Informes estadisticos > Analisis de fallas y causas"
}, {
    6411,
    "Mantenimiento Preventivo > Informes > Informes estadisticos > Analisis de fallas y causas > Adicionar"
}, {
    6412,
    "Mantenimiento Preventivo > Informes > Informes estadisticos > Analisis de fallas y causas > Modificar"
}, {
    6413,
    "Mantenimiento Preventivo > Informes > Informes estadisticos > Indices de mantenimiento"
}, {
    6414,
    "Mantenimiento Preventivo > Informes > Informes estadisticos > Indices de mantenimiento > Adicionar"
}, {
    6415,
    "Mantenimiento Preventivo > Informes > Informes estadisticos > Indices de mantenimiento > Modificar"
}, {
    6416,
    "Mantenimiento Preventivo > Informes > Informes estadisticos > Informe de paros y danos"
}, {
    6417,
    "Mantenimiento Preventivo > Informes > Informes estadisticos > Informe de paros y danos > Adicionar"
}, {
    6418,
    "Mantenimiento Preventivo > Informes > Informes estadisticos > Informe de paros y danos > Modificar"
}, {
    6398,
    "Mantenimiento Preventivo > Informes"
}, {
    6408,
    "Mantenimiento Preventivo > Informes > Informes de gestion"
}, {
    6400,
    "Mantenimiento Preventivo > Informes > Informes de gestion > Actividades de mnto no rutinario realizadas"
}, {
    6406,
    "Mantenimiento Preventivo > Informes > Informes de gestion > Actividades de mnto no rutinario realizadas > Adicionar"
}, {
    6407,
    "Mantenimiento Preventivo > Informes > Informes de gestion > Actividades de mnto no rutinario realizadas > Modificar"
}, {
    6399,
    "Mantenimiento Preventivo > Informes > Informes de gestion > Actividades de mantenimiento preventivo realizadas"
}, {
    6404,
    "Mantenimiento Preventivo > Informes > Informes de gestion > Actividades de mantenimiento preventivo realizadas > Adicionar"
}, {
    6405,
    "Mantenimiento Preventivo > Informes > Informes de gestion > Actividades de mantenimiento preventivo realizadas > Modificar"
}, {
    6401,
    "Mantenimiento Preventivo > Informes > Informes de gestion > Actividades realizadas Vs programadas"
}, {
    6402,
    "Mantenimiento Preventivo > Informes > Informes de gestion > Actividades realizadas Vs programadas > Adicionar"
}, {
    6403,
    "Mantenimiento Preventivo > Informes > Informes de gestion > Actividades realizadas Vs programadas > Modificar"
}, {
    5711,
    "Mantenimiento Preventivo > Maestros > Localidades"
}, {
    5750,
    "Mantenimiento Preventivo > Maestros > Localidades > Adicionar"
}, {
    6540,
    "Mantenimiento Preventivo > Maestros > Localidades > Consulta de localidades"
}, {
    5751,
    "Mantenimiento Preventivo > Maestros > Localidades > Consultar"
}, {
    6541,
    "Mantenimiento Preventivo > Maestros > Localidades > Consulta de localidades > Adicionar"
}, {
    6542,
    "Mantenimiento Preventivo > Maestros > Localidades > Consulta de localidades > Modificar"
}, {
    5752,
    "Mantenimiento Preventivo > Maestros > Localidades > Duplicar"
}, {
    5753,
    "Mantenimiento Preventivo > Maestros > Localidades > Eliminar"
}, {
    5754,
    "Mantenimiento Preventivo > Maestros > Localidades > Modificar"
}, {
    5755,
    "Mantenimiento Preventivo > Maestros > Localidades > Reporte"
}, {
    4884,
    "Mantenimiento Preventivo > Maestros"
}, {
    5728,
    "Mantenimiento Preventivo > Maestros > Asociacion de planes de mantenimiento > Mantenimientos iniciales - Equipos"
}, {
    5852,
    "Mantenimiento Preventivo > Maestros > Asociacion de planes de mantenimiento > Mantenimientos iniciales - Equipos > Consultar"
}, {
    5729,
    "Mantenimiento Preventivo > Maestros > Asociacion de planes de mantenimiento > Mantenimientos iniciales - Equipos - Grilla"
}, {
    6386,
    "Mantenimiento Preventivo > Maestros > Asociacion de planes de mantenimiento > Mantenimientos iniciales - Localidades - Grilla"
}, {
    6383,
    "Mantenimiento Preventivo > Maestros > Asociacion de planes de mantenimiento > Mantenimientos iniciales - Localidades"
}, {
    6384,
    "Mantenimiento Preventivo > Maestros > Asociacion de planes de mantenimiento > Mantenimientos iniciales - Localidades > Consultar"
}, {
    6385,
    "Mantenimiento Preventivo > Maestros > Asociacion de planes de mantenimiento > Mantenimientos iniciales - Localidades > Modificar"
}, {
    5851,
    "Mantenimiento Preventivo > Maestros > Asociacion de planes de mantenimiento > Mantenimientos iniciales - Equipos > Modificar"
}, {
    5716,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento predictivo"
}, {
    5855,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento predictivo > Historial de mediciones"
}, {
    5875,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento predictivo > Historial de mediciones > Adicionar"
}, {
    5876,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento predictivo > Historial de mediciones > Consultar"
}, {
    5877,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento predictivo > Historial de mediciones > Duplicar"
}, {
    5878,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento predictivo > Historial de mediciones > Eliminar"
}, {
    5879,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento predictivo > Historial de mediciones > Modificar"
}, {
    5880,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento predictivo > Historial de mediciones > Procesar"
}, {
    5856,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento predictivo > Listado de ruta"
}, {
    5881,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento predictivo > Listado de ruta > Adicionar"
}, {
    5882,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento predictivo > Listado de ruta > Consultar"
}, {
    5883,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento predictivo > Listado de ruta > Duplicar"
}, {
    5884,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento predictivo > Listado de ruta > Eliminar"
}, {
    5885,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento predictivo > Listado de ruta > Modificar"
}, {
    5886,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento predictivo > Listado de ruta > Reporte"
}, {
    5854,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento predictivo > Medidas fuera del limite"
}, {
    5874,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento predictivo > Medidas fuera del limite > Medidas fuera del limite - Grilla"
}, {
    5853,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento predictivo > Registro de mediciones"
}, {
    8559,
    "Mantenimiento Preventivo > Maestros > Motivos de paro"
}, {
    8560,
    "Mantenimiento Preventivo > Maestros > Motivos de paro > Adicionar"
}, {
    8561,
    "Mantenimiento Preventivo > Maestros > Motivos de paro > Consultar"
}, {
    8562,
    "Mantenimiento Preventivo > Maestros > Motivos de paro > Duplicar"
}, {
    8563,
    "Mantenimiento Preventivo > Maestros > Motivos de paro > Eliminar"
}, {
    8564,
    "Mantenimiento Preventivo > Maestros > Motivos de paro > Modificar"
}, {
    8565,
    "Mantenimiento Preventivo > Maestros > Motivos de paro > Reporte"
}, {
    6930,
    "Mantenimiento Preventivo > Maestros > Operarios y categorias > Operarios"
}, {
    6938,
    "Mantenimiento Preventivo > Maestros > Operarios y categorias > Operarios > Adicionar"
}, {
    6929,
    "Mantenimiento Preventivo > Maestros > Operarios y categorias"
}, {
    6939,
    "Mantenimiento Preventivo > Maestros > Operarios y categorias > Operarios > Consultar"
}, {
    6940,
    "Mantenimiento Preventivo > Maestros > Operarios y categorias > Operarios > Duplicar"
}, {
    6941,
    "Mantenimiento Preventivo > Maestros > Operarios y categorias > Operarios > Eliminar"
}, {
    6942,
    "Mantenimiento Preventivo > Maestros > Operarios y categorias > Operarios > Modificar"
}, {
    6943,
    "Mantenimiento Preventivo > Maestros > Operarios y categorias > Operarios > Reporte"
}, {
    4885,
    "Mantenimiento Preventivo > Ordenes de trabajo"
}, {
    6194,
    "Mantenimiento Preventivo > Ordenes de trabajo > Actualizacion de O.T. > Actividades realizadas por O.T. > Actividades realizadas por O.T. - Grilla Actividad > Modificar"
}, {
    6318,
    "Mantenimiento Preventivo > Ordenes de trabajo > Actualizacion de O.T. > Actividades realizadas por O.T. > Actividades realizadas por O.T. - Grilla Trabajos > Modificar"
}, {
    6184,
    "Mantenimiento Preventivo > Ordenes de trabajo > Actualizacion de O.T. > Actividades realizadas por O.T."
}, {
    6188,
    "Mantenimiento Preventivo > Ordenes de trabajo > Actualizacion de O.T. > Actividades realizadas por O.T. > Actividades realizadas por O.T. - Grilla Actividad"
}, {
    6187,
    "Mantenimiento Preventivo > Ordenes de trabajo > Actualizacion de O.T. > Actividades realizadas por O.T. > Actividades realizadas por O.T. - Grilla equipos"
}, {
    6189,
    "Mantenimiento Preventivo > Ordenes de trabajo > Actualizacion de O.T. > Actividades realizadas por O.T. > Actividades realizadas por O.T. - Grilla O.Ts"
}, {
    6190,
    "Mantenimiento Preventivo > Ordenes de trabajo > Actualizacion de O.T. > Actividades realizadas por O.T. > Actividades realizadas por O.T. - Grilla Trabajos"
}, {
    5722,
    "Mantenimiento Preventivo > Ordenes de trabajo > Actualizacion de O.T."
}, {
    6186,
    "Mantenimiento Preventivo > Ordenes de trabajo > Actualizacion de O.T. > Cierre de O.T."
}, {
    6191,
    "Mantenimiento Preventivo > Ordenes de trabajo > Actualizacion de O.T. > Cierre de O.T. > Adicionar"
}, {
    6192,
    "Mantenimiento Preventivo > Ordenes de trabajo > Actualizacion de O.T. > Cierre de O.T. > Filtro"
}, {
    6193,
    "Mantenimiento Preventivo > Ordenes de trabajo > Actualizacion de O.T. > Cierre de O.T. > Procesar"
}, {
    6185,
    "Mantenimiento Preventivo > Ordenes de trabajo > Actualizacion de O.T. > Actualización por actividad"
}, {
    5721,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s"
}, {
    5947,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Anulacion"
}, {
    6200,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Anulacion > Anular"
}, {
    6199,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Anulacion > Consultar"
}, {
    6201,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Anulacion > Modificar"
}, {
    5950,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Consulta de O.T´s por equipo"
}, {
    6321,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Consulta de O.T´s por equipo > Adicionar"
}, {
    6322,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Consulta de O.T´s por equipo > Modificar"
}, {
    6372,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Consulta de O.T´s por localidad"
}, {
    6373,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Consulta de O.T´s por localidad > Adicionar"
}, {
    6374,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Consulta de O.T´s por localidad > Modificar"
}, {
    5949,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Consulta de O.T´s por número"
}, {
    6319,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Consulta de O.T´s por número > Adicionar"
}, {
    6320,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Consulta de O.T´s por número > Modificar"
}, {
    5948,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Impresion"
}, {
    6202,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Impresion > Adicionar"
}, {
    6203,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Impresion > Filtro"
}, {
    6204,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Impresion > Generar"
}, {
    5946,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Para mantenimiento no rutinario - Equipos"
}, {
    5954,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Para mantenimiento no rutinario - Equipos > Adicionar"
}, {
    5955,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Para mantenimiento no rutinario - Equipos > Filtro"
}, {
    5956,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Para mantenimiento no rutinario - Equipos > Generar"
}, {
    6375,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Para mantenimiento no rutinario - Localidades"
}, {
    6376,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Para mantenimiento no rutinario - Localidades > Adicionar"
}, {
    6377,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Para mantenimiento no rutinario - Localidades > Filtro"
}, {
    6378,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Para mantenimiento no rutinario - Localidades > Generar"
}, {
    8225,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Proyeccion de repuestos - Equipos"
}, {
    8226,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Proyeccion de repuestos - Equipos > Adicionar"
}, {
    8255,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Proyeccion de repuestos - Localidades"
}, {
    8256,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Proyeccion de repuestos - Localidades > Adicionar"
}, {
    8257,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Proyeccion de repuestos - Localidades > Modificar"
}, {
    8227,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Proyeccion de repuestos - Equipos > Modificar"
}, {
    8411,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Informes"
}, {
    8412,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Informes > Resumen de costos"
}, {
    8413,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Informes > Resumen de costos > Adicionar"
}, {
    8414,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Informes > Resumen de costos > Modificar"
}, {
    5719,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento no rutinario"
}, {
    5927,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento no rutinario > Mantenimiento no rutinario"
}, {
    5925,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento no rutinario > Consulta"
}, {
    5928,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento no rutinario > Consulta > Adicionar"
}, {
    5929,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento no rutinario > Consulta > Modificar"
}, {
    5926,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento no rutinario > Mantenimiento no rutinario - Grilla"
}, {
    5930,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento no rutinario > Mantenimiento no rutinario - Grilla > Adicionar"
}, {
    5932,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento no rutinario > Mantenimiento no rutinario - Grilla > Duplicar"
}, {
    5933,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento no rutinario > Mantenimiento no rutinario - Grilla > Eliminar"
}, {
    5931,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento no rutinario > Mantenimiento no rutinario - Grilla > Modificar"
}, {
    5720,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo"
}, {
    5934,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Proyeccion del mantenimiento - Equipos"
}, {
    5936,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Proyeccion del mantenimiento - Equipos > Adicionar"
}, {
    5937,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Proyeccion del mantenimiento - Equipos > Consultar"
}, {
    5938,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Proyeccion del mantenimiento - Equipos > Duplicar"
}, {
    5939,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Proyeccion del mantenimiento - Equipos > Eliminar"
}, {
    6391,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Proyeccion del mantenimiento - Localidades"
}, {
    6392,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Proyeccion del mantenimiento - Localidades > Adicionar"
}, {
    6393,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Proyeccion del mantenimiento - Localidades > Consultar"
}, {
    6394,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Proyeccion del mantenimiento - Localidades > Duplicar"
}, {
    6395,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Proyeccion del mantenimiento - Localidades > Eliminar"
}, {
    6396,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Proyeccion del mantenimiento - Localidades > Modificar"
}, {
    6397,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Proyeccion del mantenimiento - Localidades > Procesar"
}, {
    5940,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Proyeccion del mantenimiento - Equipos > Modificar"
}, {
    5941,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Proyeccion del mantenimiento - Equipos > Procesar"
}, {
    8222,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Proyeccion de repuestos - Equipos"
}, {
    8223,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Proyeccion de repuestos - Equipos > Adicionar"
}, {
    8224,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Proyeccion de repuestos - Equipos > Modificar"
}, {
    8252,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Proyeccion de repuestos - Localidades"
}, {
    8253,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Proyeccion de repuestos - Localidades > Adicionar"
}, {
    8254,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Proyeccion de repuestos - Localidades > Modificar"
}, {
    5945,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Para mantenimiento preventivo - Equipos"
}, {
    5951,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Para mantenimiento preventivo - Equipos > Adicionar"
}, {
    5952,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Para mantenimiento preventivo - Equipos > Filtro"
}, {
    5953,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Para mantenimiento preventivo - Equipos > Generar"
}, {
    6379,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Para mantenimiento preventivo - Localidades"
}, {
    6380,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Para mantenimiento preventivo - Localidades > Adicionar"
}, {
    6381,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Para mantenimiento preventivo - Localidades > Filtro"
}, {
    6382,
    "Mantenimiento Preventivo > Ordenes de trabajo > Generador de O.T´s > Para mantenimiento preventivo - Localidades > Generar"
}, {
    5935,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Programacion manual - Equipos"
}, {
    5942,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Programacion manual - Equipos > Consultar"
}, {
    5944,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Programacion manual - Equipos > Programacion manual - Grilla"
}, {
    6387,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Programacion manual - Localidades"
}, {
    6388,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Programacion manual - Localidades > Consultar"
}, {
    6390,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Programacion manual - Localidades > Programacion manual - Grilla"
}, {
    6389,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Programacion manual - Localidades > Modificar"
}, {
    5943,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento preventivo > Programacion manual - Equipos > Modificar"
}, {
    7233,
    "Mantenimiento Preventivo > Ordenes de trabajo > Reprogramación de actividades"
}, {
    7234,
    "Mantenimiento Preventivo > Ordenes de trabajo > Reprogramación de actividades > Reprogramacion para equipos"
}, {
    7952,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Requisiciones"
}, {
    7077,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra"
}, {
    7230,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Requisiciones > Consulta por item"
}, {
    7231,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Requisiciones > Consulta por item > Adicionar"
}, {
    7232,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Requisiciones > Consulta por item > Modificar"
}, {
    7078,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Requisiciones > Captura directa de requisiciones"
}, {
    7079,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Requisiciones > Captura directa de requisiciones > Adicionar"
}, {
    7084,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Requisiciones > Captura directa de requisiciones > Anular"
}, {
    7083,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Requisiciones > Captura directa de requisiciones > Aprobar"
}, {
    7080,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Requisiciones > Captura directa de requisiciones > Consultar"
}, {
    8270,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Requisiciones > Captura directa de requisiciones > Desaprobar"
}, {
    7081,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Requisiciones > Captura directa de requisiciones > Modificar"
}, {
    7082,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Requisiciones > Captura directa de requisiciones > Reporte"
}, {
    7085,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Requisiciones > Impresion"
}, {
    7086,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Requisiciones > Impresion > Adicionar"
}, {
    7087,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Requisiciones > Impresion > Filtro"
}, {
    7088,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Requisiciones > Impresion > Generar"
}, {
    7953,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Solicitudes de compra"
}, {
    7961,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Solicitudes de compra > Consulta por item"
}, {
    7962,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Solicitudes de compra > Consulta por item > Adicionar"
}, {
    7963,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Solicitudes de compra > Consulta por item > Modificar"
}, {
    7954,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Solicitudes de compra > Captura directa"
}, {
    7955,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Solicitudes de compra > Captura directa > Adicionar"
}, {
    7956,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Solicitudes de compra > Captura directa > Anular"
}, {
    7957,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Solicitudes de compra > Captura directa > Aprobar"
}, {
    7958,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Solicitudes de compra > Captura directa > Consultar"
}, {
    7959,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Solicitudes de compra > Captura directa > Modificar"
}, {
    7960,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Solicitudes de compra > Captura directa > Reporte"
}, {
    7964,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Solicitudes de compra > Impresion"
}, {
    7965,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Solicitudes de compra > Impresion > Adicionar"
}, {
    7966,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Solicitudes de compra > Impresion > Filtro"
}, {
    7967,
    "Mantenimiento Preventivo > Ordenes de trabajo > Requisiciones y solicitudes de compra > Solicitudes de compra > Impresion > Generar"
}, {
    8215,
    "Mantenimiento Preventivo > Maestros > Parametros por compania"
}, {
    8216,
    "Mantenimiento Preventivo > Maestros > Parametros por compania > Adicionar"
}, {
    8217,
    "Mantenimiento Preventivo > Maestros > Parametros por compania > Consultar"
}, {
    8218,
    "Mantenimiento Preventivo > Maestros > Parametros por compania > Duplicar"
}, {
    8219,
    "Mantenimiento Preventivo > Maestros > Parametros por compania > Eliminar"
}, {
    8220,
    "Mantenimiento Preventivo > Maestros > Parametros por compania > Modificar"
}, {
    8221,
    "Mantenimiento Preventivo > Maestros > Parametros por compania > Reporte"
}, {
    5708,
    "Mantenimiento Preventivo > Maestros > Planes de Mantenimiento"
}, {
    5732,
    "Mantenimiento Preventivo > Maestros > Planes de Mantenimiento > Adicionar"
}, {
    5733,
    "Mantenimiento Preventivo > Maestros > Planes de Mantenimiento > Consultar"
}, {
    5734,
    "Mantenimiento Preventivo > Maestros > Planes de Mantenimiento > Duplicar"
}, {
    5735,
    "Mantenimiento Preventivo > Maestros > Planes de Mantenimiento > Eliminar"
}, {
    5736,
    "Mantenimiento Preventivo > Maestros > Planes de Mantenimiento > Modificar"
}, {
    5737,
    "Mantenimiento Preventivo > Maestros > Planes de Mantenimiento > Reporte"
}, {
    5714,
    "Mantenimiento Preventivo > Maestros > Procedimientos Estandar"
}, {
    5770,
    "Mantenimiento Preventivo > Maestros > Procedimientos Estandar > Adicionar"
}, {
    5771,
    "Mantenimiento Preventivo > Maestros > Procedimientos Estandar > Consultar"
}, {
    5772,
    "Mantenimiento Preventivo > Maestros > Procedimientos Estandar > Duplicar"
}, {
    5773,
    "Mantenimiento Preventivo > Maestros > Procedimientos Estandar > Eliminar"
}, {
    5774,
    "Mantenimiento Preventivo > Maestros > Procedimientos Estandar > Modificar"
}, {
    5775,
    "Mantenimiento Preventivo > Maestros > Procedimientos Estandar > Reporte"
}, {
    5717,
    "Mantenimiento Preventivo > Ordenes de trabajo > Registro de lecturas"
}, {
    5858,
    "Mantenimiento Preventivo > Ordenes de trabajo > Registro de lecturas > Actualización de base y uso promedio"
}, {
    5860,
    "Mantenimiento Preventivo > Ordenes de trabajo > Registro de lecturas > Actualización de base y uso promedio - Grilla"
}, {
    5859,
    "Mantenimiento Preventivo > Ordenes de trabajo > Registro de lecturas > Registro de lecturas - Grilla"
}, {
    5861,
    "Mantenimiento Preventivo > Ordenes de trabajo > Registro de lecturas > Historial de lecturas"
}, {
    5905,
    "Mantenimiento Preventivo > Ordenes de trabajo > Registro de lecturas > Historial de lecturas > Adicionar"
}, {
    5906,
    "Mantenimiento Preventivo > Ordenes de trabajo > Registro de lecturas > Historial de lecturas > Consultar"
}, {
    5907,
    "Mantenimiento Preventivo > Ordenes de trabajo > Registro de lecturas > Historial de lecturas > Duplicar"
}, {
    5908,
    "Mantenimiento Preventivo > Ordenes de trabajo > Registro de lecturas > Historial de lecturas > Eliminar"
}, {
    5909,
    "Mantenimiento Preventivo > Ordenes de trabajo > Registro de lecturas > Historial de lecturas > Modificar"
}, {
    5910,
    "Mantenimiento Preventivo > Ordenes de trabajo > Registro de lecturas > Historial de lecturas > Procesar"
}, {
    5857,
    "Mantenimiento Preventivo > Ordenes de trabajo > Registro de lecturas > Registro de lecturas"
}, {
    5873,
    "Mantenimiento Preventivo > Ordenes de trabajo > Mantenimiento predictivo > Registro de mediciones > Registro de mediciones - Grilla"
}, {
    5706,
    "Mantenimiento Preventivo > Maestros > Repuestos para mantenimiento"
}, {
    5723,
    "Mantenimiento Preventivo > Maestros > Repuestos para mantenimiento > Adicionar"
}, {
    5725,
    "Mantenimiento Preventivo > Maestros > Repuestos para mantenimiento > Modificar"
}, {
    5724,
    "Mantenimiento Preventivo > Maestros > Repuestos para mantenimiento > Reporte"
}, {
    6574,
    "Mantenimiento Preventivo > Maestros > Revisiones"
}, {
    6575,
    "Mantenimiento Preventivo > Maestros > Revisiones > Adicionar"
}, {
    6576,
    "Mantenimiento Preventivo > Maestros > Revisiones > Consultar"
}, {
    6577,
    "Mantenimiento Preventivo > Maestros > Revisiones > Duplicar"
}, {
    6578,
    "Mantenimiento Preventivo > Maestros > Revisiones > Eliminar"
}, {
    6579,
    "Mantenimiento Preventivo > Maestros > Revisiones > Modificar"
}, {
    6580,
    "Mantenimiento Preventivo > Maestros > Revisiones > Reporte"
}, {
    5718,
    "Mantenimiento Preventivo > Ordenes de trabajo > Solicitudes de mantenimiento"
}, {
    5863,
    "Mantenimiento Preventivo > Ordenes de trabajo > Solicitudes de mantenimiento > Administrador de solicitudes"
}, {
    5865,
    "Mantenimiento Preventivo > Ordenes de trabajo > Solicitudes de mantenimiento > Administrador de solicitudes - Detalle"
}, {
    5864,
    "Mantenimiento Preventivo > Ordenes de trabajo > Solicitudes de mantenimiento > Administrador de solicitudes - Grilla"
}, {
    5872,
    "Mantenimiento Preventivo > Ordenes de trabajo > Solicitudes de mantenimiento > Administrador de solicitudes > Modificar estado de solicitudes"
}, {
    5862,
    "Mantenimiento Preventivo > Ordenes de trabajo > Solicitudes de mantenimiento > Solicitudes de mantenimiento"
}, {
    5866,
    "Mantenimiento Preventivo > Ordenes de trabajo > Solicitudes de mantenimiento > Solicitudes de mantenimiento > Adicionar"
}, {
    5867,
    "Mantenimiento Preventivo > Ordenes de trabajo > Solicitudes de mantenimiento > Solicitudes de mantenimiento > Consultar"
}, {
    5868,
    "Mantenimiento Preventivo > Ordenes de trabajo > Solicitudes de mantenimiento > Solicitudes de mantenimiento > Duplicar"
}, {
    5869,
    "Mantenimiento Preventivo > Ordenes de trabajo > Solicitudes de mantenimiento > Solicitudes de mantenimiento > Eliminar"
}, {
    5870,
    "Mantenimiento Preventivo > Ordenes de trabajo > Solicitudes de mantenimiento > Solicitudes de mantenimiento > Modificar"
}, {
    5871,
    "Mantenimiento Preventivo > Ordenes de trabajo > Solicitudes de mantenimiento > Solicitudes de mantenimiento > Reporte"
}, {
    5709,
    "Mantenimiento Preventivo > Maestros > Tipos de Equipos"
}, {
    5738,
    "Mantenimiento Preventivo > Maestros > Tipos de Equipos > Adicionar"
}, {
    5739,
    "Mantenimiento Preventivo > Maestros > Tipos de Equipos > Consultar"
}, {
    5740,
    "Mantenimiento Preventivo > Maestros > Tipos de Equipos > Duplicar"
}, {
    5741,
    "Mantenimiento Preventivo > Maestros > Tipos de Equipos > Eliminar"
}, {
    5742,
    "Mantenimiento Preventivo > Maestros > Tipos de Equipos > Modificar"
}, {
    5743,
    "Mantenimiento Preventivo > Maestros > Tipos de Equipos > Reporte"
}, {
    4882,
    "Nomina"
}, {
    5368,
    "Nomina > Procesos Periodicos > Autoliquidación > Generacion de Autoliquidación"
}, {
    5397,
    "Nomina > Procesos Periodicos > Autoliquidación > Generacion de Autoliquidación > Adicionar"
}, {
    5399,
    "Nomina > Procesos Periodicos > Autoliquidación > Generacion de Autoliquidación > Consultar"
}, {
    5400,
    "Nomina > Procesos Periodicos > Autoliquidación > Generacion de Autoliquidación > Duplicar"
}, {
    5401,
    "Nomina > Procesos Periodicos > Autoliquidación > Generacion de Autoliquidación > Eliminar"
}, {
    5398,
    "Nomina > Procesos Periodicos > Autoliquidación > Generacion de Autoliquidación > Generar"
}, {
    5402,
    "Nomina > Procesos Periodicos > Autoliquidación > Generacion de Autoliquidación > Modificar"
}, {
    5403,
    "Nomina > Procesos Periodicos > Autoliquidación > Generacion de Autoliquidación > Reporte"
}, {
    6611,
    "Nomina > Liquidacion de Nomina > Abonos Prestamos"
}, {
    6612,
    "Nomina > Liquidacion de Nomina > Abonos Prestamos > Adicionar"
}, {
    6613,
    "Nomina > Liquidacion de Nomina > Abonos Prestamos > Consultar"
}, {
    6614,
    "Nomina > Liquidacion de Nomina > Abonos Prestamos > Duplicar"
}, {
    6615,
    "Nomina > Liquidacion de Nomina > Abonos Prestamos > Eliminar"
}, {
    6616,
    "Nomina > Liquidacion de Nomina > Abonos Prestamos > Modificar"
}, {
    6617,
    "Nomina > Liquidacion de Nomina > Abonos Prestamos > Reporte"
}, {
    6596,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Auditoria"
}, {
    6597,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Auditoria > Adicionar"
}, {
    6598,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Auditoria > Consultar"
}, {
    6599,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Auditoria > Duplicar"
}, {
    6600,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Auditoria > Eliminar"
}, {
    6601,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Auditoria > Filtro"
}, {
    6602,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Auditoria > Generar"
}, {
    6603,
    "Nomina > Liquidacion de Nomina > Prestaciones Sociales - Auditoria > Modificar"
}, {
    5185,
    "Nomina > Liquidacion de Nomina > Reportes > Auditoria Seguridad Social"
}, {
    4939,
    "Nomina > Liquidacion de Nomina > Codigos de Diagnosticos"
}, {
    5212,
    "Nomina > Liquidacion de Nomina > Codigos de Diagnosticos > Adicionar"
}, {
    5213,
    "Nomina > Liquidacion de Nomina > Codigos de Diagnosticos > Consultar"
}, {
    5214,
    "Nomina > Liquidacion de Nomina > Codigos de Diagnosticos > Duplicar"
}, {
    5215,
    "Nomina > Liquidacion de Nomina > Codigos de Diagnosticos > Eliminar"
}, {
    5216,
    "Nomina > Liquidacion de Nomina > Codigos de Diagnosticos > Modificar"
}, {
    5217,
    "Nomina > Liquidacion de Nomina > Codigos de Diagnosticos > Reporte"
}, {
    4946,
    "Nomina > Liquidacion de Nomina > Comprobantes de Pago"
}, {
    5249,
    "Nomina > Liquidacion de Nomina > Comprobantes de Pago > Adicionar"
}, {
    5250,
    "Nomina > Liquidacion de Nomina > Comprobantes de Pago > Filtro"
}, {
    5251,
    "Nomina > Liquidacion de Nomina > Comprobantes de Pago > Generar"
}, {
    4943,
    "Nomina > Liquidacion de Nomina > Consulta Prestamos"
}, {
    5234,
    "Nomina > Liquidacion de Nomina > Consulta Prestamos > Adicionar"
}, {
    5235,
    "Nomina > Liquidacion de Nomina > Consulta Prestamos > Consultar"
}, {
    5236,
    "Nomina > Liquidacion de Nomina > Consulta Prestamos > Duplicar"
}, {
    5237,
    "Nomina > Liquidacion de Nomina > Consulta Prestamos > Eliminar"
}, {
    5238,
    "Nomina > Liquidacion de Nomina > Consulta Prestamos > Modificar"
}, {
    5239,
    "Nomina > Liquidacion de Nomina > Consulta Prestamos > Procesar"
}, {
    4945,
    "Nomina > Liquidacion de Nomina > Consultas Transacciones"
}, {
    5243,
    "Nomina > Liquidacion de Nomina > Consultas Transacciones > Adicionar"
}, {
    5248,
    "Nomina > Liquidacion de Nomina > Consultas Transacciones > Consultar"
}, {
    5244,
    "Nomina > Liquidacion de Nomina > Consultas Transacciones > Duplicar"
}, {
    5245,
    "Nomina > Liquidacion de Nomina > Consultas Transacciones > Eliminar"
}, {
    5246,
    "Nomina > Liquidacion de Nomina > Consultas Transacciones > Modificar"
}, {
    5247,
    "Nomina > Liquidacion de Nomina > Consultas Transacciones > Procesar"
}, {
    4942,
    "Nomina > Liquidacion de Nomina > Consulta Vacaciones"
}, {
    5228,
    "Nomina > Liquidacion de Nomina > Consulta Vacaciones > Adicionar"
}, {
    5229,
    "Nomina > Liquidacion de Nomina > Consulta Vacaciones > Consultar"
}, {
    5230,
    "Nomina > Liquidacion de Nomina > Consulta Vacaciones > Duplicar"
}, {
    5231,
    "Nomina > Liquidacion de Nomina > Consulta Vacaciones > Eliminar"
}, {
    5232,
    "Nomina > Liquidacion de Nomina > Consulta Vacaciones > Modificar"
}, {
    5233,
    "Nomina > Liquidacion de Nomina > Consulta Vacaciones > Procesar"
}, {
    7044,
    "Nomina > Liquidacion de Nomina > Consulta Documentos"
}, {
    7045,
    "Nomina > Liquidacion de Nomina > Consulta Documentos > Adicionar"
}, {
    7046,
    "Nomina > Liquidacion de Nomina > Consulta Documentos > Filtro"
}, {
    7047,
    "Nomina > Liquidacion de Nomina > Consulta Documentos > Generar"
}, {
    7694,
    "Nomina > Liquidacion de Nomina > Distribucion devengos proceso"
}, {
    7725,
    "Nomina > Liquidacion de Nomina > Distribucion devengos proceso > Adicionar"
}, {
    7726,
    "Nomina > Liquidacion de Nomina > Distribucion devengos proceso > Consultar"
}, {
    7727,
    "Nomina > Liquidacion de Nomina > Distribucion devengos proceso > Duplicar"
}, {
    7728,
    "Nomina > Liquidacion de Nomina > Distribucion devengos proceso > Eliminar"
}, {
    7729,
    "Nomina > Liquidacion de Nomina > Distribucion devengos proceso > Modificar"
}, {
    7730,
    "Nomina > Liquidacion de Nomina > Distribucion devengos proceso > Reporte"
}, {
    7693,
    "Nomina > Liquidacion de Nomina > Distribucion devengos"
}, {
    7719,
    "Nomina > Liquidacion de Nomina > Distribucion devengos > Adicionar"
}, {
    7720,
    "Nomina > Liquidacion de Nomina > Distribucion devengos > Consultar"
}, {
    7721,
    "Nomina > Liquidacion de Nomina > Distribucion devengos > Duplicar"
}, {
    7722,
    "Nomina > Liquidacion de Nomina > Distribucion devengos > Eliminar"
}, {
    7723,
    "Nomina > Liquidacion de Nomina > Distribucion devengos > Modificar"
}, {
    7724,
    "Nomina > Liquidacion de Nomina > Distribucion devengos > Reporte"
}, {
    7691,
    "Nomina > Liquidacion de Nomina > Informe Ausentismo"
}, {
    7707,
    "Nomina > Liquidacion de Nomina > Informe Ausentismo > Adicionar"
}, {
    7708,
    "Nomina > Liquidacion de Nomina > Informe Ausentismo > Consutar"
}, {
    7709,
    "Nomina > Liquidacion de Nomina > Informe Ausentismo > Duplicar"
}, {
    7710,
    "Nomina > Liquidacion de Nomina > Informe Ausentismo > Eliminar"
}, {
    7711,
    "Nomina > Liquidacion de Nomina > Informe Ausentismo > Modificar"
}, {
    7712,
    "Nomina > Liquidacion de Nomina > Informe Ausentismo > Reporte"
}, {
    4947,
    "Nomina > Liquidacion de Nomina > Transacciones Via Interfase"
}, {
    4890,
    "Nomina > Liquidacion de Nomina"
}, {
    7253,
    "Nomina > Liquidacion de Nomina > Consulta_Abonos > Reporte"
}, {
    7425,
    "Nomina > Liquidacion de Nomina > Consulta Aniversario Empresa"
}, {
    7426,
    "Nomina > Liquidacion de Nomina > Consulta Aniversario Empresa > Consultar"
}, {
    7427,
    "Nomina > Liquidacion de Nomina > Consulta Aniversario Empresa > Procesar"
}, {
    7419,
    "Nomina > Liquidacion de Nomina > Consulta Balance de Recurso"
}, {
    7420,
    "Nomina > Liquidacion de Nomina > Consulta Balance de Recurso > Consultar"
}, {
    7421,
    "Nomina > Liquidacion de Nomina > Consulta Balance de Recurso > Procesar"
}, {
    7251,
    "Nomina > Liquidacion de Nomina > Consulta_Abonos"
}, {
    7252,
    "Nomina > Liquidacion de Nomina > Consulta_Abonos > Consultar"
}, {
    8251,
    "Nomina > Liquidacion de Nomina > Consulta cuotas"
}, {
    7529,
    "Nomina > Liquidacion de Nomina > Consulta Acumulados 12 Meses"
}, {
    7530,
    "Nomina > Liquidacion de Nomina > Consulta Acumulados 12 Meses > Consultar"
}, {
    7531,
    "Nomina > Liquidacion de Nomina > Consulta Acumulados 12 Meses > Procesar"
}, {
    7433,
    "Nomina > Liquidacion de Nomina > Consulta Cumpleaños"
}, {
    7434,
    "Nomina > Liquidacion de Nomina > Consultar"
}, {
    7435,
    "Nomina > Liquidacion de Nomina > Procesar"
}, {
    4929,
    "Nomina > Liquidacion de Nomina > Cuotas Individuales - Contratos"
}, {
    4926,
    "Nomina > Liquidacion de Nomina > Prestamos - Contratos"
}, {
    4933,
    "Nomina > Liquidacion de Nomina > Tiempo no laborado - Contratos"
}, {
    5175,
    "Nomina > Liquidacion de Nomina > Tiempo no laborado - Contratos > Adicionar"
}, {
    5173,
    "Nomina > Liquidacion de Nomina > Tiempo no laborado - Contratos > Consultar"
}, {
    5176,
    "Nomina > Liquidacion de Nomina > Tiempo no laborado - Contratos > Duplicar"
}, {
    5177,
    "Nomina > Liquidacion de Nomina > Tiempo no laborado - Contratos > Eliminar"
}, {
    5178,
    "Nomina > Liquidacion de Nomina > Tiempo no laborado - Contratos > Modificar"
}, {
    5174,
    "Nomina > Liquidacion de Nomina > Tiempo no laborado - Contratos > Reporte"
}, {
    5149,
    "Nomina > Liquidacion de Nomina > Cuotas Individuales - Contratos > Adicionar"
}, {
    5151,
    "Nomina > Liquidacion de Nomina > Cuotas Individuales - Contratos > Consultar"
}, {
    5152,
    "Nomina > Liquidacion de Nomina > Cuotas Individuales - Contratos > Duplicar"
}, {
    5153,
    "Nomina > Liquidacion de Nomina > Cuotas Individuales - Contratos > Eliminar"
}, {
    5154,
    "Nomina > Liquidacion de Nomina > Cuotas Individuales - Contratos > Modificar"
}, {
    5150,
    "Nomina > Liquidacion de Nomina > Cuotas Individuales - Contratos > Reporte"
}, {
    5135,
    "Nomina > Liquidacion de Nomina > Prestamos - Contratos > Adicionar"
}, {
    5134,
    "Nomina > Liquidacion de Nomina > Prestamos - Contratos > Consultar"
}, {
    5136,
    "Nomina > Liquidacion de Nomina > Prestamos - Contratos > Duplicar"
}, {
    5137,
    "Nomina > Liquidacion de Nomina > Prestamos - Contratos > Eliminar"
}, {
    5138,
    "Nomina > Liquidacion de Nomina > Prestamos - Contratos > Modificar"
}, {
    5139,
    "Nomina > Liquidacion de Nomina > Prestamos - Contratos > Reporte"
}, {
    5200,
    "Nomina > Liquidacion de Nomina > Programacion Vacaciones - Contratos > Adicionar"
}, {
    5204,
    "Nomina > Liquidacion de Nomina > Programacion Vacaciones - Contratos > Consultar"
}, {
    5201,
    "Nomina > Liquidacion de Nomina > Programacion Vacaciones - Contratos > Duplicar"
}, {
    5202,
    "Nomina > Liquidacion de Nomina > Programacion Vacaciones - Contratos > Eliminar"
}, {
    5203,
    "Nomina > Liquidacion de Nomina > Programacion Vacaciones - Contratos > Modificar"
}, {
    5205,
    "Nomina > Liquidacion de Nomina > Programacion Vacaciones - Contratos > Reporte"
}, {
    8118,
    "Nomina > Liquidacion de Nomina > Copia de cuotas"
}, {
    8120,
    "Nomina > Liquidacion de Nomina > Copia de cuotas > Adicionar"
}, {
    8121,
    "Nomina > Liquidacion de Nomina > Copia de cuotas > Consultar"
}, {
    8122,
    "Nomina > Liquidacion de Nomina > Copia de cuotas > Duplicar"
}, {
    8123,
    "Nomina > Liquidacion de Nomina > Copia de cuotas > Eliminar"
}, {
    8124,
    "Nomina > Liquidacion de Nomina > Copia de cuotas > Modificar"
}, {
    8125,
    "Nomina > Liquidacion de Nomina > Copia de cuotas > Procesar"
}, {
    8119,
    "Nomina > Liquidacion de Nomina > Copia distribucion"
}, {
    8132,
    "Nomina > Liquidacion de Nomina > Copia distribucion > Adicionar"
}, {
    8133,
    "Nomina > Liquidacion de Nomina > Copia distribucion > Consultar"
}, {
    8134,
    "Nomina > Liquidacion de Nomina > Copia distribucion > Duplicar"
}, {
    8135,
    "Nomina > Liquidacion de Nomina > Copia distribucion > Eliminar"
}, {
    8136,
    "Nomina > Liquidacion de Nomina > Copia distribucion > Modificar"
}, {
    8137,
    "Nomina > Liquidacion de Nomina > Copia distribucion > Procesar"
}, {
    8117,
    "Nomina > Liquidacion de Nomina > Copia de prestamos"
}, {
    8126,
    "Nomina > Liquidacion de Nomina > Copia de prestamos > Adicionar"
}, {
    8127,
    "Nomina > Liquidacion de Nomina > Copia de prestamos > Consultar"
}, {
    8128,
    "Nomina > Liquidacion de Nomina > Copia de prestamos > Duplicar"
}, {
    8129,
    "Nomina > Liquidacion de Nomina > Copia de prestamos > Eliminar"
}, {
    8130,
    "Nomina > Liquidacion de Nomina > Copia de prestamos > Modificar"
}, {
    8131,
    "Nomina > Liquidacion de Nomina > Copia de prestamos > Procesar"
}, {
    4932,
    "Nomina > Liquidacion de Nomina > Cruce de Incapacidades"
}, {
    5167,
    "Nomina > Liquidacion de Nomina > Cruce de Incapacidades > Adicionar"
}, {
    5168,
    "Nomina > Liquidacion de Nomina > Cruce de Incapacidades > Consultar"
}, {
    5169,
    "Nomina > Liquidacion de Nomina > Cruce de Incapacidades > Duplicar"
}, {
    5170,
    "Nomina > Liquidacion de Nomina > Cruce de Incapacidades > Eliminar"
}, {
    5171,
    "Nomina > Liquidacion de Nomina > Cruce de Incapacidades > Modificar"
}, {
    5172,
    "Nomina > Liquidacion de Nomina > Cruce de Incapacidades > Reporte"
}, {
    4930,
    "Nomina > Liquidacion de Nomina > Cuotas Fijas y Genericas"
}, {
    5155,
    "Nomina > Liquidacion de Nomina > Cuotas Fijas y Genericas > Adicionar"
}, {
    5156,
    "Nomina > Liquidacion de Nomina > Cuotas Fijas y Genericas > Consultar"
}, {
    5157,
    "Nomina > Liquidacion de Nomina > Cuotas Fijas y Genericas > Duplicar"
}, {
    5158,
    "Nomina > Liquidacion de Nomina > Cuotas Fijas y Genericas > Eliminar"
}, {
    5159,
    "Nomina > Liquidacion de Nomina > Cuotas Fijas y Genericas > Modificar"
}, {
    5160,
    "Nomina > Liquidacion de Nomina > Cuotas Fijas y Genericas > Reporte"
}, {
    4938,
    "Nomina > Liquidacion de Nomina > Cuotas Individuales"
}, {
    5206,
    "Nomina > Liquidacion de Nomina > Cuotas Individuales > Adicionar"
}, {
    5207,
    "Nomina > Liquidacion de Nomina > Cuotas Individuales > Consultar"
}, {
    5208,
    "Nomina > Liquidacion de Nomina > Cuotas Individuales > Duplicar"
}, {
    5209,
    "Nomina > Liquidacion de Nomina > Cuotas Individuales > Eliminar"
}, {
    5210,
    "Nomina > Liquidacion de Nomina > Cuotas Individuales > Modificar"
}, {
    5211,
    "Nomina > Liquidacion de Nomina > Cuotas Individuales > Reporte"
}, {
    7261,
    "Nomina > Liquidacion de Nomina > Documentos Recalculo"
}, {
    7262,
    "Nomina > Liquidacion de Nomina > Documentos Recalculo > Adicionar"
}, {
    7263,
    "Nomina > Liquidacion de Nomina > Documentos Recalculo > Consultar"
}, {
    7264,
    "Nomina > Liquidacion de Nomina > Documentos Recalculo > Duplicar"
}, {
    7265,
    "Nomina > Liquidacion de Nomina > Documentos Recalculo > Eliminar"
}, {
    7266,
    "Nomina > Liquidacion de Nomina > Documentos Recalculo > Modificar"
}, {
    7267,
    "Nomina > Liquidacion de Nomina > Documentos Recalculo > Reporte"
}, {
    4935,
    "Nomina > Liquidacion de Nomina > Documentos de Nomina"
}, {
    5186,
    "Nomina > Liquidacion de Nomina > Documentos de Nomina > Adicionar"
}, {
    5193,
    "Nomina > Liquidacion de Nomina > Documentos de Nomina > Anular"
}, {
    5192,
    "Nomina > Liquidacion de Nomina > Documentos de Nomina > Aprobar"
}, {
    5187,
    "Nomina > Liquidacion de Nomina > Documentos de Nomina > Consultar"
}, {
    5188,
    "Nomina > Liquidacion de Nomina > Documentos de Nomina > Duplicar"
}, {
    5189,
    "Nomina > Liquidacion de Nomina > Documentos de Nomina > Eliminar"
}, {
    5190,
    "Nomina > Liquidacion de Nomina > Documentos de Nomina > Modificar"
}, {
    5191,
    "Nomina > Liquidacion de Nomina > Documentos de Nomina > Reporte"
}, {
    4928,
    "Nomina > Liquidacion de Nomina > Transmision de Empleados entre Documentos"
}, {
    5146,
    "Nomina > Liquidacion de Nomina > Transmision de Empleados entre Documentos > Adicionar"
}, {
    5147,
    "Nomina > Liquidacion de Nomina > Transmision de Empleados entre Documentos > Filtro"
}, {
    5148,
    "Nomina > Liquidacion de Nomina > Transmision de Empleados entre Documentos > Generar"
}, {
    4925,
    "Nomina > Liquidacion de Nomina > Periodos de Nomina"
}, {
    5133,
    "Nomina > Liquidacion de Nomina > Periodos de Nomina > Adicionar"
}, {
    5128,
    "Nomina > Liquidacion de Nomina > Periodos de Nomina > Consultar"
}, {
    5129,
    "Nomina > Liquidacion de Nomina > Periodos de Nomina > Duplicar"
}, {
    5130,
    "Nomina > Liquidacion de Nomina > Periodos de Nomina > Eliminar"
}, {
    5131,
    "Nomina > Liquidacion de Nomina > Periodos de Nomina > Modificar"
}, {
    5132,
    "Nomina > Liquidacion de Nomina > Periodos de Nomina > Reporte"
}, {
    4927,
    "Nomina > Liquidacion de Nomina > Prestamos"
}, {
    5140,
    "Nomina > Liquidacion de Nomina > Prestamos > Adicionar"
}, {
    5141,
    "Nomina > Liquidacion de Nomina > Prestamos > Consultar"
}, {
    5142,
    "Nomina > Liquidacion de Nomina > Prestamos > Duplicar"
}, {
    5143,
    "Nomina > Liquidacion de Nomina > Prestamos > Eliminar"
}, {
    5144,
    "Nomina > Liquidacion de Nomina > Prestamos > Modificar"
}, {
    5145,
    "Nomina > Liquidacion de Nomina > Prestamos > Reporte"
}, {
    7268,
    "Nomina > Liquidacion de Nomina > Proceso Recalculo"
}, {
    7269,
    "Nomina > Liquidacion de Nomina > Proceso Recalculo > Adicionar"
}, {
    7270,
    "Nomina > Liquidacion de Nomina > Proceso Recalculo > Filtro"
}, {
    7271,
    "Nomina > Liquidacion de Nomina > Proceso Recalculo > Generar"
}, {
    7429,
    "Nomina > Liquidacion de Nomina > Recalculo de retenciones"
}, {
    7430,
    "Nomina > Liquidacion de Nomina > Recalculo de retenciones > Adicionar"
}, {
    7431,
    "Nomina > Liquidacion de Nomina > Recalculo de retenciones > Filtro"
}, {
    7432,
    "Nomina > Liquidacion de Nomina > Recalculo de retenciones > Generar"
}, {
    7690,
    "Nomina > Liquidacion de Nomina > Recal Salud Obligatoria"
}, {
    7689,
    "Nomina > Liquidacion de Nomina > Subsidio transporte"
}, {
    4934,
    "Nomina > Liquidacion de Nomina > Reportes"
}, {
    5184,
    "Nomina > Liquidacion de Nomina > Reportes > Auditoria Retecion en la Fuente"
}, {
    5183,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Prestaciones Sociales"
}, {
    5182,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Prestamos"
}, {
    5310,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Prestamos > Adicionar"
}, {
    5311,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Prestamos > Consultar"
}, {
    5312,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Prestamos > Duplicar"
}, {
    5313,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Prestamos > Eliminar"
}, {
    5314,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Prestamos > Modificar"
}, {
    5315,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Prestamos > Reporte"
}, {
    5179,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Tiempo no laborado"
}, {
    5292,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Tiempo no laborado > Adicionar"
}, {
    5293,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Tiempo no laborado > Consultar"
}, {
    5294,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Tiempo no laborado > Duplicar"
}, {
    5295,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Tiempo no laborado > Eliminar"
}, {
    5296,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Tiempo no laborado > Modificar"
}, {
    5297,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Tiempo no laborado > Reporte"
}, {
    5181,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Transacciones"
}, {
    5304,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Transacciones > Adicionar"
}, {
    5305,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Transacciones > Consultar"
}, {
    5306,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Transacciones > Duplicar"
}, {
    5307,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Transacciones > Eliminar"
}, {
    5308,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Transacciones > Modificar"
}, {
    5309,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Transacciones > Reporte"
}, {
    5180,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte Vacaciones"
}, {
    5298,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte Vacaciones > Adicionar"
}, {
    5299,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte Vacaciones > Consultar"
}, {
    5300,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte Vacaciones > Duplicar"
}, {
    5301,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte Vacaciones > Eliminar"
}, {
    5302,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte Vacaciones > Modificar"
}, {
    5303,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte Vacaciones > Reporte"
}, {
    5316,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Prestaciones Sociales > Adicionar"
}, {
    5317,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Prestaciones Sociales > Consultar"
}, {
    5318,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Prestaciones Sociales > Duplicar"
}, {
    5319,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Prestaciones Sociales > Eliminar"
}, {
    5320,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Prestaciones Sociales > Modificar"
}, {
    5321,
    "Nomina > Liquidacion de Nomina > Reportes > Reporte de Prestaciones Sociales > Reporte"
}, {
    4931,
    "Nomina > Liquidacion de Nomina > Tiempo no laborado"
}, {
    5161,
    "Nomina > Liquidacion de Nomina > Tiempo no laborado > Adicionar"
}, {
    5162,
    "Nomina > Liquidacion de Nomina > Tiempo no laborado > Consultar"
}, {
    5163,
    "Nomina > Liquidacion de Nomina > Tiempo no laborado > Duplicar"
}, {
    5164,
    "Nomina > Liquidacion de Nomina > Tiempo no laborado > Eliminar"
}, {
    5165,
    "Nomina > Liquidacion de Nomina > Tiempo no laborado > Modificar"
}, {
    5166,
    "Nomina > Liquidacion de Nomina > Tiempo no laborado > Reporte"
}, {
    4936,
    "Nomina > Liquidacion de Nomina > Programacion de Vacaciones"
}, {
    5194,
    "Nomina > Liquidacion de Nomina > Programacion de Vacaciones > Adicionar"
}, {
    5195,
    "Nomina > Liquidacion de Nomina > Programacion de Vacaciones > Consultar"
}, {
    4937,
    "Nomina > Liquidacion de Nomina > Programacion Vacaciones - Contratos"
}, {
    5196,
    "Nomina > Liquidacion de Nomina > Programacion de Vacaciones > Duplicar"
}, {
    5197,
    "Nomina > Liquidacion de Nomina > Programacion de Vacaciones > Eliminar"
}, {
    5198,
    "Nomina > Liquidacion de Nomina > Programacion de Vacaciones > Modificar"
}, {
    5199,
    "Nomina > Liquidacion de Nomina > Programacion de Vacaciones > Reporte"
}, {
    7422,
    "Nomina > Liquidacion de Nomina > Consulta Vacaciones Pendientes"
}, {
    7423,
    "Nomina > Liquidacion de Nomina > Consulta Vacaciones Pendientes > Consultar"
}, {
    7424,
    "Nomina > Liquidacion de Nomina > Consulta Vacaciones Pendientes > Procesar"
}, {
    7416,
    "Nomina > Liquidacion de Nomina > Consulta Vencimiento de contratos"
}, {
    7417,
    "Nomina > Liquidacion de Nomina > Consulta Vencimiento de contratos > Consultar"
}, {
    7418,
    "Nomina > Liquidacion de Nomina > Consulta Vencimiento de contratos > Procesar"
}, {
    4944,
    "Nomina > Liquidacion de Nomina > Generacion Pagos Electronicos"
}, {
    5240,
    "Nomina > Liquidacion de Nomina > Generacion Pagos Electronicos > Adicionar"
}, {
    5241,
    "Nomina > Liquidacion de Nomina > Generacion Pagos Electronicos > Filtro"
}, {
    5242,
    "Nomina > Liquidacion de Nomina > Generacion Pagos Electronicos > Generar"
}, {
    7701,
    "Nomina > Liquidacion de Nomina > Recal Salud Obligatoria > Adicionar"
}, {
    7702,
    "Nomina > Liquidacion de Nomina > Recal Salud Obligatoria > Consultar"
}, {
    7703,
    "Nomina > Liquidacion de Nomina > Recal Salud Obligatoria > Duplicar"
}, {
    7704,
    "Nomina > Liquidacion de Nomina > Recal Salud Obligatoria > Eliminar"
}, {
    7705,
    "Nomina > Liquidacion de Nomina > Recal Salud Obligatoria > Modificar"
}, {
    7706,
    "Nomina > Liquidacion de Nomina > Recal Salud Obligatoria > Reporte"
}, {
    7695,
    "Nomina > Liquidacion de Nomina > Subsidio transporte > Adicionar"
}, {
    7696,
    "Nomina > Liquidacion de Nomina > Subsidio transporte > Consultar"
}, {
    7697,
    "Nomina > Liquidacion de Nomina > Subsidio transporte > Duplicar"
}, {
    7698,
    "Nomina > Liquidacion de Nomina > Subsidio transporte > Eliminar"
}, {
    7699,
    "Nomina > Liquidacion de Nomina > Subsidio transporte > Modificar"
}, {
    7700,
    "Nomina > Liquidacion de Nomina > Subsidio transporte > Reporte"
}, {
    6604,
    "Nomina > Liquidacion de Nomina > Reestructuracion Prestamos"
}, {
    6605,
    "Nomina > Liquidacion de Nomina > Reestructuracion Prestamos > Adicionar"
}, {
    6606,
    "Nomina > Liquidacion de Nomina > Reestructuracion Prestamos > Consultar"
}, {
    6607,
    "Nomina > Liquidacion de Nomina > Reestructuracion Prestamos > Duplicar"
}, {
    6608,
    "Nomina > Liquidacion de Nomina > Reestructuracion Prestamos > Eliminar"
}, {
    6609,
    "Nomina > Liquidacion de Nomina > Reestructuracion Prestamos > Modificar"
}, {
    6610,
    "Nomina > Liquidacion de Nomina > Reestructuracion Prestamos > Reporte"
}, {
    7692,
    "Nomina > Liquidacion de Nomina > Retencion Contingente"
}, {
    7713,
    "Nomina > Liquidacion de Nomina > Retencion Contingente > Adicionar"
}, {
    7714,
    "Nomina > Liquidacion de Nomina > Retencion Contingente > Consultar"
}, {
    7715,
    "Nomina > Liquidacion de Nomina > Retencion Contingente > Duplicar"
}, {
    7716,
    "Nomina > Liquidacion de Nomina > Retencion Contingente > Eliminar"
}, {
    7717,
    "Nomina > Liquidacion de Nomina > Retencion Contingente > Modificar"
}, {
    7718,
    "Nomina > Liquidacion de Nomina > Retencion Contingente > Reporte"
}, {
    5322,
    "Nomina > Liquidacion de Nomina > Reportes > Auditoria Retecion en la Fuente > Adicionar"
}, {
    5323,
    "Nomina > Liquidacion de Nomina > Reportes > Auditoria Retecion en la Fuente > Consultar"
}, {
    5324,
    "Nomina > Liquidacion de Nomina > Reportes > Auditoria Retecion en la Fuente > Duplicar"
}, {
    5325,
    "Nomina > Liquidacion de Nomina > Reportes > Auditoria Retecion en la Fuente > Eliminar"
}, {
    5326,
    "Nomina > Liquidacion de Nomina > Reportes > Auditoria Retecion en la Fuente > Modificar"
}, {
    5327,
    "Nomina > Liquidacion de Nomina > Reportes > Auditoria Retecion en la Fuente > Reporte"
}, {
    5328,
    "Nomina > Liquidacion de Nomina > Reportes > Auditoria Seguridad Social > Adicionar"
}, {
    5329,
    "Nomina > Liquidacion de Nomina > Reportes > Auditoria Seguridad Social > Consultar"
}, {
    5330,
    "Nomina > Liquidacion de Nomina > Reportes > Auditoria Seguridad Social > Duplicar"
}, {
    5331,
    "Nomina > Liquidacion de Nomina > Reportes > Auditoria Seguridad Social > Eliminar"
}, {
    5332,
    "Nomina > Liquidacion de Nomina > Reportes > Auditoria Seguridad Social > Modificar"
}, {
    5333,
    "Nomina > Liquidacion de Nomina > Reportes > Auditoria Seguridad Social > Reporte"
}, {
    4902,
    "Nomina > Maestros de nómina > Agrupacion de conceptos"
}, {
    5019,
    "Nomina > Maestros de nómina > Agrupacion de conceptos > Adicionar"
}, {
    5020,
    "Nomina > Maestros de nómina > Agrupacion de conceptos > Consultar"
}, {
    5021,
    "Nomina > Maestros de nómina > Agrupacion de conceptos > Duplicar"
}, {
    5022,
    "Nomina > Maestros de nómina > Agrupacion de conceptos > Eliminar"
}, {
    5023,
    "Nomina > Maestros de nómina > Agrupacion de conceptos > Modificar"
}, {
    5024,
    "Nomina > Maestros de nómina > Agrupacion de conceptos > Reporte"
}, {
    6567,
    "Nomina > Maestros de nómina > Areas Organizacionales"
}, {
    6568,
    "Nomina > Maestros de nómina > Areas Organizacionales > Adicionar"
}, {
    6569,
    "Nomina > Maestros de nómina > Areas Organizacionales > Consultar"
}, {
    6570,
    "Nomina > Maestros de nómina > Areas Organizacionales > Duplicar"
}, {
    6571,
    "Nomina > Maestros de nómina > Areas Organizacionales > Eliminar"
}, {
    6572,
    "Nomina > Maestros de nómina > Areas Organizacionales > Modificar"
}, {
    6573,
    "Nomina > Maestros de nómina > Areas Organizacionales > Reporte"
}, {
    4897,
    "Nomina > Maestros de nómina > Cambio de Entidades Planilla Integrada"
}, {
    4988,
    "Nomina > Maestros de nómina > Cambio de Entidades Planilla Integrada > Adicionar"
}, {
    4989,
    "Nomina > Maestros de nómina > Cambio de Entidades Planilla Integrada > Consultar"
}, {
    4990,
    "Nomina > Maestros de nómina > Cambio de Entidades Planilla Integrada > Duplicar"
}, {
    4991,
    "Nomina > Maestros de nómina > Cambio de Entidades Planilla Integrada > Eliminar"
}, {
    4992,
    "Nomina > Maestros de nómina > Cambio de Entidades Planilla Integrada > Modificar"
}, {
    4993,
    "Nomina > Maestros de nómina > Cambio de Entidades Planilla Integrada > Reporte"
}, {
    4917,
    "Nomina > Maestros de nómina > Cargos"
}, {
    5109,
    "Nomina > Maestros de nómina > Cargos > Adicionar"
}, {
    5110,
    "Nomina > Maestros de nómina > Cargos > Consultar"
}, {
    5111,
    "Nomina > Maestros de nómina > Cargos > Duplicar"
}, {
    5112,
    "Nomina > Maestros de nómina > Cargos > Eliminar"
}, {
    5113,
    "Nomina > Maestros de nómina > Cargos > Modificar"
}, {
    5114,
    "Nomina > Maestros de nómina > Cargos > Reporte"
}, {
    5115,
    "Nomina > Maestros de nómina > Clasificacion Nacional de Ocupaciones > Adicionar"
}, {
    5116,
    "Nomina > Maestros de nómina > Clasificacion Nacional de Ocupaciones > Consultar"
}, {
    5117,
    "Nomina > Maestros de nómina > Clasificacion Nacional de Ocupaciones > Duplicar"
}, {
    5118,
    "Nomina > Maestros de nómina > Clasificacion Nacional de Ocupaciones > Eliminar"
}, {
    5119,
    "Nomina > Maestros de nómina > Clasificacion Nacional de Ocupaciones > Modificar"
}, {
    5120,
    "Nomina > Maestros de nómina > Clasificacion Nacional de Ocupaciones > Reporte"
}, {
    4909,
    "Nomina > Maestros de nómina > Centros de trabajo"
}, {
    5061,
    "Nomina > Maestros de nómina > Centros de trabajo > Adicionar"
}, {
    5062,
    "Nomina > Maestros de nómina > Centros de trabajo > Consultar"
}, {
    5063,
    "Nomina > Maestros de nómina > Centros de trabajo > Duplicar"
}, {
    5064,
    "Nomina > Maestros de nómina > Centros de trabajo > Eliminar"
}, {
    5065,
    "Nomina > Maestros de nómina > Centros de trabajo > Modificar"
}, {
    5066,
    "Nomina > Maestros de nómina > Centros de trabajo > Reporte"
}, {
    8357,
    "Nomina > Maestros de nómina > Certificado laboral"
}, {
    4918,
    "Nomina > Maestros de nómina > Clasificacion Nacional de Ocupaciones"
}, {
    4895,
    "Nomina > Maestros de nómina > Codigos de Consolidacion"
}, {
    4979,
    "Nomina > Maestros de nómina > Codigos de Consolidacion > Adicionar"
}, {
    4980,
    "Nomina > Maestros de nómina > Codigos de Consolidacion > Consultar"
}, {
    4981,
    "Nomina > Maestros de nómina > Codigos de Consolidacion > Duplicar"
}, {
    4976,
    "Nomina > Maestros de nómina > Codigos de Consolidacion > Eliminar"
}, {
    4977,
    "Nomina > Maestros de nómina > Codigos de Consolidacion > Modificar"
}, {
    4978,
    "Nomina > Maestros de nómina > Codigos de Consolidacion > Reporte"
}, {
    4915,
    "Nomina > Maestros de nómina > Codigo nacional de entidades"
}, {
    5097,
    "Nomina > Maestros de nómina > Codigo nacional de entidades > Adicionar"
}, {
    5098,
    "Nomina > Maestros de nómina > Codigo nacional de entidades > Consultar"
}, {
    5099,
    "Nomina > Maestros de nómina > Codigo nacional de entidades > Duplicar"
}, {
    5100,
    "Nomina > Maestros de nómina > Codigo nacional de entidades > Eliminar"
}, {
    5101,
    "Nomina > Maestros de nómina > Codigo nacional de entidades > Modificar"
}, {
    5102,
    "Nomina > Maestros de nómina > Codigo nacional de entidades > Reporte"
}, {
    4903,
    "Nomina > Maestros de nómina > Conceptos"
}, {
    5025,
    "Nomina > Maestros de nómina > Conceptos > Adicionar"
}, {
    5026,
    "Nomina > Maestros de nómina > Conceptos > Consultar"
}, {
    5027,
    "Nomina > Maestros de nómina > Conceptos > Duplicar"
}, {
    5028,
    "Nomina > Maestros de nómina > Conceptos > Eliminar"
}, {
    5029,
    "Nomina > Maestros de nómina > Conceptos > Modificar"
}, {
    5030,
    "Nomina > Maestros de nómina > Conceptos > Reporte"
}, {
    4919,
    "Nomina > Maestros de nómina > Consulta de Maestros"
}, {
    5121,
    "Nomina > Maestros de nómina > Consulta de Maestros > Adicionar"
}, {
    5122,
    "Nomina > Maestros de nómina > Consulta de Maestros > Consultar"
}, {
    5123,
    "Nomina > Maestros de nómina > Consulta de Maestros > Duplicar"
}, {
    5124,
    "Nomina > Maestros de nómina > Consulta de Maestros > Eliminar"
}, {
    5125,
    "Nomina > Maestros de nómina > Consulta de Maestros > Modificar"
}, {
    5126,
    "Nomina > Maestros de nómina > Consulta de Maestros > Procesar"
}, {
    4905,
    "Nomina > Maestros de nómina > Contratos"
}, {
    5037,
    "Nomina > Maestros de nómina > Contratos > Adicionar"
}, {
    5038,
    "Nomina > Maestros de nómina > Contratos > Consultar"
}, {
    5039,
    "Nomina > Maestros de nómina > Contratos > Duplicar"
}, {
    5040,
    "Nomina > Maestros de nómina > Contratos > Eliminar"
}, {
    5041,
    "Nomina > Maestros de nómina > Contratos > Modificar"
}, {
    5042,
    "Nomina > Maestros de nómina > Contratos > Reporte"
}, {
    7532,
    "Nomina > Maestros de nómina > Copia Contratos Colectiva"
}, {
    7533,
    "Nomina > Maestros de nómina > Copia Contratos Colectiva > Consulta"
}, {
    7534,
    "Nomina > Maestros de nómina > Copia Contratos Colectiva > Procesar"
}, {
    4904,
    "Nomina > Maestros de nómina > Empleados"
}, {
    4921,
    "Nomina > Maestros de nómina > Formacion Academica"
}, {
    6149,
    "Nomina > Maestros de nómina > Formacion Academica > Adicionar"
}, {
    6150,
    "Nomina > Maestros de nómina > Formacion Academica > Consultar"
}, {
    6151,
    "Nomina > Maestros de nómina > Formacion Academica > Duplicar"
}, {
    6152,
    "Nomina > Maestros de nómina > Formacion Academica > Eliminar"
}, {
    6153,
    "Nomina > Maestros de nómina > Formacion Academica > Reporte"
}, {
    4920,
    "Nomina > Maestros de nómina > Activos y pasivos"
}, {
    6144,
    "Nomina > Maestros de nómina > Activos y pasivos > Adicionar"
}, {
    6145,
    "Nomina > Maestros de nómina > Activos y pasivos > Consultar"
}, {
    6146,
    "Nomina > Maestros de nómina > Activos y pasivos > Duplicar"
}, {
    6147,
    "Nomina > Maestros de nómina > Activos y pasivos > Modificar"
}, {
    6148,
    "Nomina > Maestros de nómina > Activos y pasivos > Reporte"
}, {
    5036,
    "Nomina > Maestros de nómina > Empleados > Adicionar"
}, {
    5031,
    "Nomina > Maestros de nómina > Empleados > Consultar"
}, {
    5032,
    "Nomina > Maestros de nómina > Empleados > Duplicar"
}, {
    5033,
    "Nomina > Maestros de nómina > Empleados > Eliminar"
}, {
    4922,
    "Nomina > Maestros de nómina > Experiencia laboral"
}, {
    6154,
    "Nomina > Maestros de nómina > Experiencia laboral > Adicionar"
}, {
    6155,
    "Nomina > Maestros de nómina > Experiencia laboral > Consultar"
}, {
    6156,
    "Nomina > Maestros de nómina > Experiencia laboral > Duplicar"
}, {
    6157,
    "Nomina > Maestros de nómina > Experiencia laboral > Eliminar"
}, {
    6158,
    "Nomina > Maestros de nómina > Experiencia laboral > Modificar"
}, {
    6159,
    "Nomina > Maestros de nómina > Experiencia laboral > Reporte"
}, {
    5034,
    "Nomina > Maestros de nómina > Empleados > Modificar"
}, {
    5035,
    "Nomina > Maestros de nómina > Empleados > Reporte"
}, {
    4923,
    "Nomina > Maestros de nómina > Informacion personal y familiar"
}, {
    6160,
    "Nomina > Maestros de nómina > Informacion personal y familiar > Adicionar"
}, {
    6161,
    "Nomina > Maestros de nómina > Informacion personal y familiar > Consultar"
}, {
    6162,
    "Nomina > Maestros de nómina > Informacion personal y familiar > Duplicar"
}, {
    6163,
    "Nomina > Maestros de nómina > Informacion personal y familiar > Eliminar"
}, {
    6164,
    "Nomina > Maestros de nómina > Informacion personal y familiar > Modificar"
}, {
    6165,
    "Nomina > Maestros de nómina > Informacion personal y familiar > Reporte"
}, {
    4898,
    "Nomina > Maestros de nómina > Entidades-AFC"
}, {
    4994,
    "Nomina > Maestros de nómina > Entidades-AFC > Adicionar"
}, {
    4995,
    "Nomina > Maestros de nómina > Entidades-AFC > Consultar"
}, {
    4996,
    "Nomina > Maestros de nómina > Entidades-AFC > Duplicar"
}, {
    4997,
    "Nomina > Maestros de nómina > Entidades-AFC > Eliminar"
}, {
    4998,
    "Nomina > Maestros de nómina > Entidades-AFC > Modificar"
}, {
    4999,
    "Nomina > Maestros de nómina > Entidades-AFC > Reporte"
}, {
    4910,
    "Nomina > Maestros de nómina > Entidades-AFP"
}, {
    5067,
    "Nomina > Maestros de nómina > Entidades-AFP > Adicionar"
}, {
    5068,
    "Nomina > Maestros de nómina > Entidades-AFP > Consultar"
}, {
    5069,
    "Nomina > Maestros de nómina > Entidades-AFP > Duplicar"
}, {
    5070,
    "Nomina > Maestros de nómina > Entidades-AFP > Eliminar"
}, {
    5071,
    "Nomina > Maestros de nómina > Entidades-AFP > Modificar"
}, {
    5072,
    "Nomina > Maestros de nómina > Entidades-AFP > Reporte"
}, {
    4911,
    "Nomina > Maestros de nómina > Entidades-ARP"
}, {
    5073,
    "Nomina > Maestros de nómina > Entidades-ARP > Adicionar"
}, {
    5074,
    "Nomina > Maestros de nómina > Entidades-ARP > Consultar"
}, {
    5075,
    "Nomina > Maestros de nómina > Entidades-ARP > Duplicar"
}, {
    5076,
    "Nomina > Maestros de nómina > Entidades-ARP > Eliminar"
}, {
    5077,
    "Nomina > Maestros de nómina > Entidades-ARP > Modificar"
}, {
    5078,
    "Nomina > Maestros de nómina > Entidades-ARP > Reporte"
}, {
    4912,
    "Nomina > Maestros de nómina > Entidades-Cajas"
}, {
    5079,
    "Nomina > Maestros de nómina > Entidades-Cajas > Adicionar"
}, {
    5080,
    "Nomina > Maestros de nómina > Entidades-Cajas > Consultar"
}, {
    5081,
    "Nomina > Maestros de nómina > Entidades-Cajas > Duplicar"
}, {
    5082,
    "Nomina > Maestros de nómina > Entidades-Cajas > Eliminar"
}, {
    5083,
    "Nomina > Maestros de nómina > Entidades-Cajas > Modificar"
}, {
    5084,
    "Nomina > Maestros de nómina > Entidades-Cajas > Reporte"
}, {
    4908,
    "Nomina > Maestros de nómina > Entidades-EPS"
}, {
    5055,
    "Nomina > Maestros de nómina > Entidades-EPS > Adicionar"
}, {
    5056,
    "Nomina > Maestros de nómina > Entidades-EPS > Consultar"
}, {
    5057,
    "Nomina > Maestros de nómina > Entidades-EPS > Duplicar"
}, {
    5058,
    "Nomina > Maestros de nómina > Entidades-EPS > Eliminar"
}, {
    5059,
    "Nomina > Maestros de nómina > Entidades-EPS > Modificar"
}, {
    5060,
    "Nomina > Maestros de nómina > Entidades-EPS > Reporte"
}, {
    4900,
    "Nomina > Maestros de nómina > Entidades-Fondos"
}, {
    5006,
    "Nomina > Maestros de nómina > Entidades-Fondos > Adicionar"
}, {
    5007,
    "Nomina > Maestros de nómina > Entidades-Fondos > Consultar"
}, {
    5008,
    "Nomina > Maestros de nómina > Entidades-Fondos > Duplicar"
}, {
    5009,
    "Nomina > Maestros de nómina > Entidades-Fondos > Eliminar"
}, {
    5010,
    "Nomina > Maestros de nómina > Entidades-Fondos > Modificar"
}, {
    5011,
    "Nomina > Maestros de nómina > Entidades-Fondos > Reporte"
}, {
    4899,
    "Nomina > Maestros de nómina > Entidades-ICBF"
}, {
    5000,
    "Nomina > Maestros de nómina > Entidades-ICBF > Adicionar"
}, {
    5001,
    "Nomina > Maestros de nómina > Entidades-ICBF > Consultar"
}, {
    5002,
    "Nomina > Maestros de nómina > Entidades-ICBF > Duplicar"
}, {
    5003,
    "Nomina > Maestros de nómina > Entidades-ICBF > Eliminar"
}, {
    5004,
    "Nomina > Maestros de nómina > Entidades-ICBF > Modificar"
}, {
    5005,
    "Nomina > Maestros de nómina > Entidades-ICBF > Reporte"
}, {
    4913,
    "Nomina > Maestros de nómina > Entidades-Sena"
}, {
    5085,
    "Nomina > Maestros de nómina > Entidades-Sena > Adicionar"
}, {
    5086,
    "Nomina > Maestros de nómina > Entidades-Sena > Consultar"
}, {
    5087,
    "Nomina > Maestros de nómina > Entidades-Sena > Duplicar"
}, {
    5088,
    "Nomina > Maestros de nómina > Entidades-Sena > Eliminar"
}, {
    5089,
    "Nomina > Maestros de nómina > Entidades-Sena > Modificar"
}, {
    5090,
    "Nomina > Maestros de nómina > Entidades-Sena > Reporte"
}, {
    4916,
    "Nomina > Maestros de nómina > Extralegales"
}, {
    5103,
    "Nomina > Maestros de nómina > Extralegales > Adicionar"
}, {
    5104,
    "Nomina > Maestros de nómina > Extralegales > Consultar"
}, {
    5105,
    "Nomina > Maestros de nómina > Extralegales > Duplicar"
}, {
    5106,
    "Nomina > Maestros de nómina > Extralegales > Eliminar"
}, {
    5107,
    "Nomina > Maestros de nómina > Extralegales > Modificar"
}, {
    5108,
    "Nomina > Maestros de nómina > Extralegales > Reporte"
}, {
    4907,
    "Nomina > Maestros de nómina > Grupos de empleados"
}, {
    5049,
    "Nomina > Maestros de nómina > Grupos de empleados > Adicionar"
}, {
    5050,
    "Nomina > Maestros de nómina > Grupos de empleados > Consultar"
}, {
    5051,
    "Nomina > Maestros de nómina > Grupos de empleados > Duplicar"
}, {
    5052,
    "Nomina > Maestros de nómina > Grupos de empleados > Eliminar"
}, {
    5053,
    "Nomina > Maestros de nómina > Grupos de empleados > Modificar"
}, {
    5054,
    "Nomina > Maestros de nómina > Grupos de empleados > Reporte"
}, {
    8358,
    "Nomina > Maestros de nómina > Impresion Estandar"
}, {
    4894,
    "Nomina > Maestros de nómina > Motivos de Retiro"
}, {
    4970,
    "Nomina > Maestros de nómina > Motivos de Retiro > Adicionar"
}, {
    4971,
    "Nomina > Maestros de nómina > Motivos de Retiro > Consultar"
}, {
    4972,
    "Nomina > Maestros de nómina > Motivos de Retiro > Duplicar"
}, {
    4973,
    "Nomina > Maestros de nómina > Motivos de Retiro > Eliminar"
}, {
    4974,
    "Nomina > Maestros de nómina > Motivos de Retiro > Modificar"
}, {
    4975,
    "Nomina > Maestros de nómina > Motivos de Retiro > Reporte"
}, {
    4889,
    "Nomina > Maestros de nómina"
}, {
    7861,
    "Nomina > Maestros de nómina > Consulta Contratos"
}, {
    7648,
    "Nomina > Maestros de nómina > Maestro historico de salarios"
}, {
    7659,
    "Nomina > Maestros de nómina > Maestro historico de salarios > Adicionar"
}, {
    7660,
    "Nomina > Maestros de nómina > Maestro historico de salarios > Consultar"
}, {
    7661,
    "Nomina > Maestros de nómina > Maestro historico de salarios > Duplicar"
}, {
    7662,
    "Nomina > Maestros de nómina > Maestro historico de salarios > Eliminar"
}, {
    7663,
    "Nomina > Maestros de nómina > Maestro historico de salarios > Modificar"
}, {
    7664,
    "Nomina > Maestros de nómina > Maestro historico de salarios > Reporte"
}, {
    7649,
    "Nomina > Maestros de nómina > Consulta historico de salarios"
}, {
    7665,
    "Nomina > Maestros de nómina > Consulta historico de salarios > Adicionar"
}, {
    7666,
    "Nomina > Maestros de nómina > Consulta historico de salarios > Consultar"
}, {
    7667,
    "Nomina > Maestros de nómina > Consulta historico de salarios > Duplicar"
}, {
    7668,
    "Nomina > Maestros de nómina > Consulta historico de salarios > Eliminar"
}, {
    7669,
    "Nomina > Maestros de nómina > Consulta historico de salarios > Modificar"
}, {
    7670,
    "Nomina > Maestros de nómina > Consulta historico de salarios > Reporte"
}, {
    7650,
    "Nomina > Maestros de nómina > Actualizacion via archivo"
}, {
    7683,
    "Nomina > Maestros de nómina > Actualizacion via archivo > Adicionar"
}, {
    7684,
    "Nomina > Maestros de nómina > Actualizacion via archivo > Consultar"
}, {
    7685,
    "Nomina > Maestros de nómina > Actualizacion via archivo > Duplicar"
}, {
    7686,
    "Nomina > Maestros de nómina > Actualizacion via archivo > Eliminar"
}, {
    7687,
    "Nomina > Maestros de nómina > Actualizacion via archivo > Modificar"
}, {
    7688,
    "Nomina > Maestros de nómina > Actualizacion via archivo > Reporte"
}, {
    7652,
    "Nomina > Maestros de nómina > Impresion contrato"
}, {
    7677,
    "Nomina > Maestros de nómina > Impresion contrato > Adicionar"
}, {
    7678,
    "Nomina > Maestros de nómina > Impresion contrato > Consultar"
}, {
    7679,
    "Nomina > Maestros de nómina > Impresion contrato > Duplicar"
}, {
    7680,
    "Nomina > Maestros de nómina > Impresion contrato > Eliminar"
}, {
    7681,
    "Nomina > Maestros de nómina > Impresion contrato > Modificar"
}, {
    7682,
    "Nomina > Maestros de nómina > Impresion contrato > Reporte"
}, {
    7651,
    "Nomina > Maestros de nómina > Impresion Contratos textos"
}, {
    7671,
    "Nomina > Maestros de nómina > Impresion Contratos textos > Adicionar"
}, {
    7672,
    "Nomina > Maestros de nómina > Impresion Contratos textos > Consultar"
}, {
    7673,
    "Nomina > Maestros de nómina > Impresion Contratos textos > Duplicar"
}, {
    7674,
    "Nomina > Maestros de nómina > Impresion Contratos textos > eliminar"
}, {
    7675,
    "Nomina > Maestros de nómina > Impresion Contratos textos > Modificar"
}, {
    7676,
    "Nomina > Maestros de nómina > Impresion Contratos textos > Reporte"
}, {
    7647,
    "Nomina > Maestros de nómina > Libro prestaciones"
}, {
    7653,
    "Nomina > Maestros de nómina > Libro prestaciones > Adicionar"
}, {
    7654,
    "Nomina > Maestros de nómina > Libro prestaciones > Consultar"
}, {
    7655,
    "Nomina > Maestros de nómina > Libro prestaciones > Duplicar"
}, {
    7656,
    "Nomina > Maestros de nómina > Libro prestaciones > Eliminar"
}, {
    7657,
    "Nomina > Maestros de nómina > Libro prestaciones > Modificar"
}, {
    7658,
    "Nomina > Maestros de nómina > Libro prestaciones > Reporte"
}, {
    7893,
    "Nomina > Maestros de nómina > Nivel academico"
}, {
    7895,
    "Nomina > Maestros de nómina > Nivel academico > Adicionar"
}, {
    7896,
    "Nomina > Maestros de nómina > Nivel academico > Consultar"
}, {
    7897,
    "Nomina > Maestros de nómina > Nivel academico > Duplicar"
}, {
    7898,
    "Nomina > Maestros de nómina > Nivel academico > Eliminar"
}, {
    7899,
    "Nomina > Maestros de nómina > Nivel academico > Modificar"
}, {
    7900,
    "Nomina > Maestros de nómina > Nivel academico > Reporte"
}, {
    7894,
    "Nomina > Maestros de nómina > Retefuente_384"
}, {
    7901,
    "Nomina > Maestros de nómina > Retefuente_384 > Adicionar"
}, {
    7902,
    "Nomina > Maestros de nómina > Retefuente_384 > Consultar"
}, {
    7903,
    "Nomina > Maestros de nómina > Retefuente_384 > Duplicar"
}, {
    7904,
    "Nomina > Maestros de nómina > Retefuente_384 > Eliminar"
}, {
    7905,
    "Nomina > Maestros de nómina > Retefuente_384 > Modificar"
}, {
    7906,
    "Nomina > Maestros de nómina > Retefuente_384 > Reporte"
}, {
    4893,
    "Nomina > Maestros de nómina > Parametros por Año"
}, {
    4964,
    "Nomina > Maestros de nómina > Parametros por Año > Adicionar"
}, {
    4965,
    "Nomina > Maestros de nómina > Parametros por Año > Consultar"
}, {
    4966,
    "Nomina > Maestros de nómina > Parametros por Año > Duplicar"
}, {
    4967,
    "Nomina > Maestros de nómina > Parametros por Año > Eliminar"
}, {
    4968,
    "Nomina > Maestros de nómina > Parametros por Año > Modificar"
}, {
    4969,
    "Nomina > Maestros de nómina > Parametros por Año > Reporte"
}, {
    4892,
    "Nomina > Maestros de nómina > Parametros de Nomina"
}, {
    4958,
    "Nomina > Maestros de nómina > Parametros de Nomina > Adicionar"
}, {
    4959,
    "Nomina > Maestros de nómina > Parametros de Nomina > Consultar"
}, {
    4960,
    "Nomina > Maestros de nómina > Parametros de Nomina > Duplicar"
}, {
    4961,
    "Nomina > Maestros de nómina > Parametros de Nomina > Eliminar"
}, {
    4962,
    "Nomina > Maestros de nómina > Parametros de Nomina > Modificar"
}, {
    4963,
    "Nomina > Maestros de nómina > Parametros de Nomina > Reporte"
}, {
    4914,
    "Nomina > Maestros de nómina > Retencion en la fuente"
}, {
    5091,
    "Nomina > Maestros de nómina > Retencion en la fuente > Adicionar"
}, {
    5092,
    "Nomina > Maestros de nómina > Retencion en la fuente > Consultar"
}, {
    5093,
    "Nomina > Maestros de nómina > Retencion en la fuente > Duplicar"
}, {
    5094,
    "Nomina > Maestros de nómina > Retencion en la fuente > Eliminar"
}, {
    5095,
    "Nomina > Maestros de nómina > Retencion en la fuente > Modificar"
}, {
    5096,
    "Nomina > Maestros de nómina > Retencion en la fuente > Reporte"
}, {
    4924,
    "Nomina > Maestros de nómina > Saldos Iniciales"
}, {
    6351,
    "Nomina > Maestros de nómina > Saldos Iniciales > Adicionar"
}, {
    6352,
    "Nomina > Maestros de nómina > Saldos Iniciales > Consultar"
}, {
    6356,
    "Nomina > Maestros de nómina > Saldos Iniciales > Duplicar"
}, {
    6353,
    "Nomina > Maestros de nómina > Saldos Iniciales > Eliminar"
}, {
    6354,
    "Nomina > Maestros de nómina > Saldos Iniciales > Modificar"
}, {
    6355,
    "Nomina > Maestros de nómina > Saldos Iniciales > Reporte"
}, {
    7037,
    "Nomina > Maestros de nómina > Terceros"
}, {
    7038,
    "Nomina > Maestros de nómina > Terceros > Adicionar"
}, {
    7039,
    "Nomina > Maestros de nómina > Terceros > Consultar"
}, {
    7040,
    "Nomina > Maestros de nómina > Terceros > Duplicar"
}, {
    7041,
    "Nomina > Maestros de nómina > Terceros > Eliminar"
}, {
    7042,
    "Nomina > Maestros de nómina > Terceros > Modificar"
}, {
    7043,
    "Nomina > Maestros de nómina > Terceros > Reporte"
}, {
    4906,
    "Nomina > Maestros de nómina > Tipos de Cotizante"
}, {
    5043,
    "Nomina > Maestros de nómina > Tipos de Cotizante > Adicionar"
}, {
    5044,
    "Nomina > Maestros de nómina > Tipos de Cotizante > Consultar"
}, {
    5045,
    "Nomina > Maestros de nómina > Tipos de Cotizante > Duplicar"
}, {
    5046,
    "Nomina > Maestros de nómina > Tipos de Cotizante > Eliminar"
}, {
    5047,
    "Nomina > Maestros de nómina > Tipos de Cotizante > Modificar"
}, {
    5048,
    "Nomina > Maestros de nómina > Tipos de Cotizante > Reporte"
}, {
    4901,
    "Nomina > Maestros de nómina > Tipos de nómina"
}, {
    5012,
    "Nomina > Maestros de nómina > Tipos de nómina > Adicionar"
}, {
    5013,
    "Nomina > Maestros de nómina > Tipos de nómina > Consultar"
}, {
    5014,
    "Nomina > Maestros de nómina > Tipos de nómina > Duplicar"
}, {
    5015,
    "Nomina > Maestros de nómina > Tipos de nómina > Eliminar"
}, {
    5016,
    "Nomina > Maestros de nómina > Tipos de nómina > Modificar"
}, {
    5017,
    "Nomina > Maestros de nómina > Tipos de nómina > Reporte"
}, {
    5018,
    "Nomina > Maestros de nómina > Tipos de nómina > Tiempos basicos"
}, {
    5127,
    "Nomina > Maestros de nómina > Tipos de nómina > Tiempos basicos > Modificar codigo"
}, {
    4896,
    "Nomina > Maestros de nómina > TNL deduccion de prestaciones"
}, {
    4982,
    "Nomina > Maestros de nómina > TNL deduccion de prestaciones > Adicionar"
}, {
    4983,
    "Nomina > Maestros de nómina > TNL deduccion de prestaciones > Consultar"
}, {
    4984,
    "Nomina > Maestros de nómina > TNL deduccion de prestaciones > Duplicar"
}, {
    4985,
    "Nomina > Maestros de nómina > TNL deduccion de prestaciones > Eliminar"
}, {
    4986,
    "Nomina > Maestros de nómina > TNL deduccion de prestaciones > Modificar"
}, {
    4987,
    "Nomina > Maestros de nómina > TNL deduccion de prestaciones > Reporte"
}, {
    5421,
    "Nomina > Procesos Periodicos > Consolidación > Generación de consolidación > Adicionar"
}, {
    5423,
    "Nomina > Procesos Periodicos > Consolidación > Generación de consolidación > Consultar"
}, {
    5424,
    "Nomina > Procesos Periodicos > Consolidación > Generación de consolidación > Duplicar"
}, {
    5425,
    "Nomina > Procesos Periodicos > Consolidación > Generación de consolidación > Eliminar"
}, {
    5422,
    "Nomina > Procesos Periodicos > Consolidación > Generación de consolidación > Generar"
}, {
    5426,
    "Nomina > Procesos Periodicos > Consolidación > Generación de consolidación > Modificar"
}, {
    5427,
    "Nomina > Procesos Periodicos > Consolidación > Generación de consolidación > Reporte"
}, {
    5377,
    "Nomina > Procesos Periodicos > Consultas > Consulta autoliquidación"
}, {
    5448,
    "Nomina > Procesos Periodicos > Consultas > Consulta autoliquidación > Adicionar"
}, {
    5449,
    "Nomina > Procesos Periodicos > Consultas > Consulta autoliquidación > Consultar"
}, {
    5450,
    "Nomina > Procesos Periodicos > Consultas > Consulta autoliquidación > Duplicar"
}, {
    5451,
    "Nomina > Procesos Periodicos > Consultas > Consulta autoliquidación > Eliminar"
}, {
    5452,
    "Nomina > Procesos Periodicos > Consultas > Consulta autoliquidación > Modificar"
}, {
    5453,
    "Nomina > Procesos Periodicos > Consultas > Consulta autoliquidación > Procesar"
}, {
    5378,
    "Nomina > Procesos Periodicos > Consultas > Consulta consolidación"
}, {
    5454,
    "Nomina > Procesos Periodicos > Consultas > Consulta consolidación > Adicionar"
}, {
    5455,
    "Nomina > Procesos Periodicos > Consultas > Consulta consolidación > Consultar"
}, {
    5456,
    "Nomina > Procesos Periodicos > Consultas > Consulta consolidación > Duplicar"
}, {
    5457,
    "Nomina > Procesos Periodicos > Consultas > Consulta consolidación > Eliminar"
}, {
    5458,
    "Nomina > Procesos Periodicos > Consultas > Consulta consolidación > Modificar"
}, {
    5459,
    "Nomina > Procesos Periodicos > Consultas > Consulta consolidación > Procesar"
}, {
    8206,
    "Nomina > Procesos Periodicos > Embargos Judiciales"
}, {
    8209,
    "Nomina > Procesos Periodicos > Embargos Judiciales > Actualizacion > Adicionar"
}, {
    8210,
    "Nomina > Procesos Periodicos > Embargos Judiciales > Actualizacion > Consultar"
}, {
    8211,
    "Nomina > Procesos Periodicos > Embargos Judiciales > Actualizacion > Duplicar"
}, {
    8212,
    "Nomina > Procesos Periodicos > Embargos Judiciales > Actualizacion > Eliminar"
}, {
    8213,
    "Nomina > Procesos Periodicos > Embargos Judiciales > Actualizacion > Modificar"
}, {
    8214,
    "Nomina > Procesos Periodicos > Embargos Judiciales > Actualizacion > Reporte"
}, {
    8207,
    "Nomina > Procesos Periodicos > Embargos Judiciales > Actualizacion"
}, {
    8208,
    "Nomina > Procesos Periodicos > Embargos Judiciales > Generar plano"
}, {
    5412,
    "Nomina > Procesos Periodicos > Autoliquidación > Exportacion a planilla unica > Adicionar"
}, {
    5413,
    "Nomina > Procesos Periodicos > Autoliquidación > Exportacion a planilla unica > Filtro"
}, {
    5414,
    "Nomina > Procesos Periodicos > Autoliquidación > Exportacion a planilla unica > Generar"
}, {
    5385,
    "Nomina > Procesos Periodicos > Maestros Asociados > Parametros de planilla unica > Adicionar"
}, {
    5386,
    "Nomina > Procesos Periodicos > Maestros Asociados > Parametros de planilla unica > Consultar"
}, {
    5387,
    "Nomina > Procesos Periodicos > Maestros Asociados > Parametros de planilla unica > Duplicar"
}, {
    5388,
    "Nomina > Procesos Periodicos > Maestros Asociados > Parametros de planilla unica > Eliminar"
}, {
    5389,
    "Nomina > Procesos Periodicos > Maestros Asociados > Parametros de planilla unica > Modificar"
}, {
    5390,
    "Nomina > Procesos Periodicos > Maestros Asociados > Parametros de planilla unica > Reporte"
}, {
    5379,
    "Nomina > Procesos Periodicos > Maestros Asociados > Sucursales de autoliquidacion > Adicionar"
}, {
    5380,
    "Nomina > Procesos Periodicos > Maestros Asociados > Sucursales de autoliquidacion > Consultar"
}, {
    5381,
    "Nomina > Procesos Periodicos > Maestros Asociados > Sucursales de autoliquidacion > Duplicar"
}, {
    5382,
    "Nomina > Procesos Periodicos > Maestros Asociados > Sucursales de autoliquidacion > Eliminar"
}, {
    5383,
    "Nomina > Procesos Periodicos > Maestros Asociados > Sucursales de autoliquidacion > Modificar"
}, {
    5384,
    "Nomina > Procesos Periodicos > Maestros Asociados > Sucursales de autoliquidacion > Reporte"
}, {
    4891,
    "Nomina > Procesos Periodicos"
}, {
    4955,
    "Nomina > Procesos Periodicos > Autoliquidación"
}, {
    5370,
    "Nomina > Procesos Periodicos > Autoliquidación > Exportacion a planilla unica"
}, {
    5408,
    "Nomina > Procesos Periodicos > Autoliquidación > Modificacion de Registros > Adicionar"
}, {
    5411,
    "Nomina > Procesos Periodicos > Autoliquidación > Modificacion de Registros > Anular"
}, {
    5410,
    "Nomina > Procesos Periodicos > Autoliquidación > Modificacion de Registros > Aprobar"
}, {
    5409,
    "Nomina > Procesos Periodicos > Autoliquidación > Modificacion de Registros > Consultar"
}, {
    5404,
    "Nomina > Procesos Periodicos > Autoliquidación > Modificacion de Registros > Duplicar"
}, {
    5405,
    "Nomina > Procesos Periodicos > Autoliquidación > Modificacion de Registros > Eliminar"
}, {
    5406,
    "Nomina > Procesos Periodicos > Autoliquidación > Modificacion de Registros > Modificar"
}, {
    5369,
    "Nomina > Procesos Periodicos > Autoliquidación > Modificacion de Registros"
}, {
    5407,
    "Nomina > Procesos Periodicos > Autoliquidación > Modificacion de Registros > Reporte"
}, {
    5371,
    "Nomina > Procesos Periodicos > Autoliquidación > Reporte"
}, {
    5415,
    "Nomina > Procesos Periodicos > Autoliquidación > Reporte > Adicionar"
}, {
    5416,
    "Nomina > Procesos Periodicos > Autoliquidación > Reporte > Consultar"
}, {
    5417,
    "Nomina > Procesos Periodicos > Autoliquidación > Reporte > Duplicar"
}, {
    5418,
    "Nomina > Procesos Periodicos > Autoliquidación > Reporte > Eliminar"
}, {
    5419,
    "Nomina > Procesos Periodicos > Autoliquidación > Reporte > Modificar"
}, {
    5420,
    "Nomina > Procesos Periodicos > Autoliquidación > Reporte > Reporte"
}, {
    4956,
    "Nomina > Procesos Periodicos > Consolidación"
}, {
    8424,
    "Nomina > Procesos Periodicos > Consolidación > Transacc consolidados - Prest. soc. Extralegales"
}, {
    8425,
    "Nomina > Procesos Periodicos > Consolidación > Transacc consolidados - Prest. soc. Extralegales > Adicionar"
}, {
    8426,
    "Nomina > Procesos Periodicos > Consolidación > Transacc consolidados - Prest. soc. Extralegales > Filtro"
}, {
    8427,
    "Nomina > Procesos Periodicos > Consolidación > Transacc consolidados - Prest. soc. Extralegales > Generar"
}, {
    5438,
    "Nomina > Procesos Periodicos > Consolidación > Modificacion de Registros > Adicionar"
}, {
    5444,
    "Nomina > Procesos Periodicos > Consolidación > Modificacion de Registros > Anular"
}, {
    5437,
    "Nomina > Procesos Periodicos > Consolidación > Modificacion de Registros > Aprobar"
}, {
    5439,
    "Nomina > Procesos Periodicos > Consolidación > Modificacion de Registros > Consultar"
}, {
    5440,
    "Nomina > Procesos Periodicos > Consolidación > Modificacion de Registros > Duplicar"
}, {
    5441,
    "Nomina > Procesos Periodicos > Consolidación > Modificacion de Registros > Eliminar"
}, {
    5442,
    "Nomina > Procesos Periodicos > Consolidación > Modificacion de Registros > Modificar"
}, {
    5375,
    "Nomina > Procesos Periodicos > Consolidación > Modificacion de Registros"
}, {
    5443,
    "Nomina > Procesos Periodicos > Consolidación > Modificacion de Registros > Reporte"
}, {
    4957,
    "Nomina > Procesos Periodicos > Consultas"
}, {
    7863,
    "Nomina > Procesos Periodicos > Certificados ingresos y retenciones generacion"
}, {
    7862,
    "Nomina > Procesos Periodicos > Certificados de Ingresos y retenciones parametros"
}, {
    7864,
    "Nomina > Procesos Periodicos > Certificados de Ingresos y retenciones parametros > Adicionar"
}, {
    7865,
    "Nomina > Procesos Periodicos > Certificados de Ingresos y retenciones parametros > Consultar"
}, {
    7866,
    "Nomina > Procesos Periodicos > Certificados de Ingresos y retenciones parametros > Dulpicar"
}, {
    7867,
    "Nomina > Procesos Periodicos > Certificados de Ingresos y retenciones parametros > Eliminar"
}, {
    7868,
    "Nomina > Procesos Periodicos > Certificados de Ingresos y retenciones parametros > Modificar"
}, {
    7869,
    "Nomina > Procesos Periodicos > Certificados de Ingresos y retenciones parametros > Reporte"
}, {
    4954,
    "Nomina > Procesos Periodicos > Maestros Asociados"
}, {
    5367,
    "Nomina > Procesos Periodicos > Maestros Asociados > Codidos de Pila"
}, {
    5365,
    "Nomina > Procesos Periodicos > Maestros Asociados > Sucursales de autoliquidacion"
}, {
    5391,
    "Nomina > Procesos Periodicos > Maestros Asociados > Codidos de Pila > Adicionar"
}, {
    5392,
    "Nomina > Procesos Periodicos > Maestros Asociados > Codidos de Pila > Consultar"
}, {
    5393,
    "Nomina > Procesos Periodicos > Maestros Asociados > Codidos de Pila > Duplicar"
}, {
    5394,
    "Nomina > Procesos Periodicos > Maestros Asociados > Codidos de Pila > Eliminar"
}, {
    5395,
    "Nomina > Procesos Periodicos > Maestros Asociados > Codidos de Pila > Modificar"
}, {
    5396,
    "Nomina > Procesos Periodicos > Maestros Asociados > Codidos de Pila > Reporte"
}, {
    5366,
    "Nomina > Procesos Periodicos > Maestros Asociados > Parametros de planilla unica"
}, {
    5372,
    "Nomina > Procesos Periodicos > Consolidación > Generación de consolidación"
}, {
    5373,
    "Nomina > Procesos Periodicos > Consolidación > Reporte"
}, {
    5376,
    "Nomina > Procesos Periodicos > Consolidación > Transacc Consolidados - Prestaciones Sociales"
}, {
    5374,
    "Nomina > Procesos Periodicos > Consolidación > Transacc consolidados - Consignacion Cesant ley 50"
}, {
    5445,
    "Nomina > Procesos Periodicos > Consolidación > Transacc Consolidados - Prestaciones Sociales > Adicionar"
}, {
    5446,
    "Nomina > Procesos Periodicos > Consolidación > Transacc Consolidados - Prestaciones Sociales > Filtro"
}, {
    5447,
    "Nomina > Procesos Periodicos > Consolidación > Transacc Consolidados - Prestaciones Sociales > Generar"
}, {
    7878,
    "Nomina > Procesos Periodicos > Inf Exogena DIAN"
}, {
    7879,
    "Nomina > Procesos Periodicos > Inf Exogena DIAN > Adicionar"
}, {
    7880,
    "Nomina > Procesos Periodicos > Inf Exogena DIAN > Filtro"
}, {
    7881,
    "Nomina > Procesos Periodicos > Inf Exogena DIAN > Generar"
}, {
    5428,
    "Nomina > Procesos Periodicos > Consolidación > Reporte > Adicionar"
}, {
    5429,
    "Nomina > Procesos Periodicos > Consolidación > Reporte > Consultar"
}, {
    5430,
    "Nomina > Procesos Periodicos > Consolidación > Reporte > Duplicar"
}, {
    5431,
    "Nomina > Procesos Periodicos > Consolidación > Reporte > Eliminar"
}, {
    5432,
    "Nomina > Procesos Periodicos > Consolidación > Reporte > Modificar"
}, {
    5433,
    "Nomina > Procesos Periodicos > Consolidación > Reporte > Reporte"
}, {
    5434,
    "Nomina > Procesos Periodicos > Consolidación > Transacc consolidados - Consignacion Cesant ley 50 > Adicionar"
}, {
    5435,
    "Nomina > Procesos Periodicos > Consolidación > Transacc consolidados - Consignacion Cesant ley 50 > Filtro"
}, {
    5436,
    "Nomina > Procesos Periodicos > Consolidación > Transacc consolidados - Consignacion Cesant ley 50 > Generar"
}, {
    8428,
    "Nomina > Procesos Periodicos > Autoliquidación > Conciliacion pagos al operador"
}, {
    8429,
    "Nomina > Procesos Periodicos > Autoliquidación > Conciliacion pagos al operador > Adicionar"
}, {
    8437,
    "Nomina > Procesos Periodicos > Autoliquidación > Conciliacion pagos al operador > Anular"
}, {
    8436,
    "Nomina > Procesos Periodicos > Autoliquidación > Conciliacion pagos al operador > Aprobar"
}, {
    8430,
    "Nomina > Procesos Periodicos > Autoliquidación > Conciliacion pagos al operador > Consultar"
}, {
    8431,
    "Nomina > Procesos Periodicos > Autoliquidación > Conciliacion pagos al operador > Duplicar"
}, {
    8432,
    "Nomina > Procesos Periodicos > Autoliquidación > Conciliacion pagos al operador > Eliminar"
}, {
    8433,
    "Nomina > Procesos Periodicos > Autoliquidación > Conciliacion pagos al operador > Generar"
}, {
    8434,
    "Nomina > Procesos Periodicos > Autoliquidación > Conciliacion pagos al operador > Mofificar"
}, {
    8435,
    "Nomina > Procesos Periodicos > Autoliquidación > Conciliacion pagos al operador > Reporte"
}, {
    6618,
    "Nomina > Saldos Iniciales"
}, {
    6621,
    "Nomina > Saldos Iniciales > Acumulados"
}, {
    6626,
    "Nomina > Saldos Iniciales > Acumulados > Manuales"
}, {
    6651,
    "Nomina > Saldos Iniciales > Acumulados > Manuales > Adicionar"
}, {
    6652,
    "Nomina > Saldos Iniciales > Acumulados > Manuales > Consultar"
}, {
    6653,
    "Nomina > Saldos Iniciales > Acumulados > Manuales > Duplicar"
}, {
    6654,
    "Nomina > Saldos Iniciales > Acumulados > Manuales > Eliminar"
}, {
    6655,
    "Nomina > Saldos Iniciales > Acumulados > Manuales > Modificar"
}, {
    6656,
    "Nomina > Saldos Iniciales > Acumulados > Manuales > Reporte"
}, {
    6627,
    "Nomina > Saldos Iniciales > Acumulados > Via Archivo"
}, {
    6657,
    "Nomina > Saldos Iniciales > Acumulados > Via Archivo > Adicionar"
}, {
    6658,
    "Nomina > Saldos Iniciales > Acumulados > Via Archivo > Consultar"
}, {
    6659,
    "Nomina > Saldos Iniciales > Acumulados > Via Archivo > Duplicar"
}, {
    6660,
    "Nomina > Saldos Iniciales > Acumulados > Via Archivo > Eliminar"
}, {
    6661,
    "Nomina > Saldos Iniciales > Acumulados > Via Archivo > Modificar"
}, {
    6662,
    "Nomina > Saldos Iniciales > Acumulados > Via Archivo > Reporte"
}, {
    6624,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Amortizacion"
}, {
    6640,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Amortizacion > Adicionar"
}, {
    6641,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Amortizacion > Consultar"
}, {
    6642,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Amortizacion > Duplicar"
}, {
    6643,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Amortizacion > Eliminar"
}, {
    6644,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Amortizacion > Reporte"
}, {
    7254,
    "Nomina > Saldos Iniciales > Maestros > Contratos"
}, {
    7255,
    "Nomina > Saldos Iniciales > Maestros > Contratos > Adicionar"
}, {
    7256,
    "Nomina > Saldos Iniciales > Maestros > Contratos > Consular"
}, {
    7257,
    "Nomina > Saldos Iniciales > Maestros > Contratos > Duplicar"
}, {
    7258,
    "Nomina > Saldos Iniciales > Maestros > Contratos > Eliminar"
}, {
    7259,
    "Nomina > Saldos Iniciales > Maestros > Contratos > Modificar"
}, {
    7260,
    "Nomina > Saldos Iniciales > Maestros > Contratos > Reporte"
}, {
    6622,
    "Nomina > Saldos Iniciales > Maestros > Documentos"
}, {
    6628,
    "Nomina > Saldos Iniciales > Maestros > Documentos > Adicionar"
}, {
    6629,
    "Nomina > Saldos Iniciales > Maestros > Documentos > Consultar"
}, {
    6630,
    "Nomina > Saldos Iniciales > Maestros > Documentos > Duplicar"
}, {
    6631,
    "Nomina > Saldos Iniciales > Maestros > Documentos > Eliminar"
}, {
    6632,
    "Nomina > Saldos Iniciales > Maestros > Documentos > Modificar"
}, {
    6633,
    "Nomina > Saldos Iniciales > Maestros > Documentos > Reporte"
}, {
    7583,
    "Nomina > Saldos Iniciales > Maestros > Empleados"
}, {
    7584,
    "Nomina > Saldos Iniciales > Maestros > Empleados > Adicionar"
}, {
    7585,
    "Nomina > Saldos Iniciales > Maestros > Empleados > Consultar"
}, {
    7586,
    "Nomina > Saldos Iniciales > Maestros > Empleados > Duplicar"
}, {
    7587,
    "Nomina > Saldos Iniciales > Maestros > Empleados > Eliminar"
}, {
    7588,
    "Nomina > Saldos Iniciales > Maestros > Empleados > Modificar"
}, {
    7589,
    "Nomina > Saldos Iniciales > Maestros > Empleados > Reporte"
}, {
    6623,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Encabezados"
}, {
    6634,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Encabezados > Adicionar"
}, {
    6635,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Encabezados > Consultar"
}, {
    6636,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Encabezados > Duplicar"
}, {
    6637,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Encabezados > Eliminar"
}, {
    6638,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Encabezados > Modificar"
}, {
    6639,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Encabezados > Reporte"
}, {
    6663,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Encabezados Vacaciones"
}, {
    6664,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Encabezados Vacaciones > Adicionar"
}, {
    6665,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Encabezados Vacaciones > Consultar"
}, {
    6666,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Encabezados Vacaciones > Duplicar"
}, {
    6667,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Encabezados Vacaciones > Eliminar"
}, {
    6668,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Encabezados Vacaciones > Modificar"
}, {
    6669,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Encabezados Vacaciones > Reporte"
}, {
    6619,
    "Nomina > Saldos Iniciales > Maestros"
}, {
    6620,
    "Nomina > Saldos Iniciales > Tiempo no Laborado"
}, {
    8258,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > TNL Deduccion via archivo"
}, {
    8259,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > TNL Deduccion via archivo > Adicionar"
}, {
    8260,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > TNL Deduccion via archivo > Consultar"
}, {
    8261,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > TNL Deduccion via archivo > Duplicar"
}, {
    8262,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > TNL Deduccion via archivo > Eliminar"
}, {
    8263,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > TNL Deduccion via archivo > Modificar"
}, {
    6625,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Via Archivo"
}, {
    6645,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Via Archivo > Adicionar"
}, {
    6646,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Via Archivo > Consultar"
}, {
    6647,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Via Archivo > Duplicar"
}, {
    6648,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Via Archivo > Eliminar"
}, {
    6649,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Via Archivo > Modificar"
}, {
    6650,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Via Archivo > Reporte"
}, {
    7761,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Encabezado de vacaciones retiro"
}, {
    7762,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Encabezado de vacaciones retiro > Adicionar"
}, {
    7763,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Encabezado de vacaciones retiro > Consultar"
}, {
    7764,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Encabezado de vacaciones retiro > Duplicar"
}, {
    7765,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Encabezado de vacaciones retiro > Eliminar"
}, {
    7766,
    "Nomina > Saldos Iniciales > Tiempo no Laborado > Encabezado de vacaciones retiro > Reporte"
}, {
    4042,
    "Comercial - POS central"
}, {
    4361,
    "Comercial - POS central > Proceso de acumulacion de ventas"
}, {
    4364,
    "Comercial - POS central > Proceso de acumulacion de ventas > Monitor de inconsistencias"
}, {
    8566,
    "-No implementado > Permitir mostrar todos los procesos"
}, {
    4365,
    "Comercial - POS central > Proceso de acumulacion de ventas > Monitor de inconsistencias > Permitir revesar proceso"
}, {
    4363,
    "Comercial - POS central > Proceso de acumulacion de ventas > Proceso de acumulación"
}, {
    9109,
    "Comercial - POS central > Proceso de acumulacion de ventas > Proceso de acumulación > Permitir acumular con inconsistencias anteriores"
}, {
    11555,
    "Comercial - POS central > Proceso de acumulacion de ventas > Validar que no existan documentos en elaboración"
}, {
    4362,
    "Comercial - POS central > Proceso de acumulacion de ventas > Verificación de acumulación"
}, {
    7946,
    "Comercial - POS central > Otros procesos > CFD medios propios"
}, {
    4366,
    "Comercial - POS central > Consultas de acumulados"
}, {
    7798,
    "Comercial - POS central > Consultas de acumulados > Arreglo de mercancía"
}, {
    4433,
    "Comercial - POS central > Consultas de acumulados > Documentos de caja"
}, {
    4434,
    "Comercial - POS central > Consultas de acumulados > Documentos de caja por concepto"
}, {
    7622,
    "Comercial - POS central > Consultas de acumulados > Domicilios pendientes de cuadrar"
}, {
    4367,
    "Comercial - POS central > Consultas de acumulados > Estado de las TPVs"
}, {
    4430,
    "Comercial - POS central > Consultas de acumulados > Facturas y notas"
}, {
    4431,
    "Comercial - POS central > Consultas de acumulados > Facturas y notas por item"
}, {
    7824,
    "-No implementado > Log de actualización"
}, {
    7068,
    "Comercial - POS central > Consultas de acumulados > Movimiento de anticipos"
}, {
    8977,
    "Comercial - POS central > Consultas de acumulados > Movimiento de marcación"
}, {
    7797,
    "Comercial - POS central > Consultas de acumulados > Préstamo de mercancía"
}, {
    4675,
    "Comercial - POS central > Consultas de acumulados > Relacion de medios de pago"
}, {
    4432,
    "Comercial - POS central > Consultas de acumulados > Resumen de facturas y notas"
}, {
    4437,
    "Comercial - POS central > Consultas de acumulados > Reporte libro diario de ventas"
}, {
    7736,
    "Comercial - POS central > Consultas de acumulados > Reporte libro diario de ventas > Siempre presentar prefijo"
}, {
    7735,
    "Comercial - POS central > Consultas de acumulados > Reporte libro diario de ventas > Validar que no existan documentos en elaboración"
}, {
    7067,
    "Comercial - POS central > Consultas de acumulados > Saldos de anticipos"
}, {
    12592,
    "Comercial - POS central > Consultas de acumulados > Ventas comercial acumuladas y diarias"
}, {
    4283,
    "Comercial - POS central > Consultas diarias"
}, {
    7796,
    "Comercial - POS central > Consultas diarias > Arreglo de mercancía"
}, {
    4428,
    "Comercial - POS central > Consultas diarias > Documentos de caja"
}, {
    4429,
    "Comercial - POS central > Consultas diarias > Documentos de caja por concepto"
}, {
    7621,
    "Comercial - POS central > Consultas diarias > Domicilios pendientes de cuadrar"
}, {
    4284,
    "Comercial - POS central > Consultas diarias > Estado de las TPVs"
}, {
    4425,
    "Comercial - POS central > Consultas diarias > Facturas y notas"
}, {
    4426,
    "Comercial - POS central > Consultas diarias > Facturas y notas por item"
}, {
    7823,
    "Comercial - POS central > Maestros > Programación de actualización > Log de actualización"
}, {
    7066,
    "Comercial - POS central > Consultas diarias > Movimiento de anticipos"
}, {
    8976,
    "Comercial - POS central > Consultas diarias > Movimiento de marcación"
}, {
    7795,
    "Comercial - POS central > Consultas diarias > Préstamo de mercancía"
}, {
    4674,
    "Comercial - POS central > Consultas diarias > Relacion de medios de pago"
}, {
    4427,
    "Comercial - POS central > Consultas diarias > Resumen de facturas y notas"
}, {
    4438,
    "Comercial - POS central > Consultas diarias > Reporte libro diario de ventas"
}, {
    7738,
    "Comercial - POS central > Consultas diarias > Reporte libro diario de ventas > Siempre presentar prefijo"
}, {
    7737,
    "Comercial - POS central > Consultas diarias > Reporte libro diario de ventas > Validar que no existan documentos en elaboración"
}, {
    7065,
    "Comercial - POS central > Consultas diarias > Saldos de anticipos"
}, {
    4348,
    "Comercial - POS central > Consultas diarias > Saldos por TPVs"
}, {
    4439,
    "Comercial - POS central > Cubos"
}, {
    11553,
    "Comercial - POS central > Cubos > Análisis de fidelización"
}, {
    11260,
    "Comercial - POS central > Cubos > Análisis de KDS"
}, {
    4440,
    "Comercial - POS central > Cubos > Cubos de facturacion clientes POS"
}, {
    7944,
    "Comercial - POS central > Cubos > Análisis de ventas acumuladas"
}, {
    7943,
    "Comercial - POS central > Cubos > Análisis de ventas diarias"
}, {
    4043,
    "Comercial - POS central > Maestros"
}, {
    8027,
    "Comercial - POS central > Maestros > Autorización de cheques"
}, {
    8028,
    "Comercial - POS central > Maestros > Autorización de cheques > Adicionar"
}, {
    8029,
    "Comercial - POS central > Maestros > Autorización de cheques > Consultar"
}, {
    8030,
    "-No implementado > Duplicar"
}, {
    8031,
    "Comercial - POS central > Maestros > Autorización de cheques > Eliminar"
}, {
    8032,
    "Comercial - POS central > Maestros > Autorización de cheques > Modificar"
}, {
    8033,
    "Comercial - POS central > Maestros > Autorización de cheques > Reporte"
}, {
    4579,
    "Comercial - POS central > Maestros > Automatización de transferencias"
}, {
    4580,
    "Comercial - POS central > Maestros > Automatización de transferencias > Adicionar"
}, {
    4581,
    "Comercial - POS central > Maestros > Automatización de transferencias > Consultar"
}, {
    4582,
    "Comercial - POS central > Maestros > Automatización de transferencias > Eliminar"
}, {
    4583,
    "Comercial - POS central > Maestros > Automatización de transferencias > Modificar"
}, {
    4584,
    "Comercial - POS central > Maestros > Automatización de transferencias > Reporte"
}, {
    4638,
    "Comercial - POS central > Maestros > Bases de datos"
}, {
    4639,
    "Comercial - POS central > Maestros > Bases de datos > Adicionar"
}, {
    4640,
    "Comercial - POS central > Maestros > Bases de datos > Consultar"
}, {
    4644,
    "Comercial - POS central > Maestros > Bases de datos > Duplicar"
}, {
    4641,
    "Comercial - POS central > Maestros > Bases de datos > Eliminar"
}, {
    4642,
    "Comercial - POS central > Maestros > Bases de datos > Modificar"
}, {
    4643,
    "Comercial - POS central > Maestros > Bases de datos > Reporte"
}, {
    4193,
    "Comercial - POS central > Maestros > Cajeros /Meseros"
}, {
    4194,
    "Comercial - POS central > Maestros > Cajeros /Meseros > Adicionar"
}, {
    4195,
    "Comercial - POS central > Maestros > Cajeros /Meseros > Consultar"
}, {
    4196,
    "Comercial - POS central > Maestros > Cajeros /Meseros > Eliminar"
}, {
    4197,
    "Comercial - POS central > Maestros > Cajeros /Meseros > Modificar"
}, {
    4198,
    "Comercial - POS central > Maestros > Cajeros /Meseros > Reporte"
}, {
    10433,
    "Comercial - POS central > Maestros > Cambio automático de tarjetas de fidelización"
}, {
    4352,
    "Comercial - POS central > Maestros > Causales de devolución"
}, {
    4353,
    "Comercial - POS central > Maestros > Causales de devolución > Adicionar"
}, {
    4354,
    "Comercial - POS central > Maestros > Causales de devolución > Consultar"
}, {
    4358,
    "Comercial - POS central > Maestros > Causales de devolución > Duplicar"
}, {
    4355,
    "Comercial - POS central > Maestros > Causales de devolución > Eliminar"
}, {
    4356,
    "Comercial - POS central > Maestros > Causales de devolución > Modificar"
}, {
    4357,
    "Comercial - POS central > Maestros > Causales de devolución > Reporte"
}, {
    8728,
    "Comercial - POS central > Maestros > Centro de preparación"
}, {
    8729,
    "Comercial - POS central > Maestros > Centro de preparación > Adicionar"
}, {
    8730,
    "Comercial - POS central > Maestros > Centro de preparación > Cambiar código"
}, {
    8731,
    "Comercial - POS central > Maestros > Centro de preparación > Consultar"
}, {
    8732,
    "Comercial - POS central > Maestros > Centro de preparación > Duplicar"
}, {
    8733,
    "Comercial - POS central > Maestros > Centro de preparación > Eliminar"
}, {
    8734,
    "Comercial - POS central > Maestros > Centro de preparación > Modificar"
}, {
    8735,
    "Comercial - POS central > Maestros > Centro de preparación > Reporte"
}, {
    7049,
    "Comercial - POS central > Maestros > Clases de enrolamiento"
}, {
    7050,
    "Comercial - POS central > Maestros > Clases de enrolamiento > Adicionar"
}, {
    7051,
    "Comercial - POS central > Maestros > Clases de enrolamiento > Consultar"
}, {
    7052,
    "Comercial - POS central > Maestros > Clases de enrolamiento > Duplicar"
}, {
    7053,
    "Comercial - POS central > Maestros > Clases de enrolamiento > Eliminar"
}, {
    7054,
    "Comercial - POS central > Maestros > Clases de enrolamiento > Modificar"
}, {
    7055,
    "Comercial - POS central > Maestros > Clases de enrolamiento > Reporte"
}, {
    7884,
    "Comercial - POS central > Maestros > Clases de familia"
}, {
    7885,
    "Comercial - POS central > Maestros > Clases de familia > Adicionar"
}, {
    7886,
    "Comercial - POS central > Maestros > Clases de familia > Cambiar codigo"
}, {
    7887,
    "Comercial - POS central > Maestros > Clases de familia > Consultar"
}, {
    7888,
    "Comercial - POS central > Maestros > Clases de familia > Duplicar"
}, {
    7890,
    "Comercial - POS central > Maestros > Clases de familia > Eliminar"
}, {
    7889,
    "Comercial - POS central > Maestros > Clases de familia > Modificar"
}, {
    7891,
    "Comercial - POS central > Maestros > Clases de familia > Reporte"
}, {
    4068,
    "Comercial - POS central > Maestros > Clases de TPV"
}, {
    4069,
    "Comercial - POS central > Maestros > Clases de TPV > Adicionar"
}, {
    4070,
    "Comercial - POS central > Maestros > Clases de TPV > Cambiar código"
}, {
    4071,
    "Comercial - POS central > Maestros > Clases de TPV > Consultar"
}, {
    4072,
    "Comercial - POS central > Maestros > Clases de TPV > Duplicar"
}, {
    4073,
    "Comercial - POS central > Maestros > Clases de TPV > Eliminar"
}, {
    4074,
    "Comercial - POS central > Maestros > Clases de TPV > Modificar"
}, {
    4075,
    "Comercial - POS central > Maestros > Clases de TPV > Reporte"
}, {
    4285,
    "Comercial - POS central > Maestros > Clientes POS"
}, {
    4286,
    "Comercial - POS central > Maestros > Clientes POS > Adicionar"
}, {
    4288,
    "Comercial - POS central > Maestros > Clientes POS > Consultar"
}, {
    4289,
    "Comercial - POS central > Maestros > Clientes POS > Duplicar"
}, {
    4290,
    "Comercial - POS central > Maestros > Clientes POS > Eliminar"
}, {
    4291,
    "Comercial - POS central > Maestros > Clientes POS > Modificar"
}, {
    4292,
    "Comercial - POS central > Maestros > Clientes POS > Reporte"
}, {
    10193,
    "Comercial - POS central > Maestros > Clubes de fidelización"
}, {
    10194,
    "Comercial - POS central > Maestros > Clubes de fidelización > Adicionar"
}, {
    10195,
    "Comercial - POS central > Maestros > Clubes de fidelización > Consultar"
}, {
    10196,
    "Comercial - POS central > Maestros > Clubes de fidelización > Duplicar"
}, {
    10197,
    "Comercial - POS central > Maestros > Clubes de fidelización > Eliminar"
}, {
    10198,
    "Comercial - POS central > Maestros > Clubes de fidelización > Modificar"
}, {
    10199,
    "Comercial - POS central > Maestros > Clubes de fidelización > Reporte"
}, {
    10200,
    "Comercial - POS central > Maestros > Clubes parámetros de fidelización"
}, {
    10201,
    "Comercial - POS central > Maestros > Clubes parámetros de fidelización > Adicionar"
}, {
    10202,
    "Comercial - POS central > Maestros > Clubes parámetros de fidelización > Consultar"
}, {
    10436,
    "Comercial - POS central > Maestros > Clubes parámetros de fidelización > Duplicar"
}, {
    10203,
    "Comercial - POS central > Maestros > Clubes parámetros de fidelización > Eliminar"
}, {
    10204,
    "Comercial - POS central > Maestros > Clubes parámetros de fidelización > Modificar"
}, {
    10205,
    "Comercial - POS central > Maestros > Clubes parámetros de fidelización > Reporte"
}, {
    9144,
    "Comercial - POS central > Maestros > Código de barras bonos recogida fisico"
}, {
    9145,
    "Comercial - POS central > Maestros > Código de barras bonos recogida fisico > Adicionar"
}, {
    9146,
    "Comercial - POS central > Maestros > Código de barras bonos recogida fisico > Eliminar"
}, {
    9147,
    "Comercial - POS central > Maestros > Código de barras bonos recogida fisico > Modificar"
}, {
    4223,
    "Comercial - POS central > Maestros > Comentarios de impresión"
}, {
    4224,
    "Comercial - POS central > Maestros > Comentarios de impresión > Adicionar"
}, {
    4225,
    "Comercial - POS central > Maestros > Comentarios de impresión > Cambiar código"
}, {
    4226,
    "Comercial - POS central > Maestros > Comentarios de impresión > Consultar"
}, {
    4227,
    "Comercial - POS central > Maestros > Comentarios de impresión > Duplicar"
}, {
    4228,
    "Comercial - POS central > Maestros > Comentarios de impresión > Eliminar"
}, {
    4229,
    "Comercial - POS central > Maestros > Comentarios de impresión > Modificar"
}, {
    4230,
    "Comercial - POS central > Maestros > Comentarios de impresión > Reporte"
}, {
    6581,
    "Comercial - POS central > Maestros > Compañías fidelizadoras"
}, {
    6582,
    "Comercial - POS central > Maestros > Compañías fidelizadoras > Adicionar"
}, {
    6583,
    "Comercial - POS central > Maestros > Compañías fidelizadoras > Consultar"
}, {
    6584,
    "Comercial - POS central > Maestros > Compañías fidelizadoras > Duplicar"
}, {
    6585,
    "Comercial - POS central > Maestros > Compañías fidelizadoras > Eliminar"
}, {
    6586,
    "Comercial - POS central > Maestros > Compañías fidelizadoras > Modificar"
}, {
    6587,
    "Comercial - POS central > Maestros > Compañías fidelizadoras > Reporte"
}, {
    4094,
    "Comercial - POS central > Maestros > Conceptos de caja"
}, {
    4095,
    "Comercial - POS central > Maestros > Conceptos de caja > Adicionar"
}, {
    4096,
    "Comercial - POS central > Maestros > Conceptos de caja > Cambiar código"
}, {
    4097,
    "Comercial - POS central > Maestros > Conceptos de caja > Consultar"
}, {
    4098,
    "Comercial - POS central > Maestros > Conceptos de caja > Duplicar"
}, {
    4099,
    "Comercial - POS central > Maestros > Conceptos de caja > Eliminar"
}, {
    4100,
    "Comercial - POS central > Maestros > Conceptos de caja > Modificar"
}, {
    4101,
    "Comercial - POS central > Maestros > Conceptos de caja > Reporte"
}, {
    9120,
    "Comercial - POS central > Maestros > Decoraciones"
}, {
    9121,
    "Comercial - POS central > Maestros > Decoraciones > Adicionar"
}, {
    9122,
    "Comercial - POS central > Maestros > Decoraciones > Cambiar código"
}, {
    9123,
    "Comercial - POS central > Maestros > Decoraciones > Consultar"
}, {
    9124,
    "Comercial - POS central > Maestros > Decoraciones > Duplicar"
}, {
    9125,
    "Comercial - POS central > Maestros > Decoraciones > Eliminar"
}, {
    9126,
    "Comercial - POS central > Maestros > Decoraciones > Modificar"
}, {
    9127,
    "Comercial - POS central > Maestros > Decoraciones > Reporte"
}, {
    8742,
    "Comercial - POS central > Maestros > Dispositivos"
}, {
    8743,
    "Comercial - POS central > Maestros > Dispositivos > Adicionar"
}, {
    8744,
    "Comercial - POS central > Maestros > Dispositivos > Consultar"
}, {
    8745,
    "Comercial - POS central > Maestros > Dispositivos > Duplicar"
}, {
    8746,
    "Comercial - POS central > Maestros > Dispositivos > Eliminar"
}, {
    8747,
    "Comercial - POS central > Maestros > Dispositivos > Modificar"
}, {
    8748,
    "Comercial - POS central > Maestros > Dispositivos > Reporte"
}, {
    7056,
    "Comercial - POS central > Maestros > Enrolamiento"
}, {
    7057,
    "Comercial - POS central > Maestros > Enrolamiento > Adicionar"
}, {
    7058,
    "Comercial - POS central > Maestros > Enrolamiento > Consultar"
}, {
    7059,
    "Comercial - POS central > Maestros > Enrolamiento > Duplicar"
}, {
    7060,
    "Comercial - POS central > Maestros > Enrolamiento > Eliminar"
}, {
    7061,
    "Comercial - POS central > Maestros > Enrolamiento > Modificar"
}, {
    7062,
    "Comercial - POS central > Maestros > Enrolamiento > Reporte"
}, {
    4044,
    "Comercial - POS central > Maestros > Familia de items"
}, {
    4045,
    "Comercial - POS central > Maestros > Familia de items > Adicionar"
}, {
    4046,
    "Comercial - POS central > Maestros > Familia de items > Cambiar código"
}, {
    4047,
    "Comercial - POS central > Maestros > Familia de items > Consultar"
}, {
    4048,
    "Comercial - POS central > Maestros > Familia de items > Duplicar"
}, {
    4049,
    "Comercial - POS central > Maestros > Familia de items > Eliminar"
}, {
    4050,
    "Comercial - POS central > Maestros > Familia de items > Modificar"
}, {
    4051,
    "Comercial - POS central > Maestros > Familia de items > Reporte"
}, {
    10700,
    "Comercial - POS central > Maestros > Grupos de zonas"
}, {
    10703,
    "Comercial - POS central > Maestros > Grupos de zonas > Adicionar"
}, {
    10704,
    "Comercial - POS central > Maestros > Grupos de zonas > Cambiar código"
}, {
    10705,
    "Comercial - POS central > Maestros > Grupos de zonas > Consultar"
}, {
    10706,
    "Comercial - POS central > Maestros > Grupos de zonas > Duplicar"
}, {
    10707,
    "Comercial - POS central > Maestros > Grupos de zonas > Eliminar"
}, {
    10708,
    "Comercial - POS central > Maestros > Grupos de zonas > Modificar"
}, {
    10709,
    "Comercial - POS central > Maestros > Grupos de zonas > Reporte"
}, {
    12458,
    "Comercial - POS central > Maestros > Grupo de conceptos"
}, {
    12459,
    "Comercial - POS central > Maestros > Grupo de conceptos > Adicionar"
}, {
    12460,
    "Comercial - POS central > Maestros > Grupo de conceptos > Cambiar código"
}, {
    12461,
    "Comercial - POS central > Maestros > Grupo de conceptos > Consultar"
}, {
    12462,
    "Comercial - POS central > Maestros > Grupo de conceptos > Duplicar"
}, {
    12463,
    "Comercial - POS central > Maestros > Grupo de conceptos > Eliminar"
}, {
    12464,
    "Comercial - POS central > Maestros > Grupo de conceptos > Modificar"
}, {
    12465,
    "Comercial - POS central > Maestros > Grupo de conceptos > Reporte"
}, {
    4052,
    "Comercial - POS central > Maestros > Grupo de familias"
}, {
    4053,
    "Comercial - POS central > Maestros > Grupo de familias > Adicionar"
}, {
    4054,
    "Comercial - POS central > Maestros > Grupo de familias > Cambiar código"
}, {
    4055,
    "Comercial - POS central > Maestros > Grupo de familias > Consultar"
}, {
    4056,
    "Comercial - POS central > Maestros > Grupo de familias > Duplicar"
}, {
    4057,
    "Comercial - POS central > Maestros > Grupo de familias > Eliminar"
}, {
    4058,
    "Comercial - POS central > Maestros > Grupo de familias > Modificar"
}, {
    4059,
    "Comercial - POS central > Maestros > Grupo de familias > Reporte"
}, {
    9482,
    "Comercial - POS central > Maestros > Grupo de pasos"
}, {
    9483,
    "Comercial - POS central > Maestros > Grupo de pasos > Adicionar"
}, {
    9484,
    "Comercial - POS central > Maestros > Grupo de pasos > Cambiar código"
}, {
    9485,
    "Comercial - POS central > Maestros > Grupo de pasos > Consultar"
}, {
    9486,
    "Comercial - POS central > Maestros > Grupo de pasos > Duplicar"
}, {
    9487,
    "Comercial - POS central > Maestros > Grupo de pasos > Eliminar"
}, {
    9488,
    "Comercial - POS central > Maestros > Grupo de pasos > Modificar"
}, {
    9489,
    "Comercial - POS central > Maestros > Grupo de pasos > Reporte"
}, {
    8064,
    "Comercial - POS central > Maestros > Grupo de salones"
}, {
    8065,
    "Comercial - POS central > Maestros > Grupo de salones > Adicionar"
}, {
    8066,
    "Comercial - POS central > Maestros > Grupo de salones > Cambiar código"
}, {
    8067,
    "Comercial - POS central > Maestros > Grupo de salones > Consultar"
}, {
    8068,
    "Comercial - POS central > Maestros > Grupo de salones > Duplicar"
}, {
    8069,
    "Comercial - POS central > Maestros > Grupo de salones > Eliminar"
}, {
    8070,
    "Comercial - POS central > Maestros > Grupo de salones > Modificar"
}, {
    8071,
    "Comercial - POS central > Maestros > Grupo de salones > Reporte"
}, {
    12855,
    "Comercial - POS central > Maestros > Grupo de motivos causales de devolución"
}, {
    12856,
    "Comercial - POS central > Maestros > Grupo de motivos causales de devolución > Adicionar"
}, {
    12857,
    "Comercial - POS central > Maestros > Grupo de motivos causales de devolución > Cambiar código"
}, {
    12858,
    "Comercial - POS central > Maestros > Grupo de motivos causales de devolución > Consultar"
}, {
    12859,
    "Comercial - POS central > Maestros > Grupo de motivos causales de devolución > Duplicar"
}, {
    12860,
    "Comercial - POS central > Maestros > Grupo de motivos causales de devolución > Eliminar"
}, {
    12861,
    "Comercial - POS central > Maestros > Grupo de motivos causales de devolución > Modificar"
}, {
    12862,
    "Comercial - POS central > Maestros > Grupo de motivos causales de devolución > Reporte"
}, {
    8008,
    "Comercial - POS central > Maestros > Items de servicios públicos"
}, {
    8009,
    "Comercial - POS central > Maestros > Items de servicios públicos > Adicionar"
}, {
    8010,
    "Comercial - POS central > Maestros > Items de servicios públicos > Eliminar"
}, {
    8011,
    "Comercial - POS central > Maestros > Items de servicios públicos > Modificar"
}, {
    4245,
    "Comercial - POS central > Maestros > Item de concesión"
}, {
    4246,
    "Comercial - POS central > Maestros > Item de concesión > Adicionar"
}, {
    4248,
    "Comercial - POS central > Maestros > Item de concesión > Eliminar"
}, {
    4247,
    "Comercial - POS central > Maestros > Item de concesión > Modificar"
}, {
    8293,
    "Comercial - POS central > Maestros > Item de donación"
}, {
    8294,
    "Comercial - POS central > Maestros > Item de donación > Adicionar"
}, {
    8295,
    "Comercial - POS central > Maestros > Item de donación > Eliminar"
}, {
    8296,
    "Comercial - POS central > Maestros > Item de donación > Modificar"
}, {
    7073,
    "Comercial - POS central > Maestros > Item de gift card"
}, {
    7074,
    "Comercial - POS central > Maestros > Item de gift card > Adicionar"
}, {
    7075,
    "Comercial - POS central > Maestros > Item de gift card > Eliminar"
}, {
    7076,
    "Comercial - POS central > Maestros > Item de gift card > Modificar"
}, {
    8048,
    "Comercial - POS central > Maestros > Mesas"
}, {
    8049,
    "Comercial - POS central > Maestros > Mesas > Adicionar"
}, {
    8050,
    "Comercial - POS central > Maestros > Mesas > Cambiar código"
}, {
    8051,
    "Comercial - POS central > Maestros > Mesas > Consultar"
}, {
    8052,
    "Comercial - POS central > Maestros > Mesas > Duplicar"
}, {
    8053,
    "Comercial - POS central > Maestros > Mesas > Eliminar"
}, {
    8054,
    "Comercial - POS central > Maestros > Mesas > Modificar"
}, {
    8055,
    "Comercial - POS central > Maestros > Mesas > Reporte"
}, {
    7633,
    "Comercial - POS central > Maestros > Motivos de arreglos"
}, {
    7634,
    "Comercial - POS central > Maestros > Motivos de arreglos > Adicionar"
}, {
    7635,
    "Comercial - POS central > Maestros > Motivos de arreglos > Consultar"
}, {
    7636,
    "Comercial - POS central > Maestros > Motivos de arreglos > Duplicar"
}, {
    7637,
    "Comercial - POS central > Maestros > Motivos de arreglos > Eliminar"
}, {
    7638,
    "Comercial - POS central > Maestros > Motivos de arreglos > Modificar"
}, {
    7639,
    "Comercial - POS central > Maestros > Motivos de arreglos > Reporte"
}, {
    7407,
    "Comercial - POS central > Maestros > Motivos de fidelización"
}, {
    7408,
    "Comercial - POS central > Maestros > Motivos de fidelización > Adicionar"
}, {
    7409,
    "Comercial - POS central > Maestros > Motivos de fidelización > Consultar"
}, {
    7410,
    "Comercial - POS central > Maestros > Motivos de fidelización > Duplicar"
}, {
    7411,
    "Comercial - POS central > Maestros > Motivos de fidelización > Eliminar"
}, {
    7412,
    "Comercial - POS central > Maestros > Motivos de fidelización > Modificar"
}, {
    7413,
    "Comercial - POS central > Maestros > Motivos de fidelización > Reporte"
}, {
    8299,
    "Comercial - POS central > Maestros > Parámetros proveedor servicios"
}, {
    8300,
    "Comercial - POS central > Maestros > Parámetros proveedor servicios > Adicionar"
}, {
    8301,
    "Comercial - POS central > Maestros > Parámetros proveedor servicios > Consultar"
}, {
    8302,
    "Comercial - POS central > Maestros > Parámetros proveedor servicios > Duplicar"
}, {
    8303,
    "Comercial - POS central > Maestros > Parámetros proveedor servicios > Eliminar"
}, {
    8304,
    "Comercial - POS central > Maestros > Parámetros proveedor servicios > Modificar"
}, {
    8305,
    "Comercial - POS central > Maestros > Parámetros proveedor servicios > Reporte"
}, {
    9474,
    "Comercial - POS central > Maestros > Pasos"
}, {
    9475,
    "Comercial - POS central > Maestros > Pasos > Adicionar"
}, {
    9476,
    "Comercial - POS central > Maestros > Pasos > Cambiar código"
}, {
    9477,
    "Comercial - POS central > Maestros > Pasos > Consultar"
}, {
    9478,
    "Comercial - POS central > Maestros > Pasos > Duplicar"
}, {
    9479,
    "Comercial - POS central > Maestros > Pasos > Eliminar"
}, {
    9480,
    "Comercial - POS central > Maestros > Pasos > Modificar"
}, {
    9481,
    "Comercial - POS central > Maestros > Pasos > Reporte"
}, {
    10102,
    "Comercial - POS central > Maestros > Plano de mesas"
}, {
    8026,
    "Comercial - POS central > Maestros > Programación de actualización"
}, {
    7817,
    "Comercial - POS central > Maestros > Programación de actualización > Programación de actualización"
}, {
    7818,
    "Comercial - POS central > Maestros > Programación de actualización > Programación de actualización > Adicionar"
}, {
    7819,
    "-No implementado > Consultar"
}, {
    7820,
    "-No implementado > Eliminar"
}, {
    7821,
    "Comercial - POS central > Maestros > Programación de actualización > Programación de actualización > Modificar"
}, {
    7822,
    "Comercial - POS central > Maestros > Programación de actualización > Programación de actualización > Reporte"
}, {
    8736,
    "Comercial - POS central > Maestros > Puntos de reparación"
}, {
    8737,
    "Comercial - POS central > Maestros > Puntos de reparación > Adicionar"
}, {
    8738,
    "Comercial - POS central > Maestros > Puntos de reparación > Consultar"
}, {
    8739,
    "Comercial - POS central > Maestros > Puntos de reparación > Eliminar"
}, {
    8740,
    "Comercial - POS central > Maestros > Puntos de reparación > Modificar"
}, {
    8741,
    "Comercial - POS central > Maestros > Puntos de reparación > Reporte"
}, {
    7826,
    "Comercial - POS central > Maestros > Programación de actualización > Registro service pack"
}, {
    7827,
    "Comercial - POS central > Maestros > Programación de actualización > Registro service pack > Adicionar"
}, {
    7828,
    "-No implementado > Consultar"
}, {
    7829,
    "-No implementado > Eliminar"
}, {
    7830,
    "-No implementado > Modificar"
}, {
    7831,
    "Comercial - POS central > Maestros > Programación de actualización > Registro service pack > Reporte"
}, {
    8916,
    "Comercial - POS central > Maestros > Retiro automático de puntos"
}, {
    7568,
    "Comercial - POS central > Maestros > Rifas"
}, {
    7569,
    "Comercial - POS central > Maestros > Rifas > Adicionar"
}, {
    7575,
    "Comercial - POS central > Maestros > Rifas > Cambiar código"
}, {
    7570,
    "Comercial - POS central > Maestros > Rifas > Consultar"
}, {
    7576,
    "Comercial - POS central > Maestros > Rifas > Consulta de rifas"
}, {
    7578,
    "Comercial - POS central > Maestros > Rifas > Consulta de rifas > Permite modificar rifas asignadas"
}, {
    7571,
    "Comercial - POS central > Maestros > Rifas > Duplicar"
}, {
    7572,
    "Comercial - POS central > Maestros > Rifas > Eliminar"
}, {
    7577,
    "Comercial - POS central > Maestros > Rifas > Impresión de boletas"
}, {
    7573,
    "Comercial - POS central > Maestros > Rifas > Modificar"
}, {
    7574,
    "Comercial - POS central > Maestros > Rifas > Reporte"
}, {
    8056,
    "Comercial - POS central > Maestros > Salones"
}, {
    8057,
    "Comercial - POS central > Maestros > Salones > Adicionar"
}, {
    8058,
    "Comercial - POS central > Maestros > Salones > Cambiar código"
}, {
    8059,
    "Comercial - POS central > Maestros > Salones > Consultar"
}, {
    8060,
    "Comercial - POS central > Maestros > Salones > Duplicar"
}, {
    8061,
    "Comercial - POS central > Maestros > Salones > Eliminar"
}, {
    8062,
    "Comercial - POS central > Maestros > Salones > Modificar"
}, {
    8063,
    "Comercial - POS central > Maestros > Salones > Reporte"
}, {
    7810,
    "Comercial - POS central > Maestros > Programación de actualización > Servidor de actualización"
}, {
    7811,
    "Comercial - POS central > Maestros > Programación de actualización > Servidor de actualización > Adicionar"
}, {
    7812,
    "Comercial - POS central > Maestros > Programación de actualización > Servidor de actualización > Consultar"
}, {
    7813,
    "Comercial - POS central > Maestros > Programación de actualización > Servidor de actualización > Duplicar"
}, {
    7814,
    "Comercial - POS central > Maestros > Programación de actualización > Servidor de actualización > Eliminar"
}, {
    7815,
    "Comercial - POS central > Maestros > Programación de actualización > Servidor de actualización > Modificar"
}, {
    7816,
    "Comercial - POS central > Maestros > Programación de actualización > Servidor de actualización > Reporte"
}, {
    4703,
    "Comercial - POS central > Maestros > Tarjetas de fidelización"
}, {
    4704,
    "Comercial - POS central > Maestros > Tarjetas de fidelización > Adicionar"
}, {
    4711,
    "Comercial - POS central > Maestros > Tarjetas de fidelización > Permite adicionar movimiento de puntos"
}, {
    8915,
    "Comercial - POS central > Maestros > Tarjetas de fidelización > Permitir asignar referido al editar"
}, {
    7428,
    "Comercial - POS central > Maestros > Tarjetas de fidelización > Cambio de tarjeta"
}, {
    4705,
    "Comercial - POS central > Maestros > Tarjetas de fidelización > Consultar"
}, {
    4706,
    "Comercial - POS central > Maestros > Tarjetas de fidelización > Duplicar"
}, {
    4707,
    "Comercial - POS central > Maestros > Tarjetas de fidelización > Eliminar"
}, {
    4708,
    "Comercial - POS central > Maestros > Tarjetas de fidelización > Modificar"
}, {
    4710,
    "Comercial - POS central > Maestros > Tarjetas de fidelización > Permite modificar estado"
}, {
    4709,
    "Comercial - POS central > Maestros > Tarjetas de fidelización > Reporte"
}, {
    4712,
    "Comercial - POS central > Maestros > Tarjetas de fidelización > Permite retirar movimiento de puntos"
}, {
    10806,
    "Comercial - POS central > Maestros > Tipos de entrega"
}, {
    10807,
    "Comercial - POS central > Maestros > Tipos de entrega > Adicionar"
}, {
    10808,
    "Comercial - POS central > Maestros > Tipos de entrega > Cambiar código"
}, {
    10809,
    "Comercial - POS central > Maestros > Tipos de entrega > Consultar"
}, {
    10810,
    "Comercial - POS central > Maestros > Tipos de entrega > Duplicar"
}, {
    10811,
    "Comercial - POS central > Maestros > Tipos de entrega > Eliminar"
}, {
    10812,
    "Comercial - POS central > Maestros > Tipos de entrega > Modificar"
}, {
    10813,
    "Comercial - POS central > Maestros > Tipos de entrega > Reporte"
}, {
    4696,
    "Comercial - POS central > Maestros > Tipos de tarjetas de fidelización"
}, {
    4697,
    "Comercial - POS central > Maestros > Tipos de tarjetas de fidelización > Adicionar"
}, {
    4698,
    "Comercial - POS central > Maestros > Tipos de tarjetas de fidelización > Consultar"
}, {
    4699,
    "Comercial - POS central > Maestros > Tipos de tarjetas de fidelización > Duplicar"
}, {
    4700,
    "Comercial - POS central > Maestros > Tipos de tarjetas de fidelización > Eliminar"
}, {
    4701,
    "Comercial - POS central > Maestros > Tipos de tarjetas de fidelización > Modificar"
}, {
    6588,
    "Comercial - POS central > Maestros > Tipos de tarjetas de fidelización parámetros"
}, {
    6589,
    "Comercial - POS central > Maestros > Tipos de tarjetas de fidelización parámetros > Adicionar"
}, {
    6590,
    "Comercial - POS central > Maestros > Tipos de tarjetas de fidelización parámetros > Consultar"
}, {
    6591,
    "Comercial - POS central > Maestros > Tipos de tarjetas de fidelización parámetros > Duplicar"
}, {
    6592,
    "Comercial - POS central > Maestros > Tipos de tarjetas de fidelización parámetros > Eliminar"
}, {
    6593,
    "Comercial - POS central > Maestros > Tipos de tarjetas de fidelización parámetros > Modificar"
}, {
    6594,
    "Comercial - POS central > Maestros > Tipos de tarjetas de fidelización parámetros > Reporte"
}, {
    4702,
    "Comercial - POS central > Maestros > Tipos de tarjetas de fidelización > Reporte"
}, {
    7840,
    "Comercial - POS central > Maestros > Control tipo de bonos de mercadeo"
}, {
    7841,
    "Comercial - POS central > Maestros > Control tipo de bonos de mercadeo > Adicionar"
}, {
    7842,
    "Comercial - POS central > Maestros > Control tipo de bonos de mercadeo > Consultar"
}, {
    7843,
    "Comercial - POS central > Maestros > Control tipo de bonos de mercadeo > Duplicar"
}, {
    7844,
    "Comercial - POS central > Maestros > Control tipo de bonos de mercadeo > Eliminar"
}, {
    7845,
    "Comercial - POS central > Maestros > Control tipo de bonos de mercadeo > Modificar"
}, {
    7846,
    "Comercial - POS central > Maestros > Control tipo de bonos de mercadeo > Reporte"
}, {
    4060,
    "Comercial - POS central > Maestros > TPV (Terminal punto de venta)"
}, {
    4061,
    "Comercial - POS central > Maestros > TPV (Terminal punto de venta) > Adicionar"
}, {
    4062,
    "Comercial - POS central > Maestros > TPV (Terminal punto de venta) > Cambiar código"
}, {
    4063,
    "Comercial - POS central > Maestros > TPV (Terminal punto de venta) > Consultar"
}, {
    4064,
    "Comercial - POS central > Maestros > TPV (Terminal punto de venta) > Duplicar"
}, {
    4065,
    "Comercial - POS central > Maestros > TPV (Terminal punto de venta) > Eliminar"
}, {
    4066,
    "Comercial - POS central > Maestros > TPV (Terminal punto de venta) > Modificar"
}, {
    4067,
    "Comercial - POS central > Maestros > TPV (Terminal punto de venta) > Reporte"
}, {
    11047,
    "Comercial - POS central > Maestros > Unificar Clientes POS"
}, {
    4383,
    "Comercial - POS central > Maestros > Vendedores por C.O."
}, {
    4384,
    "Comercial - POS central > Maestros > Vendedores por C.O. > Adicionar"
}, {
    4385,
    "Comercial - POS central > Maestros > Vendedores por C.O. > Consultar"
}, {
    4386,
    "Comercial - POS central > Maestros > Vendedores por C.O. > Eliminar"
}, {
    4387,
    "Comercial - POS central > Maestros > Vendedores por C.O. > Modificar"
}, {
    4388,
    "Comercial - POS central > Maestros > Vendedores por C.O. > Reporte"
}, {
    10692,
    "Comercial - POS central > Maestros > Zonas"
}, {
    10710,
    "Comercial - POS central > Maestros > Zonas > Adicionar"
}, {
    10711,
    "Comercial - POS central > Maestros > Zonas > Cambiar código"
}, {
    10712,
    "Comercial - POS central > Maestros > Zonas > Consultar"
}, {
    10713,
    "Comercial - POS central > Maestros > Zonas > Duplicar"
}, {
    10714,
    "Comercial - POS central > Maestros > Zonas > Eliminar"
}, {
    10715,
    "Comercial - POS central > Maestros > Zonas > Modificar"
}, {
    10716,
    "Comercial - POS central > Maestros > Zonas > Reporte"
}, {
    6487,
    "Comercial - POS central > Monitor TPV´S"
}, {
    9118,
    "Comercial - POS central > Monitor TPV´S > Análisis de inactividad de sincronización"
}, {
    6493,
    "Comercial - POS central > Monitor TPV´S > Consultas diarias  de análisis de inactividad."
}, {
    6491,
    "Comercial - POS central > Monitor TPV´S > Consultas diarias  de estados"
}, {
    6494,
    "Comercial - POS central > Monitor TPV´S > Consultas diarias de pendientes de acumulación"
}, {
    6492,
    "Comercial - POS central > Monitor TPV´S > Consultas diarias de recogidas inminentes"
}, {
    6490,
    "Comercial - POS central > Monitor TPV´S > Consultas diarias de saldos"
}, {
    9119,
    "Comercial - POS central > Monitor TPV´S > Consultas diarias de análisis de inactividad docto"
}, {
    8087,
    "Comercial - POS central > Monitor TPV´S > Consulta registros eliminados"
}, {
    6488,
    "Comercial - POS central > Monitor TPV´S > Paquetes transaccionales con errores"
}, {
    6489,
    "Comercial - POS central > Monitor TPV´S > Paquetes transaccionales sin procesar"
}, {
    7825,
    "Comercial - POS central > Monitor TPV´S > Consulta registro control de actualización"
}, {
    9887,
    "Comercial - POS central > Otros procesos"
}, {
    9888,
    "Comercial - POS central > Otros procesos > Cancelación de anticipos"
}, {
    12365,
    "Comercial - POS central > Otros procesos > Cuadre de caja fisico"
}, {
    10898,
    "Comercial - POS central > Otros procesos > Liberar separados"
}, {
    11719,
    "Comercial - POS central > Maestros > Tipos de identificación"
}, {
    1792,
    "Personalizados"
}, {
    2595,
    "Personalizados > Activos fijos USD EKA"
}, {
    4280,
    "Personalizados > Actualización de parámetros - Tropi"
}, {
    3936,
    "Personalizados > Consulta acumulado de existencia - Top 100 - Gulda"
}, {
    3932,
    "Personalizados > Consulta acumulado de ventas - Gulda"
}, {
    2167,
    "Personalizados > Activo fijo Usgap"
}, {
    3231,
    "Personalizados > Amortizacion de contratos (OPEN)"
}, {
    7117,
    "Personalizados > Análisis de precios - Marion"
}, {
    3937,
    "Personalizados > Consulta antiguedad de stock - Gulda"
}, {
    10908,
    "Personalizados > Aprobar pedidos con anticipos - cementos"
}, {
    2195,
    "Personalizados > Archivos planos syngenta"
}, {
    2447,
    "Personalizados > Asientos complementarios (Conalvias PERU)"
}, {
    3228,
    "Personalizados > Asignacion de costos (FANALCA)"
}, {
    8458,
    "Personalizados > Asignar obligación C. Riesgo- Union arroceros"
}, {
    11146,
    "Personalizados > Asignación de cupos clientes - Dsierra"
}, {
    12008,
    "Personalizados > Auditoria de compromisos parciales - Eka"
}, {
    4004,
    "Personalizados > Consulta de auditoria transaccionales (Ecuador)"
}, {
    4396,
    "Personalizados > Automatizar avalúo (Conalvias)"
}, {
    3761,
    "Personalizados > Balance de inventarios - Agremezclas"
}, {
    10675,
    "Personalizados > Resumen de balance de masas - QBCO"
}, {
    7883,
    "Personalizados > Bitácora de resoluciones - StudioF"
}, {
    7882,
    "Personalizados > Bitácora de transacciones de facturas - StudioF"
}, {
    7768,
    "Personalizados > Boletin de caja -Electro Japonesa"
}, {
    6534,
    "Personalizados > Calcular tasa de producción por hora (Fanalca)"
}, {
    11102,
    "Personalizados > Calculo automático del VNR"
}, {
    4244,
    "Personalizados > Calculo de bonos - Hoteles Estelar"
}, {
    7112,
    "Personalizados > Calculo de cupo de clientes - Marion"
}, {
    8913,
    "Personalizados > Calculo factor bodega - Gilmedica"
}, {
    6683,
    "Personalizados > Cambio de cobrador - Electro Japonesa"
}, {
    6898,
    "Personalizados > Captura de lista de materiales - Expofaro"
}, {
    4102,
    "Personalizados > Captura de lista de materiales - Supertex"
}, {
    8348,
    "Personalizados > Carco"
}, {
    10780,
    "Personalizados > Carco exportación de egresos de caja"
}, {
    8353,
    "Personalizados > Carco > Exportación de documentos contables"
}, {
    8350,
    "Personalizados > Carco > Exportación de facturas"
}, {
    8351,
    "Personalizados > Carco > Informes de recaudos"
}, {
    8349,
    "Personalizados > Carco > Porcentajes por fechas"
}, {
    8352,
    "Personalizados > Carco > Procesos de recaudos"
}, {
    6682,
    "Personalizados > Circularizacion - Electro Japonesa"
}, {
    12482,
    "Personalizados > Circularización - Inversiones GLP"
}, {
    3752,
    "Personalizados > Informe comparativo de inventarios - Miratex"
}, {
    8894,
    "Personalizados > Comprobación de OPs - Andina"
}, {
    7119,
    "Personalizados > Comprobantes facturas - ACR"
}, {
    3908,
    "Personalizados > Compromiso de pedidos TexComercial"
}, {
    8791,
    "Personalizados > Comprometer pedidos y requisiones - Surtifuver"
}, {
    4826,
    "Personalizados > Comparación de lista de materiales - Superpolo"
}, {
    3389,
    "Personalizados > Confrontación Inventarios zona franca (Cosmoagro)"
}, {
    6562,
    "Personalizados > Consulta costos truput facturas - GyJ"
}, {
    4693,
    "Personalizados > Consulta costos truput venta - GyJ"
}, {
    3909,
    "Personalizados > Consulta documentos verificados - Belleza Express"
}, {
    12801,
    "Personalizados > Consulta de inventario en proceso - RHércules"
}, {
    11442,
    "Personalizados > Consulta de Log de movimiento de inventario"
}, {
    12803,
    "Personalizados > Consulta de simulación individual - RHércules"
}, {
    10678,
    "Personalizados > Resumen detallado de consumos - QBCO"
}, {
    4233,
    "Personalizados > Consulta contratos - INVEMAR"
}, {
    8245,
    "Personalizados > Consulta descuentos entidades bancarias - Studio F"
}, {
    8246,
    "Personalizados > Consulta descuentos entidades bancarias -Studiof-a"
}, {
    6671,
    "Personalizados > Consulta de existencias proyeccion entrega"
}, {
    11195,
    "Personalizados > Consulta Hoja de costos indentada - cato"
}, {
    7739,
    "Personalizados > Consulta de inventarios por edades -Euro"
}, {
    11560,
    "Personalizados > Consulta de inventario en proceso equiv -resortes"
}, {
    11597,
    "Personalizados > Consulta relación de medios de pago - Corral"
}, {
    8198,
    "Personalizados > Consulta órdenes de compra por ítem -Superiberia"
}, {
    11641,
    "Personalizados > Consulta de operaciones por OPs - resortes"
}, {
    4076,
    "Personalizados > Consulta pedidos por ítem - MIRATEX"
}, {
    11559,
    "Personalizados > Consulta de stock en componentes - resortes"
}, {
    11558,
    "Personalizados > Consulta de usos por ítem - resortes"
}, {
    11642,
    "Personalizados > Consulta valorizada de remisiones - romulo"
}, {
    6545,
    "Personalizados > Contabilización de Mercancia en consignación"
}, {
    8454,
    "Personalizados > Convenios - Supermercados"
}, {
    8460,
    "Personalizados > Convenios - Supermercados > Adicionar"
}, {
    8461,
    "Personalizados > Convenios - Supermercados > Consultar"
}, {
    8462,
    "Personalizados > Convenios - Supermercados > Duplicar"
}, {
    8463,
    "Personalizados > Convenios - Supermercados > Eliminar"
}, {
    8464,
    "Personalizados > Convenios - Supermercados > Modificar"
}, {
    8465,
    "Personalizados > Convenios - Supermercados > Reporte"
}, {
    10674,
    "Personalizados > Resumen de costos acumulados por Ítem OP - QBCO"
}, {
    3753,
    "Personalizados > Informe costos integracion nacional - Fanalca"
}, {
    3447,
    "Personalizados > Generar cuentas entre distribuidora y hoteles"
}, {
    9949,
    "Personalizados > Cubos de actividades Siesa SGD"
}, {
    9971,
    "Personalizados > Cubo de actividades terminadas -Siesa SGD"
}, {
    10900,
    "Personalizados > Cubo de pedidos - Stilotex"
}, {
    3309,
    "Personalizados > Cubrimiento de pedidos (Fanalca)"
}, {
    2168,
    "Personalizados > CxC Imbanaco"
}, {
    11796,
    "Personalizados > Desconexión > Desconexión consulta historia"
}, {
    11795,
    "Personalizados > Desconexión > Desconexión proceso"
}, {
    11794,
    "Personalizados > Desconexión"
}, {
    2464,
    "Personalizados > Distribución de C.Costos (ORO)"
}, {
    3390,
    "Personalizados > Distribución  de costos e ingresos (FANALCA)"
}, {
    7838,
    "Personalizados > Distribucion cuenta Superinter"
}, {
    6778,
    "Personalizados > Distribución por U.N.(Salud Vida Eps)"
}, {
    2376,
    "Personalizados > Distribucion de C.Costos"
}, {
    3885,
    "Personalizados > Documentos emitidos autoimpresores (Ecuador)"
}, {
    6546,
    "Personalizados > Empadronamiento - Fanalca"
}, {
    7152,
    "Personalizados > Empadronamiento - Fanalca > Habilitar impresión"
}, {
    7151,
    "Personalizados > Empadronamiento - Fanalca > Imprimir"
}, {
    8400,
    "Personalizados > Empresa andina generación documento compañia"
}, {
    3229,
    "Personalizados > Endoso de cartera (INCAMETAL)"
}, {
    3410,
    "Personalizados > Estado de costos (Fanalca)"
}, {
    6961,
    "Personalizados > Estado de cuenta FESI"
}, {
    11640,
    "Personalizados > Evalucación de proveedores - resortes"
}, {
    3322,
    "Personalizados > Exportación contable de documentos"
}, {
    3391,
    "Personalizados > Exportación contable de ventas (OBEN)"
}, {
    3440,
    "Personalizados > Exportación planos de vehiculos"
}, {
    7226,
    "Personalizados > Exportar archivos para POS - Invercomer"
}, {
    3445,
    "Personalizados > Exportar maestros - FANALCA"
}, {
    3512,
    "Personalizados > Exportar maestros - STUDIO F"
}, {
    6896,
    "Personalizados > Facturación de equipos - Sainc"
}, {
    3132,
    "Personalizados > Facturas y notas por item - serial"
}, {
    4160,
    "Personalizados > Facturación ventas comercial (COIMPRESORES)"
}, {
    9540,
    "Personalizados > Generación de ajustes - Paratel"
}, {
    12040,
    "Personalizados > Generación de OPs desde pedidos - Rómulo"
}, {
    3946,
    "Personalizados > Generación de planos WMS - Tropi"
}, {
    3203,
    "Personalizados > Generacion plano activos fijos (Contegral)"
}, {
    10786,
    "Personalizados > Generación de pronósticos - doron"
}, {
    3724,
    "Personalizados > Generación de pronóstico - (ROY ALPHA)"
}, {
    3398,
    "Personalizados > Generación vehiculos con base en seriales"
}, {
    2846,
    "Personalizados > Generar anulación contable"
}, {
    2311,
    "Personalizados > Generar orden con descuento"
}, {
    12693,
    "Personalizados > Generar planos Aeropuerto"
}, {
    7947,
    "Personalizados > Generar planos STF-OPAIN"
}, {
    4653,
    "Personalizados > Generar ajustes - Contegral"
}, {
    4650,
    "Personalizados > Generar ajustes - Tropi"
}, {
    8002,
    "Personalizados > Generación automática de devolución - Calzatodo"
}, {
    4309,
    "Personalizados > Generar cargue de pedidos - Tropi"
}, {
    9110,
    "Personalizados > Generación de comisiones - Motores"
}, {
    3234,
    "Personalizados > Generar consumo desde compromisos (FANALCA)"
}, {
    7632,
    "Personalizados > Generación de curvas - Rocha"
}, {
    8455,
    "Personalizados > Generación descuentos por convenio - supermercados"
}, {
    8403,
    "Personalizados > Generación de evaluación de proveedor - Calzatodo"
}, {
    6774,
    "Personalizados > Generar notas crédito desde facturas"
}, {
    6761,
    "Personalizados > Generar pedidos con base en OC - STUDIO F"
}, {
    9367,
    "Personalizados > Generar pedidos con base en OC - Surtifruver"
}, {
    4265,
    "Personalizados > Generacion plano consolidacion - Conalvias"
}, {
    7997,
    "Personalizados > Generar plano de ítems en físico - Superinter"
}, {
    8572,
    "Personalizados > Generar plano de ventas pos - Superinter"
}, {
    7630,
    "Personalizados > Generación de precios - Pollo andino"
}, {
    9128,
    "Personalizados > Generación de precios -Supermercados"
}, {
    8005,
    "Personalizados > Generar precio base y descuentos - Invercomer"
}, {
    10843,
    "Personalizados > Generación de pronósticos desde ppto - StudioF"
}, {
    4279,
    "Personalizados > Generación de pronosticos - Tropi"
}, {
    8749,
    "Personalizados > Generar requisiciones -Ecco center"
}, {
    4724,
    "Personalizados > Generar requisición desde cantidad a pedir GyJ"
}, {
    4351,
    "Personalizados > Generación de requisiciones - Hoteles Estelar"
}, {
    4586,
    "Personalizados > Generar salidas - Conalvias"
}, {
    6899,
    "Personalizados > Generar salidas - Conalvias > Validar registros sin existencias"
}, {
    7631,
    "Personalizados > Generar seriales y códigos de barras - Rocha"
}, {
    6365,
    "Personalizados > Generar solicitudes desde compromisos OP - Imecol"
}, {
    4533,
    "Personalizados > Generar stock de seguridad estático - Dyna"
}, {
    7606,
    "Personalizados > Generar stock de seguridad - Superinter"
}, {
    8410,
    "Personalizados > Generar valoración de ingreso de bodega - Forsa"
}, {
    9711,
    "Personalizados > Generar Valoración de ingreso a bodega"
}, {
    6763,
    "Personalizados > Ficha Gestion Cobro - Electro Japonesa"
}, {
    4532,
    "Personalizados > Historico de OP a un corte - Fanalca"
}, {
    8645,
    "Personalizados > Hoteles, impuestos a descontar a perú"
}, {
    3413,
    "Personalizados > Hoja de vida de vehiculos en garantia"
}, {
    12813,
    "Personalizados > Imbanaco Egresos vs Facturas"
}, {
    12814,
    "-No implementado > Egresos vs Facturas"
}, {
    2350,
    "Personalizados > Imprimir otros doctos"
}, {
    4310,
    "Personalizados > Importar cargue de pedidos - Tropi"
}, {
    3910,
    "Personalizados > Importar y exportar plano Venda Seguro"
}, {
    4737,
    "Personalizados > Incentivos de proveedores - Tropi"
}, {
    4738,
    "Personalizados > Incentivos de proveedores - Tropi > Adicionar"
}, {
    4739,
    "Personalizados > Incentivos de proveedores - Tropi > Consultar"
}, {
    4740,
    "Personalizados > Incentivos de proveedores - Tropi > Duplicar"
}, {
    4741,
    "Personalizados > Incentivos de proveedores - Tropi > Eliminar"
}, {
    4742,
    "Personalizados > Incentivos de proveedores - Tropi > Modificar"
}, {
    4743,
    "Personalizados > Incentivos de proveedores - Tropi > Reporte"
}, {
    11305,
    "Personalizados > Incentivos - Consulta de liquidación - RHércules"
}, {
    11240,
    "Personalizados > Incentivos - Grupos de fallas - RHércules"
}, {
    11307,
    "Personalizados > Incentivos - Grupos de fallas - RHércules > Adicionar"
}, {
    11308,
    "Personalizados > Incentivos - Grupos de fallas - RHércules > Consultar"
}, {
    11309,
    "Personalizados > Incentivos - Grupos de fallas - RHércules > Duplicar"
}, {
    11310,
    "Personalizados > Incentivos - Grupos de fallas - RHércules > Eliminar"
}, {
    11311,
    "Personalizados > Incentivos - Grupos de fallas - RHércules > Modificar"
}, {
    11312,
    "Personalizados > Incentivos - Grupos de fallas - RHércules > Reporte"
}, {
    11242,
    "Personalizados > Incentivos - Liquidación de incentivos - RHércules"
}, {
    11241,
    "-No implementado > Incentivos - Parámetros C.Costos - RHércules"
}, {
    11243,
    "-No implementado > Incentivos - Reversión de liquidación - RHércules"
}, {
    11245,
    "Personalizados > Incentivos - Reporte por C.Costo - RHércules"
}, {
    11244,
    "Personalizados > Incentivos - Reporte por empleado - RHércules"
}, {
    10028,
    "Personalizados > Informe scrap - Andina"
}, {
    4170,
    "Personalizados > Interfase compras - Coomeva"
}, {
    8897,
    "Personalizados > Inventario en proceso al estándar - Andina"
}, {
    3759,
    "Personalizados > Libro de compras PANAMA"
}, {
    2517,
    "Personalizados > Libro de Compras y Ventas PERU"
}, {
    2596,
    "Personalizados > Liquidacion de comisiones DYNA"
}, {
    10627,
    "Personalizados > Liquidación por documentos"
}, {
    6895,
    "Personalizados > Liquidación de fletes y planillas - GyJ..."
}, {
    10626,
    "Personalizados > Liquidación de movimiento"
}, {
    8972,
    "Personalizados > Liquidación de regalías - Primavera"
}, {
    6420,
    "Personalizados > Liquidación de facturas arrendamiento-Forsa"
}, {
    7089,
    "Personalizados > Liquidación de operacion - Conalvias"
}, {
    10814,
    "Personalizados > Liquidación y pago de leche -pomar"
}, {
    11554,
    "Personalizados > Consulta de Log de costos x movto de inventario"
}, {
    10677,
    "Personalizados > Resumen mensual de componentes - QBCO"
}, {
    10676,
    "Personalizados > Resumen mensual de ítems OP - QBCO"
}, {
    11050,
    "Personalizados > Modelos - Rocha"
}, {
    11103,
    "Personalizados > Modelo de previsión"
}, {
    4029,
    "Personalizados > Consulta movimiento de kits - Concentrados"
}, {
    4531,
    "Personalizados > Movimiento de OP en proceso- Fanalca"
}, {
    4199,
    "Personalizados > Generar notas crédito desde pedidos - Tropi"
}, {
    3934,
    "Personalizados > Consulta objetivo de ventas - Gulda"
}, {
    12491,
    "Personalizados > Operaciones por OPs - Rómulo"
}, {
    11598,
    "Personalizados > Consulta operaciones de herramentales - resortes"
}, {
    11202,
    "Personalizados > Pagos entre compañias"
}, {
    7549,
    "Generales > Parámetros generales"
}, {
    7551,
    "Generales > Parámetros generales > Consultar"
}, {
    7550,
    "Generales > Parámetros generales > Modificar"
}, {
    3523,
    "Personalizados > Pedido sugerido - FANALCA"
}, {
    11781,
    "Personalizados > Prioridades de producción - RHércules"
}, {
    12091,
    "Personalizados > Proceso cambio tipo de cuenta"
}, {
    4405,
    "Personalizados > Proceso especial"
}, {
    7837,
    "Personalizados > Prorratero IVA - Superinter"
}, {
    3230,
    "Personalizados > Proteccion de cartera (COIMPRESORES)"
}, {
    3746,
    "Personalizados > Proyección de materiales (PRONAVICOLA)"
}, {
    11979,
    "Personalizados > Reabastecimiento de punto de ventas - StudioF"
}, {
    3476,
    "Personalizados > Recibos de caja (ALPES)"
}, {
    2984,
    "Personalizados > Recibos de caja cartera cheques (FENALCO)"
}, {
    6925,
    "Personalizados > Recalcular margen para obseq como descuentos-TROPI"
}, {
    8451,
    "Personalizados > Reconstruir saldos"
}, {
    9952,
    "Personalizados > Reconstruir saldos abiertos"
}, {
    8452,
    "Personalizados > Reconstruir saldos de caja"
}, {
    9953,
    "Personalizados > Reconstruir saldos diferidos"
}, {
    11261,
    "Personalizados > Recaudos empleados entre compañias"
}, {
    2448,
    "Personalizados > Relación de ingresos para afiliadas (ORO)"
}, {
    4557,
    "Personalizados > Reporte CDP - Invemar"
}, {
    4234,
    "Personalizados > Reporte de contratos - INVEMAR"
}, {
    11293,
    "Personalizados > Reporte de sabana - Stilotex"
}, {
    11138,
    "Personalizados > Reporte de unidades equivalentes - Resortes hércul"
}, {
    4077,
    "Personalizados > Reporte de consumos y producciones - Concetrados"
}, {
    7646,
    "Personalizados > Restricción de bodegas"
}, {
    3233,
    "Personalizados > Resumen de inventarios (Contegral)"
}, {
    3755,
    "Personalizados > Informe resumen de ordenes de produccion cumplidas"
}, {
    3232,
    "Personalizados > Resumen de ventas (Contegral)"
}, {
    11556,
    "Personalizados > Revisión de vehículos - MPI"
}, {
    4236,
    "Personalizados > Rotación ABC - La Balinera"
}, {
    12261,
    "Personalizados > Reporte acumulado libro diario vtas - Surtifruve"
}, {
    4821,
    "Personalizados > Reporte de análisis de costos motos - FANALCA"
}, {
    10179,
    "Personalizados > Reporte de cantidades al corte - Rocha"
}, {
    12260,
    "Personalizados > Reporte libro diario de ventas - Surtifuver"
}, {
    7610,
    "Personalizados > Reporte excel desde lista de materiales - Supertex"
}, {
    12381,
    "Personalizados > Reporte de máquinas facturadoras - Fanalca"
}, {
    4810,
    "Personalizados > Reporte de movimiento de OP con saldo"
}, {
    3933,
    "Personalizados > Consulta saldos de compras- ventas - Gulda"
}, {
    3690,
    "Personalizados > Simulacion colectiva - (BELLEZA EXPRESS)"
}, {
    3691,
    "Personalizados > Simulacion colectiva - (ROY ALPHA)"
}, {
    6369,
    "Personalizados > Simulación colectiva desde requisicion - Superpolo"
}, {
    2923,
    "Personalizados > Solicitud de compra valorada"
}, {
    2924,
    "Personalizados > Solicitud de compra valorada > Adicionar"
}, {
    2931,
    "Personalizados > Solicitud de compra valorada > Alterar precios"
}, {
    2925,
    "Personalizados > Solicitud de compra valorada > Anular"
}, {
    2926,
    "Personalizados > Solicitud de compra valorada > Aprobar"
}, {
    2927,
    "Personalizados > Solicitud de compra valorada > Consultar"
}, {
    3291,
    "Personalizados > Solicitud de compra valorada > Controlar bodega de asignacion"
}, {
    2928,
    "Personalizados > Solicitud de compra valorada > Dar por cumplido"
}, {
    2929,
    "Personalizados > Solicitud de compra valorada > Modificar"
}, {
    2930,
    "Personalizados > Solicitud de compra valorada > Obligar documento referencia"
}, {
    7807,
    "Personalizados > Solicitudes en SGD - Siesa"
}, {
    3935,
    "Personalizados > Consulta stock por proveedor - Gulda"
}, {
    7767,
    "Personalizados > Sugerido de compras -Superinter"
}, {
    11294,
    "Personalizados > Tanques - MPI"
}, {
    11295,
    "Personalizados > Tanques - MPI > Adicionar"
}, {
    11296,
    "Personalizados > Tanques - MPI > Consultar"
}, {
    11297,
    "Personalizados > Tanques - MPI > Duplicar"
}, {
    11298,
    "Personalizados > Tanques - MPI > Eliminar"
}, {
    11299,
    "Personalizados > Tanques - MPI > Modificar"
}, {
    11300,
    "Personalizados > Tanques - MPI > Reporte"
}, {
    6897,
    "Personalizados > Transferir pedidos - Contegral"
}, {
    3719,
    "Personalizados > Traslado de anticipos a CxP y utilidad (FANALCA)"
}, {
    4811,
    "Personalizados > Traslado de cuentas por pagar - factoring"
}, {
    3320,
    "Personalizados > Traslado de pasivo a capital (COIMPRESORES)"
}, {
    9942,
    "Personalizados > Trazabilidad de pedidos - Fragancias"
}, {
    3707,
    "Personalizados > Verificación de despachos - (BELLEZA EXPRESS)"
}, {
    4231,
    "Personalizados > Cambiar la bodega del pedido - Fanalca"
}, {
    12288,
    "Personalizados > Consulta resumen transacciones proyecto - Dsierr"
}, {
    10444,
    "Planeación gruesa"
}, {
    10445,
    "Planeación gruesa > Consultas"
}, {
    10447,
    "Planeación gruesa > Consultas > Confirmar/desconfirmar ordenes"
}, {
    10446,
    "Planeación gruesa > Consultas > Editar ordenes planeadas"
}, {
    10508,
    "Planeación gruesa > Consultas > Log de procesos"
}, {
    10509,
    "Planeación gruesa > Consultas > Log de procesos > Eliminar"
}, {
    10448,
    "Planeación gruesa > Consultas > Ordenes planeadas"
}, {
    10449,
    "Planeación gruesa > Monitor de planeación"
}, {
    10593,
    "Planeación gruesa > Monitor de planeación > Ordenes planeadas"
}, {
    10594,
    "Planeación gruesa > Monitor de planeación > Ordenes planeadas > Adicionar"
}, {
    10595,
    "Planeación gruesa > Monitor de planeación > Ordenes planeadas > Adicionar Múltiples"
}, {
    10599,
    "Planeación gruesa > Monitor de planeación > Ordenes planeadas > Permitir cambiar la cantidad"
}, {
    10600,
    "Planeación gruesa > Monitor de planeación > Ordenes planeadas > Permitir cambiar las fechas"
}, {
    10601,
    "Planeación gruesa > Monitor de planeación > Ordenes planeadas > Permitir cambiar tipo"
}, {
    10596,
    "Planeación gruesa > Monitor de planeación > Ordenes planeadas > Consultar"
}, {
    10597,
    "Planeación gruesa > Monitor de planeación > Ordenes planeadas > Eliminar"
}, {
    10598,
    "Planeación gruesa > Monitor de planeación > Ordenes planeadas > Modificar"
}, {
    10450,
    "Planeación gruesa > MPS Generación"
}, {
    10451,
    "Planeación gruesa > MPS Generación > Validar lista de materiales"
}, {
    10452,
    "Planeación gruesa > MRP Generación"
}, {
    12158,
    "Comercial - Control de proyectos"
}, {
    12248,
    "Comercial - Control de proyectos > Administración de proyectos"
}, {
    12533,
    "Comercial - Control de proyectos > Avances de actividades"
}, {
    12541,
    "Comercial - Control de proyectos > Avances de actividades > Cantidades facturadas"
}, {
    12542,
    "Comercial - Control de proyectos > Avances de actividades > Cantidades facturadas > Adicionar"
}, {
    12543,
    "Comercial - Control de proyectos > Avances de actividades > Cantidades facturadas > Anular"
}, {
    12544,
    "Comercial - Control de proyectos > Avances de actividades > Cantidades facturadas > Aprobar"
}, {
    12545,
    "Comercial - Control de proyectos > Avances de actividades > Cantidades facturadas > Consultar"
}, {
    12547,
    "Comercial - Control de proyectos > Avances de actividades > Cantidades facturadas > Eliminar"
}, {
    12546,
    "Comercial - Control de proyectos > Avances de actividades > Cantidades facturadas > Modificar"
}, {
    12534,
    "Comercial - Control de proyectos > Avances de actividades > Cantidades terminadas"
}, {
    12535,
    "Comercial - Control de proyectos > Avances de actividades > Cantidades terminadas > Adicionar"
}, {
    12536,
    "Comercial - Control de proyectos > Avances de actividades > Cantidades terminadas > Anular"
}, {
    12537,
    "Comercial - Control de proyectos > Avances de actividades > Cantidades terminadas > Aprobar"
}, {
    12538,
    "Comercial - Control de proyectos > Avances de actividades > Cantidades terminadas > Consultar"
}, {
    12540,
    "Comercial - Control de proyectos > Avances de actividades > Cantidades terminadas > Eliminar"
}, {
    12539,
    "Comercial - Control de proyectos > Avances de actividades > Cantidades terminadas > Modificar"
}, {
    12548,
    "Comercial - Control de proyectos > Saldos iniciales"
}, {
    12549,
    "Comercial - Control de proyectos > Saldos iniciales > Actividades"
}, {
    12551,
    "Comercial - Control de proyectos > Saldos iniciales > Actividades > Adicionar"
}, {
    12552,
    "Comercial - Control de proyectos > Saldos iniciales > Actividades > Anular"
}, {
    12553,
    "Comercial - Control de proyectos > Saldos iniciales > Actividades > Aprobar"
}, {
    12554,
    "Comercial - Control de proyectos > Saldos iniciales > Actividades > Consultar"
}, {
    12556,
    "Comercial - Control de proyectos > Saldos iniciales > Actividades > Eliminar"
}, {
    12555,
    "Comercial - Control de proyectos > Saldos iniciales > Actividades > Modificar"
}, {
    12550,
    "Comercial - Control de proyectos > Saldos iniciales > Recursos"
}, {
    12557,
    "Comercial - Control de proyectos > Saldos iniciales > Recursos > Adicionar"
}, {
    12558,
    "Comercial - Control de proyectos > Saldos iniciales > Recursos > Anular"
}, {
    12559,
    "Comercial - Control de proyectos > Saldos iniciales > Recursos > Aprobar"
}, {
    12560,
    "Comercial - Control de proyectos > Saldos iniciales > Recursos > Consultar"
}, {
    12562,
    "Comercial - Control de proyectos > Saldos iniciales > Recursos > Eliminar"
}, {
    12561,
    "Comercial - Control de proyectos > Saldos iniciales > Recursos > Modificar"
}, {
    12167,
    "Comercial - Control de proyectos > Clases de proyecto"
}, {
    12168,
    "Comercial - Control de proyectos > Clases de proyecto > Adicionar"
}, {
    12169,
    "Comercial - Control de proyectos > Clases de proyecto > Consultar"
}, {
    12170,
    "Comercial - Control de proyectos > Clases de proyecto > Duplicar"
}, {
    12171,
    "Comercial - Control de proyectos > Clases de proyecto > Eliminar"
}, {
    12172,
    "Comercial - Control de proyectos > Clases de proyecto > Modificar"
}, {
    12173,
    "Comercial - Control de proyectos > Clases de proyecto > Reporte"
}, {
    12159,
    "Comercial - Control de proyectos > Consultas"
}, {
    12737,
    "Comercial - Control de proyectos > Consultas > Control de costos"
}, {
    12256,
    "Comercial - Control de proyectos > Consultas > Presupuesto"
}, {
    12161,
    "-No implementado > Etapas"
}, {
    12160,
    "Comercial - Control de proyectos > Consultas > Proyecto"
}, {
    12162,
    "-No implementado > Recursos"
}, {
    12309,
    "Comercial - Control de proyectos > Estructura de proyectos"
}, {
    12310,
    "Comercial - Control de proyectos > Estructura de proyectos > Adicionar"
}, {
    12311,
    "Comercial - Control de proyectos > Estructura de proyectos > Consultar"
}, {
    12312,
    "Comercial - Control de proyectos > Estructura de proyectos > Duplicar"
}, {
    12313,
    "Comercial - Control de proyectos > Estructura de proyectos > Eliminar"
}, {
    12314,
    "Comercial - Control de proyectos > Estructura de proyectos > Modificar"
}, {
    12315,
    "Comercial - Control de proyectos > Estructura de proyectos > Reporte"
}, {
    12163,
    "Comercial - Control de proyectos > Etapas"
}, {
    12164,
    "Comercial - Control de proyectos > Etapas > Apropiación"
}, {
    12247,
    "Comercial - Control de proyectos > Gestión de cambios"
}, {
    12432,
    "Comercial - Control de proyectos > Gestión de cambios > Anular"
}, {
    12431,
    "Comercial - Control de proyectos > Gestión de cambios > Aprobar"
}, {
    12436,
    "Comercial - Control de proyectos > Gestión de cambios > Centros de operación"
}, {
    12442,
    "Comercial - Control de proyectos > Gestión de cambios > Centros de operación > Adicionar"
}, {
    12433,
    "Comercial - Control de proyectos > Gestión de cambios > Consultar"
}, {
    12434,
    "Comercial - Control de proyectos > Gestión de cambios > Etapas"
}, {
    12438,
    "Comercial - Control de proyectos > Gestión de cambios > Etapas > Adicionar"
}, {
    12439,
    "Comercial - Control de proyectos > Gestión de cambios > Etapas > Modificar"
}, {
    12435,
    "Comercial - Control de proyectos > Gestión de cambios > Recursos"
}, {
    12440,
    "Comercial - Control de proyectos > Gestión de cambios > Recursos > Adicionar"
}, {
    12441,
    "Comercial - Control de proyectos > Gestión de cambios > Recursos > Modificar"
}, {
    12483,
    "Comercial - Control de proyectos > Gestión de cambios > Recursos > Permitir modificar valor unitario"
}, {
    12437,
    "Comercial - Control de proyectos > Gestión de cambios > Responsables"
}, {
    12443,
    "Comercial - Control de proyectos > Gestión de cambios > Responsables > Adicionar"
}, {
    12444,
    "Comercial - Control de proyectos > Gestión de cambios > Responsables > Modificar"
}, {
    12249,
    "Comercial - Control de proyectos > Gestión de proyectos"
}, {
    12250,
    "Comercial - Control de proyectos > Gestión de proyectos > Adicionar"
}, {
    12430,
    "Comercial - Control de proyectos > Gestión de proyectos > Anular"
}, {
    12429,
    "Comercial - Control de proyectos > Gestión de proyectos > Apropiar"
}, {
    12515,
    "Comercial - Control de proyectos > Gestión de proyectos > Confirmar"
}, {
    12251,
    "Comercial - Control de proyectos > Gestión de proyectos > Consultar"
}, {
    12252,
    "Comercial - Control de proyectos > Gestión de proyectos > Duplicar"
}, {
    12253,
    "Comercial - Control de proyectos > Gestión de proyectos > Eliminar"
}, {
    12254,
    "Comercial - Control de proyectos > Gestión de proyectos > Modificar"
}, {
    12255,
    "Comercial - Control de proyectos > Gestión de proyectos > Reporte"
}, {
    12266,
    "Comercial - Control de proyectos > Gestión de proyectos > Etapas"
}, {
    12267,
    "Comercial - Control de proyectos > Gestión de proyectos > Etapas > Adicionar"
}, {
    12268,
    "Comercial - Control de proyectos > Gestión de proyectos > Etapas > Consultar"
}, {
    12269,
    "Comercial - Control de proyectos > Gestión de proyectos > Etapas > Duplicar"
}, {
    12270,
    "Comercial - Control de proyectos > Gestión de proyectos > Etapas > Eliminar"
}, {
    12271,
    "Comercial - Control de proyectos > Gestión de proyectos > Etapas > Modificar"
}, {
    12272,
    "Comercial - Control de proyectos > Gestión de proyectos > Recursos"
}, {
    12273,
    "Comercial - Control de proyectos > Gestión de proyectos > Recursos > Adicionar"
}, {
    12274,
    "Comercial - Control de proyectos > Gestión de proyectos > Recursos > Consultar"
}, {
    12275,
    "Comercial - Control de proyectos > Gestión de proyectos > Recursos > Duplicar"
}, {
    12276,
    "Comercial - Control de proyectos > Gestión de proyectos > Recursos > Eliminar"
}, {
    12277,
    "Comercial - Control de proyectos > Gestión de proyectos > Recursos > Modificar"
}, {
    12454,
    "-No implementado > Gestión de solicitudes"
}, {
    12455,
    "-No implementado > Gestión de solicitudes > Consultar"
}, {
    12456,
    "-No implementado > Gestión de solicitudes > Modificar"
}, {
    12528,
    "Comercial - Control de proyectos > Habilitar impresión de documentos"
}, {
    12530,
    "Comercial - Control de proyectos > Habilitar impresión de documentos > Avance de cant. facturadas"
}, {
    12529,
    "Comercial - Control de proyectos > Habilitar impresión de documentos > Avance de cant. terminadas"
}, {
    12531,
    "Comercial - Control de proyectos > Habilitar impresión de documentos > Saldos iniciales actividades"
}, {
    12532,
    "Comercial - Control de proyectos > Habilitar impresión de documentos > Saldos iniciales de recursos"
}, {
    12451,
    "Comercial - Control de proyectos > Imprimir documentos"
}, {
    12452,
    "Comercial - Control de proyectos > Imprimir documentos > Apropiación"
}, {
    12525,
    "Comercial - Control de proyectos > Imprimir documentos > Avance de cant. facturadas"
}, {
    12524,
    "Comercial - Control de proyectos > Imprimir documentos > Avance de cant. terminadas"
}, {
    12453,
    "Comercial - Control de proyectos > Imprimir documentos > Gestión de cambios"
}, {
    12526,
    "Comercial - Control de proyectos > Imprimir documentos > Saldos iniciales actividades"
}, {
    12527,
    "Comercial - Control de proyectos > Imprimir documentos > Saldos iniciales de recursos"
}, {
    12196,
    "-No implementado > Proyectos"
}, {
    12165,
    "Comercial - Control de proyectos > Recursos"
}, {
    12166,
    "Comercial - Control de proyectos > Recursos > Apropiación"
}, {
    12174,
    "Comercial - Control de proyectos > Roles"
}, {
    12175,
    "Comercial - Control de proyectos > Roles > Adicionar"
}, {
    12176,
    "Comercial - Control de proyectos > Roles > Consultar"
}, {
    12177,
    "Comercial - Control de proyectos > Roles > Duplicar"
}, {
    12178,
    "Comercial - Control de proyectos > Roles > Eliminar"
}, {
    12179,
    "Comercial - Control de proyectos > Roles > Modificar"
}, {
    12180,
    "Comercial - Control de proyectos > Roles > Reporte"
}, {
    12222,
    "Comercial - Control de proyectos > Tipos de recurso"
}, {
    12223,
    "Comercial - Control de proyectos > Tipos de recurso > Adicionar"
}, {
    12224,
    "Comercial - Control de proyectos > Tipos de recurso > Consultar"
}, {
    12225,
    "Comercial - Control de proyectos > Tipos de recurso > Duplicar"
}, {
    12226,
    "Comercial - Control de proyectos > Tipos de recurso > Eliminar"
}, {
    12227,
    "Comercial - Control de proyectos > Tipos de recurso > Modificar"
}, {
    12228,
    "Comercial - Control de proyectos > Tipos de recurso > Reporte"
}, {
    306,
    "Financiero - Cuentas por pagar"
}, {
    3443,
    "Financiero - Cuentas por pagar > Acumulados"
}, {
    3444,
    "Financiero - Cuentas por pagar > Acumulados > Cubo de CxP"
}, {
    927,
    "Financiero - Cuentas por pagar > Control bancos > Entrega de cheques"
}, {
    930,
    "Financiero - Cuentas por pagar > Control bancos > Entrega de cheques > Aplicar"
}, {
    929,
    "Financiero - Cuentas por pagar > Control bancos > Entrega de cheques > Reporte"
}, {
    1573,
    "Financiero - Cuentas por pagar > Control bancos > Relación de cheques"
}, {
    928,
    "Financiero - Cuentas por pagar > Control bancos > Reversar entrega cheque"
}, {
    924,
    "Financiero - Cuentas por pagar > Control bancos > Saldo real"
}, {
    925,
    "Financiero - Cuentas por pagar > Control bancos > Saldo real > Modificar"
}, {
    926,
    "Financiero - Cuentas por pagar > Control bancos > Saldo real > Reporte"
}, {
    923,
    "Financiero - Cuentas por pagar > Control bancos"
}, {
    498,
    "Financiero - Cuentas por pagar > Comprobante de egreso"
}, {
    514,
    "Financiero - Cuentas por pagar > Comprobante de egreso > Adicionar"
}, {
    519,
    "Financiero - Cuentas por pagar > Comprobante de egreso > Anular"
}, {
    518,
    "Financiero - Cuentas por pagar > Comprobante de egreso > Aprobar"
}, {
    7556,
    "Financiero - Cuentas por pagar > Comprobante de egreso > Capturar múltiples libros"
}, {
    513,
    "Financiero - Cuentas por pagar > Comprobante de egreso > Consultar"
}, {
    517,
    "Financiero - Cuentas por pagar > Comprobante de egreso > Eliminar"
}, {
    521,
    "Financiero - Cuentas por pagar > Comprobante de egreso > Habilitar impresión de pagos en cheque"
}, {
    2390,
    "Financiero - Cuentas por pagar > Comprobante de egreso > Habilitar impresión de pagos en efectivo"
}, {
    520,
    "Financiero - Cuentas por pagar > Comprobante de egreso > Imprimir pagos en cheque"
}, {
    2383,
    "Financiero - Cuentas por pagar > Comprobante de egreso > Imprimir pagos en efecfivo"
}, {
    515,
    "Financiero - Cuentas por pagar > Comprobante de egreso > Modificar"
}, {
    10935,
    "Financiero - Cuentas por pagar > Comprobante de egreso > Modificar Beneficiario"
}, {
    6426,
    "Financiero - Cuentas por pagar > Comprobante de egreso > Modificar entidades dinámicas en doctos aprobados"
}, {
    6424,
    "Financiero - Cuentas por pagar > Comprobante de egreso > Modificar entidades dinámicas docto en elaboración"
}, {
    6595,
    "Financiero - Cuentas por pagar > Comprobante de egreso > Modificar fecha de cheque"
}, {
    516,
    "Financiero - Cuentas por pagar > Comprobante de egreso > Refrescar"
}, {
    10184,
    "Financiero - Cuentas por pagar > Consultas > Programaciones pagadas/anuladas"
}, {
    2471,
    "Financiero - Cuentas por pagar > Consultas > Resumen de saldos de proveedores"
}, {
    3192,
    "Financiero - Cuentas por pagar > Consultas > Seguimiento de documentos"
}, {
    499,
    "Financiero - Cuentas por pagar > Consultas"
}, {
    10208,
    "Financiero - Cuentas por pagar > Consultas > Ordenes de pago"
}, {
    2164,
    "Financiero - Compra de servicios > Consultas > Contratos"
}, {
    522,
    "Financiero - Cuentas por pagar > Consultas > Estado de cuenta"
}, {
    1970,
    "Financiero - Compra de servicios > Consultas > Facturas y notas"
}, {
    10827,
    "Financiero - Compra de servicios > Consultas > Facturas y notas > Modificar notas"
}, {
    1971,
    "Financiero - Compra de servicios > Consultas > Facturas y notas por servicio"
}, {
    555,
    "Financiero - Cuentas por pagar > Consultas > Movimiento de proveedor"
}, {
    1343,
    "Financiero - Compra de servicios > Consultas > Ordenes de compra"
}, {
    1968,
    "Financiero - Compra de servicios > Consultas > Ordenes de compra por servicio"
}, {
    1342,
    "Financiero - Compra de servicios > Consultas > Registros fijos"
}, {
    1969,
    "Financiero - Compra de servicios > Consultas > Registros fijos por servicios"
}, {
    2498,
    "Financiero - Cuentas por pagar > Consultas > Relación de comprobantes de pago vs. facturas"
}, {
    1786,
    "Financiero - Cuentas por pagar > Consultas > Relación de comprobantes de pago"
}, {
    6360,
    "Financiero - Cuentas por pagar > Consultas > Saldos abiertos por número"
}, {
    2113,
    "Financiero - Compra de servicios > Contratos"
}, {
    2116,
    "Financiero - Compra de servicios > Contratos > Cancelar"
}, {
    2117,
    "Financiero - Compra de servicios > Contratos > Cancelar > Adicionar"
}, {
    2119,
    "Financiero - Compra de servicios > Contratos > Cancelar > Anular"
}, {
    2120,
    "Financiero - Compra de servicios > Contratos > Cancelar > Aprobar"
}, {
    2123,
    "Financiero - Compra de servicios > Contratos > Cancelar > Consultar"
}, {
    2121,
    "Financiero - Compra de servicios > Contratos > Cancelar > Habilitar impresión"
}, {
    2122,
    "Financiero - Compra de servicios > Contratos > Cancelar > Imprimir"
}, {
    2118,
    "Financiero - Compra de servicios > Contratos > Cancelar > Modificar"
}, {
    2114,
    "Financiero - Compra de servicios > Contratos > Crear"
}, {
    2124,
    "Financiero - Compra de servicios > Contratos > Crear > Adicionar"
}, {
    2125,
    "Financiero - Compra de servicios > Contratos > Crear > Anular"
}, {
    2126,
    "Financiero - Compra de servicios > Contratos > Crear > Aprobar"
}, {
    2146,
    "Financiero - Compra de servicios > Contratos > Crear > Cancelar"
}, {
    2127,
    "Financiero - Compra de servicios > Contratos > Crear > Consultar"
}, {
    2128,
    "Financiero - Compra de servicios > Habilitar impresión documentos > Habilitar impresión contratos"
}, {
    2129,
    "Financiero - Compra de servicios > Imprimir documentos > Imprimir contratos"
}, {
    2130,
    "Financiero - Compra de servicios > Contratos > Crear > Modificar"
}, {
    2465,
    "Financiero - Compra de servicios > Contratos > Modificar cuotas"
}, {
    2115,
    "Financiero - Compra de servicios > Contratos > Renovar"
}, {
    2131,
    "Financiero - Compra de servicios > Contratos > Renovar > Adicionar"
}, {
    2132,
    "Financiero - Compra de servicios > Contratos > Renovar > Anular"
}, {
    2133,
    "Financiero - Compra de servicios > Contratos > Renovar > Aprobar"
}, {
    2147,
    "Financiero - Compra de servicios > Contratos > Renovar > Cancelar"
}, {
    2134,
    "Financiero - Compra de servicios > Contratos > Renovar > Consultar"
}, {
    2137,
    "Financiero - Compra de servicios > Contratos > Renovar > Modificar"
}, {
    10014,
    "Financiero - Compra de servicios > Contratos > Crear > Modificar entidades dinámicas docto anulados"
}, {
    10013,
    "Financiero - Compra de servicios > Contratos > Crear > Modificar entidades dinámicas docto aprobados"
}, {
    3131,
    "Financiero - Cuentas por pagar > Documento de reversión de pagos"
}, {
    11032,
    "Financiero - Cuentas por pagar > Documento de reversión de pagos > Permitir reversión de comprobantes de egreso"
}, {
    11033,
    "Financiero - Cuentas por pagar > Documento de reversión de pagos > Permitir revesión de pagos electrónicos"
}, {
    2138,
    "Financiero - Compra de servicios > Facturar contrato"
}, {
    2139,
    "Financiero - Compra de servicios > Facturar contrato > Adicionar"
}, {
    2140,
    "Financiero - Compra de servicios > Facturar contrato > Anular"
}, {
    2141,
    "Financiero - Compra de servicios > Facturar contrato > Aprobar"
}, {
    11323,
    "Financiero - Compra de servicios > Facturar contrato > Permitir cambiar tipo de proveedor"
}, {
    7852,
    "Financiero - Compra de servicios > Facturar contrato > Permitir cambiar condición de pago"
}, {
    8007,
    "Financiero - Compra de servicios > Facturar contrato > Permitir cambiar pronto pago"
}, {
    2142,
    "Financiero - Compra de servicios > Facturar contrato > Consultar"
}, {
    2143,
    "Financiero - Compra de servicios > Facturar contrato > Habilitar impresión"
}, {
    2144,
    "Financiero - Compra de servicios > Facturar contrato > Imprimir"
}, {
    2145,
    "Financiero - Compra de servicios > Facturar contrato > Modificar"
}, {
    4085,
    "Financiero - Compra de servicios > Facturar contrato > Modificar entidades dinámicas en doctos aprobados"
}, {
    7975,
    "Financiero - Compra de servicios > Facturar contrato > Permitir sobrepasar monto anual por proveedor"
}, {
    7614,
    "Financiero - Compra de servicios > Facturar contrato > Validar documento proveedor por tercero"
}, {
    1012,
    "Financiero - Compra de servicios > Facturación"
}, {
    1014,
    "Financiero - Compra de servicios > Facturación > Adicionar"
}, {
    8469,
    "Financiero - Compra de servicios > Facturación > Permitir cruzar anticipos múltiples libros"
}, {
    4370,
    "Financiero - Compra de servicios > Facturación > Permitir anticipos de otra auxiliar de anticipos"
}, {
    3119,
    "Financiero - Compra de servicios > Facturación > Permitir anticipos de otra U.N."
}, {
    3118,
    "Financiero - Compra de servicios > Facturación > Permitir anticipos de otro C.O."
}, {
    2935,
    "Financiero - Compra de servicios > Facturación > Permitir anticipos de otro proveedor"
}, {
    1017,
    "Financiero - Compra de servicios > Facturación > Anular"
}, {
    1016,
    "Financiero - Compra de servicios > Facturación > Aprobar"
}, {
    7851,
    "Financiero - Compra de servicios > Facturación > Permitir cambiar condición de pago"
}, {
    10888,
    "Financiero - Compra de servicios > Facturación > Permitir cambiar instrumento financiero sugerido"
}, {
    7998,
    "Financiero - Compra de servicios > Facturación > Permitir cambiar pronto pago"
}, {
    9701,
    "Financiero - Compra de servicios > Facturación > Permitir capturar instrumento financiero"
}, {
    2594,
    "Financiero - Compra de servicios > Facturación > Permite causar facturas de mas de 180 dias"
}, {
    1019,
    "Financiero - Compra de servicios > Facturación > Consultar"
}, {
    2577,
    "Financiero - Compra de servicios > Facturación > Permitir contabilizar por C.O."
}, {
    9514,
    "Financiero - Compra de servicios > Facturación > Permitir cruzar CxC"
}, {
    10839,
    "Financiero - Compra de servicios > Facturación > Permitir cruzar CxP"
}, {
    1085,
    "Financiero - Compra de servicios > Habilitar impresión documentos > Habilitar impresión factura"
}, {
    1018,
    "Financiero - Compra de servicios > Imprimir documentos > Imprimir factura"
}, {
    1015,
    "Financiero - Compra de servicios > Facturación > Modificar"
}, {
    11246,
    "Financiero - Compra de servicios > Facturación > Permitir modificar documento cruce en servicios"
}, {
    4082,
    "Financiero - Compra de servicios > Facturación > Modificar entidades dinámicas en doctos aprobados"
}, {
    2819,
    "Financiero - Compra de servicios > Facturación > No chequear valor del documento"
}, {
    3730,
    "Financiero - Compra de servicios > Facturación > Permitir mandatos de diferente C.O."
}, {
    7974,
    "Financiero - Compra de servicios > Facturación > Permitir sobrepasar monto anual por proveedor"
}, {
    7612,
    "Financiero - Compra de servicios > Facturación > Validar documento proveedor por tercero"
}, {
    2486,
    "Financiero - Cuentas por pagar > Generales"
}, {
    4726,
    "Financiero - Cuentas por pagar > Generales > Permitir fecha vcto menor que fecha docto"
}, {
    2487,
    "Financiero - Cuentas por pagar > Generales > Permite alterar saldos de creación"
}, {
    2489,
    "Financiero - Cuentas por pagar > Generales > Permite aplicar un valor mayor que el saldo"
}, {
    2488,
    "Financiero - Cuentas por pagar > Generales > Permite creditar saldos abiertos cancelados"
}, {
    2573,
    "Financiero - Cuentas por pagar > Generales > Permite debitar saldos abiertos cancelados"
}, {
    3307,
    "Financiero - Cuentas por pagar > Generales > Permite crear saldos de nat. contraria al auxiliar"
}, {
    3419,
    "Financiero - Compra de servicios > Facturar legalización de gastos"
}, {
    3420,
    "Financiero - Compra de servicios > Facturar legalización de gastos > Adicionar"
}, {
    8471,
    "Financiero - Compra de servicios > Facturar legalización de gastos > Permitir cruzar anticipos múltiples libros"
}, {
    4371,
    "Financiero - Compra de servicios > Facturar legalización de gastos > Permitir anticipos de otra auxiliar de anticipos"
}, {
    3427,
    "Financiero - Compra de servicios > Facturar legalización de gastos > Permitir anticipos de otra U.N."
}, {
    3428,
    "Financiero - Compra de servicios > Facturar legalización de gastos > Permitir anticipos de otro C.O."
}, {
    3429,
    "Financiero - Compra de servicios > Facturar legalización de gastos > Permitir anticipos de otro proveedor"
}, {
    3421,
    "Financiero - Compra de servicios > Facturar legalización de gastos > Anular"
}, {
    3422,
    "Financiero - Compra de servicios > Facturar legalización de gastos > Aprobar"
}, {
    7853,
    "Financiero - Compra de servicios > Facturar legalización de gastos > Permitir cambiar condición de pago"
}, {
    10889,
    "Financiero - Compra de servicios > Facturar legalización de gastos > Permitir cambiar instrumento financiero sugerido"
}, {
    8003,
    "Financiero - Compra de servicios > Facturar legalización de gastos > Permitir cambiar pronto pago"
}, {
    9702,
    "Financiero - Compra de servicios > Facturar legalización de gastos > Permitir capturar instrumento financiero"
}, {
    3426,
    "Financiero - Compra de servicios > Facturar legalización de gastos > Permite causar facturas de mas de 180 dias"
}, {
    3423,
    "Financiero - Compra de servicios > Facturar legalización de gastos > Consultar"
}, {
    3430,
    "Financiero - Compra de servicios > Facturar legalización de gastos > Permitir contabilizar por C.O."
}, {
    3424,
    "Financiero - Compra de servicios > Facturar legalización de gastos > Modificar"
}, {
    4083,
    "Financiero - Compra de servicios > Facturar legalización de gastos > Modificar entidades dinámicas en doctos aprobados"
}, {
    3425,
    "Financiero - Compra de servicios > Facturar legalización de gastos > No chequear valor del documento"
}, {
    7615,
    "Financiero - Compra de servicios > Facturar legalización de gastos > Validar documento proveedor por tercero"
}, {
    7242,
    "Financiero - Cuentas por pagar > Letras"
}, {
    7314,
    "Financiero - Cuentas por pagar > Letras > Anulación de letras"
}, {
    7315,
    "Financiero - Cuentas por pagar > Letras > Asignación números de letras"
}, {
    7316,
    "Financiero - Cuentas por pagar > Letras > Consultas"
}, {
    7317,
    "Financiero - Cuentas por pagar > Letras > Consultas > Letras"
}, {
    7318,
    "Financiero - Cuentas por pagar > Letras > Consultas > Planilla de traslado"
}, {
    7319,
    "Financiero - Cuentas por pagar > Letras > Generación de letras"
}, {
    7320,
    "Financiero - Cuentas por pagar > Letras > Generación de letras > Generar"
}, {
    7322,
    "Financiero - Cuentas por pagar > Letras > Generación de letras > Modificar fecha de vencimiento"
}, {
    7323,
    "Financiero - Cuentas por pagar > Letras > Generación de letras > Modificar valor"
}, {
    7321,
    "Financiero - Cuentas por pagar > Letras > Generación de letras > Generar multiples letras"
}, {
    7324,
    "Financiero - Cuentas por pagar > Letras > Generación de letras > Unificar saldos abiertos"
}, {
    7325,
    "Financiero - Cuentas por pagar > Letras > Habilitar impresión de documentos"
}, {
    7326,
    "Financiero - Cuentas por pagar > Letras > Habilitar impresión de documentos > Letras"
}, {
    7327,
    "Financiero - Cuentas por pagar > Letras > Habilitar impresión de documentos > Planillas de traslado"
}, {
    7328,
    "Financiero - Cuentas por pagar > Letras > Imprimir documentos"
}, {
    7329,
    "Financiero - Cuentas por pagar > Letras > Imprimir documentos > Letras"
}, {
    7330,
    "Financiero - Cuentas por pagar > Letras > Imprimir documentos > Planillas de traslados"
}, {
    7243,
    "Financiero - Cuentas por pagar > Letras > Maestros"
}, {
    7244,
    "Financiero - Cuentas por pagar > Letras > Maestros > Ubicaciones"
}, {
    7245,
    "Financiero - Cuentas por pagar > Letras > Maestros > Ubicaciones > Adicionar"
}, {
    7246,
    "Financiero - Cuentas por pagar > Letras > Maestros > Ubicaciones > Consultar"
}, {
    7247,
    "Financiero - Cuentas por pagar > Letras > Maestros > Ubicaciones > Duplicar"
}, {
    7248,
    "Financiero - Cuentas por pagar > Letras > Maestros > Ubicaciones > Eliminar"
}, {
    7249,
    "Financiero - Cuentas por pagar > Letras > Maestros > Ubicaciones > Modificar"
}, {
    7250,
    "Financiero - Cuentas por pagar > Letras > Maestros > Ubicaciones > Reporte"
}, {
    7331,
    "Financiero - Cuentas por pagar > Letras > Planillas de traslados"
}, {
    7332,
    "Financiero - Cuentas por pagar > Letras > Planillas de traslados > Adicionar"
}, {
    7333,
    "Financiero - Cuentas por pagar > Letras > Planillas de traslados > Anular"
}, {
    7334,
    "Financiero - Cuentas por pagar > Letras > Planillas de traslados > Aprobar"
}, {
    7335,
    "Financiero - Cuentas por pagar > Letras > Planillas de traslados > Consultar"
}, {
    7336,
    "Financiero - Cuentas por pagar > Letras > Planillas de traslados > Imprimir"
}, {
    7337,
    "Financiero - Cuentas por pagar > Letras > Planillas de traslados > Modificar"
}, {
    2657,
    "Financiero - Cuentas por pagar > Notas"
}, {
    8571,
    "Financiero - Cuentas por pagar > Notas > Conciliación cheques efectivamente pagados"
}, {
    2658,
    "Financiero - Cuentas por pagar > Notas > Reclasificación de cuentas por pagar"
}, {
    2659,
    "Financiero - Cuentas por pagar > Notas > Reclasificación de cuentas por pagar > Anular"
}, {
    2660,
    "Financiero - Cuentas por pagar > Notas > Reclasificación de cuentas por pagar > Aprobar"
}, {
    4728,
    "Financiero - Cuentas por pagar > Notas > Reclasificación de cuentas por pagar > Permitir cambiar tercero contrapartida"
}, {
    2661,
    "Financiero - Cuentas por pagar > Notas > Reclasificación de cuentas por pagar > Consultar"
}, {
    2662,
    "Financiero - Cuentas por pagar > Notas > Reclasificación de cuentas por pagar > Cruzar con cuentas por cobrar"
}, {
    2663,
    "Financiero - Cuentas por pagar > Notas > Reclasificación de cuentas por pagar > Cruzar con cuentas por pagar"
}, {
    9946,
    "Financiero - Cuentas por pagar > Notas > Reclasificación de cuentas por pagar > Permitir cruzar múltiples clientes o proveedores"
}, {
    2664,
    "Financiero - Cuentas por pagar > Notas > Reclasificación de cuentas por pagar > Habilitar impresión"
}, {
    2666,
    "Financiero - Cuentas por pagar > Notas > Reclasificación de cuentas por pagar > Imprimir"
}, {
    2665,
    "Financiero - Cuentas por pagar > Notas > Reclasificación de cuentas por pagar > Reversar"
}, {
    6512,
    "Financiero - Cuentas por pagar > Notas > Reclasificación de cuentas por pagar > Modificar entidades dinámicas en doctos aprobados"
}, {
    6511,
    "Financiero - Cuentas por pagar > Notas > Reclasificación de cuentas por pagar > Modificar entidades dinámicas docto en elaboración"
}, {
    6889,
    "Financiero - Cuentas por pagar > Notas > Traslado de cuentas por pagar"
}, {
    6890,
    "Financiero - Cuentas por pagar > Notas > Traslado de cuentas por pagar > Generar"
}, {
    1069,
    "Financiero - Compra de servicios > Nota débito"
}, {
    1070,
    "Financiero - Compra de servicios > Nota débito > Adicionar"
}, {
    1071,
    "Financiero - Compra de servicios > Nota débito > Anular"
}, {
    1072,
    "Financiero - Compra de servicios > Nota débito > Aprobar"
}, {
    7854,
    "Financiero - Compra de servicios > Nota débito > Permitir cambiar condición de pago"
}, {
    8268,
    "Financiero - Compra de servicios > Nota débito > Permitir cambiar pronto pago"
}, {
    1073,
    "Financiero - Compra de servicios > Nota débito > Consultar"
}, {
    2579,
    "Financiero - Compra de servicios > Nota débito > Permitir contabilizar por C.O."
}, {
    3760,
    "Financiero - Compra de servicios > Nota débito > Permitir cruzar facturas de diferente C.O."
}, {
    8470,
    "Financiero - Compra de servicios > Nota débito > Permitir cruzar facturas múltiples libros"
}, {
    1074,
    "Financiero - Compra de servicios > Habilitar impresión documentos > Habilitar impresión nota"
}, {
    1075,
    "Financiero - Compra de servicios > Imprimir documentos > Imprimir nota"
}, {
    1076,
    "Financiero - Compra de servicios > Nota débito > Modificar"
}, {
    11247,
    "Financiero - Compra de servicios > Nota débito > Permitir modificar documento cruce en servicios"
}, {
    4084,
    "Financiero - Compra de servicios > Nota débito > Modificar entidades dinámicas en doctos aprobados"
}, {
    3939,
    "Financiero - Compra de servicios > Nota débito > No chequear valor del documento"
}, {
    3731,
    "Financiero - Compra de servicios > Nota débito > Permitir mandatos de diferente C.O."
}, {
    7616,
    "Financiero - Compra de servicios > Nota débito > Validar documento proveedor por tercero"
}, {
    4801,
    "Financiero - Compra de servicios > Ordenes de compra > Modificar entidades dinámicas en doctos aprobados"
}, {
    1087,
    "Financiero - Compra de servicios > Ordenes de compra"
}, {
    1117,
    "Financiero - Compra de servicios > Ordenes de compra > Adicionar"
}, {
    7855,
    "-No implementado > Alterar condición de pago"
}, {
    1120,
    "Financiero - Compra de servicios > Ordenes de compra > Anular"
}, {
    1119,
    "Financiero - Compra de servicios > Ordenes de compra > Aprobar"
}, {
    4213,
    "Financiero - Compra de servicios > Ordenes de compra > Permitir cambiar condicion de pago"
}, {
    1122,
    "Financiero - Compra de servicios > Ordenes de compra > Confirmar"
}, {
    1116,
    "Financiero - Compra de servicios > Ordenes de compra > Consultar"
}, {
    6525,
    "Financiero - Compra de servicios > Ordenes de compra > Desaprobar"
}, {
    1123,
    "Financiero - Compra de servicios > Ordenes de compra > Facturar"
}, {
    1321,
    "Financiero - Compra de servicios > Habilitar impresión documentos > Habilitar impresión orden"
}, {
    1124,
    "Financiero - Compra de servicios > Imprimir documentos > Imprimir orden"
}, {
    1118,
    "Financiero - Compra de servicios > Ordenes de compra > Modificar"
}, {
    11197,
    "Financiero - Compra de servicios > Ordenes de compra > No obligar solicitante"
}, {
    3544,
    "Financiero - Compra de servicios > Ordenes de compra > No validar monto de aprobación"
}, {
    4212,
    "Financiero - Compra de servicios > Ordenes de compra > No validar estado de la fecha"
}, {
    3729,
    "Financiero - Compra de servicios > Ordenes de compra > Permitir mandatos de diferente C.O."
}, {
    1121,
    "Financiero - Compra de servicios > Ordenes de compra > Rechazar"
}, {
    4394,
    "Financiero - Compra de servicios > Ordenes de compra > Permitir sobrepasar monto anual por proveedor"
}, {
    497,
    "Financiero - Cuentas por pagar > Orden de pago"
}, {
    508,
    "Financiero - Cuentas por pagar > Orden de pago > Anular"
}, {
    506,
    "Financiero - Cuentas por pagar > Orden de pago > Aprobar"
}, {
    7971,
    "Financiero - Cuentas por pagar > Orden de pago > Cambiar datos de descuento pronto pago"
}, {
    512,
    "Financiero - Cuentas por pagar > Orden de pago > Editar"
}, {
    511,
    "Financiero - Cuentas por pagar > Orden de pago > Generar comprobante de egreso"
}, {
    510,
    "Financiero - Cuentas por pagar > Orden de pago > Habilitar impresión"
}, {
    509,
    "Financiero - Cuentas por pagar > Orden de pago > Imprimir"
}, {
    10043,
    "Financiero - Cuentas por pagar > Orden de pago > Modificar fecha cheque"
}, {
    10937,
    "Financiero - Cuentas por pagar > Orden de pago > Modificar Beneficiario"
}, {
    8038,
    "Financiero - Cuentas por pagar > Orden de pago > Modificar entidades dinámicas en orden aprobadas"
}, {
    11038,
    "Financiero - Cuentas por pagar > Orden de pago > Modificar fecha de pago"
}, {
    8486,
    "-No implementado > Otros motivos"
}, {
    1565,
    "Financiero - Cuentas por pagar > Pagos electrónicos"
}, {
    1577,
    "Financiero - Cuentas por pagar > Pagos electrónicos > Adicionar"
}, {
    1566,
    "Financiero - Cuentas por pagar > Pagos electrónicos > Anular"
}, {
    1578,
    "Financiero - Cuentas por pagar > Pagos electrónicos > Aprobar"
}, {
    7557,
    "Financiero - Cuentas por pagar > Pagos electrónicos > Capturar múltiples libros"
}, {
    1567,
    "Financiero - Cuentas por pagar > Pagos electrónicos > Consultar"
}, {
    1569,
    "Financiero - Cuentas por pagar > Pagos electrónicos > Generar"
}, {
    7236,
    "Financiero - Cuentas por pagar > Pagos electrónicos > Permite generar sin encriptar"
}, {
    1568,
    "Financiero - Cuentas por pagar > Pagos electrónicos > Habilitar para imprir o generar"
}, {
    1574,
    "Financiero - Cuentas por pagar > Pagos electrónicos > Imprimir"
}, {
    1594,
    "Financiero - Cuentas por pagar > Pagos electrónicos > Modificar"
}, {
    6425,
    "Financiero - Cuentas por pagar > Pagos electrónicos > Modificar entidades dinámicas en doctos aprobados"
}, {
    6427,
    "Financiero - Cuentas por pagar > Pagos electrónicos > Modificar entidades dinámicas docto en elaboración"
}, {
    496,
    "Financiero - Cuentas por pagar > Programación de pagos"
}, {
    501,
    "Financiero - Cuentas por pagar > Programación de pagos > Anular"
}, {
    10666,
    "Financiero - Cuentas por pagar > Programación de pagos > Permitir anular con pago detracción generado"
}, {
    4851,
    "Financiero - Cuentas por pagar > Programación de pagos > Cambiar datos de descuento pronto pago"
}, {
    8574,
    "Financiero - Cuentas por pagar > Programación de pagos > Permitir cruzar multiples libros"
}, {
    505,
    "Financiero - Cuentas por pagar > Programación de pagos > Editar"
}, {
    10717,
    "Financiero - Cuentas por pagar > Programación de pagos > Permitir fecha de pago anterior a la del sistema"
}, {
    504,
    "Financiero - Cuentas por pagar > Programación de pagos > Generar comprobante de egreso"
}, {
    503,
    "Financiero - Cuentas por pagar > Programación de pagos > Generar orden de pago"
}, {
    6893,
    "Financiero - Cuentas por pagar > Programación de pagos > Generar prog. de pagos de otros usuarios"
}, {
    10665,
    "Financiero - Cuentas por pagar > Programación de pagos > Generar pago detracciones"
}, {
    502,
    "Financiero - Cuentas por pagar > Programación de pagos > Imprimir"
}, {
    10042,
    "Financiero - Cuentas por pagar > Programación de pagos > Modificar fecha cheque"
}, {
    10936,
    "Financiero - Cuentas por pagar > Programación de pagos > Modificar Beneficiario"
}, {
    6891,
    "Financiero - Cuentas por pagar > Programación de pagos > Consultar prog. de pago de otros usuarios"
}, {
    11104,
    "Financiero - Cuentas por pagar > Programación de pagos > Permitir pronto pago mayor valor programado"
}, {
    10185,
    "Financiero - Cuentas por pagar > Programación de pagos > Permitir saldos abiertos de doctos en elaboración"
}, {
    6892,
    "Financiero - Cuentas por pagar > Programación de pagos > Modificar y anular prog. pagos de otros usuarios"
}, {
    1086,
    "Financiero - Compra de servicios > Registros fijos"
}, {
    1114,
    "Financiero - Compra de servicios > Registros fijos > Activar"
}, {
    1112,
    "Financiero - Compra de servicios > Registros fijos > Adicionar"
}, {
    1200,
    "Financiero - Compra de servicios > Registros fijos > Anular"
}, {
    3431,
    "Financiero - Compra de servicios > Registros fijos > Cambiar precios automaticamente"
}, {
    7856,
    "Financiero - Compra de servicios > Registros fijos > Permitir cambiar condición de pago"
}, {
    1111,
    "Financiero - Compra de servicios > Registros fijos > Consultar"
}, {
    3187,
    "Financiero - Compra de servicios > Registros fijos > Facturar"
}, {
    1204,
    "Financiero - Compra de servicios > Registros fijos > Generar orden"
}, {
    1115,
    "Financiero - Compra de servicios > Imprimir documentos > Imprimir reg fijos"
}, {
    1113,
    "Financiero - Compra de servicios > Registros fijos > Modificar"
}, {
    4802,
    "Financiero - Compra de servicios > Registros fijos > Modificar entidades dinámicas en doctos aprobados"
}, {
    11198,
    "Financiero - Compra de servicios > Registros fijos > No obligar solicitante"
}, {
    3728,
    "Financiero - Compra de servicios > Registros fijos > Permitir mandatos de diferente C.O."
}, {
    1199,
    "Financiero - Compra de servicios > Registros fijos > Suspender"
}, {
    500,
    "Financiero - Cuentas por pagar > Reportes"
}, {
    525,
    "Financiero - Cuentas por pagar > Reportes > Vencimiento por edades"
}, {
    4540,
    "Financiero - Cuentas por pagar > Reportes > Circularización"
}, {
    524,
    "Financiero - Cuentas por pagar > Reportes > Estado de cuenta"
}, {
    10012,
    "Financiero - Compra de servicios > Contratos > Cancelar > Modificar entidades dinámicas docto anulados"
}, {
    10011,
    "Financiero - Compra de servicios > Contratos > Cancelar > Modificar entidades dinámicas docto aprobados"
}, {
    10016,
    "Financiero - Compra de servicios > Contratos > Renovar > Modificar entidades dinámicas docto anulados"
}, {
    10015,
    "Financiero - Compra de servicios > Contratos > Renovar > Modificar entidades dinámicas docto aprobados"
}, {
    4161,
    "Comercial - TPV"
}, {
    4776,
    "Comercial - TPV > Ajustes"
}, {
    7740,
    "Comercial - TPV > Ajustes > Actualizar"
}, {
    4777,
    "Comercial - TPV > Ajustes > Consecutivos"
}, {
    9944,
    "Comercial - TPV > Otros procesos > Contadores de ítems"
}, {
    10076,
    "Comercial - TPV > Otros procesos > Documentos en elaboración"
}, {
    6423,
    "Comercial - TPV > Ajustes > Pendientes"
}, {
    9143,
    "Comercial - TPV > Ajustes > Programación puntos preparación"
}, {
    7580,
    "Comercial - TPV > Otros procesos > Refacturación"
}, {
    4165,
    "Comercial - TPV > Caja"
}, {
    4173,
    "Comercial - TPV > Caja > Adiciones"
}, {
    4171,
    "Comercial - TPV > Caja > Apertura"
}, {
    8228,
    "Comercial - TPV > Caja > Apertura > Permitir apertura gaveta"
}, {
    4172,
    "Comercial - TPV > Caja > Cierre"
}, {
    8354,
    "Comercial - TPV > Caja > Cierre > Permitir cerrar caja con saldo"
}, {
    12287,
    "Comercial - TPV > Caja > Cierre > Permitir cierre con documentos en elaboración"
}, {
    11238,
    "Comercial - TPV > Caja > Cierre > Permitir cierre con domicilios pdtes por cuadrar"
}, {
    11689,
    "Comercial - TPV > Caja > Cierre > Permitir confirmar"
}, {
    7558,
    "Comercial - TPV > Caja > Cuadre domicilios"
}, {
    4168,
    "Comercial - TPV > Caja > Egresos"
}, {
    10157,
    "Comercial - TPV > Caja > Egresos > Anular"
}, {
    11725,
    "Comercial - TPV > Caja > Egresos > Permitir confirmar"
}, {
    4259,
    "Comercial - TPV > Habilitar impresión de documentos"
}, {
    4260,
    "Comercial - TPV > Habilitar impresión de documentos > Habilitar impresión de documentos de caja"
}, {
    4261,
    "Comercial - TPV > Habilitar impresión de documentos > Habilitar impresión de facturas"
}, {
    4619,
    "Comercial - TPV > Habilitar impresión de documentos > Habilitar impresión de notas crédito"
}, {
    4262,
    "Comercial - TPV > Imprimir documentos"
}, {
    4263,
    "Comercial - TPV > Imprimir documentos > Imprimir documentos de caja"
}, {
    4264,
    "Comercial - TPV > Imprimir documentos > Imprimir facturas"
}, {
    4854,
    "Comercial - TPV > Imprimir documentos > Generar factura electrónica"
}, {
    7641,
    "Comercial - TPV > Imprimir documentos > Imprimir arreglos"
}, {
    6547,
    "Comercial - TPV > Imprimir documentos > Impresora fiscal"
}, {
    7640,
    "Comercial - TPV > Imprimir documentos > Imprimir prestamos"
}, {
    4492,
    "Comercial - TPV > Imprimir documentos > Imprimir libro diario de ventas"
}, {
    4618,
    "Comercial - TPV > Imprimir documentos > Imprimir notas credito"
}, {
    10672,
    "Comercial - TPV > Imprimir documentos > Imprimir órdenes"
}, {
    7360,
    "Comercial - TPV > Imprimir documentos > Otros reportes"
}, {
    4167,
    "Comercial - TPV > Caja > Ingresos"
}, {
    10158,
    "Comercial - TPV > Caja > Ingresos > Anular"
}, {
    11726,
    "Comercial - TPV > Caja > Ingresos > Permitir confirmar"
}, {
    6548,
    "Comercial - TPV > Caja > Cierre > Permitir cierre sin cfd"
}, {
    8459,
    "Comercial - TPV > Caja > Permitir solo ingresos y egresos del mismo cajero"
}, {
    4174,
    "Comercial - TPV > Caja > Recogida"
}, {
    11690,
    "Comercial - TPV > Caja > Recogida > Permitir confirmar"
}, {
    12307,
    "Comercial - TPV > Caja > Recogida > Permitir cuadre físico posterior"
}, {
    4420,
    "Comercial - TPV > Consultas"
}, {
    4421,
    "Comercial - TPV > Consultas > Existencias"
}, {
    4422,
    "Comercial - TPV > Consultas > Saldos"
}, {
    9094,
    "Comercial - TPV > Consultas > Consulta de saldo gift card"
}, {
    7358,
    "Comercial - TPV > Consultas > Consulta de ventas por vendedor"
}, {
    4162,
    "Comercial - TPV > Facturar"
}, {
    4164,
    "Comercial - TPV > Facturar > Boutique"
}, {
    4453,
    "Comercial - TPV > Facturar > Boutique > Anular"
}, {
    7793,
    "Comercial - TPV > Facturar > Boutique > Anular prestamo"
}, {
    7645,
    "Comercial - TPV > Facturar > Boutique > Arreglos de mercancía"
}, {
    10686,
    "Comercial - TPV > Facturar > Boutique > Arreglos de mercancía > Permitir realizar arreglos con base en factura"
}, {
    10685,
    "Comercial - TPV > Facturar > Boutique > Arreglos de mercancía > Permitir realizar arreglos directos"
}, {
    10687,
    "Comercial - TPV > Facturar > Boutique > Arreglos de mercancía > Permitir gestionar arreglos"
}, {
    4436,
    "Comercial - TPV > Facturar > Boutique > Cambiar vendedor"
}, {
    4176,
    "Comercial - TPV > Facturar > Boutique > Cambio"
}, {
    8276,
    "Comercial - TPV > Facturar > Boutique > Permitir cambiar grupo menú familia"
}, {
    7805,
    "Comercial - TPV > Facturar > Boutique > Permitir cancelar separado"
}, {
    4602,
    "Comercial - TPV > Facturar > Boutique > Permitir capturar perfil del cliente"
}, {
    10782,
    "Comercial - TPV > Facturar > Boutique > Permitir captura cliente domicilio"
}, {
    4360,
    "Comercial - TPV > Facturar > Boutique > Captura ítem"
}, {
    4293,
    "Comercial - TPV > Facturar > Boutique > Clientes"
}, {
    11776,
    "Comercial - TPV > Facturar > Boutique > Permitir comfirmar obsequio"
}, {
    4177,
    "Comercial - TPV > Facturar > Boutique > Congelar"
}, {
    4175,
    "Comercial - TPV > Facturar > Boutique > Consultar"
}, {
    9632,
    "Comercial - TPV > Facturar > Boutique > Permitir crédito en tiquete/boleta"
}, {
    4178,
    "Comercial - TPV > Facturar > Boutique > Descogelar"
}, {
    4298,
    "Comercial - TPV > Facturar > Boutique > Permitir devolución ítems"
}, {
    6744,
    "Comercial - TPV > Facturar > Boutique > Permitir devolver item redimido"
}, {
    8282,
    "Comercial - TPV > Facturar > Boutique > Donación"
}, {
    4594,
    "Comercial - TPV > Facturar > Boutique > Descuento global"
}, {
    8234,
    "Comercial - TPV > Facturar > Boutique > Permitir duplicar ítem"
}, {
    9105,
    "Comercial - TPV > Facturar > Boutique > Permitir editar ítem comanda"
}, {
    9135,
    "Comercial - TPV > Facturar > Boutique > Permitir editar ítem con cambio de tamaño"
}, {
    9820,
    "Comercial - TPV > Facturar > Boutique > Permitir editar obsequios"
}, {
    8241,
    "Comercial - TPV > Facturar > Boutique > Eliminar documento actual"
}, {
    4299,
    "Comercial - TPV > Facturar > Boutique > Permitir eliminar ítems"
}, {
    12035,
    "Comercial - TPV > Facturar > Boutique > Eliminar múltiples ítems"
}, {
    12599,
    "Comercial - TPV > Facturar > Boutique > Facturar anticipos"
}, {
    4809,
    "Comercial - TPV > Facturar > Boutique > Permitir facturar tiquete"
}, {
    8364,
    "Comercial - TPV > Facturar > Boutique > Financiación"
}, {
    12487,
    "Comercial - TPV > Facturar > Boutique > Financiación > Permitir seleccionar primer valor por defecto"
}, {
    4296,
    "Comercial - TPV > Facturar > Boutique > Permitir modificar cantidad"
}, {
    4295,
    "Comercial - TPV > Facturar > Boutique > Permitir modificar cliente POS"
}, {
    4297,
    "Comercial - TPV > Facturar > Boutique > Permitir modificar descuentos"
}, {
    6367,
    "Comercial - TPV > Facturar > Boutique > Obsequio"
}, {
    7220,
    "Comercial - TPV > Facturar > Boutique > Otros"
}, {
    11206,
    "Comercial - TPV > Facturar > Boutique > Facturar pedido domicilio"
}, {
    4181,
    "Comercial - TPV > Facturar > Boutique > Preliquidar"
}, {
    7599,
    "Comercial - TPV > Facturar > Boutique > Prestamos"
}, {
    6741,
    "Comercial - TPV > Facturar > Boutique > Redimir item"
}, {
    4596,
    "Comercial - TPV > Facturar > Boutique > Retención"
}, {
    7104,
    "Comercial - TPV > Facturar > Boutique > Separar"
}, {
    4183,
    "-No implementado > Subtotal"
}, {
    4179,
    "Comercial - TPV > Facturar > Boutique > Totalizar"
}, {
    8088,
    "Comercial - TPV > Facturar > Comidas rapidas"
}, {
    8089,
    "Comercial - TPV > Facturar > Comidas rapidas > Anular"
}, {
    8090,
    "Comercial - TPV > Facturar > Comidas rapidas > Cambiar vendedor"
}, {
    8091,
    "Comercial - TPV > Facturar > Comidas rapidas > Captura ítem"
}, {
    10783,
    "Comercial - TPV > Facturar > Comidas rapidas > Permitir captura cliente domicilio"
}, {
    8100,
    "Comercial - TPV > Facturar > Comidas rapidas > Permitir capturar perfil del cliente"
}, {
    8092,
    "Comercial - TPV > Facturar > Comidas rapidas > Clientes"
}, {
    11777,
    "Comercial - TPV > Facturar > Comidas rapidas > Permitir comfirmar obsequio"
}, {
    8093,
    "Comercial - TPV > Facturar > Comidas rapidas > Congelar"
}, {
    8094,
    "Comercial - TPV > Facturar > Comidas rapidas > Consultar"
}, {
    9633,
    "Comercial - TPV > Facturar > Comidas rapidas > Permitir crédito en tiquete/boleta"
}, {
    8095,
    "Comercial - TPV > Facturar > Comidas rapidas > Descongelar"
}, {
    8101,
    "Comercial - TPV > Facturar > Comidas rapidas > Permitir devolución ítems"
}, {
    8102,
    "Comercial - TPV > Facturar > Comidas rapidas > Permitir devolver ítem redimido"
}, {
    8283,
    "Comercial - TPV > Facturar > Comidas rapidas > Donación"
}, {
    8096,
    "Comercial - TPV > Facturar > Comidas rapidas > Descuento global"
}, {
    8235,
    "Comercial - TPV > Facturar > Comidas rapidas > Permitir duplicar ítem"
}, {
    9103,
    "Comercial - TPV > Facturar > Comidas rapidas > Permitir editar ítem comanda"
}, {
    9821,
    "Comercial - TPV > Facturar > Comidas rapidas > Permitir editar obsequios"
}, {
    8242,
    "Comercial - TPV > Facturar > Comidas rapidas > Eliminar documento actual"
}, {
    8103,
    "Comercial - TPV > Facturar > Comidas rapidas > Permitir eliminar ítems"
}, {
    12036,
    "Comercial - TPV > Facturar > Comidas rapidas > Eliminar múltiples ítems"
}, {
    8104,
    "Comercial - TPV > Facturar > Comidas rapidas > Permitir facturar tiquete"
}, {
    8365,
    "Comercial - TPV > Facturar > Comidas rapidas > Financiación"
}, {
    8097,
    "Comercial - TPV > Facturar > Comidas rapidas > Llevar"
}, {
    8105,
    "Comercial - TPV > Facturar > Comidas rapidas > Permitir modificar cantidad"
}, {
    8106,
    "Comercial - TPV > Facturar > Comidas rapidas > Permitir modificar clientes POS"
}, {
    8107,
    "Comercial - TPV > Facturar > Comidas rapidas > Permitir modificar descuentos"
}, {
    8098,
    "Comercial - TPV > Facturar > Comidas rapidas > Obsequio"
}, {
    8099,
    "Comercial - TPV > Facturar > Comidas rapidas > Otros"
}, {
    8229,
    "Comercial - TPV > Facturar > Comidas rapidas > Partir cuenta"
}, {
    11207,
    "Comercial - TPV > Facturar > Comidas rapidas > Facturar pedido domicilio"
}, {
    8108,
    "Comercial - TPV > Facturar > Comidas rapidas > Preliquidar"
}, {
    11430,
    "Comercial - TPV > Facturar > Comidas rapidas > Propina"
}, {
    8109,
    "Comercial - TPV > Facturar > Comidas rapidas > Redimir ítem"
}, {
    8110,
    "Comercial - TPV > Facturar > Comidas rapidas > Retención"
}, {
    8111,
    "Comercial - TPV > Facturar > Comidas rapidas > Totalizar"
}, {
    8657,
    "Comercial - TPV > Facturar > Comidas rapidas > Transferir cuenta"
}, {
    8277,
    "Comercial - TPV > Facturar > Comidas rapidas > Permitir cambiar grupo menú familia"
}, {
    12488,
    "Comercial - TPV > Facturar > Comidas rapidas > Financiación > Permitir seleccionar primer valor por defecto"
}, {
    9136,
    "Comercial - TPV > Facturar > Comidas rapidas > Permitir editar ítem con cambio de tamaño"
}, {
    7747,
    "Comercial - TPV > Facturar > Facturar ordenes"
}, {
    7789,
    "Comercial - TPV > Facturar > Facturar ordenes > Anular"
}, {
    9634,
    "Comercial - TPV > Facturar > Facturar ordenes > Permitir crédito en tiquete/boleta"
}, {
    7788,
    "Comercial - TPV > Facturar > Facturar ordenes > Descuento global"
}, {
    8284,
    "Comercial - TPV > Facturar > Facturar ordenes > Donación"
}, {
    8366,
    "Comercial - TPV > Facturar > Facturar ordenes > Financiación"
}, {
    12489,
    "Comercial - TPV > Facturar > Facturar ordenes > Financiación > Permitir seleccionar primer valor por defecto"
}, {
    7791,
    "Comercial - TPV > Facturar > Facturar ordenes > Permitir capturar tiquete"
}, {
    7790,
    "Comercial - TPV > Facturar > Facturar ordenes > Retención"
}, {
    7746,
    "Comercial - TPV > Facturar > Ordenes"
}, {
    7769,
    "Comercial - TPV > Facturar > Ordenes > Cambio"
}, {
    8278,
    "Comercial - TPV > Facturar > Ordenes > Permitir cambiar grupo menú familia"
}, {
    7806,
    "Comercial - TPV > Facturar > Ordenes > Cambiar vendedor"
}, {
    7772,
    "Comercial - TPV > Facturar > Ordenes > Captura ítem"
}, {
    10784,
    "Comercial - TPV > Facturar > Ordenes > Permitir captura cliente domicilio"
}, {
    7780,
    "Comercial - TPV > Facturar > Ordenes > Clientes"
}, {
    7776,
    "Comercial - TPV > Facturar > Ordenes > Comfirmar orden"
}, {
    11778,
    "Comercial - TPV > Facturar > Ordenes > Permitir comfirmar obsequio"
}, {
    7773,
    "Comercial - TPV > Facturar > Ordenes > Congelar"
}, {
    7779,
    "Comercial - TPV > Facturar > Ordenes > Consultar"
}, {
    7778,
    "Comercial - TPV > Facturar > Ordenes > Descongelar"
}, {
    7771,
    "Comercial - TPV > Facturar > Ordenes > Descuento global"
}, {
    8236,
    "Comercial - TPV > Facturar > Ordenes > Permitir duplicar ítem"
}, {
    11376,
    "Comercial - TPV > Facturar > Ordenes > Editar"
}, {
    9137,
    "Comercial - TPV > Facturar > Ordenes > Permitir editar ítem con cambio de tamaño"
}, {
    9822,
    "Comercial - TPV > Facturar > Ordenes > Permitir editar obsequios"
}, {
    7777,
    "Comercial - TPV > Facturar > Ordenes > Eliminar"
}, {
    8243,
    "Comercial - TPV > Facturar > Ordenes > Eliminar documento actual"
}, {
    12037,
    "Comercial - TPV > Facturar > Ordenes > Eliminar múltiples ítems"
}, {
    9541,
    "Comercial - TPV > Facturar > Ordenes > Facturas"
}, {
    7770,
    "Comercial - TPV > Facturar > Ordenes > Obsequio"
}, {
    7775,
    "Comercial - TPV > Facturar > Ordenes > Otros"
}, {
    7781,
    "Comercial - TPV > Facturar > Ordenes > Permitir capturar perfil de cliente"
}, {
    7782,
    "Comercial - TPV > Facturar > Ordenes > Permitir eliminar ítem"
}, {
    9542,
    "Comercial - TPV > Facturar > Ordenes > Permitir ordenes desde factura de todos los C.O."
}, {
    7783,
    "Comercial - TPV > Facturar > Ordenes > Permitir modificar cantidad"
}, {
    7784,
    "Comercial - TPV > Facturar > Ordenes > Permitir modificar cliente POS"
}, {
    7785,
    "Comercial - TPV > Facturar > Ordenes > Permitir modificar descuentos"
}, {
    9116,
    "Comercial - TPV > Facturar > Ordenes > Permitir modificar notas item"
}, {
    7786,
    "Comercial - TPV > Facturar > Ordenes > Preliquidar"
}, {
    7774,
    "Comercial - TPV > Facturar > Ordenes > Redimir ítem"
}, {
    7787,
    "Comercial - TPV > Facturar > Ordenes > Totalizar"
}, {
    11054,
    "Comercial - TPV > Facturar > Pedidos Domicilio"
}, {
    11055,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Anular"
}, {
    11067,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Permitir cambiar grupo menú familiar"
}, {
    11056,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Cambiar vendedor"
}, {
    11068,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Permitir capturar cliente domicilio"
}, {
    11057,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Capturar ítem"
}, {
    11069,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Permitir captura perfil de cliente"
}, {
    11058,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Clientes"
}, {
    11779,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Permitir comfirmar obsequio"
}, {
    11059,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Congelar"
}, {
    11060,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Consultar"
}, {
    11302,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Dar por cumplido"
}, {
    11061,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Descongelar"
}, {
    11070,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Permitir devolución ítems"
}, {
    11071,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Permitir devolver ítem redimido"
}, {
    11062,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Donación"
}, {
    11072,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Permitir duplicar ítem"
}, {
    11074,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Permitir editar ítem con cambio de tamaño"
}, {
    11073,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Permitir editar ítem comanda"
}, {
    11075,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Permitir editar obsequios"
}, {
    12038,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Eliminar múltiples ítems"
}, {
    11063,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Eliminar documento actual"
}, {
    11076,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Permitir eliminar ítems"
}, {
    11064,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Llevar"
}, {
    11077,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Permitir modificar cantidad"
}, {
    11078,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Permitir modificar clientes POS"
}, {
    11079,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Permitir modificar descuentos"
}, {
    11065,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Obsequio"
}, {
    11066,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Otros"
}, {
    11080,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Preliquidar"
}, {
    11081,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Redimir ítem"
}, {
    11301,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Revertir pedido"
}, {
    11082,
    "Comercial - TPV > Facturar > Pedidos Domicilio > Totalizar"
}, {
    7919,
    "Comercial - TPV > Facturar > Restaurante"
}, {
    8679,
    "Comercial - TPV > Facturar > Restaurante > Permitit forzar abrir pedidos"
}, {
    7920,
    "Comercial - TPV > Facturar > Restaurante > Anular"
}, {
    7921,
    "Comercial - TPV > Facturar > Restaurante > Cambiar vendedor"
}, {
    8279,
    "Comercial - TPV > Facturar > Restaurante > Permitir cambiar grupo menú familia"
}, {
    8238,
    "Comercial - TPV > Facturar > Restaurante > Permitir cancelar separado"
}, {
    7922,
    "Comercial - TPV > Facturar > Restaurante > Captura ítem"
}, {
    10785,
    "Comercial - TPV > Facturar > Restaurante > Permitir captura cliente domicilio"
}, {
    7930,
    "Comercial - TPV > Facturar > Restaurante > Permitir capturar perfil del cliente"
}, {
    7923,
    "Comercial - TPV > Facturar > Restaurante > Clientes"
}, {
    10467,
    "Comercial - TPV > Facturar > Restaurante > Permitir marchar comandas exclusivas mesero"
}, {
    11780,
    "Comercial - TPV > Facturar > Restaurante > Permitir comfirmar obsequio"
}, {
    7924,
    "Comercial - TPV > Facturar > Restaurante > Congelar"
}, {
    7925,
    "Comercial - TPV > Facturar > Restaurante > Consultar"
}, {
    9635,
    "Comercial - TPV > Facturar > Restaurante > Permitir crédito en tiquete/boleta"
}, {
    7926,
    "Comercial - TPV > Facturar > Restaurante > Descongelar"
}, {
    8409,
    "Comercial - TPV > Facturar > Restaurante > Descongelar documentos de otra tpv"
}, {
    7927,
    "Comercial - TPV > Facturar > Restaurante > Descuento global"
}, {
    7931,
    "Comercial - TPV > Facturar > Restaurante > Permitir devoluciones ítems"
}, {
    7932,
    "Comercial - TPV > Facturar > Restaurante > Permitir devolver item redimido"
}, {
    8285,
    "Comercial - TPV > Facturar > Restaurante > Donación"
}, {
    8237,
    "Comercial - TPV > Facturar > Restaurante > Permitir duplicar ítem"
}, {
    8230,
    "Comercial - TPV > Facturar > Restaurante > Permitir editar ítem comanda"
}, {
    9138,
    "Comercial - TPV > Facturar > Restaurante > Permitir editar ítem con cambio de tamaño"
}, {
    9823,
    "Comercial - TPV > Facturar > Restaurante > Permitir editar obsequios"
}, {
    8244,
    "Comercial - TPV > Facturar > Restaurante > Eliminar documento actual"
}, {
    7933,
    "Comercial - TPV > Facturar > Restaurante > Permitir eliminar ítems"
}, {
    12039,
    "Comercial - TPV > Facturar > Restaurante > Eliminar múltiples ítems"
}, {
    12600,
    "Comercial - TPV > Facturar > Restaurante > Facturar anticipos"
}, {
    7934,
    "Comercial - TPV > Facturar > Restaurante > Permitir facturar tiquete"
}, {
    8367,
    "Comercial - TPV > Facturar > Restaurante > Financiación"
}, {
    12490,
    "Comercial - TPV > Facturar > Restaurante > Financiación > Permitir seleccionar primer valor por defecto"
}, {
    8112,
    "Comercial - TPV > Facturar > Restaurante > Generar cuenta"
}, {
    10456,
    "-No implementado > Permitir eliminar ítems no marchados"
}, {
    8139,
    "Comercial - TPV > Facturar > Restaurante > Llevar"
}, {
    10928,
    "Comercial - TPV > Facturar > Restaurante > Mesa"
}, {
    10929,
    "Comercial - TPV > Facturar > Restaurante > Mesa > Permitir adicionar mesa"
}, {
    10934,
    "Comercial - TPV > Facturar > Restaurante > Mesa > Permitir asignar mesas"
}, {
    10930,
    "Comercial - TPV > Facturar > Restaurante > Mesa > Permitir cambiar número de cubiertos"
}, {
    10931,
    "Comercial - TPV > Facturar > Restaurante > Mesa > Permitir transferir cuenta"
}, {
    10932,
    "Comercial - TPV > Facturar > Restaurante > Mesa > Permitir unir mesa"
}, {
    10933,
    "Comercial - TPV > Facturar > Restaurante > Mesa > Permitir separar mesas"
}, {
    7935,
    "Comercial - TPV > Facturar > Restaurante > Permitir modificar cantidad"
}, {
    7936,
    "Comercial - TPV > Facturar > Restaurante > Permitir modificar cliente POS"
}, {
    7937,
    "Comercial - TPV > Facturar > Restaurante > Permitir modificar descuentos"
}, {
    8663,
    "Comercial - TPV > Facturar > Restaurante > Permitir modificar silla"
}, {
    7928,
    "Comercial - TPV > Facturar > Restaurante > Obsequio"
}, {
    7929,
    "Comercial - TPV > Facturar > Restaurante > Otros"
}, {
    8113,
    "Comercial - TPV > Facturar > Restaurante > Partir cuenta"
}, {
    9600,
    "Comercial - TPV > Facturar > Restaurante > Permitir modificar paso del servicio"
}, {
    11208,
    "Comercial - TPV > Facturar > Restaurante > Facturar pedido domicilio"
}, {
    7938,
    "Comercial - TPV > Facturar > Restaurante > Preliquidar"
}, {
    8114,
    "Comercial - TPV > Facturar > Restaurante > Propina"
}, {
    7939,
    "Comercial - TPV > Facturar > Restaurante > Redimir ítem"
}, {
    8343,
    "Comercial - TPV > Facturar > Restaurante > Permitir reimprimir comandas"
}, {
    7940,
    "Comercial - TPV > Facturar > Restaurante > Retención"
}, {
    8115,
    "Comercial - TPV > Facturar > Restaurante > Revertir factura"
}, {
    8231,
    "Comercial - TPV > Facturar > Restaurante > Separar"
}, {
    8138,
    "Comercial - TPV > Facturar > Restaurante > Terminar comanda"
}, {
    7941,
    "Comercial - TPV > Facturar > Restaurante > Totalizar"
}, {
    8658,
    "Comercial - TPV > Facturar > Restaurante > Transferir cuenta"
}, {
    4163,
    "Comercial - TPV > Facturar > Autoservicio"
}, {
    4452,
    "Comercial - TPV > Facturar > Autoservicio > Anular"
}, {
    7792,
    "Comercial - TPV > Facturar > Autoservicio > Anular prestamo"
}, {
    7644,
    "Comercial - TPV > Facturar > Autoservicio > Arreglos de mercancía"
}, {
    10689,
    "Comercial - TPV > Facturar > Autoservicio > Arreglos de mercancía > Permitir realizar arreglos con base en factura"
}, {
    10688,
    "Comercial - TPV > Facturar > Autoservicio > Arreglos de mercancía > Permirtir realizar arreglos directos"
}, {
    10690,
    "Comercial - TPV > Facturar > Autoservicio > Arreglos de mercancía > Permitir gestionar arreglos"
}, {
    4435,
    "Comercial - TPV > Facturar > Autoservicio > Cambiar vendedor"
}, {
    4184,
    "Comercial - TPV > Facturar > Autoservicio > Cambio"
}, {
    8275,
    "Comercial - TPV > Facturar > Autoservicio > Permitir cambiar grupo menú familia"
}, {
    7804,
    "Comercial - TPV > Facturar > Autoservicio > Permitir cancelar separado"
}, {
    4601,
    "Comercial - TPV > Facturar > Autoservicio > Permitir capturar perfil del cliente"
}, {
    10781,
    "Comercial - TPV > Facturar > Autoservicio > Permitir captura cliente domicilio"
}, {
    4359,
    "Comercial - TPV > Facturar > Autoservicio > Captura ítem"
}, {
    4294,
    "Comercial - TPV > Facturar > Autoservicio > Clientes"
}, {
    11775,
    "Comercial - TPV > Facturar > Autoservicio > Permitir comfirmar obsequio"
}, {
    4185,
    "Comercial - TPV > Facturar > Autoservicio > Congelar"
}, {
    4186,
    "Comercial - TPV > Facturar > Autoservicio > Consultar"
}, {
    9631,
    "Comercial - TPV > Facturar > Autoservicio > Permitir crédito en tiquete/boleta"
}, {
    4187,
    "Comercial - TPV > Facturar > Autoservicio > Descongelar"
}, {
    4300,
    "Comercial - TPV > Facturar > Autoservicio > Permitir devolución ítems"
}, {
    6743,
    "Comercial - TPV > Facturar > Autoservicio > Permitir devolver item redimido"
}, {
    8281,
    "Comercial - TPV > Facturar > Autoservicio > Donación"
}, {
    4593,
    "Comercial - TPV > Facturar > Autoservicio > Descuento global"
}, {
    8233,
    "Comercial - TPV > Facturar > Autoservicio > Permitir duplicar ítem"
}, {
    9104,
    "Comercial - TPV > Facturar > Autoservicio > Permitir editar ítem comanda"
}, {
    9134,
    "Comercial - TPV > Facturar > Autoservicio > Permitir editar ítem con cambio de tamaño"
}, {
    9819,
    "Comercial - TPV > Facturar > Autoservicio > Permitir editar obsequios"
}, {
    8240,
    "Comercial - TPV > Facturar > Autoservicio > Eliminar documento actual"
}, {
    4301,
    "Comercial - TPV > Facturar > Autoservicio > Permitir eliminar ítems"
}, {
    12034,
    "Comercial - TPV > Facturar > Autoservicio > Eliminar múltiples ítems"
}, {
    12598,
    "Comercial - TPV > Facturar > Autoservicio > Facturar anticipos"
}, {
    4808,
    "Comercial - TPV > Facturar > Autoservicio > Permitir facturar tiquete"
}, {
    8363,
    "Comercial - TPV > Facturar > Autoservicio > Financiación"
}, {
    12486,
    "Comercial - TPV > Facturar > Autoservicio > Financiación > Permitir seleccionar primer valor por defecto"
}, {
    4304,
    "Comercial - TPV > Facturar > Autoservicio > Permitir modificar descuentos"
}, {
    4302,
    "Comercial - TPV > Facturar > Autoservicio > Permitir modificar cantidad"
}, {
    4303,
    "Comercial - TPV > Facturar > Autoservicio > Permitir modificar cliente POS"
}, {
    6366,
    "Comercial - TPV > Facturar > Autoservicio > Obsequio"
}, {
    7219,
    "Comercial - TPV > Facturar > Autoservicio > Otros"
}, {
    11205,
    "Comercial - TPV > Facturar > Autoservicio > Factura pedido domicilio"
}, {
    4190,
    "Comercial - TPV > Facturar > Autoservicio > Preliquidar"
}, {
    7598,
    "Comercial - TPV > Facturar > Autoservicio > Prestamos"
}, {
    6740,
    "Comercial - TPV > Facturar > Autoservicio > Redimir item"
}, {
    4595,
    "Comercial - TPV > Facturar > Autoservicio > Retención"
}, {
    7103,
    "Comercial - TPV > Facturar > Autoservicio > Separar"
}, {
    4191,
    "-No implementado > Subtotal"
}, {
    4192,
    "Comercial - TPV > Facturar > Autoservicio > Totalizar"
}, {
    4305,
    "Comercial - TPV > Generales"
}, {
    7794,
    "Comercial - TPV > Generales > Permitir abrir gaveta"
}, {
    10507,
    "Comercial - TPV > Generales > Bloquear cierre de sesión sin cierre de caja"
}, {
    4308,
    "Comercial - TPV > Generales > Cambiar condicion de pago segun nivel de recaudo"
}, {
    4423,
    "Comercial - TPV > Generales > Permitir cambiar vendedor"
}, {
    8814,
    "Comercial - TPV > Generales > Permitir cancelar sincronización cuando es exigida"
}, {
    8195,
    "Comercial - TPV > Generales > Permitir capturar causal de devolución"
}, {
    7381,
    "Comercial - TPV > Generales > Permitir capturar notas medio de pago otros"
}, {
    7380,
    "Comercial - TPV > Generales > Permitir capturar referencia medio de pago otros"
}, {
    8805,
    "Comercial - TPV > Generales > Permitir cheque autorizado sin conexión a central"
}, {
    4838,
    "Comercial - TPV > Generales > Clientes POS"
}, {
    4842,
    "Comercial - TPV > Generales > Clientes POS > Exigir barrio"
}, {
    4845,
    "Comercial - TPV > Generales > Clientes POS > Exigir celular"
}, {
    8306,
    "Comercial - TPV > Generales > Clientes POS > Exigir ciiu"
}, {
    4841,
    "Comercial - TPV > Generales > Clientes POS > Exigir ciudad"
}, {
    4850,
    "Comercial - TPV > Generales > Clientes POS > Exigir codigo EAN"
}, {
    4848,
    "Comercial - TPV > Generales > Clientes POS > Exigir cod. postal"
}, {
    4839,
    "Comercial - TPV > Generales > Clientes POS > Exigir contacto"
}, {
    4840,
    "Comercial - TPV > Generales > Clientes POS > Exigir dirección"
}, {
    4847,
    "Comercial - TPV > Generales > Clientes POS > Exigir e-mail"
}, {
    4844,
    "Comercial - TPV > Generales > Clientes POS > Exigir fax"
}, {
    11893,
    "Comercial - TPV > Generales > Clientes POS > Exigir habeas data"
}, {
    4849,
    "Comercial - TPV > Generales > Clientes POS > Exigir notas"
}, {
    4846,
    "Comercial - TPV > Generales > Clientes POS > Exigir sexo"
}, {
    4843,
    "Comercial - TPV > Generales > Clientes POS > Exigir telefono"
}, {
    11894,
    "Comercial - TPV > Generales > Clientes POS > Permitir modificar habeas data"
}, {
    8654,
    "Comercial - TPV > Generales > Clientes POS > Permitir adicionar clientes POS"
}, {
    8307,
    "Comercial - TPV > Generales > Clientes POS > Permitir capturar ciiu"
}, {
    12485,
    "Comercial - TPV > Generales > Clientes POS > Permitir capturar criterios de clasificación"
}, {
    11756,
    "Comercial - TPV > Generales > Clientes POS > Permitir capturar número de identificación"
}, {
    4450,
    "Comercial - TPV > Generales > Permitir consultar analisis del cliente"
}, {
    7643,
    "Comercial - TPV > Generales > Permitir consultar arreglos del cliente"
}, {
    7359,
    "Comercial - TPV > Generales > Permitir consultar ítems separados clientes"
}, {
    4449,
    "Comercial - TPV > Generales > Permitir consultar movimiento de venta del cliente"
}, {
    7642,
    "Comercial - TPV > Generales > Permitir consultar prestamos del cliente"
}, {
    7069,
    "Comercial - TPV > Generales > Permitir consultar saldos anticipos cliente"
}, {
    8804,
    "Comercial - TPV > Generales > Permitir crédito sin conexión a central"
}, {
    4306,
    "Comercial - TPV > Generales > Permitir eliminar medio de pago"
}, {
    7945,
    "Comercial - TPV > Generales > Exigir cantidad al preliquidar"
}, {
    4307,
    "Comercial - TPV > Generales > Permitir modificar condiciones de pago"
}, {
    7222,
    "Comercial - TPV > Generales > Permitir modificar notas"
}, {
    7808,
    "Comercial - TPV > Generales > Permitir mostrar aviso de recogida"
}, {
    7872,
    "-No implementado > Permitir omitir cantidad al preliquidar"
}, {
    10794,
    "Comercial - TPV > Generales > Clientes POS > Permitir solo números en celular"
}, {
    10793,
    "Comercial - TPV > Generales > Clientes POS > Permitir solo números en fax"
}, {
    10792,
    "Comercial - TPV > Generales > Clientes POS > Permitir solo números en teléfono"
}, {
    11774,
    "-No implementado > Permitir obsequios especiales"
}, {
    12278,
    "Comercial - TPV > Generales > Permitir reimprimir desde facturación"
}, {
    4424,
    "Comercial - TPV > Generales > Permitir transferir vendedor"
}, {
    7048,
    "Comercial - TPV > Marcación"
}, {
    4495,
    "Comercial - TPV > Notas credito"
}, {
    12306,
    "Comercial - TPV > Notas credito > Permitir adicionar ítems"
}, {
    4496,
    "Comercial - TPV > Notas credito > Anular"
}, {
    4497,
    "Comercial - TPV > Notas credito > Cambiar vendedor"
}, {
    8274,
    "Comercial - TPV > Notas credito > Permitir cambiar grupo menú familia"
}, {
    4603,
    "Comercial - TPV > Notas credito > Permitir capturar perfil del cliente"
}, {
    4498,
    "Comercial - TPV > Notas credito > Captura ítem"
}, {
    4499,
    "Comercial - TPV > Notas credito > Clientes"
}, {
    4500,
    "Comercial - TPV > Notas credito > Congelar"
}, {
    4501,
    "Comercial - TPV > Notas credito > Consultar"
}, {
    4502,
    "Comercial - TPV > Notas credito > Descogelar"
}, {
    6745,
    "Comercial - TPV > Notas credito > Permitir devolver item redimido"
}, {
    8280,
    "Comercial - TPV > Notas credito > Donación"
}, {
    4592,
    "Comercial - TPV > Notas credito > Descuento global"
}, {
    9825,
    "Comercial - TPV > Notas credito > Permitir editar obsequios"
}, {
    8239,
    "Comercial - TPV > Notas credito > Eliminar documento actual"
}, {
    4503,
    "Comercial - TPV > Notas credito > Permitir eliminar ítems"
}, {
    4541,
    "Comercial - TPV > Notas credito > Facturas"
}, {
    8362,
    "Comercial - TPV > Notas credito > Financiación"
}, {
    4506,
    "Comercial - TPV > Notas credito > Permitir modificar descuentos"
}, {
    4504,
    "Comercial - TPV > Notas credito > Permitir modificar cantidad"
}, {
    4505,
    "Comercial - TPV > Notas credito > Permitir modificar cliente POS"
}, {
    4508,
    "Comercial - TPV > Notas credito > Permitir modificar precio"
}, {
    6368,
    "Comercial - TPV > Notas credito > Obsequio"
}, {
    7221,
    "Comercial - TPV > Notas credito > Otros"
}, {
    9114,
    "Comercial - TPV > Notas credito > Permitir nota crédito desde fact de todos los C.O."
}, {
    8232,
    "Comercial - TPV > Notas credito > Permitir duplicar ítem"
}, {
    6742,
    "Comercial - TPV > Notas credito > Redimir item"
}, {
    4597,
    "Comercial - TPV > Notas credito > Retención"
}, {
    4507,
    "Comercial - TPV > Notas credito > Totalizar"
}, {
    10841,
    "Comercial - TPV > Otros procesos"
}, {
    10842,
    "Comercial - TPV > Otros procesos > Gestión domiciliarios"
}, {
    11440,
    "Comercial - TPV > Otros procesos > Gestión domiciliarios > Permitir imprimir documentos al asignar"
}, {
    2849,
    "Vehiculos"
}, {
    1443,
    "Comercial - Ventas"
}, {
    3394,
    "Comercial - Ventas > Acumulados"
}, {
    3395,
    "Comercial - Ventas > Acumulados > Cubo de facturación"
}, {
    3396,
    "Comercial - Ventas > Acumulados > Cubo de facturación cliente ocacional"
}, {
    4251,
    "Comercial - Ventas > Acumulados > Cubo de facturacion cliente ocacional sumarizado"
}, {
    4250,
    "Comercial - Ventas > Acumulados > Cubo de facturacion sumarizado"
}, {
    7969,
    "Comercial - Ventas > Análisis"
}, {
    3491,
    "Comercial - Ventas > Analisis cliente"
}, {
    8712,
    "Comercial - Ventas > Analisis cliente > Permitir análisis en documentos aprobados"
}, {
    3493,
    "Comercial - Ventas > Analisis cliente > Calcular cheques devueltos"
}, {
    3494,
    "Comercial - Ventas > Analisis cliente > Calcular cheques posfechados"
}, {
    3492,
    "Comercial - Ventas > Analisis cliente > Calcular dias promedio de pago"
}, {
    3570,
    "Comercial - Ventas > Analisis cliente > Permitir consultar cartera"
}, {
    3569,
    "Comercial - Ventas > Analisis cliente > Permitir consultar cliente"
}, {
    3571,
    "Comercial - Ventas > Analisis cliente > Permitir consultar pedidos"
}, {
    3572,
    "Comercial - Ventas > Analisis cliente > Permitir consultar ventas"
}, {
    7970,
    "Comercial - Ventas > Análisis > Facturas y notas"
}, {
    1909,
    "Comercial - Ventas > Automatización de documentos"
}, {
    10169,
    "Comercial - Ventas > Cerrar impresión documentos"
}, {
    10170,
    "Comercial - Ventas > Cerrar impresión documentos > Cerrar pantalla cotizaciones"
}, {
    10171,
    "Comercial - Ventas > Cerrar impresión documentos > Cerrar pantalla devoluciones"
}, {
    10172,
    "Comercial - Ventas > Cerrar impresión documentos > Cerrar pantalla facturas"
}, {
    10173,
    "Comercial - Ventas > Cerrar impresión documentos > Cerrar pantalla notas"
}, {
    10174,
    "Comercial - Ventas > Cerrar impresión documentos > Cerrar pantalla pedidos"
}, {
    10176,
    "Comercial - Ventas > Cerrar impresión documentos > Cerrar pantalla planilla de cuadre"
}, {
    10175,
    "Comercial - Ventas > Cerrar impresión documentos > Cerrar pantalla planilla de cuadre de facturas"
}, {
    10177,
    "Comercial - Ventas > Cerrar impresión documentos > Cerrar pantalla remisiones"
}, {
    10265,
    "Comercial - Ventas > Comisiones"
}, {
    10273,
    "Comercial - Ventas > Comisiones > Consulta"
}, {
    10266,
    "Comercial - Ventas > Comisiones > Tabla de comisiones"
}, {
    10267,
    "Comercial - Ventas > Comisiones > Tabla de comisiones > Adicionar"
}, {
    10268,
    "Comercial - Ventas > Comisiones > Tabla de comisiones > Consultar"
}, {
    10269,
    "Comercial - Ventas > Comisiones > Tabla de comisiones > Duplicar"
}, {
    10270,
    "Comercial - Ventas > Comisiones > Tabla de comisiones > Eliminar"
}, {
    10271,
    "Comercial - Ventas > Comisiones > Tabla de comisiones > Modificar"
}, {
    10272,
    "Comercial - Ventas > Comisiones > Tabla de comisiones > Reporte"
}, {
    1794,
    "Comercial - Ventas > Consultas"
}, {
    4823,
    "Comercial - Ventas > Consultas > Compromisos"
}, {
    12009,
    "Comercial - Ventas > Consultas > Compromisos por grupo de compañías"
}, {
    7439,
    "Comercial - Ventas > Consultas > Compromisos > Modificar notas"
}, {
    1795,
    "Comercial - Ventas > Consultas > Cotizaciones"
}, {
    1841,
    "Comercial - Ventas > Consultas > Cotizaciones por item"
}, {
    7458,
    "Comercial - Ventas > Consultas > Cotizaciones > Seguimiento de documento"
}, {
    2945,
    "Comercial - Ventas > Consultas > Cubrimiento de pedidos"
}, {
    9610,
    "Comercial - Ventas > Consultas > Entidades de documentos"
}, {
    12025,
    "Comercial - Ventas > Consultas > Facturas ágil"
}, {
    12026,
    "Comercial - Ventas > Consultas > Facturas ágil por ítem"
}, {
    1798,
    "Comercial - Ventas > Consultas > Facturas y notas"
}, {
    1844,
    "Comercial - Ventas > Consultas > Facturas y notas por item"
}, {
    7450,
    "Comercial - Ventas > Consultas > Facturas y notas por item > Modificar notas"
}, {
    10019,
    "Comercial - Ventas > Consultas > Facturas y notas por item > Modificar notas > Permitir modificar el vendedor"
}, {
    7440,
    "Comercial - Ventas > Consultas > Facturas y notas > Modificar notas"
}, {
    7443,
    "Comercial - Ventas > Consultas > Facturas y notas > Modificar notas > Permitir modificar cargue"
}, {
    7442,
    "Comercial - Ventas > Consultas > Facturas y notas > Modificar notas > Permitir modificar notas"
}, {
    7444,
    "Comercial - Ventas > Consultas > Facturas y notas > Modificar notas > Permitir modificar número de la OC"
}, {
    7441,
    "Comercial - Ventas > Consultas > Facturas y notas > Modificar notas > Permitir modificar referencias"
}, {
    1923,
    "Comercial - Ventas > Consultas > Facturas y notas resumen"
}, {
    7461,
    "Comercial - Ventas > Consultas > Facturas y notas > Seguimiento de documento"
}, {
    6990,
    "Comercial - Ventas > Consultas > Facturas y notas diferidas"
}, {
    7445,
    "Comercial - Ventas > Consultas > Facturas y notas diferidas > Modificar notas"
}, {
    7448,
    "Comercial - Ventas > Consultas > Facturas y notas diferidas > Modificar notas > Permitir modificar cargue"
}, {
    7447,
    "Comercial - Ventas > Consultas > Facturas y notas diferidas > Modificar notas > Permitir modificar notas"
}, {
    7449,
    "Comercial - Ventas > Consultas > Facturas y notas diferidas > Modificar notas > Permitir modificar número de OC"
}, {
    7446,
    "Comercial - Ventas > Consultas > Facturas y notas diferidas > Modificar notas > Permitir modificar referencia"
}, {
    6991,
    "Comercial - Ventas > Consultas > Facturas y notas diferidas por item"
}, {
    9699,
    "Comercial - Ventas > Consultas > Facturas y notas por ítem - serial"
}, {
    6673,
    "Comercial - Ventas > Consultas > Facturas pendientes de planillas de cuadre"
}, {
    7459,
    "Comercial - Ventas > Consultas > Facturas pendientes de planillas de cuadre > Seguimiento de documento"
}, {
    7732,
    "Comercial - Ventas > Consultas > Libro diario de ventas > Siempre presentar prefijo"
}, {
    7731,
    "Comercial - Ventas > Consultas > Libro diario de ventas > Validar que no existan documentos en elaboración"
}, {
    2641,
    "Comercial - Ventas > Consultas > Libro diario de ventas"
}, {
    7629,
    "Comercial - Ventas > Consultas > Lista de precios por cliente"
}, {
    1927,
    "Comercial - Ventas > Consultas > Lista de precios por item"
}, {
    1928,
    "Comercial - Ventas > Consultas > Lista de precios por item columnario"
}, {
    4330,
    "Comercial - Ventas > Consultas > Planilla de cuadre de facturas"
}, {
    1796,
    "Comercial - Ventas > Consultas > Pedidos"
}, {
    1842,
    "Comercial - Ventas > Consultas > Pedidos por item"
}, {
    7451,
    "Comercial - Ventas > Consultas > Pedidos por item > Modificar notas"
}, {
    8082,
    "Comercial - Ventas > Consultas > Pedidos por item > Modificar notas > Permitir modificar la fecha de entrega"
}, {
    7463,
    "Comercial - Ventas > Consultas > Pedidos > Seguimiento de documento"
}, {
    3308,
    "Comercial - Ventas > Consultas > Planilla de cuadre"
}, {
    3757,
    "Comercial - Ventas > Consultas > Planilla de cuadre por documentos"
}, {
    4763,
    "Comercial - Ventas > Consultas > Planilla de cuadre por ítem"
}, {
    9612,
    "Comercial - Ventas > Presupuesto controlado > Consultas > Presupuesto no controlado ejecución"
}, {
    9611,
    "Comercial - Ventas > Presupuesto controlado > Consultas > Presupuesto no controlado movimiento"
}, {
    12027,
    "Comercial - Ventas > Consultas > Remisiones ágil pendientes"
}, {
    1797,
    "Comercial - Ventas > Consultas > Remisiones y devoluciones"
}, {
    1845,
    "Comercial - Ventas > Consultas > Remisiones y devoluciones por item"
}, {
    1925,
    "Comercial - Ventas > Consultas > Remisiones y devoluciones resumen"
}, {
    11239,
    "Comercial - Ventas > Consultas > Remisiones y devoluciones por ítem - serial"
}, {
    7452,
    "Comercial - Ventas > Consultas > Remisiones y devoluciones > Modificar notas"
}, {
    7455,
    "Comercial - Ventas > Consultas > Remisiones y devoluciones > Modificar notas > Permitir modificar cargue"
}, {
    7454,
    "Comercial - Ventas > Consultas > Remisiones y devoluciones > Modificar notas > Permitir modificar notas"
}, {
    7456,
    "Comercial - Ventas > Consultas > Remisiones y devoluciones > Modificar notas > Permitir modificar número de la OC"
}, {
    7453,
    "Comercial - Ventas > Consultas > Remisiones y devoluciones > Modificar notas > Permitir modificar referencia"
}, {
    7460,
    "Comercial - Ventas > Consultas > Remisiones y devoluciones > Seguimiento de documento"
}, {
    7457,
    "Comercial - Ventas > Consultas > Remisiones y devoluciones por item > Modificar notas"
}, {
    10020,
    "Comercial - Ventas > Consultas > Remisiones y devoluciones por item > Modificar notas > Permitir modificar el vendedor"
}, {
    9191,
    "Comercial - Ventas > Consultas > Reporte de seriales"
}, {
    6992,
    "Comercial - Ventas > Consultas > Resumen de facturas y notas diferidas"
}, {
    3194,
    "Comercial - Ventas > Consultas > Seguimiento de documentos"
}, {
    10702,
    "Comercial - Ventas > Consultas > Compromisos por ubicación, lote y seriales"
}, {
    4463,
    "Comercial - Ventas > Consultas > Validación de facturas"
}, {
    10018,
    "Comercial - Ventas > Consultas > Pedidos por item > Modificar notas > Permitir modificar el vendedor"
}, {
    1628,
    "Comercial - Ventas > Cotizaciones"
}, {
    1629,
    "Comercial - Ventas > Cotizaciones > Adicionar"
}, {
    1633,
    "Comercial - Ventas > Cotizaciones > Anular"
}, {
    1632,
    "Comercial - Ventas > Cotizaciones > Aprobar"
}, {
    3495,
    "Comercial - Ventas > Cotizaciones > Calcular análisis cupo para doctos en elaboración"
}, {
    1631,
    "Comercial - Ventas > Cotizaciones > Consultar"
}, {
    12031,
    "Comercial - Ventas > Cotizaciones > Dar por perdida"
}, {
    8079,
    "Comercial - Ventas > Cotizaciones > Duplicar"
}, {
    10437,
    "Comercial - Ventas > Cotizaciones > Elegir por defecto indicador de notas"
}, {
    4666,
    "Comercial - Ventas > Cotizaciones > Exceder margen"
}, {
    1638,
    "Comercial - Ventas > Cotizaciones > Generar pedidos"
}, {
    1635,
    "Comercial - Ventas > Habilitar impresión documentos > Habilitar impresión cotizaciones"
}, {
    1634,
    "Comercial - Ventas > Imprimir documentos > Imprimir cotizaciones"
}, {
    1630,
    "Comercial - Ventas > Cotizaciones > Modificar"
}, {
    1636,
    "Comercial - Ventas > Cotizaciones > Modificar condiciones de venta"
}, {
    1640,
    "Comercial - Ventas > Cotizaciones > Modificar descuentos"
}, {
    1639,
    "Comercial - Ventas > Cotizaciones > Modificar precios"
}, {
    4278,
    "Comercial - Ventas > Cotizaciones > Modificar entidades dinámicas en doctos aprobados"
}, {
    3929,
    "Comercial - Ventas > Cotizaciones > Permitir obserquiar paquetes"
}, {
    12032,
    "Comercial - Ventas > Cotizaciones > Perdida"
}, {
    1637,
    "Comercial - Ventas > Cotizaciones > Permitir clientes ocasionales"
}, {
    6946,
    "Comercial - Ventas > Cotizaciones > Permitir adicionar ítems sin modificar docto"
}, {
    8711,
    "Comercial - Ventas > Cotizaciones > Presentar disponibles"
}, {
    12033,
    "Comercial - Ventas > Cotizaciones > Reversar perdida"
}, {
    1641,
    "Comercial - Ventas > Cotizaciones > Seleccionar descuentos exclusivos"
}, {
    8760,
    "Comercial - Ventas > Cotizaciones > Sugerir el último centro de costo capturado"
}, {
    8971,
    "Comercial - Ventas > Cotizaciones > Validar la captura del campo \"Entrega en\""
}, {
    10191,
    "Comercial - Ventas > Cotizaciones > Validar la fecha de vencimiento al generar pedido"
}, {
    1751,
    "Comercial - Ventas > Devoluciones > Directas"
}, {
    1765,
    "Comercial - Ventas > Devoluciones > Generales > Adicionar"
}, {
    1766,
    "Comercial - Ventas > Devoluciones > Generales > Anular"
}, {
    1767,
    "Comercial - Ventas > Devoluciones > Generales > Aprobar"
}, {
    11156,
    "Comercial - Ventas > Devoluciones > Generales > Asumir costos estándar para ítem sin costo"
}, {
    1768,
    "Comercial - Ventas > Devoluciones > Generales > Consultar"
}, {
    1788,
    "Comercial - Ventas > Devoluciones > Desde remisiones"
}, {
    3269,
    "Comercial - Ventas > Devoluciones > Directas > Liquidar descuentos vigentes"
}, {
    1769,
    "Comercial - Ventas > Devoluciones > Generales > Facturar"
}, {
    1770,
    "Comercial - Ventas > Habilitar impresión documentos > Habilitar impresión devoluciones"
}, {
    1771,
    "Comercial - Ventas > Imprimir documentos > Imprimir devoluciones"
}, {
    1772,
    "Comercial - Ventas > Devoluciones > Generales > Modificar"
}, {
    1773,
    "Comercial - Ventas > Devoluciones > Generales > Modificar condiciones de venta"
}, {
    1774,
    "Comercial - Ventas > Devoluciones > Generales > Modificar descuentos"
}, {
    1775,
    "Comercial - Ventas > Devoluciones > Generales > Modificar precios"
}, {
    4031,
    "Comercial - Ventas > Devoluciones > Generales > Modificar entidades dinámicas en doctos aprobados"
}, {
    11157,
    "Comercial - Ventas > Devoluciones > Generales > Obligar que la transacción genere costo"
}, {
    1776,
    "Comercial - Ventas > Devoluciones > Generales > Permitir clientes ocasionales"
}, {
    1777,
    "Comercial - Ventas > Devoluciones > Generales > Seleccionar descuentos exclusivos"
}, {
    9736,
    "Comercial - Ventas > Devoluciones > Generales > Sugerir lote"
}, {
    9735,
    "Comercial - Ventas > Devoluciones > Generales > Sugerir ubicación de salida"
}, {
    11933,
    "Comercial - Ventas > Dispensación"
}, {
    11934,
    "Comercial - Ventas > Dispensación > RIPS"
}, {
    1554,
    "Comercial - Ventas > Descuentos"
}, {
    1557,
    "Comercial - Ventas > Descuentos > Actualizar descuentos manuales"
}, {
    3498,
    "Comercial - Ventas > Descuentos > Buscar listas de precios"
}, {
    1556,
    "Comercial - Ventas > Descuentos > Eliminar descuentos automáticos"
}, {
    6422,
    "Comercial - Ventas > Descuentos > Permitir descuentos globales"
}, {
    1555,
    "Comercial - Ventas > Descuentos > Seleccionar descuentos exclusivos"
}, {
    6986,
    "Comercial - Ventas > Facturas"
}, {
    11755,
    "Comercial - Ventas > Facturas > Ágil"
}, {
    11876,
    "Comercial - Ventas > Facturas > Ágil > Adicionar"
}, {
    11877,
    "Comercial - Ventas > Facturas > Ágil > Anular"
}, {
    12484,
    "Comercial - Ventas > Facturas > Ágil > Anulación de pendientes"
}, {
    11883,
    "Comercial - Ventas > Facturas > Ágil > Confirmar anular"
}, {
    11874,
    "Comercial - Ventas > Facturas > Ágil > Congelar"
}, {
    11878,
    "Comercial - Ventas > Facturas > Ágil > Consultar"
}, {
    11875,
    "Comercial - Ventas > Facturas > Ágil > Descongelar"
}, {
    11879,
    "Comercial - Ventas > Facturas > Ágil > Habilitar impresión"
}, {
    11880,
    "Comercial - Ventas > Facturas > Ágil > Imprimir"
}, {
    11881,
    "Comercial - Ventas > Facturas > Ágil > Modificar"
}, {
    11882,
    "Comercial - Ventas > Facturas > Ágil > Totalizar"
}, {
    8205,
    "-No implementado > Desde nota crédito"
}, {
    6987,
    "Comercial - Ventas > Facturas > Desde pedidos diferidos"
}, {
    6994,
    "Comercial - Ventas > Facturas > Desde pedidos diferidos > Adicionar"
}, {
    6995,
    "Comercial - Ventas > Facturas > Desde pedidos diferidos > Anular"
}, {
    6996,
    "Comercial - Ventas > Facturas > Desde pedidos diferidos > Aprobar"
}, {
    6997,
    "Comercial - Ventas > Facturas > Desde pedidos diferidos > Consultar"
}, {
    6998,
    "Comercial - Ventas > Facturas > Desde pedidos diferidos > Habilitar impresion"
}, {
    6999,
    "Comercial - Ventas > Facturas > Desde pedidos diferidos > Imprimir"
}, {
    7000,
    "Comercial - Ventas > Facturas > Desde pedidos diferidos > Modificar"
}, {
    7001,
    "Comercial - Ventas > Facturas > Desde pedidos diferidos > Modificar cuentas por cobrar"
}, {
    7002,
    "Comercial - Ventas > Facturas > Desde pedidos diferidos > Modificar entidades dinamicas en doctos aprobados"
}, {
    7003,
    "Comercial - Ventas > Facturas > Desde pedidos diferidos > Modificar retenciones"
}, {
    7007,
    "Comercial - Ventas > Facturas > Desde pedidos diferidos > Permitir anticipos de otro C.O."
}, {
    7004,
    "Comercial - Ventas > Facturas > Desde pedidos diferidos > Permitir anticipos de otro auxiliar de anticipos"
}, {
    7005,
    "Comercial - Ventas > Facturas > Desde pedidos diferidos > Permitir anticipos de otra sucursal"
}, {
    7006,
    "Comercial - Ventas > Facturas > Desde pedidos diferidos > Permitir anticipos de otra U.N."
}, {
    8401,
    "Comercial - Ventas > Facturas > Desde pedidos diferidos > Permitir generar factura con forma de pago contado"
}, {
    11016,
    "Comercial - Ventas > Facturas > Desde pedidos diferidos > Presentar mensaje de remisión despacho al aprobar"
}, {
    8821,
    "Comercial - Ventas > Facturas > Permitir distribuir la cartera al contabilizar"
}, {
    8649,
    "Comercial - Ventas > Facturas > Utilizar las notas digitadas en las generación"
}, {
    11371,
    "Comercial - Ventas > Facturas > No obligar información de las tarjetas en recaudos"
}, {
    11370,
    "Comercial - Ventas > Facturas > Sugerir el valor por aplicar en recaudos"
}, {
    11441,
    "Comercial - Ventas > Facturas > Validar cupo y mora al adicionar ítem desde fletes"
}, {
    1908,
    "Comercial - Ventas > Facturas > Desde pedidos"
}, {
    1910,
    "Comercial - Ventas > Facturas > Desde pedidos > Adicionar"
}, {
    2985,
    "Comercial - Ventas > Facturas > Desde pedidos > Alterar descuentos"
}, {
    2986,
    "Comercial - Ventas > Facturas > Desde pedidos > Alterar precios"
}, {
    4374,
    "Comercial - Ventas > Facturas > Desde pedidos > Permitir anticipos de otra auxiliar de anticipos"
}, {
    3218,
    "Comercial - Ventas > Facturas > Desde pedidos > Permitir anticipos de otra sucursal"
}, {
    3125,
    "Comercial - Ventas > Facturas > Desde pedidos > Permitir anticipos de otra U.N."
}, {
    3126,
    "Comercial - Ventas > Facturas > Desde pedidos > Permitir anticipos de otro C.O."
}, {
    1911,
    "Comercial - Ventas > Facturas > Desde pedidos > Anular"
}, {
    1912,
    "Comercial - Ventas > Facturas > Desde pedidos > Aprobar"
}, {
    10206,
    "Comercial - Ventas > Facturas > Desde pedidos > Asignar la bodega de ventas desde las preferencias"
}, {
    3302,
    "Comercial - Ventas > Facturas > Desde pedidos > Borrar cargue"
}, {
    8417,
    "Comercial - Ventas > Facturas > Desde pedidos > Captura bodega según maestros por usuarios"
}, {
    7835,
    "Comercial - Ventas > Facturas > Desde pedidos > Permitir comprometer y descomprometer"
}, {
    1913,
    "Comercial - Ventas > Facturas > Desde pedidos > Consultar"
}, {
    10469,
    "Comercial - Ventas > Facturas > Desde pedidos > Al generar ubicarse por defecto en CxC o recaudo"
}, {
    2989,
    "Comercial - Ventas > Facturas > Desde pedidos > Seleccionar descuentos exclusivos"
}, {
    11636,
    "Comercial - Ventas > Facturas > Desde pedidos > Presentar por despachar en unidad de inventario"
}, {
    8375,
    "Comercial - Ventas > Facturas > Desde pedidos > Permitir generar factura con forma de pago contado"
}, {
    1914,
    "Comercial - Ventas > Facturas > Desde pedidos > Habilitar impresión"
}, {
    11155,
    "Comercial - Ventas > Facturas > Desde pedidos > Permitir heredar el CO al movimiento y cartera"
}, {
    1915,
    "Comercial - Ventas > Facturas > Desde pedidos > Imprimir"
}, {
    12480,
    "Comercial - Ventas > Facturas > Desde pedidos > Imprimir al generar"
}, {
    1916,
    "Comercial - Ventas > Facturas > Desde pedidos > Modificar"
}, {
    2987,
    "Comercial - Ventas > Facturas > Desde pedidos > Modificar condiciones de venta"
}, {
    1918,
    "Comercial - Ventas > Facturas > Desde pedidos > Modificar cuentas por cobrar"
}, {
    4106,
    "Comercial - Ventas > Facturas > Desde pedidos > Modificar entidades dinamicas en doctos aprobados"
}, {
    1917,
    "Comercial - Ventas > Facturas > Desde pedidos > Modificar retenciones"
}, {
    2988,
    "Comercial - Ventas > Facturas > Desde pedidos > Permite clientes ocasionales"
}, {
    8382,
    "Comercial - Ventas > Facturas > Desde pedidos > Validar fecha del pedido"
}, {
    1850,
    "Comercial - Ventas > Facturas > Desde remisión"
}, {
    1793,
    "Comercial - Ventas > Facturas > Desde remisión > Adicionar"
}, {
    4375,
    "Comercial - Ventas > Facturas > Desde remisión > Permitir anticipos de otra auxiliar de anticipos"
}, {
    3219,
    "Comercial - Ventas > Facturas > Desde remisión > Permitir anticipos de otra sucursal"
}, {
    3127,
    "Comercial - Ventas > Facturas > Desde remisión > Permitir anticipos de otra U.N."
}, {
    3128,
    "Comercial - Ventas > Facturas > Desde remisión > Permitir anticipos de otro C.O."
}, {
    1858,
    "Comercial - Ventas > Facturas > Desde remisión > Anular"
}, {
    1857,
    "Comercial - Ventas > Facturas > Desde remisión > Aprobar"
}, {
    1856,
    "Comercial - Ventas > Facturas > Desde remisión > Consultar"
}, {
    8376,
    "Comercial - Ventas > Facturas > Desde remisión > Permitir generar factura con forma de pago contado"
}, {
    1860,
    "Comercial - Ventas > Facturas > Desde remisión > Habilitar impresión"
}, {
    1859,
    "Comercial - Ventas > Facturas > Desde remisión > Imprimir"
}, {
    1855,
    "Comercial - Ventas > Facturas > Desde remisión > Modificar"
}, {
    1862,
    "Comercial - Ventas > Facturas > Desde remisión > Modificar cuentas por cobrar"
}, {
    4107,
    "Comercial - Ventas > Facturas > Desde remisión > Modificar entidades dinamicas en doctos aprobados"
}, {
    1861,
    "Comercial - Ventas > Facturas > Desde remisión > Modificar retenciones"
}, {
    12245,
    "Comercial - Ventas > Facturas > Desde remisión > Presentar resumen por ítem al generar"
}, {
    7130,
    "Comercial - Ventas > Facturas > Desde remisión > Validar si la remisión tiene devoluciones"
}, {
    8383,
    "Comercial - Ventas > Facturas > Desde remisión > Validar fecha de la remisión"
}, {
    1851,
    "Comercial - Ventas > Facturas directas"
}, {
    11884,
    "Comercial - Ventas > Facturas directas > Actualizar movimientos grabados al adicionar"
}, {
    1871,
    "Comercial - Ventas > Facturas directas > Adicionar"
}, {
    1881,
    "Comercial - Ventas > Facturas directas > Alterar descuentos"
}, {
    1880,
    "Comercial - Ventas > Facturas directas > Alterar precios"
}, {
    4376,
    "Comercial - Ventas > Facturas directas > Permitir anticipos de otra auxiliar de anticipos"
}, {
    3217,
    "Comercial - Ventas > Facturas directas > Permitir anticipos de otra sucursal"
}, {
    3129,
    "Comercial - Ventas > Facturas directas > Permitir anticipos de otra U.N."
}, {
    3130,
    "Comercial - Ventas > Facturas directas > Permitir anticipos de otro C.O."
}, {
    1875,
    "Comercial - Ventas > Facturas directas > Anular"
}, {
    3717,
    "Comercial - Ventas > Facturas directas > Anular facturas sin imprimir"
}, {
    1874,
    "Comercial - Ventas > Facturas directas > Aprobar"
}, {
    7462,
    "Comercial - Ventas > Facturas directas > Cambiar lista de precio del cliente"
}, {
    10892,
    "Comercial - Ventas > Facturas directas > Permitir cambiar instrumento financiero sugerido"
}, {
    8001,
    "Comercial - Ventas > Facturas directas > Permitir cambiar pronto pago"
}, {
    9705,
    "Comercial - Ventas > Facturas directas > Permitir capturar instrumento financiero"
}, {
    3373,
    "Comercial - Ventas > Facturas directas > Permitir capturar vehiculos"
}, {
    1873,
    "Comercial - Ventas > Facturas directas > Consultar"
}, {
    1882,
    "Comercial - Ventas > Facturas directas > Seleccionar descuentos exclusivos"
}, {
    1877,
    "Comercial - Ventas > Habilitar impresión documentos > Habilitar impresión facturas"
}, {
    1876,
    "Comercial - Ventas > Imprimir documentos > Imprimir facturas"
}, {
    1872,
    "Comercial - Ventas > Facturas directas > Modificar"
}, {
    1878,
    "Comercial - Ventas > Facturas directas > Modificar condiciones de venta"
}, {
    1884,
    "Comercial - Ventas > Facturas directas > Modificar cuentas por cobrar"
}, {
    4108,
    "Comercial - Ventas > Facturas directas > Modificar entidades dinamicas en doctos aprobados"
}, {
    8085,
    "Comercial - Ventas > Facturas directas > Modificar recaudos de contado"
}, {
    1883,
    "Comercial - Ventas > Facturas directas > Modificar retenciones"
}, {
    3727,
    "Comercial - Ventas > Facturas directas > Modificar vendedor"
}, {
    1879,
    "Comercial - Ventas > Facturas directas > Permitir clientes ocasionales"
}, {
    3470,
    "Comercial - Ventas > Facturas directas > Permitir facturas de contado"
}, {
    10188,
    "Comercial - Ventas > Facturas directas > Sugerir lote próximo a vencer o más antiguo"
}, {
    3948,
    "Comercial - Ventas > Facturas > Modificar datos basicos"
}, {
    3952,
    "Comercial - Ventas > Facturas > Modificar datos basicos > Cargue"
}, {
    3949,
    "Comercial - Ventas > Facturas > Modificar datos basicos > Condición de pago"
}, {
    3999,
    "Comercial - Ventas > Facturas > Modificar datos basicos > Notas"
}, {
    3951,
    "Comercial - Ventas > Facturas > Modificar datos basicos > Número de OC"
}, {
    7833,
    "Comercial - Ventas > Facturas > Modificar datos basicos > Punto de envio"
}, {
    3950,
    "Comercial - Ventas > Facturas > Modificar datos basicos > Referencia"
}, {
    4000,
    "Comercial - Ventas > Facturas > Modificar datos basicos > Transportador"
}, {
    7019,
    "Comercial - Ventas > Facturas > Modificar datos basicos > Vendedor"
}, {
    4855,
    "Comercial - Ventas > Imprimir documentos > Generar factura electrónica"
}, {
    3766,
    "Comercial - Ventas > Generales"
}, {
    3947,
    "Comercial - Ventas > Generales > Cambiar condición de pago segun nivel de recaudo"
}, {
    12596,
    "Comercial - Ventas > Generales > Permitir cambiar generación automática de CxC"
}, {
    10980,
    "Comercial - Ventas > Generales > La cantidad debe ser múltiplo de la UM de empaque"
}, {
    8378,
    "Comercial - Ventas > Generales > Capturar tercero vendedores en consultas"
}, {
    3920,
    "Comercial - Ventas > Generales > Capturar cant. en unidades de empaque e inventario"
}, {
    6675,
    "Comercial - Ventas > Generales > Permitir modificar cuotas hacia abajo"
}, {
    6674,
    "Comercial - Ventas > Generales > Permitir modificar cuotas hacia arriba"
}, {
    3861,
    "Comercial - Ventas > Generales > Filtrar el cliente con el C.O. del documento"
}, {
    12597,
    "Comercial - Ventas > Generales > Habilitar fecha de vencimiento de CxC"
}, {
    8389,
    "Comercial - Ventas > Generales > Presentar el margen en la captura de documentos"
}, {
    3867,
    "Comercial - Ventas > Generales > Permitir modificar C.Costo de la CxC"
}, {
    3868,
    "Comercial - Ventas > Generales > Permitir modificar U.N. de la CxC"
}, {
    7090,
    "Comercial - Ventas > Generales > Permitir modificar valor impuesto en recaudos"
}, {
    6962,
    "Comercial - Ventas > Generales > No obligar la guia en el trasportador"
}, {
    7756,
    "Comercial - Ventas > Generales > No obligar valor impuesto en recaudos"
}, {
    7745,
    "Comercial - Ventas > Generales > Permitir anular con fecha de aprobación diferente"
}, {
    10836,
    "Comercial - Ventas > Generales > Permitir autorización topes en descuento"
}, {
    12563,
    "-No implementado > Permitir cambiar CxC"
}, {
    4860,
    "Comercial - Ventas > Generales > Presentar costos en las consultas de ventas"
}, {
    6773,
    "Comercial - Ventas > Generales > Solicitar notas en generación de remisiones y fact"
}, {
    3767,
    "Comercial - Ventas > Generales > Solicitar transportador en documentos"
}, {
    3096,
    "Comercial - Ventas > Devoluciones"
}, {
    6993,
    "Comercial - Ventas > Devoluciones > Desde remisiones diferidas"
}, {
    3098,
    "Comercial - Ventas > Devoluciones > Desde remisiones no facturables"
}, {
    3097,
    "Comercial - Ventas > Devoluciones > Generales"
}, {
    11691,
    "Comercial - Ventas > Devoluciones > Generales > Sugerir Causal"
}, {
    3099,
    "Comercial - Ventas > Devoluciones > No facturables"
}, {
    3089,
    "Comercial - Ventas > Pedidos"
}, {
    11306,
    "Comercial - Ventas > Pedidos > Generales > Leer anticipos según maestro por usuario de Tipo"
}, {
    3091,
    "Comercial - Ventas > Pedidos > Aprobar > Por compañía"
}, {
    3366,
    "Comercial - Ventas > Pedidos > Aprobar > Por compañía > Aprobar cartera"
}, {
    4879,
    "Comercial - Ventas > Pedidos > Aprobar > Por compañía > Aprobar cartera > No controlar parámetros de aprobación por usuario"
}, {
    12304,
    "Comercial - Ventas > Pedidos > Aprobar > Por compañía > Aprobar cartera > Al aprobar por mora revalidar el cupo"
}, {
    10776,
    "Comercial - Ventas > Pedidos > Aprobar"
}, {
    10777,
    "Comercial - Ventas > Pedidos > Aprobar > Por grupo de compañía"
}, {
    3367,
    "Comercial - Ventas > Pedidos > Aprobar > Por compañía > Aprobar margen"
}, {
    10187,
    "Comercial - Ventas > Pedidos > Aprobar > Por compañía > Aprobar monto mínimo"
}, {
    8047,
    "Comercial - Ventas > Pedidos > Aprobar > Por compañía > Recalcular fecha entrega al aprobar aútomatico"
}, {
    8046,
    "Comercial - Ventas > Pedidos > Aprobar > Por compañía > Recalcular fecha entrega al aprobar manualmente"
}, {
    8911,
    "Comercial - Ventas > Pedidos > Aprobar pedidos por cupo para despacho"
}, {
    10264,
    "Comercial - Ventas > Pedidos > Aprobar pedidos por cupo para despacho > Aprobar manualmente"
}, {
    12052,
    "Comercial - Ventas > Pedidos > Cambiar fechas de entrega"
}, {
    10718,
    "Comercial - Ventas > Pedidos > Comprometer cantidad parcial al comprometer"
}, {
    11255,
    "Comercial - Ventas > Pedidos > Generales > Presentación > Abrir captura de ítems al seleccionar el cliente"
}, {
    3092,
    "Comercial - Ventas > Pedidos > Comprometer"
}, {
    4736,
    "Comercial - Ventas > Pedidos > Generales > Comprometer parciales"
}, {
    8651,
    "Comercial - Ventas > Pedidos > Comprometer con cambio de bodegas"
}, {
    3093,
    "Comercial - Ventas > Pedidos > Dar por cumplido"
}, {
    7836,
    "Comercial - Ventas > Pedidos > Dar por cumplido > Permitir reversar cumplido"
}, {
    7535,
    "Comercial - Ventas > Pedidos > Para devolución"
}, {
    3090,
    "Comercial - Ventas > Pedidos > Generales"
}, {
    7027,
    "Comercial - Ventas > Pedidos > Generales > Permitir cambiar bodegas en compromisos"
}, {
    8912,
    "Comercial - Ventas > Pedidos > Generales > Permitir cambiar componente del paquete por equiv"
}, {
    8202,
    "Comercial - Ventas > Pedidos > Generales > Controlar fecha pedido igual fecha sistema"
}, {
    8552,
    "Comercial - Ventas > Pedidos > Generales > Descomprometer"
}, {
    10470,
    "Comercial - Ventas > Pedidos > Generales > Presentación > Expandir la sección de descuentos en los ítems"
}, {
    9108,
    "Comercial - Ventas > Pedidos > Generales > Permitir facturar desde otro CO."
}, {
    7064,
    "Comercial - Ventas > Pedidos > Generales > Pedir filtro en los compromisos automáticos"
}, {
    10468,
    "Comercial - Ventas > Pedidos > Generales > Presentación > Sugerir por defecto pestaña de generales -adición"
}, {
    11199,
    "Comercial - Ventas > Pedidos > Generales > Sugerir el último proyecto capturado"
}, {
    3368,
    "Comercial - Ventas > Pedidos > Generales > Validar número de orden de compra"
}, {
    8419,
    "Comercial - Ventas > Pedidos > Generales > Validar capacidad del cargue"
}, {
    10920,
    "Comercial - Ventas > Pedidos > Generales > Siempre permitir condiciones de pago crédito"
}, {
    11833,
    "Comercial - Ventas > Pedidos > Generales > Adicionar pedido directo"
}, {
    9192,
    "Comercial - Ventas > Pedidos > Generales > Permitir duplicar pedidos cumplidos"
}, {
    9193,
    "Comercial - Ventas > Pedidos > Generales > Comprometer todo el lote en ítems con UM inv"
}, {
    11873,
    "Comercial - Ventas > Pedidos > Generales > Validar registros duplicados"
}, {
    3458,
    "Comercial - Ventas > Pedidos > Generales > Restringe compromiso ítem con lote y unidad adic."
}, {
    8888,
    "Comercial - Ventas > Pedidos > Generales > La cantidad debe ser múltiplo de la UM de empaque"
}, {
    3459,
    "Comercial - Ventas > Pedidos > Generales > Modificar datos basicos"
}, {
    8710,
    "Comercial - Ventas > Pedidos > Generales > Modificar datos basicos > Backorder"
}, {
    4825,
    "Comercial - Ventas > Pedidos > Generales > Modificar datos basicos > Cliente despacho"
}, {
    4824,
    "Comercial - Ventas > Pedidos > Generales > Modificar datos basicos > Cliente factura"
}, {
    3463,
    "Comercial - Ventas > Pedidos > Generales > Modificar datos basicos > Condicion de pago"
}, {
    3467,
    "Comercial - Ventas > Pedidos > Generales > Modificar datos basicos > Condicion de pago > Permitir cambiar de contado a contado"
}, {
    3466,
    "Comercial - Ventas > Pedidos > Generales > Modificar datos basicos > Condicion de pago > Permitir cambiar de contado a crédito"
}, {
    3464,
    "Comercial - Ventas > Pedidos > Generales > Modificar datos basicos > Condicion de pago > Permitir cambiar de crédito a contado"
}, {
    3465,
    "Comercial - Ventas > Pedidos > Generales > Modificar datos basicos > Condicion de pago > Permitir cambiar de crédito a crédito"
}, {
    3461,
    "Comercial - Ventas > Pedidos > Generales > Modificar datos basicos > Fecha de entrega"
}, {
    6902,
    "Comercial - Ventas > Pedidos > Generales > Modificar datos basicos > Financiación"
}, {
    6901,
    "Comercial - Ventas > Pedidos > Generales > Modificar datos basicos > Notas"
}, {
    3460,
    "Comercial - Ventas > Pedidos > Generales > Modificar datos basicos > Permitir pedidos con despachos"
}, {
    7832,
    "Comercial - Ventas > Pedidos > Generales > Modificar datos basicos > Punto de envio"
}, {
    3462,
    "Comercial - Ventas > Pedidos > Generales > Modificar datos basicos > Vendedor"
}, {
    3114,
    "Comercial - Ventas > Pedidos > Importar EDI"
}, {
    6544,
    "Comercial - Ventas > Pedidos > Importar EDI > Borrar archivo al importar exitosamente"
}, {
    11035,
    "Comercial - Ventas > Pedidos > Importar EDI > Consulta de movimiento"
}, {
    3116,
    "Comercial - Ventas > Pedidos > Importar EDI > Eliminar"
}, {
    3115,
    "Comercial - Ventas > Pedidos > Importar EDI > Importar"
}, {
    3117,
    "Comercial - Ventas > Pedidos > Importar EDI > Log de importación"
}, {
    3723,
    "Comercial - Ventas > Pedidos > Importar EDI > Capturar parámetros EDI"
}, {
    12593,
    "Comercial - Ventas > Pedidos > Liberar anticipos"
}, {
    11369,
    "-No implementado > Presentar margen de los movimientos del documento"
}, {
    4040,
    "Comercial - Ventas > Pedidos > Modificar precios"
}, {
    3725,
    "Comercial - Ventas > Pedidos > Generales > Modificar vendedor"
}, {
    4820,
    "Comercial - Ventas > Pedidos > Generales > Permitir modificar cantidades de ítems con OP"
}, {
    12244,
    "Comercial - Ventas > Pedidos > Generales > No permitir modificar la dirección de envío"
}, {
    11377,
    "Comercial - Ventas > Pedidos > Generales > Presentación"
}, {
    11790,
    "Comercial - Ventas > Pedidos > Generales > Presentación > Presentar pantalla de extensiones completa"
}, {
    7154,
    "Comercial - Ventas > Pedidos > Recalcular pedidos"
}, {
    8759,
    "Comercial - Ventas > Pedidos > Generales > Sugerir el último centro de costo capturado"
}, {
    3122,
    "Comercial - Ventas > Pedidos > Transferencia de pedidos"
}, {
    8423,
    "Comercial - Ventas > Pedidos > Transferencia de pedidos > Permirtir generar pedidos en otra moneda"
}, {
    3720,
    "Comercial - Ventas > Pedidos > Transferencia de pedidos > Permitir transferir ítems sin disponible"
}, {
    4001,
    "Comercial - Ventas > Pedidos > Transferencia de pedidos > Permitir pedidos en elaboración"
}, {
    4003,
    "Comercial - Ventas > Pedidos > Transferencia de pedidos > Sugerir recalculo de descuentos"
}, {
    4002,
    "Comercial - Ventas > Pedidos > Transferencia de pedidos > Sugerir recalculo de precios"
}, {
    11256,
    "Comercial - Ventas > Pedidos > Generales > Presentación > Ubicarse en descripción del ítem al adicionar"
}, {
    9939,
    "Comercial - Ventas > Pedidos > Validar la captura del campo Entrega en"
}, {
    3496,
    "Comercial - Ventas > Pedidos > Generales > Calcular análisis cupo para doctos en elaboración"
}, {
    3094,
    "Comercial - Ventas > Remisiones"
}, {
    6985,
    "Comercial - Ventas > Remisiones > Desde pedidos diferidos"
}, {
    3095,
    "Comercial - Ventas > Remisiones > Generales"
}, {
    12481,
    "Comercial - Ventas > Pedidos > Comprometer > Permitir compromisos manuales de servicios"
}, {
    10183,
    "Comercial - Ventas > Pedidos > Comprometer > No excluir pedidos que solo tengan UM adicional"
}, {
    2158,
    "Comercial - Ventas > Habilitar impresión documentos"
}, {
    6550,
    "Comercial - Ventas > Imprimir documentos > Impresora fiscal"
}, {
    2157,
    "Comercial - Ventas > Imprimir documentos"
}, {
    6988,
    "Comercial - Ventas > Notas CR"
}, {
    8203,
    "Comercial - Ventas > Notas CR > Desde descuentos condicionados"
}, {
    1852,
    "Comercial - Ventas > Notas CR > Desde devolución"
}, {
    1838,
    "Comercial - Ventas > Notas CR > Desde devolución > Adicionar"
}, {
    1866,
    "Comercial - Ventas > Notas CR > Desde devolución > Anular"
}, {
    1865,
    "Comercial - Ventas > Notas CR > Desde devolución > Aprobar"
}, {
    1864,
    "Comercial - Ventas > Notas CR > Desde devolución > Consultar"
}, {
    9112,
    "Comercial - Ventas > Notas CR > Desde devolución > Cruzar con la factura de la devolución"
}, {
    3103,
    "Comercial - Ventas > Notas CR > Desde devolución > Capturar cxc en transacciones de contado"
}, {
    1868,
    "Comercial - Ventas > Notas CR > Desde devolución > Habilitar impresión"
}, {
    1867,
    "Comercial - Ventas > Notas CR > Desde devolución > Imprimir"
}, {
    1863,
    "Comercial - Ventas > Notas CR > Desde devolución > Modificar"
}, {
    1870,
    "Comercial - Ventas > Notas CR > Desde devolución > Modificar cuentas por cobrar"
}, {
    4103,
    "Comercial - Ventas > Notas CR > Desde devolución > Modificar entidades dinamicas en doctos aprobados"
}, {
    1869,
    "Comercial - Ventas > Notas CR > Desde devolución > Modificar retenciones"
}, {
    1854,
    "Comercial - Ventas > Notas CR > Desde facturas"
}, {
    1899,
    "Comercial - Ventas > Notas CR > Desde facturas > Adicionar"
}, {
    1903,
    "Comercial - Ventas > Notas CR > Desde facturas > Anular"
}, {
    1902,
    "Comercial - Ventas > Notas CR > Desde facturas > Aprobar"
}, {
    11196,
    "Comercial - Ventas > Notas CR > Desde facturas > Permitir aprobar Nota con mes de factura diferente"
}, {
    11870,
    "Comercial - Ventas > Notas CR > Desde facturas > Asumir costos de la factura"
}, {
    1901,
    "Comercial - Ventas > Notas CR > Desde facturas > Consultar"
}, {
    3104,
    "Comercial - Ventas > Notas CR > Desde facturas > Capturar cxc en transacciones de contado"
}, {
    7113,
    "Comercial - Ventas > Notas CR > Desde facturas > Generar automático"
}, {
    10837,
    "Comercial - Ventas > Notas CR > Desde facturas > Permitir generar anticipos"
}, {
    1905,
    "Comercial - Ventas > Notas CR > Desde facturas > Habilitar impresión"
}, {
    1904,
    "Comercial - Ventas > Notas CR > Desde facturas > Imprimir"
}, {
    1900,
    "Comercial - Ventas > Notas CR > Desde facturas > Modificar"
}, {
    1907,
    "Comercial - Ventas > Notas CR > Desde facturas > Modificar cuentas por cobrar"
}, {
    4104,
    "Comercial - Ventas > Notas CR > Desde facturas > modificar entidades dinamicas en doctos aprobados"
}, {
    1906,
    "Comercial - Ventas > Notas CR > Desde facturas > Modificar retenciones"
}, {
    9877,
    "Comercial - Ventas > Notas CR > Desde facturas > Permitir Notas desde diferentes CO"
}, {
    11871,
    "Comercial - Ventas > Notas CR > Desde facturas > Obligar que la transacción genere costo"
}, {
    6364,
    "Comercial - Ventas > Notas CR > Desde facturas > Permitir reversar el pedido"
}, {
    10972,
    "Comercial - Ventas > Notas CR > Desde facturas > Permitir capturar documento referencia"
}, {
    10826,
    "Comercial - Ventas > Notas CR > Desde facturas > Cruzar facturas automáticamente al aprobar"
}, {
    6989,
    "Comercial - Ventas > Notas CR > Desde facturas diferidas"
}, {
    7008,
    "Comercial - Ventas > Notas CR > Desde facturas diferidas > Adicionar"
}, {
    7009,
    "Comercial - Ventas > Notas CR > Desde facturas diferidas > Anular"
}, {
    7010,
    "Comercial - Ventas > Notas CR > Desde facturas diferidas > Aprobar"
}, {
    7012,
    "Comercial - Ventas > Notas CR > Desde facturas diferidas > Consultar"
}, {
    7011,
    "Comercial - Ventas > Notas CR > Desde facturas diferidas > Capturar cxc en transacciones de contado"
}, {
    7114,
    "Comercial - Ventas > Notas CR > Desde facturas diferidas > Generar automático"
}, {
    7013,
    "Comercial - Ventas > Notas CR > Desde facturas diferidas > Habilitar impresion"
}, {
    7014,
    "Comercial - Ventas > Notas CR > Desde facturas diferidas > Imprimir"
}, {
    7015,
    "Comercial - Ventas > Notas CR > Desde facturas diferidas > Modificar"
}, {
    7016,
    "Comercial - Ventas > Notas CR > Desde facturas diferidas > Modificar cuentas por cobrar"
}, {
    7017,
    "Comercial - Ventas > Notas CR > Desde facturas diferidas > Modificar entidades dinamicas en doctos aprobados"
}, {
    7018,
    "Comercial - Ventas > Notas CR > Desde facturas diferidas > Modificar retenciones"
}, {
    10973,
    "Comercial - Ventas > Notas CR > Desde facturas > Permitir documentos sin referencia"
}, {
    10974,
    "Comercial - Ventas > Notas CR > Desde facturas > Validar documento referencia"
}, {
    8204,
    "Comercial - Ventas > Notas CR > Desde valores a distribuir - NC"
}, {
    10618,
    "Comercial - Ventas > Notas CR > Desde valores a distribuir - FP"
}, {
    10617,
    "-No implementado > Desde valores a distribuir - NC"
}, {
    1853,
    "Comercial - Ventas > Notas CR directas"
}, {
    11885,
    "Comercial - Ventas > Notas CR directas > Actualizar movimientos grabados al adicionar"
}, {
    1885,
    "Comercial - Ventas > Notas CR directas > Adicionar"
}, {
    1895,
    "Comercial - Ventas > Notas CR directas > Alterar descuentos"
}, {
    1894,
    "Comercial - Ventas > Notas CR directas > Alterar precios"
}, {
    1889,
    "Comercial - Ventas > Notas CR directas > Anular"
}, {
    3718,
    "Comercial - Ventas > Notas CR directas > Anular notas sin imprimir"
}, {
    1888,
    "Comercial - Ventas > Notas CR directas > Aprobar"
}, {
    3374,
    "Comercial - Ventas > Notas CR directas > Permitir capturar vehiculos"
}, {
    1887,
    "Comercial - Ventas > Notas CR directas > Consultar"
}, {
    3105,
    "Comercial - Ventas > Notas CR directas > Capturar cxc en transacciones de contado"
}, {
    1896,
    "Comercial - Ventas > Notas CR directas > Seleccionar descuentos exclusivos"
}, {
    10971,
    "Comercial - Ventas > Notas CR directas > Validar documento referencia"
}, {
    10970,
    "Comercial - Ventas > Notas CR directas > Permitir documentos sin referencias"
}, {
    6903,
    "Comercial - Ventas > Notas CR directas > Asumir costos estándar para ítem sin costo"
}, {
    8906,
    "Comercial - Ventas > Notas CR directas > Permitir facturas de otra auxiliar de CXC"
}, {
    8907,
    "Comercial - Ventas > Notas CR directas > Permitir facturas de otra sucursal"
}, {
    8908,
    "Comercial - Ventas > Notas CR directas > Permitir facturas de otra U.N."
}, {
    8909,
    "Comercial - Ventas > Notas CR directas > Permitir facturas de otro C.O."
}, {
    1891,
    "Comercial - Ventas > Habilitar impresión documentos > Habilitar impresión notas"
}, {
    1890,
    "Comercial - Ventas > Imprimir documentos > Imprimir notas"
}, {
    3270,
    "Comercial - Ventas > Notas CR directas > Liquidar descuentos vigentes"
}, {
    1886,
    "Comercial - Ventas > Notas CR directas > Modificar"
}, {
    1892,
    "Comercial - Ventas > Notas CR directas > Modificar condiciones de venta"
}, {
    1898,
    "Comercial - Ventas > Notas CR directas > Modificar cuentas por cobrar"
}, {
    4105,
    "Comercial - Ventas > Notas CR directas > Modificar entidades dinamicas en doctos aprobados"
}, {
    1897,
    "Comercial - Ventas > Notas CR directas > Modificar retenciones"
}, {
    7036,
    "Comercial - Ventas > Notas CR directas > Obligar que la transacción genere costo"
}, {
    1893,
    "Comercial - Ventas > Notas CR directas > Permitir clientes ocasionales"
}, {
    3292,
    "Comercial - Ventas > Notas CR directas > Permitir multiples facturas"
}, {
    11692,
    "Comercial - Ventas > Notas CR directas > Sugerir Causal"
}, {
    8822,
    "Comercial - Ventas > Notas CR > Permitir distribuir la cartera al contabilizar"
}, {
    7020,
    "Comercial - Ventas > Notas CR > Modificar datos basicos"
}, {
    7021,
    "Comercial - Ventas > Notas CR > Modificar datos basicos > Cargue"
}, {
    7022,
    "Comercial - Ventas > Notas CR > Modificar datos basicos > Condición de pago"
}, {
    7023,
    "Comercial - Ventas > Notas CR > Modificar datos basicos > Notas"
}, {
    7024,
    "-No implementado > Número de OC"
}, {
    7025,
    "Comercial - Ventas > Notas CR > Modificar datos basicos > Referencia"
}, {
    7026,
    "Comercial - Ventas > Notas CR > Modificar datos basicos > Transportador"
}, {
    7620,
    "Comercial - Ventas > Notas CR > Modificar datos basicos > Vendedor"
}, {
    7536,
    "Comercial - Ventas > Notas CR > Notas CR desde pedidos para devolución"
}, {
    7537,
    "Comercial - Ventas > Notas CR > Notas CR desde pedidos para devolución > Adicionar"
}, {
    7538,
    "Comercial - Ventas > Notas CR > Notas CR desde pedidos para devolución > Anular"
}, {
    7539,
    "Comercial - Ventas > Notas CR > Notas CR desde pedidos para devolución > Aprobar"
}, {
    11158,
    "Comercial - Ventas > Notas CR > Notas CR desde pedidos para devolución > Asumir costos estándar para ítem sin costo"
}, {
    7540,
    "Comercial - Ventas > Notas CR > Notas CR desde pedidos para devolución > Captura cxc en transacciones de contado"
}, {
    7541,
    "Comercial - Ventas > Notas CR > Notas CR desde pedidos para devolución > Consultar"
}, {
    7542,
    "Comercial - Ventas > Notas CR > Notas CR desde pedidos para devolución > Generar automatico"
}, {
    7543,
    "Comercial - Ventas > Notas CR > Notas CR desde pedidos para devolución > Habilitar impresión"
}, {
    7544,
    "Comercial - Ventas > Notas CR > Notas CR desde pedidos para devolución > Imprimir"
}, {
    7545,
    "Comercial - Ventas > Notas CR > Notas CR desde pedidos para devolución > Modificar"
}, {
    7546,
    "Comercial - Ventas > Notas CR > Notas CR desde pedidos para devolución > Modificar cuentas por cobrar"
}, {
    7547,
    "Comercial - Ventas > Notas CR > Notas CR desde pedidos para devolución > Modificar entidades dinamicas en doctos aprobados"
}, {
    7548,
    "Comercial - Ventas > Notas CR > Notas CR desde pedidos para devolución > Modificar retenciones"
}, {
    11159,
    "Comercial - Ventas > Notas CR > Notas CR desde pedidos para devolución > Obligar que la transacción genere costo"
}, {
    10021,
    "-No implementado > No validar el cupo y la mora del cliente"
}, {
    10022,
    "Comercial - Ventas > Notas CR > Desde valores a distribuir - NC > No validar el cupo y mora del cliente al factura"
}, {
    4311,
    "Comercial - Ventas > Planilla de cuadre de facturas"
}, {
    4317,
    "Comercial - Ventas > Planilla de cuadre de facturas > Aprobación"
}, {
    7857,
    "Comercial - Ventas > Planilla de cuadre de facturas > Aprobación > Validar el aplicar cambiar fecha radicación"
}, {
    4318,
    "Comercial - Ventas > Planilla de cuadre de facturas > Aprobación > Aprobar"
}, {
    4764,
    "Comercial - Ventas > Planilla de cuadre de facturas > Aprobación > Capturar fecha de radicación"
}, {
    4765,
    "Comercial - Ventas > Planilla de cuadre de facturas > Aprobación > Capturar fecha de radicación > Recalcular fecha de vencimiento"
}, {
    4319,
    "Comercial - Ventas > Planilla de cuadre de facturas > Aprobación > Desaprobar"
}, {
    4320,
    "Comercial - Ventas > Planilla de cuadre de facturas > Aprobación > Legalizar"
}, {
    4349,
    "Comercial - Ventas > Planilla de cuadre de facturas > Aprobación > Permitir múltiples redespachos"
}, {
    4322,
    "Comercial - Ventas > Planilla de cuadre de facturas > Aprobación > Permitir crédito"
}, {
    4321,
    "Comercial - Ventas > Planilla de cuadre de facturas > Aprobación > Permitir notas crédito"
}, {
    4312,
    "Comercial - Ventas > Planilla de cuadre de facturas > Generación"
}, {
    4313,
    "Comercial - Ventas > Planilla de cuadre de facturas > Generación > Adicionar"
}, {
    4315,
    "Comercial - Ventas > Planilla de cuadre de facturas > Generación > Anular"
}, {
    4314,
    "Comercial - Ventas > Planilla de cuadre de facturas > Generación > Consultar"
}, {
    4316,
    "Comercial - Ventas > Planilla de cuadre de facturas > Generación > Modificar"
}, {
    4331,
    "Comercial - Ventas > Habilitar impresión documentos > Habilitar impresion planilla de cuadre de facturas"
}, {
    4332,
    "Comercial - Ventas > Imprimir documentos > Imprimir planilla de cuadre de facturas"
}, {
    4323,
    "Comercial - Ventas > Planilla de cuadre de facturas > Legalización"
}, {
    4324,
    "Comercial - Ventas > Planilla de cuadre de facturas > Legalización > Adicionar registro control"
}, {
    4325,
    "Comercial - Ventas > Planilla de cuadre de facturas > Legalización > Anular recibos de caja"
}, {
    8399,
    "Comercial - Ventas > Planilla de cuadre de facturas > Legalización > Imprimir recibos de caja al legalizar"
}, {
    4326,
    "Comercial - Ventas > Planilla de cuadre de facturas > Legalización > Legalizar registro control"
}, {
    4327,
    "Comercial - Ventas > Planilla de cuadre de facturas > Legalización > Modificar calculo de valor local o alterno"
}, {
    6370,
    "Comercial - Ventas > Planilla de cuadre de facturas > Legalización > Modificar fecha de registro control"
}, {
    4328,
    "Comercial - Ventas > Planilla de cuadre de facturas > Legalización > Modificar registro control"
}, {
    11109,
    "Comercial - Ventas > Planilla de cuadre de facturas > Legalización > No controla tope máximo en otros ingresos"
}, {
    4329,
    "Comercial - Ventas > Planilla de cuadre de facturas > Legalización > Permitir consultar notas"
}, {
    6729,
    "Comercial - Ventas > Planilla de cuadre de facturas > Legalización > Permitir cambiar caja preferida"
}, {
    6732,
    "Comercial - Ventas > Planilla de cuadre de facturas > Legalización > Permitir liberar facturas"
}, {
    6730,
    "Comercial - Ventas > Planilla de cuadre de facturas > Legalización > Permitir llevar a credito"
}, {
    6731,
    "Comercial - Ventas > Planilla de cuadre de facturas > Legalización > Permitir llevar a redespacho"
}, {
    1642,
    "Comercial - Ventas > Pedidos > Facturables"
}, {
    1643,
    "Comercial - Ventas > Pedidos > Generales > Adicionar"
}, {
    1647,
    "Comercial - Ventas > Pedidos > Generales > Anular"
}, {
    1646,
    "Comercial - Ventas > Pedidos > Generales > Aprobar"
}, {
    1656,
    "Comercial - Ventas > Pedidos > Generales > Aprobar pedidos retenidos"
}, {
    7465,
    "Comercial - Ventas > Pedidos > Cambiar items"
}, {
    7466,
    "Comercial - Ventas > Pedidos > Cambiar items > Modificar precios"
}, {
    1652,
    "Comercial - Ventas > Pedidos > Generales > Comprometer"
}, {
    2983,
    "Comercial - Ventas > Pedidos > Generales > Comprometer automáticamente después de aprobar"
}, {
    6734,
    "Comercial - Ventas > Pedidos > Generales > Comprometer items obsequios auto proporcionalmente"
}, {
    1645,
    "Comercial - Ventas > Pedidos > Generales > Consultar"
}, {
    1654,
    "Comercial - Ventas > Pedidos > Generales > Dar por cumplido"
}, {
    6670,
    "Comercial - Ventas > Pedidos > Generales > Duplicar"
}, {
    8309,
    "Comercial - Ventas > Pedidos > Generales > Duplicar > Dar por cumplido documento origen"
}, {
    8310,
    "Comercial - Ventas > Pedidos > Generales > Duplicar > Heredar la fecha del documento origen"
}, {
    8311,
    "Comercial - Ventas > Pedidos > Generales > Duplicar > Recalcular la fecha de entrega"
}, {
    2373,
    "Comercial - Ventas > Pedidos > Eliminar lote de importación"
}, {
    7626,
    "Comercial - Ventas > Pedidos > Generales > Exceder margen"
}, {
    1926,
    "Comercial - Ventas > Pedidos > Generales > Facturar"
}, {
    10977,
    "Comercial - Ventas > Pedidos > Generales > Abrir múltiples pestañas"
}, {
    11328,
    "Comercial - Ventas > Pedidos > Generales > Comprometer - bloquear manuales"
}, {
    11327,
    "Comercial - Ventas > Pedidos > Generales > Comprometer - bloquear parciales"
}, {
    10976,
    "-No implementado > No retener pedidos de contado"
}, {
    1649,
    "Comercial - Ventas > Habilitar impresión documentos > Habilitar impresión pedidos"
}, {
    2372,
    "Comercial - Ventas > Pedidos > Importar"
}, {
    1648,
    "Comercial - Ventas > Imprimir documentos > Imprimir pedidos"
}, {
    2374,
    "Comercial - Ventas > Pedidos > Log de importación"
}, {
    1644,
    "Comercial - Ventas > Pedidos > Generales > Modificar"
}, {
    1789,
    "Comercial - Ventas > Pedidos > Asignar cargue"
}, {
    1650,
    "Comercial - Ventas > Pedidos > Generales > Modificar condiciones de venta"
}, {
    1660,
    "Comercial - Ventas > Pedidos > Generales > Modificar descuentos"
}, {
    1659,
    "Comercial - Ventas > Pedidos > Generales > Cambiar lista de precios"
}, {
    4277,
    "Comercial - Ventas > Pedidos > Generales > Modificar entidades dinámicas en doctos aprobados"
}, {
    4587,
    "Comercial - Ventas > Pedidos > Modificar punto de envío en pedidos aprobados"
}, {
    6746,
    "Comercial - Ventas > Pedidos > Generales > No almacenar cantidades parciales al aprob y comp"
}, {
    2766,
    "Comercial - Ventas > Pedidos > No facturables"
}, {
    10874,
    "Comercial - Ventas > Pedidos > Generales > No retener pedidos de contado"
}, {
    3928,
    "Comercial - Ventas > Pedidos > Generales > Permitir obsequiar paquetes"
}, {
    3167,
    "Comercial - Ventas > Pedidos > Generales > Permitir adicionar ítems en pedidos aprobados"
}, {
    1651,
    "Comercial - Ventas > Pedidos > Generales > Permitir clientes ocasionales"
}, {
    3168,
    "Comercial - Ventas > Pedidos > Generales > Permitir eliminar ítem en pedido aprob y retenidos"
}, {
    3051,
    "Comercial - Ventas > Pedidos > Generales > Permitir equivalentes en compromisos"
}, {
    6748,
    "Comercial - Ventas > Pedidos > Generales > Permitir modificar cond. de pago en ped. con ítems"
}, {
    3169,
    "Comercial - Ventas > Pedidos > Generales > Permitir modificar ítems en pedidos aprobados"
}, {
    6738,
    "Comercial - Ventas > Pedidos > Generales > Permitir modificar ítems con obsequios aprobados"
}, {
    6736,
    "Comercial - Ventas > Pedidos > Generales > Permitir modificar ítems con obsequios en elab"
}, {
    6759,
    "Comercial - Ventas > Pedidos > Generales > Permitir modificar las notas del documento"
}, {
    6737,
    "Comercial - Ventas > Pedidos > Generales > Permitir modificar obsequios automáticos aprobados"
}, {
    6735,
    "Comercial - Ventas > Pedidos > Generales > Permitir modificar obsequios automáticos en elab"
}, {
    1658,
    "Comercial - Ventas > Pedidos > Generales > Remisionar"
}, {
    6781,
    "Comercial - Ventas > Pedidos > Generales > Restringe compromiso ítem con lote y unidad inv."
}, {
    1655,
    "Comercial - Ventas > Pedidos > Generales > Retener"
}, {
    1657,
    "Comercial - Ventas > Pedidos > Generales > Reversar cumplido"
}, {
    1661,
    "Comercial - Ventas > Pedidos > Generales > Seleccionar descuentos exclusivos"
}, {
    7464,
    "Comercial - Ventas > Pedidos > Generales > Sugerir siempre la lista de precio del cliente"
}, {
    6536,
    "Comercial - Ventas > Pedidos > Generales > Sugerir último transportador capturado"
}, {
    4787,
    "Comercial - Ventas > Pedidos > Generales > Sugerir las tasas en cero"
}, {
    3293,
    "Comercial - Ventas > Planilla de cuadre"
}, {
    11257,
    "Comercial - Ventas > Planilla de cuadre > Actualizar fecha de radiación factura al cerrar"
}, {
    3294,
    "Comercial - Ventas > Planilla de cuadre > Adicionar"
}, {
    3296,
    "Comercial - Ventas > Planilla de cuadre > Anular"
}, {
    3297,
    "Comercial - Ventas > Planilla de cuadre > Aprobar"
}, {
    9111,
    "-No implementado > Permitir capturar pronto pago con dif. Medios"
}, {
    3299,
    "Comercial - Ventas > Planilla de cuadre > Cerrar"
}, {
    3298,
    "Comercial - Ventas > Planilla de cuadre > Consultar"
}, {
    3304,
    "Comercial - Ventas > Planilla de cuadre > Desaprobar"
}, {
    3305,
    "Comercial - Ventas > Planilla de cuadre > Deshacer"
}, {
    4729,
    "Comercial - Ventas > Planilla de cuadre > Permitir generar documentos"
}, {
    3300,
    "Comercial - Ventas > Habilitar impresión documentos > Habilitar impresión planillas de cuadre"
}, {
    3301,
    "Comercial - Ventas > Imprimir documentos > Imprimir planillas de cuadre"
}, {
    4720,
    "Comercial - Ventas > Planilla de cuadre > Permitir liquidación de fletes"
}, {
    3295,
    "Comercial - Ventas > Planilla de cuadre > Modificar"
}, {
    8037,
    "Comercial - Ventas > Planilla de cuadre > Modificar entidades dinámicas en doctos aprobados"
}, {
    8439,
    "Comercial - Ventas > Planilla de cuadre > Validar remisión y factura relacionadas"
}, {
    3500,
    "Comercial - Ventas > Presupuesto"
}, {
    3510,
    "Comercial - Ventas > Presupuesto > Consulta"
}, {
    3511,
    "Comercial - Ventas > Presupuesto > Consulta > Ejecución presupuestal"
}, {
    8155,
    "Comercial - Ventas > Presupuesto controlado"
}, {
    10945,
    "-No implementado > Aprobación"
}, {
    8166,
    "Comercial - Ventas > Presupuesto controlado > Apropiación"
}, {
    8167,
    "Comercial - Ventas > Presupuesto controlado > Apropiación > Adicionar"
}, {
    8169,
    "Comercial - Ventas > Presupuesto controlado > Apropiación > Eliminar"
}, {
    8168,
    "Comercial - Ventas > Presupuesto controlado > Apropiación > Modificar"
}, {
    8185,
    "Comercial - Ventas > Presupuesto controlado > Consultas"
}, {
    9107,
    "Comercial - Ventas > Presupuesto controlado > Consultas > Presupuesto controlado ejecución"
}, {
    9106,
    "Comercial - Ventas > Presupuesto controlado > Consultas > Presupuesto controlado movimiento"
}, {
    8186,
    "Comercial - Ventas > Presupuesto controlado > Consultas > Presupuestos controlados"
}, {
    8187,
    "Comercial - Ventas > Presupuesto controlado > Consultas > Presupuesto no controlados"
}, {
    8156,
    "Comercial - Ventas > Presupuesto controlado > Control presupuestal"
}, {
    8157,
    "Comercial - Ventas > Presupuesto controlado > Control presupuestal > Adicionar"
}, {
    8163,
    "Comercial - Ventas > Presupuesto controlado > Control presupuestal > Aprobar"
}, {
    8165,
    "Comercial - Ventas > Presupuesto controlado > Control presupuestal > Cerrar"
}, {
    8160,
    "Comercial - Ventas > Presupuesto controlado > Control presupuestal > Consultar"
}, {
    8164,
    "Comercial - Ventas > Presupuesto controlado > Control presupuestal > Desaprobar"
}, {
    8161,
    "Comercial - Ventas > Presupuesto controlado > Control presupuestal > Duplicar"
}, {
    8159,
    "Comercial - Ventas > Presupuesto controlado > Control presupuestal > Eliminar"
}, {
    8158,
    "Comercial - Ventas > Presupuesto controlado > Control presupuestal > Modificar"
}, {
    8162,
    "Comercial - Ventas > Presupuesto controlado > Control presupuestal > Reporte"
}, {
    8708,
    "Comercial - Ventas > Presupuesto controlado > Control presupuestal > Permitir adicionar vendedores con ppto aprobado"
}, {
    8170,
    "Comercial - Ventas > Presupuesto controlado > Traslados, adiciones y reducciones"
}, {
    8171,
    "Comercial - Ventas > Presupuesto controlado > Traslados, adiciones y reducciones > Adiciones"
}, {
    8172,
    "Comercial - Ventas > Presupuesto controlado > Traslados, adiciones y reducciones > Adiciones > Adicionar"
}, {
    8174,
    "Comercial - Ventas > Presupuesto controlado > Traslados, adiciones y reducciones > Adiciones > Eliminar"
}, {
    8173,
    "Comercial - Ventas > Presupuesto controlado > Traslados, adiciones y reducciones > Adiciones > Modificar"
}, {
    8184,
    "Comercial - Ventas > Presupuesto controlado > Traslados, adiciones y reducciones > Eliminar"
}, {
    8179,
    "Comercial - Ventas > Presupuesto controlado > Traslados, adiciones y reducciones > Reducciones"
}, {
    8180,
    "Comercial - Ventas > Presupuesto controlado > Traslados, adiciones y reducciones > Reducciones > Adicionar"
}, {
    8182,
    "Comercial - Ventas > Presupuesto controlado > Traslados, adiciones y reducciones > Reducciones > Eliminar"
}, {
    8181,
    "Comercial - Ventas > Presupuesto controlado > Traslados, adiciones y reducciones > Reducciones > Modificar"
}, {
    8183,
    "Comercial - Ventas > Presupuesto controlado > Traslados, adiciones y reducciones > Reporte"
}, {
    8175,
    "Comercial - Ventas > Presupuesto controlado > Traslados, adiciones y reducciones > Traslados"
}, {
    8176,
    "Comercial - Ventas > Presupuesto controlado > Traslados, adiciones y reducciones > Traslados > Adicionar"
}, {
    8178,
    "Comercial - Ventas > Presupuesto controlado > Traslados, adiciones y reducciones > Traslados > Eliminar"
}, {
    8177,
    "Comercial - Ventas > Presupuesto controlado > Traslados, adiciones y reducciones > Traslados > Modificar"
}, {
    3501,
    "Comercial - Ventas > Presupuesto > Definición"
}, {
    7759,
    "Comercial - Ventas > Presupuesto > Definición > Alterar presupuesto en proceso"
}, {
    7758,
    "Comercial - Ventas > Presupuesto > Definición > Generación"
}, {
    3860,
    "Comercial - Ventas > Presupuesto > Definición > Presupuesto > Modificar cifras diferentes a cero"
}, {
    3502,
    "Comercial - Ventas > Presupuesto > Definición > Plan presupuestal"
}, {
    3503,
    "Comercial - Ventas > Presupuesto > Definición > Plan presupuestal > Adicionar"
}, {
    3507,
    "Comercial - Ventas > Presupuesto > Definición > Plan presupuestal > Consultar"
}, {
    3506,
    "Comercial - Ventas > Presupuesto > Definición > Plan presupuestal > Duplicar"
}, {
    3505,
    "Comercial - Ventas > Presupuesto > Definición > Plan presupuestal > Eliminar"
}, {
    3504,
    "Comercial - Ventas > Presupuesto > Definición > Plan presupuestal > Modificar"
}, {
    3508,
    "Comercial - Ventas > Presupuesto > Definición > Plan presupuestal > Reporte"
}, {
    3509,
    "Comercial - Ventas > Presupuesto > Definición > Presupuesto"
}, {
    1750,
    "Comercial - Ventas > Remisiones > Directas"
}, {
    1752,
    "Comercial - Ventas > Remisiones > Generales > Adicionar"
}, {
    1753,
    "Comercial - Ventas > Remisiones > Generales > Anular"
}, {
    1756,
    "Comercial - Ventas > Remisiones > Generales > Aprobar"
}, {
    12054,
    "Comercial - Ventas > Remisiones > Generales > Comprometer - bloquear manuales"
}, {
    12053,
    "Comercial - Ventas > Remisiones > Generales > Comprometer - bloquear parciales"
}, {
    1755,
    "Comercial - Ventas > Remisiones > Generales > Consultar"
}, {
    1778,
    "Comercial - Ventas > Remisiones > Desde pedidos"
}, {
    8418,
    "Comercial - Ventas > Remisiones > Desde pedidos > Captura bodega según maestros por usuarios"
}, {
    7834,
    "Comercial - Ventas > Remisiones > Desde pedidos > Permitir comprometer y descomprometer"
}, {
    9803,
    "Comercial - Ventas > Remisiones > Desde pedidos > Elegir por defecto indicador de notas"
}, {
    2767,
    "Comercial - Ventas > Remisiones > Desde pedidos no facturables"
}, {
    1843,
    "Comercial - Ventas > Remisiones > Generales > Exceder margen"
}, {
    1761,
    "Comercial - Ventas > Remisiones > Generales > Facturar"
}, {
    1758,
    "Comercial - Ventas > Habilitar impresión documentos > Habilitar impresion remisiones"
}, {
    1757,
    "Comercial - Ventas > Imprimir documentos > Imprimir remisiones"
}, {
    1754,
    "Comercial - Ventas > Remisiones > Generales > Modificar"
}, {
    1759,
    "Comercial - Ventas > Remisiones > Generales > Modificar condiciones de venta"
}, {
    1763,
    "Comercial - Ventas > Remisiones > Generales > Modificar descuentos"
}, {
    1762,
    "Comercial - Ventas > Remisiones > Generales > Modificar precios"
}, {
    3726,
    "Comercial - Ventas > Remisiones > Generales > Modificar vendedor"
}, {
    4030,
    "Comercial - Ventas > Remisiones > Generales > Modificar entidades dinámicas en doctos aprobados"
}, {
    2272,
    "Comercial - Ventas > Remisiones > No facturables"
}, {
    1760,
    "Comercial - Ventas > Remisiones > Generales > Permitir clientes ocasionales"
}, {
    1764,
    "Comercial - Ventas > Remisiones > Generales > Seleccionar descuentos exclusivos"
}, {
    9734,
    "Comercial - Ventas > Remisiones > Generales > Sugerir lote"
}, {
    9733,
    "Comercial - Ventas > Remisiones > Generales > Sugerir ubicación de salida"
}, {
    10978,
    "Comercial - Ventas > Remisiones > Desde pedidos > No marcar los registros al consultar"
}, {
    6963,
    "Comercial - Ventas > Siesa Mobile"
}, {
    6966,
    "Comercial - Ventas > Siesa Mobile > Parametros perfiles"
}, {
    6979,
    "Comercial - Ventas > Siesa Mobile > Parametros perfiles > Adicionar"
}, {
    6980,
    "Comercial - Ventas > Siesa Mobile > Parametros perfiles > Consultar"
}, {
    6981,
    "Comercial - Ventas > Siesa Mobile > Parametros perfiles > Duplicar"
}, {
    6982,
    "Comercial - Ventas > Siesa Mobile > Parametros perfiles > Eliminar"
}, {
    6983,
    "Comercial - Ventas > Siesa Mobile > Parametros perfiles > Modificar"
}, {
    6984,
    "Comercial - Ventas > Siesa Mobile > Parametros perfiles > Reporte"
}, {
    6964,
    "Comercial - Ventas > Siesa Mobile > Parametros vendedores"
}, {
    6967,
    "Comercial - Ventas > Siesa Mobile > Parametros vendedores > Adicionar"
}, {
    6968,
    "Comercial - Ventas > Siesa Mobile > Parametros vendedores > Consultar"
}, {
    6969,
    "Comercial - Ventas > Siesa Mobile > Parametros vendedores > Duplicar"
}, {
    6970,
    "Comercial - Ventas > Siesa Mobile > Parametros vendedores > Eliminar"
}, {
    6971,
    "Comercial - Ventas > Siesa Mobile > Parametros vendedores > Modificar"
}, {
    6972,
    "Comercial - Ventas > Siesa Mobile > Parametros vendedores > Reporte"
}, {
    6965,
    "Comercial - Ventas > Siesa Mobile > Perfiles"
}, {
    6973,
    "Comercial - Ventas > Siesa Mobile > Perfiles > Adicionar"
}, {
    6974,
    "Comercial - Ventas > Siesa Mobile > Perfiles > Consultar"
}, {
    6975,
    "Comercial - Ventas > Siesa Mobile > Perfiles > Duplicar"
}, {
    6976,
    "Comercial - Ventas > Siesa Mobile > Perfiles > Eliminar"
}, {
    6977,
    "Comercial - Ventas > Siesa Mobile > Perfiles > Modificar"
}, {
    6978,
    "Comercial - Ventas > Siesa Mobile > Perfiles > Reporte"
}, {
    2344,
    "Comercial - Ventas > Uno Movil"
}, {
    2349,
    "Comercial - Ventas > Uno Movil > Exportar maestros"
}, {
    2354,
    "Comercial - Ventas > Uno Movil > Gestión por vendedor"
}, {
    2355,
    "Comercial - Ventas > Uno Movil > Eliminar lote importación"
}, {
    2356,
    "Comercial - Ventas > Uno Movil > Log de importación"
}, {
    2345,
    "Comercial - Ventas > Uno Movil > Importar pedidos y recaudos"
}, {
    4464,
    "Comercial - Ventas > Validación de facturas"
}, {
    4468,
    "Comercial - Ventas > Validación de facturas > Permitir anular facturas con validación"
}, {
    4466,
    "Comercial - Ventas > Validación de facturas > Autorizar"
}, {
    4467,
    "Comercial - Ventas > Validación de facturas > Continua con facturas invalidas"
}, {
    4465,
    "Comercial - Ventas > Validación de facturas > Validar"
}, {
    9712,
    "-No implementado > Ver costos"
}, {
    3652,
    "Comercial - Ventas > Verificación de despachos"
}, {
    3666,
    "Comercial - Ventas > Verificación de despachos > Análisis de auditoria"
}, {
    9131,
    "Comercial - Ventas > Verificación de despachos > Capturar cantidad en código de barras"
}, {
    3665,
    "Comercial - Ventas > Verificación de despachos > Consulta"
}, {
    3653,
    "Comercial - Ventas > Verificación de despachos > Facturas"
}, {
    3655,
    "Comercial - Ventas > Verificación de despachos > Facturas > Aprobar descuadres"
}, {
    3657,
    "Comercial - Ventas > Verificación de despachos > Facturas > Permitir captura manual"
}, {
    3658,
    "Comercial - Ventas > Verificación de despachos > Facturas > Permitir códigos de barras manuales"
}, {
    3656,
    "Comercial - Ventas > Verificación de despachos > Facturas > Eliminar verificación"
}, {
    3654,
    "Comercial - Ventas > Verificación de despachos > Facturas > Limpiar verificación"
}, {
    3659,
    "Comercial - Ventas > Verificación de despachos > Remisiones"
}, {
    3661,
    "Comercial - Ventas > Verificación de despachos > Remisiones > Aprobar descuadres"
}, {
    3663,
    "Comercial - Ventas > Verificación de despachos > Remisiones > Permitir captura manual"
}, {
    3664,
    "Comercial - Ventas > Verificación de despachos > Remisiones > Permitir códigos de barras manuales"
}, {
    3662,
    "Comercial - Ventas > Verificación de despachos > Remisiones > Eliminar verificación"
}, {
    3660,
    "Comercial - Ventas > Verificación de despachos > Remisiones > Limpiar verificación"
}, {
    3676,
    "Comercial - Ventas > Verificación de despachos > Resumen de movimiento y novedades"
}, {
    1440,
    "Financiero - Venta de servicios"
}, {
    9708,
    "Financiero - Venta de servicios > Automatización de documentos"
}, {
    1441,
    "Financiero - Venta de servicios > Consultas"
}, {
    2785,
    "Financiero - Venta de servicios > Consultas > Libro diario de ventas"
}, {
    7734,
    "Financiero - Venta de servicios > Consultas > Libro diario de ventas > Siempre presentar prefijo"
}, {
    7733,
    "Financiero - Venta de servicios > Consultas > Libro diario de ventas > Validar que no existan documentos en elaboración"
}, {
    3873,
    "Financiero - Venta de servicios > Generales"
}, {
    8265,
    "Financiero - Venta de servicios > Generales > Permitir anular con fecha de aprobación diferente"
}, {
    3874,
    "Financiero - Venta de servicios > Generales > Permitir modificar C.Costo de la CxC"
}, {
    3875,
    "Financiero - Venta de servicios > Generales > Permitir modificar U.N. de la CxC"
}, {
    3918,
    "Financiero - Venta de servicios > Generales > Permitir modificar retenciones en facturas"
}, {
    3919,
    "Financiero - Venta de servicios > Generales > Permitir modificar retenciones en notas"
}, {
    7092,
    "Financiero - Venta de servicios > Generales > Permitir modificar valor impuesto en recaudos"
}, {
    7755,
    "Financiero - Venta de servicios > Generales > No obligar valor impuesto en recaudos"
}, {
    2163,
    "Financiero - Venta de servicios > Habilitar impresión documentos"
}, {
    2162,
    "Financiero - Venta de servicios > Imprimir documentos"
}, {
    9954,
    "Vehiculos > Análisis"
}, {
    9955,
    "Vehiculos > Análisis > Facturas y notas"
}, {
    3268,
    "Vehiculos > Automatización de documentos"
}, {
    3201,
    "Vehiculos > Consultas"
}, {
    3204,
    "Vehiculos > Consultas > Documentos de cargues, devoluciones y ajustes"
}, {
    3220,
    "Vehiculos > Consultas > Facturas y notas"
}, {
    3221,
    "Vehiculos > Consultas > Facturas y notas por item"
}, {
    3407,
    "Vehiculos > Consultas > Movimientos de cargues de mano de obra"
}, {
    3408,
    "Vehiculos > Consultas > Movimientos de cargues de mano de obra > Permitir ver todas las compañias"
}, {
    3416,
    "Vehiculos > Consultas > Movimientos de cargues de mano de obra > Permitir ver liquidación"
}, {
    3205,
    "Vehiculos > Consultas > Movimientos de cargues, devoluciones y ajustes"
}, {
    3206,
    "Vehiculos > Consultas > Movimientos de cargues, devoluciones y ajustes > Permitir ver todas las compañias"
}, {
    3202,
    "Vehiculos > Consultas > Ordenes de taller"
}, {
    3222,
    "Vehiculos > Consultas > Resumen de facturas y notas"
}, {
    3406,
    "Vehiculos > Consultas > Seguimiento de documentos"
}, {
    3397,
    "Vehiculos > Consultas > Vehiculos"
}, {
    2990,
    "Vehiculos > Documentos de cargue"
}, {
    3026,
    "Vehiculos > Documentos de cargue > Ajustes en valor"
}, {
    3027,
    "Vehiculos > Documentos de cargue > Ajustes en valor > Adicionar"
}, {
    3028,
    "Vehiculos > Documentos de cargue > Ajustes en valor > Anular"
}, {
    3029,
    "Vehiculos > Documentos de cargue > Ajustes en valor > Aprobar"
}, {
    12029,
    "Vehiculos > Documentos de cargue > Ajustes en valor > En captura de movimientos sugerir últimos datos"
}, {
    3030,
    "Vehiculos > Documentos de cargue > Ajustes en valor > Consultar"
}, {
    3033,
    "Vehiculos > Documentos de cargue > Ajustes en valor > Modificar"
}, {
    3034,
    "Vehiculos > Documentos de cargue > Ajustes en valor > Modificar condiciones de venta"
}, {
    3035,
    "Vehiculos > Documentos de cargue > Ajustes en valor > Modificar descuentos"
}, {
    3036,
    "Vehiculos > Documentos de cargue > Ajustes en valor > Modificar precios"
}, {
    6906,
    "Vehiculos > Documentos de cargue > Ajustes en valor > Modificar entidades dinámicas doctos aprobados"
}, {
    6907,
    "Vehiculos > Documentos de cargue > Ajustes en valor > Modificar entidades dinámicas docto en elaboración"
}, {
    3190,
    "Vehiculos > Documentos de cargue > Ajustes en valor > Permite ajustes por debajo del costo"
}, {
    3037,
    "Vehiculos > Documentos de cargue > Ajustes en valor > Selecccionar descuentos exclusivos"
}, {
    3011,
    "Vehiculos > Documentos de cargue > Devolucion de servicios y repuestos"
}, {
    3012,
    "Vehiculos > Documentos de cargue > Devolucion de servicios y repuestos > Adicionar"
}, {
    3013,
    "Vehiculos > Documentos de cargue > Devolucion de servicios y repuestos > Anular"
}, {
    3014,
    "Vehiculos > Documentos de cargue > Devolucion de servicios y repuestos > Aprobar"
}, {
    3018,
    "Vehiculos > Documentos de cargue > Devolucion de servicios y repuestos > Consultar"
}, {
    3021,
    "Vehiculos > Documentos de cargue > Devolucion de servicios y repuestos > Modificar"
}, {
    3023,
    "Vehiculos > Documentos de cargue > Devolucion de servicios y repuestos > Modificar descuentos"
}, {
    3024,
    "Vehiculos > Documentos de cargue > Devolucion de servicios y repuestos > Modificar precios"
}, {
    3022,
    "Vehiculos > Documentos de cargue > Devolucion de servicios y repuestos > Modificar condiciones de venta"
}, {
    6912,
    "Vehiculos > Documentos de cargue > Devolucion de servicios y repuestos > Modificar entidades dinámicas doctos aprobados"
}, {
    6913,
    "Vehiculos > Documentos de cargue > Devolucion de servicios y repuestos > Modificar entidades dinamicas docto en elaboración"
}, {
    3025,
    "Vehiculos > Documentos de cargue > Devolucion de servicios y repuestos > Seleccionar descuentos exclusivos"
}, {
    3010,
    "Vehiculos > Documentos de cargue > Habilitar impresión"
}, {
    3009,
    "Vehiculos > Documentos de cargue > Imprimir"
}, {
    3311,
    "Vehiculos > Documentos de cargue > Cargue de Mano de obra"
}, {
    3312,
    "Vehiculos > Documentos de cargue > Cargue de Mano de obra > Adicionar"
}, {
    3313,
    "Vehiculos > Documentos de cargue > Cargue de Mano de obra > Anular"
}, {
    3314,
    "Vehiculos > Documentos de cargue > Cargue de Mano de obra > Aprobar"
}, {
    3315,
    "Vehiculos > Documentos de cargue > Cargue de Mano de obra > Consultar"
}, {
    3318,
    "Vehiculos > Documentos de cargue > Cargue de Mano de obra > Habilitar impresion"
}, {
    3317,
    "Vehiculos > Documentos de cargue > Cargue de Mano de obra > Imprimir"
}, {
    3316,
    "Vehiculos > Documentos de cargue > Cargue de Mano de obra > Modificar"
}, {
    6908,
    "Vehiculos > Documentos de cargue > Cargue de Mano de obra > Modificar entidades dinámicas doctos aprobados"
}, {
    6909,
    "Vehiculos > Documentos de cargue > Cargue de Mano de obra > Modificar entidades dinámicas docto en elaboración"
}, {
    2993,
    "Vehiculos > Documentos de cargue > Cargue de servicios y repuestos"
}, {
    9637,
    "-No implementado > Cambiar lista de precio del cliente"
}, {
    6910,
    "Vehiculos > Documentos de cargue > Cargue de servicios y repuestos > Modificar entidades dinámicas doctos aprobados"
}, {
    6911,
    "Vehiculos > Documentos de cargue > Cargue de servicios y repuestos > Modificar entidades dinámicas docto en elaboración"
}, {
    2991,
    "Vehiculos > Documentos de cargue > Cargue de servicios y repuestos > Adicionar"
}, {
    2992,
    "Vehiculos > Documentos de cargue > Cargue de servicios y repuestos > Anular"
}, {
    2994,
    "Vehiculos > Documentos de cargue > Cargue de servicios y repuestos > Aprobar"
}, {
    12030,
    "Vehiculos > Documentos de cargue > Cargue de servicios y repuestos > En captura de movimientos sugerir últimos datos"
}, {
    2998,
    "Vehiculos > Documentos de cargue > Cargue de servicios y repuestos > Cargar repuestos"
}, {
    2997,
    "Vehiculos > Documentos de cargue > Cargue de servicios y repuestos > Cargar servicios"
}, {
    2999,
    "Vehiculos > Documentos de cargue > Cargue de servicios y repuestos > Cargar temparios"
}, {
    2996,
    "Vehiculos > Documentos de cargue > Cargue de servicios y repuestos > Cargar temparios por servicios y repuestos"
}, {
    2995,
    "Vehiculos > Documentos de cargue > Cargue de servicios y repuestos > Consultar"
}, {
    3007,
    "Vehiculos > Documentos de cargue > Cargue de servicios y repuestos > Exceder margen"
}, {
    3003,
    "Vehiculos > Documentos de cargue > Cargue de servicios y repuestos > Modificar"
}, {
    3004,
    "Vehiculos > Documentos de cargue > Cargue de servicios y repuestos > Modificar condiciones de venta"
}, {
    3005,
    "Vehiculos > Documentos de cargue > Cargue de servicios y repuestos > Modificar descuentos"
}, {
    3006,
    "Vehiculos > Documentos de cargue > Cargue de servicios y repuestos > Modificar precios"
}, {
    3001,
    "Vehiculos > Documentos de cargue > Cargue de servicios y repuestos > Exige operarios en repuestos"
}, {
    3000,
    "Vehiculos > Documentos de cargue > Cargue de servicios y repuestos > Exige operarios en servicios"
}, {
    3002,
    "Vehiculos > Documentos de cargue > Cargue de servicios y repuestos > Exige operarios en temparios"
}, {
    3008,
    "Vehiculos > Documentos de cargue > Cargue de servicios y repuestos > Seleccionar descuentos exclusivos"
}, {
    3065,
    "Vehiculos > Documentos de facturación"
}, {
    8267,
    "Vehiculos > Documentos de facturación > Permitir anular con fecha de aprobación diferente"
}, {
    10067,
    "Vehiculos > Documentos de facturación > Marcar estado factura responsable principal"
}, {
    3108,
    "Vehiculos > Documentos de facturación > Habilitar impresion"
}, {
    3107,
    "Vehiculos > Documentos de facturación > Imprimir"
}, {
    7121,
    "Vehiculos > Documentos de facturación > Permitir modificar valor impuesto en recaudos"
}, {
    3257,
    "Vehiculos > Documentos de facturación > Nota credito desde OT."
}, {
    3258,
    "Vehiculos > Documentos de facturación > Nota credito desde OT. > Adicionar"
}, {
    7218,
    "Vehiculos > Documentos de facturación > Nota credito desde OT. > Alterar precios"
}, {
    3259,
    "Vehiculos > Documentos de facturación > Nota credito desde OT. > Anular"
}, {
    3260,
    "Vehiculos > Documentos de facturación > Nota credito desde OT. > Aprobar"
}, {
    3262,
    "Vehiculos > Documentos de facturación > Nota credito desde OT. > Consultar"
}, {
    3261,
    "Vehiculos > Documentos de facturación > Nota credito desde OT. > Capturar cxc en transacciones de contado"
}, {
    3263,
    "Vehiculos > Documentos de facturación > Nota credito desde OT. > Habilitar impresion"
}, {
    3264,
    "Vehiculos > Documentos de facturación > Nota credito desde OT. > Imprimir"
}, {
    3265,
    "Vehiculos > Documentos de facturación > Nota credito desde OT. > Modificar"
}, {
    3266,
    "Vehiculos > Documentos de facturación > Nota credito desde OT. > Modificar cuentas por cobrar"
}, {
    6914,
    "Vehiculos > Documentos de facturación > Nota credito desde OT. > Modificar entidades dinámicas doctos aprobados"
}, {
    6915,
    "Vehiculos > Documentos de facturación > Nota credito desde OT. > Modificar entidades dinámicas docto en elaboración"
}, {
    3267,
    "Vehiculos > Documentos de facturación > Nota credito desde OT. > Modificar retenciones"
}, {
    3077,
    "Vehiculos > Documentos de facturación > Responsable entidad"
}, {
    3078,
    "Vehiculos > Documentos de facturación > Responsable entidad > Adicionar"
}, {
    8810,
    "Vehiculos > Documentos de facturación > Responsable entidad > Permitir anticipos de otra auxiliar de anticipos"
}, {
    8811,
    "Vehiculos > Documentos de facturación > Responsable entidad > Permitir anticipos de otra sucursal"
}, {
    8812,
    "Vehiculos > Documentos de facturación > Responsable entidad > Permitir anticipos de otra U.N."
}, {
    8813,
    "Vehiculos > Documentos de facturación > Responsable entidad > Permitir anticipos de otro C.O."
}, {
    3079,
    "Vehiculos > Documentos de facturación > Responsable entidad > Anular"
}, {
    8802,
    "Vehiculos > Documentos de facturación > Responsable entidad > Permitir aplicar descuentos"
}, {
    3080,
    "Vehiculos > Documentos de facturación > Responsable entidad > Aprobar"
}, {
    9706,
    "Vehiculos > Documentos de facturación > Responsable entidad > Permitir capturar instrumento financiero"
}, {
    3081,
    "Vehiculos > Documentos de facturación > Responsable entidad > Consultar"
}, {
    10465,
    "Vehiculos > Documentos de facturación > Responsable entidad > Exceder margen"
}, {
    8655,
    "Vehiculos > Documentos de facturación > Responsable entidad > Permitir facturas de contado"
}, {
    3085,
    "Vehiculos > Documentos de facturación > Responsable entidad > Permite facturar multiples OTs"
}, {
    3082,
    "Vehiculos > Documentos de facturación > Responsable entidad > Modificar"
}, {
    3083,
    "Vehiculos > Documentos de facturación > Responsable entidad > Modificar condiciones de venta"
}, {
    3084,
    "Vehiculos > Documentos de facturación > Responsable entidad > Modificar cuentas por cobrar"
}, {
    6916,
    "Vehiculos > Documentos de facturación > Responsable entidad > Modificar entidades dinámicas doctos aprobados"
}, {
    6917,
    "Vehiculos > Documentos de facturación > Responsable entidad > Modificar entidades dinámicas docto en elaboración"
}, {
    3086,
    "Vehiculos > Documentos de facturación > Responsable entidad > Modificar retenciones"
}, {
    10894,
    "Vehiculos > Documentos de facturación > Responsable entidad > Permitir cambiar instrumento financiero sugerido"
}, {
    9629,
    "Vehiculos > Documentos de facturación > Responsable entidad > Modificar entidades dinámicas doctos anulados"
}, {
    3066,
    "Vehiculos > Documentos de facturación > Responsable principal"
}, {
    3067,
    "Vehiculos > Documentos de facturación > Responsable principal > Adicionar"
}, {
    8806,
    "Vehiculos > Documentos de facturación > Responsable principal > Permitir anticipos de otra auxiliar de anticipos"
}, {
    8807,
    "Vehiculos > Documentos de facturación > Responsable principal > Permitir anticipos de otra sucursal"
}, {
    8808,
    "Vehiculos > Documentos de facturación > Responsable principal > Permitir anticipos de otra U.N."
}, {
    8809,
    "Vehiculos > Documentos de facturación > Responsable principal > Permitir anticipos de otro C.O."
}, {
    3070,
    "Vehiculos > Documentos de facturación > Responsable principal > Anular"
}, {
    8801,
    "Vehiculos > Documentos de facturación > Responsable principal > Permitir aplicar descuentos"
}, {
    3071,
    "Vehiculos > Documentos de facturación > Responsable principal > Aprobar"
}, {
    10893,
    "Vehiculos > Documentos de facturación > Responsable principal > Permitir cambiar instrumento financiero sugerido"
}, {
    9707,
    "Vehiculos > Documentos de facturación > Responsable principal > Permitir capturar instrumento financiero"
}, {
    3072,
    "Vehiculos > Documentos de facturación > Responsable principal > Consultar"
}, {
    10466,
    "Vehiculos > Documentos de facturación > Responsable principal > Exceder margen"
}, {
    8656,
    "Vehiculos > Documentos de facturación > Responsable principal > Permitir facturas de contado"
}, {
    3073,
    "Vehiculos > Documentos de facturación > Responsable principal > Modificar"
}, {
    3075,
    "Vehiculos > Documentos de facturación > Responsable principal > Modificar condiciones de venta"
}, {
    3076,
    "Vehiculos > Documentos de facturación > Responsable principal > Modificar cuentas por cobrar"
}, {
    3069,
    "Vehiculos > Documentos de facturación > Responsable principal > Modificar deducible del movimiento"
}, {
    6918,
    "Vehiculos > Documentos de facturación > Responsable principal > Modificar entidades dinámicas doctos aprobados"
}, {
    6919,
    "Vehiculos > Documentos de facturación > Responsable principal > Modificar entidades dinámicas docto en elaboración"
}, {
    9630,
    "Vehiculos > Documentos de facturación > Responsable principal > Modificar entidades dinámicas doctos anulados"
}, {
    3068,
    "Vehiculos > Documentos de facturación > Responsable principal > Modificar responsable del movto"
}, {
    3074,
    "Vehiculos > Documentos de facturación > Responsable principal > Modificar retenciones"
}, {
    9947,
    "Vehiculos > Generales"
}, {
    9948,
    "Vehiculos > Generales > Presentar costos en las consultas de ventas"
}, {
    2850,
    "Vehiculos > Maestros"
}, {
    2851,
    "Vehiculos > Maestros > Accesorios"
}, {
    2852,
    "Vehiculos > Maestros > Accesorios > Adicionar"
}, {
    2853,
    "Vehiculos > Maestros > Accesorios > Consultar"
}, {
    2854,
    "Vehiculos > Maestros > Accesorios > Duplicar"
}, {
    2855,
    "Vehiculos > Maestros > Accesorios > Eliminar"
}, {
    2856,
    "Vehiculos > Maestros > Accesorios > Modificar"
}, {
    2857,
    "Vehiculos > Maestros > Accesorios > Reporte"
}, {
    2947,
    "Vehiculos > Maestros > Clases de OT"
}, {
    2948,
    "Vehiculos > Maestros > Clases de OT > Adicionar"
}, {
    2949,
    "Vehiculos > Maestros > Clases de OT > Consultar"
}, {
    2950,
    "Vehiculos > Maestros > Clases de OT > Duplicar"
}, {
    2951,
    "Vehiculos > Maestros > Clases de OT > Eliminar"
}, {
    2952,
    "Vehiculos > Maestros > Clases de OT > Modificar"
}, {
    2953,
    "Vehiculos > Maestros > Clases de OT > Reporte"
}, {
    2858,
    "Vehiculos > Maestros > Criterios de clasificacion de vehiculos"
}, {
    2866,
    "Vehiculos > Maestros > Criterios de clasificacion de vehiculos > Mayores"
}, {
    2867,
    "Vehiculos > Maestros > Criterios de clasificacion de vehiculos > Mayores > Adicionar"
}, {
    2868,
    "Vehiculos > Maestros > Criterios de clasificacion de vehiculos > Mayores > Consultar"
}, {
    2869,
    "Vehiculos > Maestros > Criterios de clasificacion de vehiculos > Mayores > Duplicar"
}, {
    2870,
    "Vehiculos > Maestros > Criterios de clasificacion de vehiculos > Mayores > Eliminar"
}, {
    2871,
    "Vehiculos > Maestros > Criterios de clasificacion de vehiculos > Mayores > Modificar"
}, {
    2872,
    "Vehiculos > Maestros > Criterios de clasificacion de vehiculos > Mayores > Reportes"
}, {
    2859,
    "Vehiculos > Maestros > Criterios de clasificacion de vehiculos > Planes"
}, {
    2860,
    "Vehiculos > Maestros > Criterios de clasificacion de vehiculos > Planes > Adicionar"
}, {
    2861,
    "Vehiculos > Maestros > Criterios de clasificacion de vehiculos > Planes > Consultar"
}, {
    2862,
    "Vehiculos > Maestros > Criterios de clasificacion de vehiculos > Planes > Duplicar"
}, {
    2863,
    "Vehiculos > Maestros > Criterios de clasificacion de vehiculos > Planes > Eliminar"
}, {
    2864,
    "Vehiculos > Maestros > Criterios de clasificacion de vehiculos > Planes > Modificar"
}, {
    2865,
    "Vehiculos > Maestros > Criterios de clasificacion de vehiculos > Planes > Reporte"
}, {
    2964,
    "Vehiculos > Maestros > Centros de trabajo de vehiculos"
}, {
    2965,
    "Vehiculos > Maestros > Centros de trabajo de vehiculos > Adicionar"
}, {
    2966,
    "Vehiculos > Maestros > Centros de trabajo de vehiculos > Consultar"
}, {
    2967,
    "Vehiculos > Maestros > Centros de trabajo de vehiculos > Duplicar"
}, {
    2968,
    "Vehiculos > Maestros > Centros de trabajo de vehiculos > Eliminar"
}, {
    2969,
    "Vehiculos > Maestros > Centros de trabajo de vehiculos > Modificar"
}, {
    2970,
    "Vehiculos > Maestros > Centros de trabajo de vehiculos > Reporte"
}, {
    3145,
    "Vehiculos > Maestros > Fechas"
}, {
    3159,
    "Vehiculos > Maestros > Fechas > Doctos vehiculo"
}, {
    3146,
    "Vehiculos > Maestros > Fechas > Doctos vehiculo > Activar fecha"
}, {
    3147,
    "Vehiculos > Maestros > Fechas > Doctos vehiculo > Cerrar fecha"
}, {
    3106,
    "Vehiculos > Maestros > Grupo de motivos"
}, {
    2880,
    "Vehiculos > Maestros > Modelos de vehiculos"
}, {
    2881,
    "Vehiculos > Maestros > Modelos de vehiculos > Adicionar"
}, {
    2882,
    "Vehiculos > Maestros > Modelos de vehiculos > Consultar"
}, {
    2883,
    "Vehiculos > Maestros > Modelos de vehiculos > Duplicar"
}, {
    2884,
    "Vehiculos > Maestros > Modelos de vehiculos > Eliminar"
}, {
    2885,
    "Vehiculos > Maestros > Modelos de vehiculos > Modificar"
}, {
    2886,
    "Vehiculos > Maestros > Modelos de vehiculos > Reportes"
}, {
    3059,
    "Vehiculos > Maestros > Motivos"
}, {
    3060,
    "Vehiculos > Maestros > Motivos > Adicionar"
}, {
    3061,
    "Vehiculos > Maestros > Motivos > Consultar"
}, {
    3062,
    "Vehiculos > Maestros > Motivos > Eliminar"
}, {
    3063,
    "Vehiculos > Maestros > Motivos > Modificar"
}, {
    3064,
    "Vehiculos > Maestros > Motivos > Reporte"
}, {
    2887,
    "Vehiculos > Maestros > Propietarios"
}, {
    2888,
    "Vehiculos > Maestros > Propietarios > Adicionar"
}, {
    2889,
    "Vehiculos > Maestros > Propietarios > Consultar"
}, {
    2890,
    "Vehiculos > Maestros > Propietarios > Duplicar"
}, {
    2891,
    "Vehiculos > Maestros > Propietarios > Eliminar"
}, {
    2892,
    "Vehiculos > Maestros > Propietarios > Modificar"
}, {
    3226,
    "Vehiculos > Maestros > Propietarios > No obligar informacion de contactos"
}, {
    2893,
    "Vehiculos > Maestros > Propietarios > Reporte"
}, {
    3399,
    "Vehiculos > Maestros > Seguimiento"
}, {
    3400,
    "Vehiculos > Maestros > Seguimiento > Adicionar"
}, {
    3401,
    "Vehiculos > Maestros > Seguimiento > Consultar"
}, {
    3402,
    "Vehiculos > Maestros > Seguimiento > Duplicar"
}, {
    3403,
    "Vehiculos > Maestros > Seguimiento > Eliminar"
}, {
    3404,
    "Vehiculos > Maestros > Seguimiento > Modificar"
}, {
    3405,
    "Vehiculos > Maestros > Seguimiento > Reporte"
}, {
    2954,
    "Vehiculos > Maestros > Temparios por modelo"
}, {
    2955,
    "Vehiculos > Maestros > Temparios por modelo > Adicionar"
}, {
    2956,
    "Vehiculos > Maestros > Temparios por modelo > Consultar"
}, {
    2957,
    "Vehiculos > Maestros > Temparios por modelo > Duplicar"
}, {
    2958,
    "Vehiculos > Maestros > Temparios por modelo > Eliminar"
}, {
    2959,
    "Vehiculos > Maestros > Temparios por modelo > Modificar"
}, {
    2960,
    "Vehiculos > Maestros > Temparios por modelo > Reporte"
}, {
    2894,
    "Vehiculos > Maestros > Tipos de identificacion"
}, {
    2895,
    "Vehiculos > Maestros > Tipos de identificacion > Adicionar"
}, {
    2896,
    "Vehiculos > Maestros > Tipos de identificacion > Consultar"
}, {
    2897,
    "Vehiculos > Maestros > Tipos de identificacion > Duplicar"
}, {
    2898,
    "Vehiculos > Maestros > Tipos de identificacion > Eliminar"
}, {
    2899,
    "Vehiculos > Maestros > Tipos de identificacion > Modificar"
}, {
    2900,
    "Vehiculos > Maestros > Tipos de identificacion > Reporte"
}, {
    2873,
    "Vehiculos > Maestros > Tipos de vehiculos"
}, {
    2874,
    "Vehiculos > Maestros > Tipos de vehiculos > Adicionar"
}, {
    2875,
    "Vehiculos > Maestros > Tipos de vehiculos > Consultar"
}, {
    2876,
    "Vehiculos > Maestros > Tipos de vehiculos > Duplicar"
}, {
    2877,
    "Vehiculos > Maestros > Tipos de vehiculos > Eliminar"
}, {
    2878,
    "Vehiculos > Maestros > Tipos de vehiculos > Modificar"
}, {
    2879,
    "Vehiculos > Maestros > Tipos de vehiculos > Reporte"
}, {
    2901,
    "Vehiculos > Maestros > Vehiculos"
}, {
    2902,
    "Vehiculos > Maestros > Vehiculos > Adicionar"
}, {
    3243,
    "Vehiculos > Maestros > Vehiculos > Permitir cambiar matricula"
}, {
    2971,
    "Vehiculos > Maestros > Vehiculos > Permitir cambiar odometro"
}, {
    2973,
    "Vehiculos > Maestros > Vehiculos > Permitir cambiar propietario"
}, {
    2972,
    "Vehiculos > Maestros > Vehiculos > Permitir cambiar ultima entrada"
}, {
    2903,
    "Vehiculos > Maestros > Vehiculos > Consultar"
}, {
    2904,
    "Vehiculos > Maestros > Vehiculos > Duplicar"
}, {
    2905,
    "Vehiculos > Maestros > Vehiculos > Eliminar"
}, {
    2906,
    "Vehiculos > Maestros > Vehiculos > Modificar"
}, {
    2907,
    "Vehiculos > Maestros > Vehiculos > Reporte"
}, {
    2974,
    "Vehiculos > Ordenes de taller"
}, {
    2975,
    "Vehiculos > Ordenes de taller > Adicionar"
}, {
    2976,
    "Vehiculos > Ordenes de taller > Anular"
}, {
    2977,
    "Vehiculos > Ordenes de taller > Aprobar"
}, {
    9941,
    "Vehiculos > Ordenes de taller > Permitir cambiar datos básicos"
}, {
    3245,
    "Vehiculos > Ordenes de taller > Permitir cambiar observaciones"
}, {
    3303,
    "Vehiculos > Ordenes de taller > Permitir cambiar responsable principal"
}, {
    3111,
    "Vehiculos > Ordenes de taller > Cerrar O.T. no facturables o sin valor factura"
}, {
    2980,
    "Vehiculos > Ordenes de taller > Consultar"
}, {
    2978,
    "Vehiculos > Ordenes de taller > Desaprobar"
}, {
    3195,
    "Vehiculos > Ordenes de taller > Entrega de vehiculos"
}, {
    3196,
    "Vehiculos > Ordenes de taller > Entrega de vehiculos > No obliga contacto de entrega"
}, {
    3112,
    "Vehiculos > Ordenes de taller > Entrega de vehiculos > Imprimir orden de salida"
}, {
    2982,
    "Vehiculos > Ordenes de taller > Habilitar impresion"
}, {
    2981,
    "Vehiculos > Ordenes de taller > Imprimir"
}, {
    2979,
    "Vehiculos > Ordenes de taller > Modificar"
}, {
    6904,
    "Vehiculos > Ordenes de taller > Modificar entidades dinámicas doctos aprobados"
}, {
    8803,
    "Vehiculos > Ordenes de taller > Modificar entidades dinámicas doctos cerrados"
}, {
    6905,
    "Vehiculos > Ordenes de taller > Modificar entidades dinámicas docto en elaboración"
}, {
    3087,
    "Vehiculos > Ordenes de taller > Permitir cambiar pago minimo"
}, {
    3751,
    "Vehiculos > Ordenes de taller > Permitir OTs sin consumo promedio"
}, {
    3244,
    "Vehiculos > Ordenes de taller > Permitir OTs sin matricula"
}, {
    3113,
    "Vehiculos > Ordenes de taller > Reversar cierre de O.T"
}, {
    5337,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Tiempos Basicos > Adicionar"
}, {
    5338,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Tiempos Basicos > Filtro"
}, {
    5339,
    "Nomina > Liquidacion de Nomina > Transacciones Automaticas > Tiempos Basicos > Generar"
}};



        public static IEnumerable<Permiso> EstructuraFlatParaRecursiva(IEnumerable<Permiso> flatObjects)
        {
            // convert flat objects into heirarchial objects and store them in a dictionary keyed with the object's Id
            var recursiveObjectsById = flatObjects.Select(item => 
                new Permiso {
                    IdPermiso = item.IdPermiso,
                    NombrePermiso = item.NombrePermiso,
                    Constante = item.Constante,
                    IdPermisoPadre=item.IdPermisoPadre})
                .ToDictionary(item => item.IdPermiso);

            // group flat objects by their ParentId
            var flatObjectsGroupedByParentId = flatObjects.Where(item => item.IdPermisoPadre.HasValue).GroupBy(item => item.IdPermisoPadre.Value);
            foreach (var group in flatObjectsGroupedByParentId)
            {
                // find each group's parent object
                Permiso parent;
                if (recursiveObjectsById.TryGetValue(group.Key, out parent))
                {
                    // convert the group of flat objects to a list of heirarchial objects by looking up the correct heirarchial object from the dictionary
                    parent.Children = group.Select(item => recursiveObjectsById[item.IdPermiso]).ToList();

                    // assign the parent object to each child object
                    foreach (var child in parent.Children)
                    {
                        child.Padre = parent;
                    }
                }
                else
                {
                    // something's wrong!!!  ParentId refers to a non-existant object.
                }
            }

            return recursiveObjectsById.Values.Where(x=> 0 == x.IdPermisoPadre.Value).ToList();
        }
    }
}
