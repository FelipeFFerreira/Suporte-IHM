using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IHM.Models
{
    public class AnalogicalInput : INotifyPropertyChanged
    {
        private string nome;
        private bool status;
        private float value;

        public AnalogicalInput(
            string nome,
            bool status,
            float value)
        {
            Nome = nome;
            Status = status;
            Value = value;
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
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Status)));
                }
            }
        }
        public float Value
        {
            get { return value; }
            set
            {
                if (this.value != value)
                {
                    this.value = value;
                    // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Status)));
                }
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
