using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAC.UserStrings
{
    public class GeneralStrings
    {
        // Strings Datos Generales
        public const string GenUsername = "Usuario";
        public const string GenPassword = "Contraseña";
        public const string GenEmail = "Correo Electrónico";
        public const string GenPhone = "Teléfono";

        // Strings secciones Generales
        public const string GenProfile = "Perfil";
        public const string GenTwoFactor = "Autenticación de doble factor";
        public const string GenExLogins = "Logins Externos";

        // Strings Botones Generales
        public const string GenSave = "Guardar";
        public const string GenUpdPass = "Actualizar " + GenPassword;
        public const string GenConAuth = "Configurar App de Autenticación";
        public const string GenResAuth = "Reiniciar Llave de Autenticación";
        public const string GenAddAuth = "Agregar App de Autenticación";
        public const string GenResRecov = "Reiniciar códigos de recuperación";
        public const string GenDis2fa = "Desactivar Autenticación de Doble Factor";
    }
}
