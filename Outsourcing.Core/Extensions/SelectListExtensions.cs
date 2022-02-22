using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Outsourcing.Core;
using System.ComponentModel;
using Outsourcing.Data.Models;


namespace Outsourcing.Core.Extensions
{
    public static class SelectListExtensions
    {
        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<AccountUser> AccountUsers, string selectedId)
        {
            return

                AccountUsers.OrderBy(user => user.Id)
                      .Select(user =>
                          new SelectListItem
                          {
                              Selected = (user.Id == selectedId),
                              Text = user.DisplayName,
                              Value = user.Id.ToString()
                          });
        }

    }
}
