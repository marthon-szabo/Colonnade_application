using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseA.Models
{
    public abstract class Options
    {
        private protected readonly int _id;
        private protected readonly int _accidentalInsuranceLimit;
        private protected readonly int _cash;
        private protected readonly int _luggage;
        private protected readonly int _luggageLimit;
        private protected readonly string _name;

        protected Options(int id, int accidentalInsuranceLimit, int cash, int luggage, int luggageLimit, string name)
        {
            _id = id;
            _accidentalInsuranceLimit = accidentalInsuranceLimit;
            _cash = cash;
            _luggage = luggage;
            _luggageLimit = luggageLimit;
            _name = name;
        }

        public int Id { get => _id;}
        public int AccidentInsuranceLimit { get => _accidentalInsuranceLimit;}
        public int Cash { get => _cash;}
        public int Luggage { get => _luggage;}
        public int LuggageLimit { get => _luggageLimit;}
        public string Name { get => _name;}
    }
}
