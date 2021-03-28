using Microsoft.AspNetCore.Mvc;

namespace Mvc.Filters
{
  public class AuthorizeAttribute : TypeFilterAttribute
  {
    private readonly string _roleName;

    public AuthorizeAttribute(string permission)
      : base(typeof(AuthorizeAttribute))
    {
      this._roleName = permission;
    }
  }
}