using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PowerCell
{
    public class Cell
    {

//- _charge : float
        private float _charge;
        //private string _character;

// + Name : string
        public string Name { get; }

//constructor
        public Cell(string name)

        {
            Name = name;
            _charge = 200;

        }

        /*public void Character(string name)
        {
            Name = name;
        }*/
        
// + Charge : float
        public float Charge
        {
            get => _charge;
            set
            {
                _charge = value;
                if (_charge < 0)
                {
                    _charge = 0;
                }
                else if (_charge > 200)
                {
                    _charge = 200;
                }
            }
        }
//+Level : int
        public int Level => 1 + (int)_charge / 40;

    
//+Consume(float amount)
        public void Consume(float amount)
        {
            _charge -= amount;
        }
//+Restore(void)
        public void Restore()
        {
            _charge = 200;
        }
// +Tostring(string)
        public override string ToString()
{
    return $"[{Name}] Level {Level}: {_charge}/200";
}
/*
        public Name(string name)
        {
            Name = name;
        }
        */
        //
    }
}