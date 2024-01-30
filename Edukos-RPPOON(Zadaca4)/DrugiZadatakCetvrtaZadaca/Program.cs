using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * BUILDER - OBRASCI STVARANJA
 */

namespace DrugiZadatakCetvrtaZadaca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PresetPermissions presetPermissions = new PresetPermissions();
            PresetPermissionsBuilder builder = new PresetPermissionsBuilder(presetPermissions);

            builder.AddEditPermission(new EditPermission());
            builder.AddDeletePermission(new DeletePermission());
            builder.AddCreatePermission(new CreatePermission());
            builder.AddViewPermission(new ViewPermission());

            PresetPermissions configuredPermissions = builder.Build();

            configuredPermissions.Admin();
            configuredPermissions.User();
            configuredPermissions.Manager();
        }
    }
    public class PresetPermissions
    {
        public void Admin()
        {
            Console.WriteLine("Admin user granted all permissions");
        }
        public void User()
        {
            Console.WriteLine("Regular user granted view permission");
        }
        public void Manager()
        {
            Console.WriteLine("Manager granted create, view, edit permissions");
        }
    }
    public interface IPermission
    {
        void Allow();
    }
    public class EditPermission: IPermission
    {
        public void Allow()
        {
            Console.WriteLine("User has edit permission");
        }
    }
    public class DeletePermission: IPermission
    {
        public void Allow()
        {
            Console.WriteLine("User has delete permission");
        }
    }
    public class CreatePermission: IPermission
    {
        public void Allow()
        {
            Console.WriteLine("User has create permission");
        }
    }
    public class ViewPermission: IPermission
    {
        public void Allow()
        {
            Console.WriteLine("User has view permission");
        }
    }
    public interface AccountConfigurator
    {
        void AddEditPermission(EditPermission permission);
        void AddDeletePermission(DeletePermission permission);
        void AddCreatePermission(CreatePermission permission);
        void AddViewPermission(ViewPermission permission);
        void ClearPermissions();
    }
    public class PresetPermissionsBuilder : AccountConfigurator
    {
        private PresetPermissions permissions;

        public PresetPermissionsBuilder(PresetPermissions permissions)
        {
            this.permissions = permissions;
        }

        public void AddCreatePermission(CreatePermission permission)
        {
            Console.WriteLine("Added create permission");
        }

        public void AddDeletePermission(DeletePermission permission)
        {
            Console.WriteLine("Added delete permission");
        }

        public void AddEditPermission(EditPermission permission)
        {
            Console.WriteLine("Added edit permission");
        }

        public void AddViewPermission(ViewPermission permission)
        {
            Console.WriteLine("Added view permission");
        }

        public void ClearPermissions()
        {
            Console.WriteLine("Clear permissions");
        }
        public PresetPermissions Build()
        {
            return permissions;
        }
    }
}
