using System.ComponentModel.DataAnnotations;

namespace Model;

public class AccountModel
{
    [MaxLength(25)]
    public string username {get;set;} = string.Empty;

    [MaxLength(25)]
    public string paswword {get;set;} = string.Empty;
}