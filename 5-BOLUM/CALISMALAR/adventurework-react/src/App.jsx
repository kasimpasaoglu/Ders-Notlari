import { useState, useEffect } from 'react';
import FilterForm from './components/FilterForm';
import ProductList from './components/ProductList';
import { fetchCategories, fetchSubcategories, fetchProducts } from './services/api';

const App = () => {
  const [categories, setCategories] = useState([]);
  const [subcategories, setSubcategories] = useState([]);
  const [products, setProducts] = useState([]);
  const [filters, setFilters] = useState({});

  useEffect(() => {
    fetchCategories().then(setCategories);
  }, []);

  useEffect(() => {
    fetchProducts(filters).then(setProducts);
  }, [filters]);


  useEffect(() => {
    if (filters.categoryId) { // Eğer bir kategori seçilmişse
      fetchSubcategories(filters.categoryId).then(setSubcategories);
    } else {
      setSubcategories([]); // Eğer kategori seçilmemişse alt kategorileri temizle
    }
  }, [filters.categoryId]);

  useEffect(() => {
    setFilters((prevFilters) => ({
      ...prevFilters,
      subcategoryId: null, // categoryId değiştiğinde subcategoryId'yi sıfırla
    }));
  }, [filters.categoryId]);

  const handleFilterChange = (newFilters) => {
    setFilters(newFilters);
  };

  return (
    <div className="container my-4">
      <header className="bg-dark text-white text-center py-4">
        <h1>AdventureWorks Products</h1>
        <p>Explore our product catalog</p>
      </header>
      <div className="row">
        <aside className="col-md-3">
          <FilterForm categories={categories} subcategories={subcategories} onFilterChange={handleFilterChange} />
        </aside>
        <section className="col-md-9">
          <ProductList products={products} />
        </section>
      </div>
    </div>
  );
};

export default App;
