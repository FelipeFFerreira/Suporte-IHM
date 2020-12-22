using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IHM.Models
{
    public class DigitalInput : INotifyPropertyChanged
    {
        private string nome;
        private bool status;

        public DigitalInput(
            string nome,
            bool status)
        {
            Nome = nome;
            Status = status;
        }

        public string Nome
        {
            get { return nome; }

            set
            {
                if (nome != value)
                {
                    nome = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Nome)));

                }
            }
        }

        public bool Status
        {
            get { return status; }

            set
            {
                if (status != value)
                {
                    status = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Status)));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
