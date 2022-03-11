namespace exercicio1.src
{
    public class Veiculo
    {
        private string Marca {get; set;}
        private string Modelo {get; set;}
        private string Placa {get; set;}
        private string Cor {get; set;}
        private float Km {get; set;}
        private bool isLigado{get; set;}
        private int litrosCombustivel{get; set;}
        private int Velocidade {get; set;}
        private double Preco {get; set;}
        
        public string getMarca()
        {
            return this.Marca;
        }

        public void setMarca(string marca)
        {
            this.Marca = marca;
        }

        public string getCor()
        {
            return this.Cor;
        }

        public void setCor(string cor)
        {
            this.Cor = cor;
        }

        public string getModelo()
        {
            return this.Marca;
        }

        public void setModelo(string modelo)
        {
            this.Modelo = modelo;
        }

        public string getPlaca()
        {
            return this.Placa;
        }

        public void setPlaca(string placa)
        {
            this.Placa = placa;
        }
        public float getKm()
        {
            return this.Km;
        }

        public void setKm(float km)
        {
            this.Km = km;
        }
        public bool getIsLigado()
        {
            return this.isLigado;
        }

        public void setIsLigado(bool isLigado)
        {
            this.isLigado = isLigado;
        }

        public int getLitrosCombustivel()
        {
            return this.litrosCombustivel;
        }

        public void setLitrosCombustivel(int litrosCombustivel)
        {
            this.litrosCombustivel = litrosCombustivel;
        }

        public int getVelocidade()
        {
            return this.Velocidade;
        }

        public void setVelocidade(int velocidade)
        {
            this.Velocidade = velocidade;
        }

        public double getPreco()
        {
            return this.Preco;
        }

        public void setPreco(double preco)
        {
            this.Preco = preco;
        }

        public string acelerar()
        {
            this.Velocidade += 20;
            return $"A velocidade atual é {this.Velocidade} Km/h.";
        }

        public string abastecer(int combustivel)
        {
            const int limite = 60;
            if(this.litrosCombustivel == 60)
            {
                return "O tanque está cheio";
            }
            else if(this.litrosCombustivel + combustivel > limite)
            {   
                int diferenca = limite - this.litrosCombustivel;
                this.litrosCombustivel = 60;
                return $"Abastecido com {diferenca} litros, limite de 60 litros atingido.";
            } 
            else 
            {
                this.litrosCombustivel += combustivel;
                return $"O tanque possui atualmente {this.litrosCombustivel} litros de combustivel";
            }
        }

        public string frear()
        {
            if(Velocidade == 0)
            {
                return "O veículo está parado";
            }
            else
            {   
                this.Velocidade -= 20;
                return $"A velocidade atual é {this.Velocidade} Km/h";
            }
        }

        public string pintar(string cor)
        {
            this.Cor = cor;
            return $"A cor atual do veículo é: {this.Cor}";
        }

        public string ligar()
        {
            if(this.isLigado)
            {
                return $"O veículo está ligado? {this.isLigado}";
            }
            else
            {
                this.isLigado = true;
            }
            return $"O veículo está ligado? {this.isLigado}";
        }

        public string desligar()
        {
            if(this.isLigado == false)
            {
                return $"O veículo está ligado? {this.isLigado}";
            }
            else if(Velocidade > 0)
            {
                return "É necessário parar o veículo para desliga-lo";
            }
            else
            {
                this.isLigado = false;
            }
            return $"O veículo está ligado? {this.isLigado}";
        }
    }
}