using Application.Features.Brands.Dtos;
using Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Models
{
    //Dto'nun içerdiği bilgilerin yanı sıra sayfalama bilgisinin de tutulabilmesi için
    //model yapısı kullanılmıştır.
    public class BrandListModel : BasePageableModel
    {
        public IList<BrandListDto> Items { get; set; }
    }
}
