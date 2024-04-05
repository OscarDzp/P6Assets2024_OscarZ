using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P6Assets2024_OscarZ.Models;

namespace P6Assets2024_OscarZ.ViewModels
{
    public class UserViewModel : BaseViewModel
    {

        public UserPost MyUserToPost { get; set; }

        //TODO: Crear modelos para el rol.

        public UserViewModel() 
        {
        MyUserToPost = new UserPost();
        }
    }
}
