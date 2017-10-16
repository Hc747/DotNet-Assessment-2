using System.Drawing;

namespace Assessment2.Solution {

    public static class Constants {

        public static readonly Color Valid = Color.FromArgb(25, 181, 254);
        public static readonly Color Invalid = Color.FromArgb(220, 97, 128);

        public const string UsernameAndPasswordRegex = "^[a-zA-Z0-9]{2,}$";
        public const string FirstAndLastNameRegex = "^[A-Z]{1}[a-z]+$";

        public const string DateTimeFormat = "DD-MM-YYYY";

        public const string DataPath = "Data";

    }

}