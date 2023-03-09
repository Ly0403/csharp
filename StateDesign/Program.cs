using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StateDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context=new Context();
            RunStates(new AddedState(),context);
            RunStates(new ModifiedState(), context);
            RunStates(new DeletedState(), context);
            Console.ReadLine();
        }

        static void RunStates(IState state, Context context)
        {
            state.DoAction(context);
            Console.WriteLine(context.GetState());
        }
    }

    

    interface IState
    {
        void DoAction(Context context);
    }

    class AddedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Added Item");
            context.SetState(this);
        }
    }

    class ModifiedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Added Item");
            context.SetState(this);
        }
    }

    class DeletedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Added Item");
            context.SetState(this);
        }
    }

    class Context
    {
        private IState _state;

        public void SetState(IState state)
        {
            _state=state;
        }
        public IState GetState()
        {
            return _state;
        }
    }
}
