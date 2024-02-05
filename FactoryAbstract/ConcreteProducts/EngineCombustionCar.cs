using FactoryAbstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryAbstract.ConcreteProducts
{
    internal class EngineCombustionCar : IEngineCombustion
    {
        private double _potenciaTotal;
        private double _volumeTotal;
        private double _consumo;
        public bool ligado { get; set; } = false;
        public int numCilindros { get; set; }
        public double volumePorCilindro { get; set; }
        public double potenciaPorCilindro { get; set; }
        public double potenciaTotal { 
            get { return _potenciaTotal;}
            private set
            {
                    _potenciaTotal = numCilindros * potenciaPorCilindro*0.85;
            }
        }
        public double volumeTotal { get { return _volumeTotal; } private set { _volumeTotal = value; } }
        public double rotacaoMaxima { get; set; }
        public double rotacao { get; set; } = 0;
        public double consumo { 
            get { return _consumo; }  
            private set 
            {
                if (_potenciaTotal <= 120)
                {
                    _consumo = _potenciaTotal * 0.1;
                }else if(_potenciaTotal <= 300)
                {
                    _consumo = _potenciaTotal * 0.05;
                }
                _consumo = _potenciaTotal * 0.03;
            } 
        }
        public EngineCombustionCar(int numCilindros,double volumePorCilindro,double potenciaPorCilindro)
        {
            this.numCilindros = numCilindros;
            this.volumePorCilindro = volumePorCilindro;
            this.potenciaPorCilindro = potenciaPorCilindro;
            _volumeTotal = numCilindros * volumePorCilindro;
            potenciaTotal = _potenciaTotal;
        }
        public void Acionar()
        {
            ligado = true;
            Console.WriteLine("Motor Acionado");
            while (ligado)
            {
                while (rotacao > 100)
                {
                    rotacao -= 10;
                    Console.WriteLine($"Rotação do motor: {rotacao}: status: Ligado");
                    Thread.Sleep(500);
                }
                Console.WriteLine($"Rotação do motor: {rotacao} | status: Ligado | Potencia: {_potenciaTotal}\n Seleciona um aumento na rotação \n Digite close para desligar");
                string upRotation = Console.ReadLine();
                if (upRotation == "close")
                {
                    rotacao = 0;
                    Console.WriteLine($"Rotação do motor: {rotacao}: status: Desligado ");
                    ligado = false;
                    break;
                }
                Acelerar(double.Parse(upRotation));
            }
        }

        public void Desligar()
        {
            throw new NotImplementedException();
        }
        public void Acelerar(double Rotacao)
        {
            if (rotacao != null)
            {
                rotacao += Rotacao;
            }
            rotacao = rotacao;
        }
    }
}
