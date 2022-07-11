using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TangDuLieu;


namespace News_Online.Models.Repository
{
    public class SideMenuRepository
    {
        DBase db = new DBase();
        public SideMenuModel SideMenu()
        {
            SideMenuModel SideMenu = new SideMenuModel();
            List<SideMenu_ParentModel> listMenuParent = new List<SideMenu_ParentModel>();
            List<SideMenu_ChildModel> listMenuChild = new List<SideMenu_ChildModel>();

            string sqlParent = @"select * from SideMenuParent";
            DataTable tbParent = db.ExecuteDataSet(sqlParent, CommandType.Text, "server37_Article", null).Tables[0];
            if (tbParent != null && tbParent.Rows.Count > 0)
            {
                for (int i = 0; i < tbParent.Rows.Count; i++)
                {
                    SideMenu_ParentModel MenuParent = new SideMenu_ParentModel();
                    MenuParent.Name = tbParent.Rows[i]["Name"].ToString();
                    MenuParent.ID = int.Parse(tbParent.Rows[i]["ID"].ToString());
                    listMenuParent.Add(MenuParent);

                    string sqlChild = @"select * from SideMenuChild where IDParent = '"+ tbParent.Rows[i]["ID"].ToString() + "'";
                    DataTable tbChild = db.ExecuteDataSet(sqlChild, CommandType.Text, "server37_Article", null).Tables[0];
                    if (tbChild != null && tbChild.Rows.Count > 0)
                    {
                        for (int y = 0; y < tbChild.Rows.Count; y++)
                        {
                            SideMenu_ChildModel MenuChild = new SideMenu_ChildModel();
                            MenuChild.ID = int.Parse(tbChild.Rows[y]["ID"].ToString());
                            MenuChild.Name = tbChild.Rows[y]["Name"].ToString();
                            MenuChild.IDParent = int.Parse(tbChild.Rows[y]["IDParent"].ToString());
                            listMenuChild.Add(MenuChild);
                        }
                    }
                }
            }
            SideMenu.ListSideMenu_Child = listMenuChild;
            SideMenu.ListSideMenu_Parent = listMenuParent;
            return SideMenu;
        }
    }
}
