namespace TDX_Extended
{
    internal class TDX_People_GetUserListQuery
    {

        private bool _isActive = false;
        private bool _isConfidential = false;
        private bool _isEmployee = false;
        private int _userType = 0;
        private bool _activeSet = false;
        private bool _confidentialSet = false;
        private bool _employeeSet = false;
        private bool _typeSet = false;
        private string _queryString = "";

        public TDX_People_GetUserListQuery()
        {
            _isActive = false;
            _isConfidential = false;
            _isEmployee = false;
            _userType = 0;
            _queryString = "";
        }

        public string getQueryString()
        {
            _queryString = "";
            var priorSetting = false;

            if (_activeSet)
            {
                _queryString += "isActive=" + _isActive;
                priorSetting = true;
            }
            if (_confidentialSet)
            {
                if (priorSetting)
                    _queryString += "&";

                _queryString += "isConfidential=" + _isConfidential;
                priorSetting = true;
            }
            if (_employeeSet)
            {
                if (priorSetting)
                    _queryString += "&";

                _queryString += "isEmployee=" + _isEmployee;
                priorSetting=true;
            }
            if (_typeSet)
            {
                if (priorSetting)
                    _queryString += "&";

                _queryString += "userType=" + _userType;
            }

            Console.WriteLine("Query String is: " + _queryString);
            return _queryString;
        }

        public void setIsActive(bool active)
        {
            _isActive = active;
            _activeSet = true;
        }

        public void disableIsActive()
        {
            _activeSet = false;
        }

        public void setIsConfidential(bool confidential)
        {
            _isConfidential = confidential;
            _confidentialSet = true;
        }

        public void disableIsConfidential()
        {
            _confidentialSet = false;
        }

        public void setIsEmployee(bool employee)
        {
            _isEmployee = employee;
            _employeeSet = true;
        }

        public void disableIsEmployee()
        {
            _employeeSet= false;
        }

        public void setUserType(int type)
        {
            _userType = type;
            _typeSet = true;
        }

        public void disableUserType()
        {
            _typeSet= false;
        }


    }

}
