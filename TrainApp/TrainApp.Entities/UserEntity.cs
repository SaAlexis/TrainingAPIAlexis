namespace TrainApp.Entities
{
    public class UserEntity : IBaseEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        UserEntity(int id, string username, string password)
        {
            Id = id;
            UserName = username;
            Password = password;
        }
    }
}