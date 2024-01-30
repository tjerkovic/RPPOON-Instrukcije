using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiZadatakSedmaZadaca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IExerciseHandler standUpHandler = new StandUpHandler();
            IExerciseHandler squatHandler = new SquatHandler();
            IExerciseHandler sitDownHandler = new SitDownHandler();

            standUpHandler.SetNextHandler(squatHandler);
            squatHandler.SetNextHandler(sitDownHandler);
            sitDownHandler.SetNextHandler(standUpHandler);

            standUpHandler.HandleExercise("StandUp");
            standUpHandler.HandleExercise("squat");
            squatHandler.HandleExercise("standUP");
        }
    }
    public interface IExerciseHandler
    {
        void HandleExercise(string exercise);
        void SetNextHandler(IExerciseHandler nextHandler);
    }
    public class StandUpHandler : IExerciseHandler
    {
        private IExerciseHandler nextHandler;

        public void SetNextHandler(IExerciseHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public void HandleExercise(string exercise)
        {
            if (exercise.ToLower() == "standup")
            {
                Console.WriteLine("Person is performing: StandUp");
            }
            else
            {
                Console.WriteLine("Person cannot perform StandUp. Passing to next handler.");
                nextHandler.HandleExercise(exercise);
            }
        }
    }
    public class SquatHandler : IExerciseHandler
    {
        private IExerciseHandler nextHandler;

        public void SetNextHandler(IExerciseHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public void HandleExercise(string exercise)
        {
            if (exercise.ToLower() == "squat")
            {
                Console.WriteLine("Person is performing: Squat");
            }
            else
            {
                Console.WriteLine("Person cannot perform Squat. Passing to next handler.");
                nextHandler.HandleExercise(exercise);
            }
        }
    }
    public class SitDownHandler : IExerciseHandler
    {
        private IExerciseHandler nextHandler;

        public void SetNextHandler(IExerciseHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public void HandleExercise(string exercise)
        {
            if (exercise.ToLower() == "sitdown")
            {
                Console.WriteLine("Person is performing: SitDown");
            }
            else
            {
                Console.WriteLine("Person cannot perform SitDown. Passing to next handler.");
                nextHandler.HandleExercise(exercise);
            }
        }
    }
}
