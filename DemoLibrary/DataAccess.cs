using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{

    // Do a mental check at this point and confirm "X is a Y" when thinking about abstract class use, as sometimes interfaces are a better fit or the classes
    // just co-incidentally have the same code at this point in time
    public abstract class DataAccess
    {
        public virtual string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "testConnectionString";
        }

        public abstract void LoadData(string sql);

        public abstract void SaveData(string sql);

    }
}
