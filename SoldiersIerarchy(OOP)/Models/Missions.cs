using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesIerarchy
{
    public enum MissionStatus
    {
        InProgress,
        Finished
    }


    public class Missions 
    {
        private string missionName;
                 
        public Missions(string missionName,MissionStatus status)
        {
            this.missionName = missionName;
            this.Status = status;
        }


        public string MissionName
        {
            get { return this.missionName; }
            set { missionName = value; }
        }

        public MissionStatus Status { get; set; }

        public override string ToString()
        {
            return $"CodeName: {MissionName} Status: {Status}";
        }


    }
}
