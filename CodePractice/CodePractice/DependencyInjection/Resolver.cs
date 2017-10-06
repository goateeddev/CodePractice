using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodePractice.Calculator;
using CodePractice.Calculator.Interfaces;
using Microsoft.Practices.Unity;

namespace CodePractice.DependencyInjection
{
    public static class Resolver
    {
        private static IUnityContainer _unityContainer;

        /// <summary>
        /// Resolve a class on this container
        /// </summary>
        /// <typeparam name="T">Type of the class to resolve</typeparam>
        /// <returns>Resolved class</returns>
        public static T Resolve<T>()
        {
            if (_unityContainer == null)
            {
                SetupDefaultBehaviour();
            }

            return _unityContainer.Resolve<T>();
        }

        /// <summary>
        /// Standard behaviour for the software.
        /// </summary>
        /// <returns></returns>
        private static void SetupDefaultBehaviour()
        {
            _unityContainer = new UnityContainer();
            RegisterTypes(_unityContainer);
        }

        /// <summary>
        /// Any types unity manages from inside this project should be setup here.
        /// </summary>
        private static void RegisterTypes(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<IFormatter, Formatter>();
            unityContainer.RegisterType<ICalc, Calc>();
        }
    }
}
