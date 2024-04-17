namespace MeetingApp.Models
{
    public class Repository
    {
        private static List<UserInfo> _users = new();
        static Repository()
        {
            _users.Add(new UserInfo(){Id=1,Name="Mert",Email="abc@gmail.com",Phone="34234123213",WillAttend=true});
            _users.Add(new UserInfo(){Id=2,Name="Ahmet",Email="abc@gmail.com",Phone="34234123213",WillAttend=true});
            _users.Add(new UserInfo(){Id=3,Name="Mehmet",Email="abc@gmail.com",Phone="34234123213",WillAttend=true});
        }
        public static List<UserInfo> Users {
            get{
                return _users;
            }
        } 
        public static void CreaetUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }
        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user =>user.Id ==id);
        }
    }
}