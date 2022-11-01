using System.Collections.Concurrent;
using System.Reflection;

namespace SIS.MvcFramework
{
    public class ServiceCollection : IServiceCollection
    {
        private IDictionary<Type, Type> dependencyContainer = 
            new ConcurrentDictionary<Type, Type>();
        public void Add<TSource, TDestination>()
        {
            dependencyContainer[typeof(TSource)] = typeof(TDestination);
        }

        public object CreateInstance(Type type)
        {
            if (dependencyContainer.ContainsKey(type))
            {
                type = dependencyContainer[type];
            }

            var constructor = type.GetConstructors(BindingFlags.Public | BindingFlags.Instance)
                .OrderBy(c => c.GetParameters().Count()).FirstOrDefault();
            
            var parameterValues = new List<object>();
            foreach (var parameter in constructor.GetParameters())
            {
                var instance = CreateInstance(parameter.ParameterType);
                parameterValues.Add(instance);
            }

            return constructor.Invoke(parameterValues.ToArray());
            // return Activator.CreateInstance(type); // same as above
        }

        public T CreateInstance<T>()
        {
            return (T)this.CreateInstance(typeof(T));
        }
    }
}