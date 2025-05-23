﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_skip_take;
public class PagedResult<T> : PagedResultBase where T : class
{
    // Essa classe precisa ser instanciada com um tipo de outra classe.

    // Quando instanciamos essa classe, criamos uma lista (List) do tipo da classe fornecida aqui.

    public IList<T> Results { get; set; }

    public PagedResult()
    {
        Results = new List<T>();
    }
}
