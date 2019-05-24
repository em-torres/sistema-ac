using GenStr = SistemaAC.UserStrings.GeneralStrings;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAC.UserStrings
{
    public class AuthStrings
    {
        // Strings del archivo Views/Account/AccountDenied.cshtml
        public const string AcDenDesc = "Usted no tiene acceso a este recurso.";
        public const string AcDenTitle = "Acceso Denegado";

        // Strings del archivo Views/Manage/Index.cshtml
        public const string MaIndTitle = "Perfil";
        public const string MaIndSendVer = "Enviar código de verificación";

        // Strings del archivo Views/Manage/_Layout.cshtml
        public const string MaLayTitle = "Gestionar tu Cuenta";
        public const string MaLaySubtitle = "Cambiar las configuraciones de la cuenta";

        // Strings del archivo Views/Manage/ChangePassword.cshtml
        public const string MaPasTitle = GenStr.GenPassword + " Anterior";
        public const string MaPasCurPass = GenStr.GenPassword + " Actual";
        public const string MaPasConPass = "Confirmar " + GenStr.GenPassword;
        public const string MaPasNewPass = "Nueva " + GenStr.GenPassword;

        // Strings del archivo Views/Manage/TwoFactorAuthentication.cshtml
        public const string MaTwoApp = "App de Autenticación";
        public const string MaTwoNoCodeLeft = "No te quedan códigos de verificación";
        public const string MaTwoGenNewSet = "generar un nuevo set de códigos";
    }
}
