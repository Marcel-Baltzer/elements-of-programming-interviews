using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._10._Sorting._05._RenderCalendar
{
    public class Solution
    {
        public class Event
        {
            public int Start;
            public int Finish;

            public Event(int start, int finish)
            {
                Start = start;
                Finish = finish;
            }
        }

        private class Endpoint : IComparable
        {
            public int Time;
            public bool IsStart;

            public Endpoint(int time, bool isStart)
            {
                Time = time;
                IsStart = isStart;
            }
            
            public int CompareTo(object obj)
            {
                var e = obj as Endpoint;

                if (Time != e.Time)
                {
                    return Time.CompareTo(e.Time);
                }

                return IsStart && !e.IsStart ? -1 : !IsStart && e.IsStart ? 1 : 0;
            }
        }

        public static int FindMaxSimultaneousEvents(List<Event> A)
        {
            // Builds an array of all endpoints.
            var endpoints = new List<Endpoint>();

            foreach (var @event in A)
            {
                endpoints.Add(new Endpoint(@event.Start, true));
                endpoints.Add(new Endpoint(@event.Finish, false));
            }
            
            // Sorts the endpoint array according to the time, breaking ties
            // by putting start times before end times.
            endpoints.Sort();
            
            // Track the number of simultaneous events, and record the maximum
            // number of simultaneous events.
            var maxNumSimultaneousEvents = 0;
            var numSimultaneousEvents = 0;

            foreach (var endpoint in endpoints)
            {
                if (endpoint.IsStart)
                {
                    ++numSimultaneousEvents;
                    maxNumSimultaneousEvents = Math.Max(numSimultaneousEvents, maxNumSimultaneousEvents);
                }
                else
                {
                    --numSimultaneousEvents;
                }
            }

            return maxNumSimultaneousEvents;
        }
    }
}