using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test,Order(1)]
            public void AddingShareSkillTest()
            {
                ShareSkill shareSkillobj = new ShareSkill();
                shareSkillobj.EnterShareSkill();
            }

            [Test,Order(3)]
            public void ViewingManageListing()
            {
                ManageListings viewListingobj = new ManageListings();
                viewListingobj.ViewManageListing();
            }

            [Test,Order(2)]
            public void EditingManageListing()
            {
                ManageListings editListingobj = new ManageListings();
                editListingobj.EditManageListing();
            }

            [Test,Order(4)]
            public void DeletingManageListing()
            {
                ManageListings deleteListingobj = new ManageListings();
                deleteListingobj.DeleteManageListing();
            }

        }
    }
}