using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPatternRealTimeExample
{
    public class TeamLeader : Employee
    {
        // TeamLeader can only approve upto 10 days of leave
        private int MAX_LEAVES_CAN_APPROVE = 10;
        public override void applyLeave(string employeeName, int numberofDaysLeave)
        {
            // check if TeamLeader can process this request
            if (numberofDaysLeave <= MAX_LEAVES_CAN_APPROVE)
            {
                ApproveLeave(employeeName, numberofDaysLeave);
            }
            // if TeamLeader can't process the LeaveRequest then pass on to the supervisor(ProjectLeader)
            // so that he can process
            else
            {
                supervisor.applyLeave(employeeName, numberofDaysLeave);
            }
        }
        private void ApproveLeave(string employeeName, int numberofDaysLeave)
        {
            Console.WriteLine("TeamLeader approved " + numberofDaysLeave + " days " + "Leave for the employee : "
                            + employeeName);
        }
    }
}
