﻿

namespace Mooc.Model.Entity;

public class Menu : BaseEntity
{
    public string? Title { get; set; }
    public string? Permission { get; set; }
    public MenuType MenuType { get; set; }
    public string? Mark { get; set; }
    public int OrderNum { get; set; } = 0;
    public string? Route { get; set; }
    public string? ComponentPath { get; set; }
    public virtual ICollection<Menu> Children { get; set; } = new List<Menu>();
    public long? ParentId { get; set; }
    public Menu? Parent { get; set; }
    public virtual ICollection<RoleMenu> RoleMenus { get; set; } = new List<RoleMenu>();
}
