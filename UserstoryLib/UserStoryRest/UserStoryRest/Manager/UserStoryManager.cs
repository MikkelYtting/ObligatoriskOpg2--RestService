using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserstoryLib;

namespace UserStoryRest.Manager
{
    public class UserStoryManager
    {
        private static int _nextid = 1;
        private static List<UserStory> UserStoryData = new List<UserStory>()
        {
            new UserStory{id = _nextid++, tittle = "AddItem", description = "As a user i want to add an item to the list", businessValue = 4, state = "Doing"},
            new UserStory{id = _nextid++, tittle = "DeleteItem", description = "As a user i want to delete an item from the list", businessValue = 4, state = "Doing"},
            new UserStory{id = _nextid++, tittle = "UpdateItem", description = "As a user i want to update an item on the list", businessValue = 4, state = "Doing"},
        };
        public List<UserStory> getAll()
        {
            return UserStoryData;
        }

        public UserStory GetById(int id)
        {
            return UserStoryData.Find(UserStory => UserStory.id == id);
        }
        public UserStory Add(UserStory newUserStory)
        {
            newUserStory.id = _nextid++;
            UserStoryData.Add(newUserStory);
            return newUserStory;
        }

        public bool Delete(int id)
        {
            UserStory userStory = UserStoryData.Find(UserStory1 => UserStory1.id == id);
            if (userStory == null) return false;
            UserStoryData.Remove(userStory);
            return true;
        }

        public UserStory Update(int id, UserStory updates)
        {
            UserStory userStory = UserStoryData.Find(UserStory1 => UserStory1.id == id);
            if (userStory == null) return null;
            userStory.tittle = updates.tittle;
            userStory.state = updates.state;
            userStory.businessValue = updates.businessValue;
            userStory.description = updates.description;

            return userStory;
        }

    }
}
