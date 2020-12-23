using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IHM.Models
{
    class TransistorOutput
    {
        private int porcPwm;
        private int frequencia;
        private bool status;
        private string nome;

        public TransistorOutput(
            string nome,
            bool status,
            int porcPwm,
            int frequencia
            )
        {
            Nome = nome;
            PorcPwm = porcPwm;
            Frequencia = frequencia;
            Status = status;           
        }

        public TransistorOutput()
        {
            
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

        public int PorcPwm
        {
            get { return porcPwm; }
            set
            {
                if (porcPwm != value)
                {
                    porcPwm = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Nome)));
                }
            }
        }

        public int Frequencia
        {
            get { return frequencia; }
            set
            {
                if (frequencia != value)
                {
                    frequencia = value;
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
