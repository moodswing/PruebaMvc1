using System.Data.Entity;
using Devtalk.EF.CodeFirst;
using MarcasWeb2.Models;

[assembly: WebActivator.PreApplicationStartMethod(typeof(MarcasWeb2.App_Start.DontDropDbJustCreateTablesIfModelChangedStart), "Start")]

namespace MarcasWeb2.App_Start {
    public static class DontDropDbJustCreateTablesIfModelChangedStart {
        public static void Start() {
            // Uncomment this line and replace CONTEXT_NAME with the name of your DbContext if you are 
            // using your DbContext to create and manage your database
            Database.SetInitializer(new DropCreateDatabaseAlways<DataBaseContext>());
        }
    }
}
