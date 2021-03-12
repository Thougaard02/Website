using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website
{
    class Actor
    {
        #region Properties

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        #endregion

        #region Constructors
        public Actor()
        {

        }
        public Actor(int _id, string _firstName, string _lastName)
        {
            Id = _id;
            FirstName = _firstName;
            LastName = _lastName;
        }
        #endregion
    }
}
