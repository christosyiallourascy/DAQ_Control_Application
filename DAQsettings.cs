using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotControlApplication
{
    static class DAQsettings
    {
        private static bool[] _portsX;
        private static bool[] _portsXr;
        private static string _edgecounterX;
        private static string _sourcecounterX;

        private static bool[] _portsY;
        private static bool[] _portsYr;
        private static string _edgecounterY;
        private static string _sourcecounterY;

        private static bool[] _portsZ;
        private static bool[] _portsZr;
        private static string _edgecounterZ;
        private static string _sourcecounterZ;

        private static bool[] _portsThita;
        private static bool[] _portsThitar;
        private static string _edgecounterThita;
        private static string _sourcecounterThita;

        private static string merged_string = string.Empty;

        //X...
        public static bool[] PortsX
        {
            get
            {
                var value = Environment.GetEnvironmentVariable("_portsX", EnvironmentVariableTarget.User);
                _portsX = convertToBool(value);
                return _portsX;
            }
            set
            {
                _portsX = value;
            }
        }
        public static bool[] PortsXr
        {
            get
            {
                var value = Environment.GetEnvironmentVariable("_portsXr", EnvironmentVariableTarget.User);
                _portsXr = convertToBool(value);
                return _portsXr;
            }
            set
            {
                _portsXr = value;
            }
        }
        public static string EdgecounterX
        {
            get
            {
                var value = Environment.GetEnvironmentVariable("_edgecounterX", EnvironmentVariableTarget.User);
                _edgecounterX = value;
                return _edgecounterX;
            }
            set
            {
                _edgecounterX = value;
            }
        }
        public static string SourcecounterX
        {
            get
            {
                var value = Environment.GetEnvironmentVariable("_sourcecounterX", EnvironmentVariableTarget.User);
                _sourcecounterX = value;
                return _sourcecounterX;
            }
            set
            {
                _sourcecounterX = value;
            }
        }

        //Y...
        public static bool[] PortsY
        {
            get
            {
                var value = Environment.GetEnvironmentVariable("_portsY", EnvironmentVariableTarget.User);
                _portsY = convertToBool(value);
                return _portsY;
            }
            set
            {
                _portsY = value;
            }
        }
        public static bool[] PortsYr
        {
            get
            {
                var value = Environment.GetEnvironmentVariable("_portsYr", EnvironmentVariableTarget.User);
                _portsYr = convertToBool(value);
                return _portsYr;
            }
            set
            {
                _portsYr = value;
            }
        }
        public static string EdgecounterY
        {
            get
            {
                var value = Environment.GetEnvironmentVariable("_edgecounterY", EnvironmentVariableTarget.User);
                _edgecounterY = value;
                return _edgecounterY;
            }
            set
            {
                _edgecounterY = value;
            }
        }
        public static string SourcecounterY
        {
            get
            {
                var value = Environment.GetEnvironmentVariable("_sourcecounterY", EnvironmentVariableTarget.User);
                _sourcecounterY = value;
                return _sourcecounterY;
            }
            set
            {
                _sourcecounterY = value;
            }
        }

        //Z...
        public static bool[] PortsZ
        {
            get
            {
                var value = Environment.GetEnvironmentVariable("_portsZ", EnvironmentVariableTarget.User);
                _portsZ = convertToBool(value);
                return _portsZ;
            }
            set
            {
                _portsZ = value;
            }
        }
        public static bool[] PortsZr
        {
            get
            {
                var value = Environment.GetEnvironmentVariable("_portsZr", EnvironmentVariableTarget.User);
                _portsZr = convertToBool(value);
                return _portsZr;
            }
            set
            {
                _portsZr = value;
            }
        }
        public static string EdgecounterZ
        {
            get
            {
                var value = Environment.GetEnvironmentVariable("_edgecounterZ", EnvironmentVariableTarget.User);
                _edgecounterZ = value;
                return _edgecounterZ;
            }
            set
            {
                _edgecounterZ = value;
            }
        }
        public static string SourcecounterZ
        {
            get
            {
                var value = Environment.GetEnvironmentVariable("_sourcecounterZ", EnvironmentVariableTarget.User);
                _sourcecounterZ = value;
                return _sourcecounterZ;
            }
            set
            {
                _sourcecounterZ = value;
            }
        }

        //Thita...
        public static bool[] PortsThita
        {
            get
            {
                var value = Environment.GetEnvironmentVariable("_portsThita", EnvironmentVariableTarget.User);
                _portsThita = convertToBool(value);
                return _portsThita;
            }
            set
            {
                _portsThita = value;
            }
        }
        public static bool[] PortsThitar
        {
            get
            {
                var value = Environment.GetEnvironmentVariable("_portsThitar", EnvironmentVariableTarget.User);
                _portsThitar = convertToBool(value);
                return _portsThitar;
            }
            set
            {
                _portsThitar = value;
            }
        }
        public static string EdgecounterThita
        {
            get
            {
                var value = Environment.GetEnvironmentVariable("_edgecounterThita", EnvironmentVariableTarget.User);
                _edgecounterThita = value;
                return _edgecounterThita;
            }
            set
            {
                _edgecounterThita = value;
            }
        }
        public static string SourcecounterThita
        {
            get
            {
                var value = Environment.GetEnvironmentVariable("_sourcecounterThita", EnvironmentVariableTarget.User);
                _sourcecounterThita = value;
                return _sourcecounterThita;
            }
            set
            {
                _sourcecounterThita = value;
            }
        }

        public static bool[] convertToBool(string value)
        {
            string temp = string.Empty;
            int commacounter = 0;
            bool[] boolelements = new bool[8];
            for (int i = 0; i < value.Count(); i++)
            {
                if (commacounter == 7)
                {
                    temp = temp + value.Substring(i, 1);
                    if (i == value.Count() - 1)
                    {
                        boolelements[commacounter] = Convert.ToBoolean(temp);

                    }
                }
                else
                {
                    if (value.Substring(i, 2) == ", ")
                    {
                        boolelements[commacounter] = Convert.ToBoolean(temp);
                        commacounter += 1;
                        temp = string.Empty;
                    }
                    else
                    {
                        temp = temp + value.Substring(i, 1);
                    }
                }
            }
            return boolelements;
        }

        public static void Default_settings()
        {
            _portsX = new bool[8] { false, true, true, true, true, true, true, true };
            _portsXr = new bool[8] { true, false, true, true, true, true, true, true };
            _edgecounterX = "/ctr0";
            _sourcecounterX = "/PFI8";

            _portsY = new bool[8] { true, true, false, true, true, true, true, true };
            _portsYr = new bool[8] { true, true, true, false, true, true, true, true };
            _edgecounterY = "/ctr1";
            _sourcecounterY = "/PFI3";

            _portsZ = new bool[8] { true, true, true, true, false, true, true, true };
            _portsZr = new bool[8] { true, true, true, true, true, false, true, true };
            _edgecounterZ = "/ctr2";
            _sourcecounterZ = "/PFI0";

            _portsThita = new bool[8] { true, true, true, true, true, true, false, true };
            _portsThitar = new bool[8] { true, true, true, true, true, true, true, false };
            _edgecounterThita = "/ctr3";
            _sourcecounterThita = "/PFI5";

            merged_string = string.Join(", ", _portsX.Select(b => b.ToString()).ToArray());
            Environment.SetEnvironmentVariable("_portsX", merged_string, EnvironmentVariableTarget.User);

            merged_string = string.Empty;
            merged_string = string.Join(", ", _portsXr.Select(b => b.ToString()).ToArray());
            Environment.SetEnvironmentVariable("_portsXr", merged_string, EnvironmentVariableTarget.User);

            merged_string = string.Empty;
            merged_string = _edgecounterX;
            Environment.SetEnvironmentVariable("_edgecounterX", merged_string, EnvironmentVariableTarget.User);

            merged_string = string.Empty;
            merged_string = _sourcecounterX;
            Environment.SetEnvironmentVariable("_sourcecounterX", merged_string, EnvironmentVariableTarget.User);

            merged_string = string.Empty;
            merged_string = string.Join(", ", _portsY.Select(b => b.ToString()).ToArray());
            Environment.SetEnvironmentVariable("_portsY", merged_string, EnvironmentVariableTarget.User);

            merged_string = string.Empty;
            merged_string = string.Join(", ", _portsYr.Select(b => b.ToString()).ToArray());
            Environment.SetEnvironmentVariable("_portsYr", merged_string, EnvironmentVariableTarget.User);

            merged_string = string.Empty;
            merged_string = _edgecounterY;
            Environment.SetEnvironmentVariable("_edgecounterY", merged_string, EnvironmentVariableTarget.User);

            merged_string = string.Empty;
            merged_string = _sourcecounterY;
            Environment.SetEnvironmentVariable("_sourcecounterY", merged_string, EnvironmentVariableTarget.User);

            merged_string = string.Empty;
            merged_string = string.Join(", ", _portsZ.Select(b => b.ToString()).ToArray());
            Environment.SetEnvironmentVariable("_portsZ", merged_string, EnvironmentVariableTarget.User);

            merged_string = string.Empty;
            merged_string = string.Join(", ", _portsZr.Select(b => b.ToString()).ToArray());
            Environment.SetEnvironmentVariable("_portsZr", merged_string, EnvironmentVariableTarget.User);

            merged_string = string.Empty;
            merged_string = _edgecounterZ;
            Environment.SetEnvironmentVariable("_edgecounterZ", merged_string, EnvironmentVariableTarget.User);

            merged_string = string.Empty;
            merged_string = _sourcecounterZ;
            Environment.SetEnvironmentVariable("_sourcecounterZ", merged_string, EnvironmentVariableTarget.User);

            merged_string = string.Empty;
            merged_string = string.Join(", ", _portsThita.Select(b => b.ToString()).ToArray());
            Environment.SetEnvironmentVariable("_portsThita", merged_string, EnvironmentVariableTarget.User);

            merged_string = string.Empty;
            merged_string = string.Join(", ", _portsThitar.Select(b => b.ToString()).ToArray());
            Environment.SetEnvironmentVariable("_portsThitar", merged_string, EnvironmentVariableTarget.User);

            merged_string = string.Empty;
            merged_string = _edgecounterThita;
            Environment.SetEnvironmentVariable("_edgecounterThita", merged_string, EnvironmentVariableTarget.User);

            merged_string = string.Empty;
            merged_string = _sourcecounterX;
            Environment.SetEnvironmentVariable("_sourcecounterThita", merged_string, EnvironmentVariableTarget.User);

            
        }
    }
}
