using System;

namespace Bll.Exceptions
{
    public class CoronaVaccineException : Exception
    {
        public CoronaVaccineException(string message) : base(message)
        {
        }

        public CoronaVaccineException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }


    public class MemberNotFoundException : CoronaVaccineException
    {
        public MemberNotFoundException(string message) : base(message)
        {
        }
    }

    public class MemberVaccineLimitReachedException : CoronaVaccineException
    {
        public MemberVaccineLimitReachedException(string message) : base(message)
        {
        }
    }
}
