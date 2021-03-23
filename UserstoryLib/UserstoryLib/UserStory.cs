using System;

namespace UserstoryLib
{
    public class UserStory
    {
        private int _id;
        private string _title;
        private string _description;
        private int _businessValue;
        private string _state;

        public int id
        {
            get => _id;
            set => _id = value;
        }
        public string tittle
        {
            get => _title;
            set => _title = value;
        }
        public string description
        {
            get => _description;
            set => _description = value;
        }
        public int businessValue
        {
            get => _businessValue;
            set => _businessValue = value;
        }
        public string state
        {
            get => _state;
            set => _state = value;
        }
        public override string ToString()
        {
            return "UserStory" + tittle + description + businessValue + state;
        }
    }
}
