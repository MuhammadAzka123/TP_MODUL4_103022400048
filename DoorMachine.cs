using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL4_103022400048
{
    public class DoorMachine
    {
        enum State
        {
            Terkunci,
            Terbuka
        }
        private State state;
        public DoorMachine()
        {
            state = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
        public void BukaPintu()
        {
            if (state == State.Terkunci)
            {
                state = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
        }
        public void KunciPintu()
        {
            if (state == State.Terbuka)
            {
                state = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
        }
    }
}
