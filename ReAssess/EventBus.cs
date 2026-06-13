using System;
using System.Collections.Generic;
using System.Text;

namespace ZorksRevenge.ReAssess
{
    internal static class EventBus
    {
        private static readonly Dictionary<Type, List<Delegate>> subs = new();

        public static void Subscribe<T>(Action<T> handler) where T :IGameEvent
        {
            Type t = typeof(T);
            if(!subs.TryGetValue(t, out List<Delegate> list))
            {
                list = new();
                subs[t] = list;
            }
            list.Add(handler);
        }
        public static void Unubscribe<T>(Action<T> handler) where T : IGameEvent
        {
            Type t = typeof(T);
            if (subs.TryGetValue(t, out List<Delegate> list))
            {
                list.Remove(handler);
                if(list.Count == 0) subs.Remove(t);
            }
            
        }
        public static void Publish<T>(T ev) where T : IGameEvent
        {
            Type t = typeof(T);
            if (subs.TryGetValue(t, out List<Delegate> list))
            {
                Delegate[] copy = list.ToArray();
                foreach(var d in copy)
                {
                    ((Action<T>)d)(ev);
                }
            }
        }

    }
}
public interface IGameEvent
{

}