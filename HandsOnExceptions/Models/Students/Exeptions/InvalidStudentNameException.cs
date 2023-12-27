namespace HandsOnExceptions.Models.Students.Exeptions
{
    internal class InvalidStudentNameException: Exception
    {
        public InvalidStudentNameException()
            :base()
        {

        }
        public InvalidStudentNameException(string messege)
            :base(messege)     
        {
                        
        }
    }
}
