using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repository;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
	public class EFBLogRepository : GenericRepository<Blog>, IBlogDal
	{
		public List<Blog> GetListWithCategory()
		{
			using (var _context = new Context())
			{
				return _context.Blogs.Include(x => x.Category).ToList();
			}
		}
	}
}
