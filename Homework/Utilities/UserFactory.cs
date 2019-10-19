namespace Homework
{
    public static class UserFactory
    {
        public static RegistrationUser CreateValidUser()
        {
            return new RegistrationUser
            {
                Gender = "male",
                FirstName = "FirstName",
                LastName = "LastName",
                Email = "anyemail@gmail.com",
                Password = "password123",
                Date = "21",
                Month = "12",
                Year = "1990",
                Address = "Address",
                City = "City",
                State = "Alaska",
                PostCode = "16000",
                Phone = "12345678"
            };
        }
    }
}
