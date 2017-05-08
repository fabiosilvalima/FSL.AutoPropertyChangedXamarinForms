using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSL.XF5.ViewModels
{
    [ImplementPropertyChanged]
    public class HomePageViewModel
    {
        public string Titulo { get; set; }
    }
}
