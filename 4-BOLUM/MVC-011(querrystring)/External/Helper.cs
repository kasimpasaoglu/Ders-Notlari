// Http Context web teknolojilerinde ana siniftir, Web/e ait bir cok sey http context icinde yakalanabilir
// HttpContextin'in icindekilere mvc action icinden erisilebilir
// ancak Httpcontext icindekilerine action disinda ulasilamaz,
// bu durumda IHttpContextAccessor vasitasi ile erisilebilir
// asagidaki ornekte HttpContext icindeki querry string verisine erisilebilir