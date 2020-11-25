using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerApp.Entities
{
    class Department
    {
        //Creating variables

        public string DepartmentName { get; set; }


        //Creating Constructors

        public Department()
        {

        }

        public Department(string name)
        {
            DepartmentName = name;
        }



    }
}
