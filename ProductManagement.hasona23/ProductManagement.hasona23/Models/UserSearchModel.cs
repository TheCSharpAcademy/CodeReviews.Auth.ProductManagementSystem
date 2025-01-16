using System.Collections;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ProductManagement.hasona23.Models;

public class UserSearchModel
{
    public IEnumerable<IdentityUser>? Users { get; set; }
    public string? SearchRole { get; set; }
    public string? SearchEmail { get; set; }
    public string? SearchUserName { get; set; }
    public bool? IsEmailConfirmed { get; set; }

    public async Task<IEnumerable<IdentityUser>> SearchUsers(UserManager<IdentityUser> userManager)
    {
        IEnumerable<IdentityUser> users = Users ?? await userManager.Users.ToListAsync();
        if (SearchRole != null)
        {
            users = users.Where(user =>  userManager.IsInRoleAsync(user, SearchRole).Result);
        }

        if (IsEmailConfirmed.HasValue)
        {
            users = users.Where(user => userManager.IsEmailConfirmedAsync(user).Result == IsEmailConfirmed);
        }

        if (SearchUserName != null)
        {
            users = users.Where(user => user.UserName.ToUpper().Contains(SearchUserName.ToUpper()));
        }

        if (SearchEmail != null)
        {
            users = users.Where(user => user.Email.Contains(SearchEmail));
        }
        return users;
    } 
}