using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory_Design_Pattern.classdemo
{
    public interface ICar
    {
        void start();
    }
    public class SixSeatercar : ICar
    {
        public void start()
        {
            throw new NotImplementedException();
        }
    }
    public class SevenSeatercar : ICar
    {
        public void start()
        {
            throw new NotImplementedException();
        }
    }

    public class CarFactory
    {
        public ICar GetCar(string cartype)
        {
            switch (cartype)
            {
                case "SixSeatercar":
                    return new SixSeatercar();
                case "SevenSeatercar":
                    return new SevenSeatercar();
            }
            return null;
        }
    }
}
