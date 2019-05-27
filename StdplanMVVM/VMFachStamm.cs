using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using StdplanModel;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace StdplanMVVM
{
    public class VMFachStamm:INotifyPropertyChanged
    {
        private ICommand buttonAdd;
        public ICommand ButtonAdd { get => buttonAdd; set => buttonAdd = value; }
        public IEnumerable<Fach> Faecherliste { get => faecherliste.ListFaecher; 
            //set => faecherliste.ListFaecher = value; 
        }

     
        private Faecher faecherliste;

        public VMFachStamm()
        {
            this.ButtonAdd = new UserCommand(Add);
            faecherliste = new Faecher();
           

        }

        private void Add(Object obj)
        {
            //String  bez = (String)obj;
            VMFach vf = (VMFach)obj;
            Fach f = new Fach
            {
                FachBezeichnung = vf.Bezeichnung
            };
            faecherliste.ListFaecher.Add(f);
            //RaiseEvent("Faecherliste"); unnötig, da ObservableCollection
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void RaiseEvent(String propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
