const BASE_URL = 'http://adventureworks.runasp.net/api';

export const fetchCategories = async () => {
    const response = await fetch(`${BASE_URL}/Filters/categories`);
    if (!response.ok) throw new Error('Failed to fetch categories');
    return response.json();
};

export const fetchSubcategories = async (categoryId) => {
    const response = await fetch(`${BASE_URL}/Filters/categories/${categoryId}`);
    if (!response.ok) throw new Error('Failed to fetch subcategories');
    return response.json();
};

export const fetchProducts = async (filters) => {
    const response = await fetch(`${BASE_URL}/Products`, {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({
            page: 1,
            productRequested: 20,
            ...filters,
        }),
    });
    if (!response.ok) throw new Error('Failed to fetch products');
    return response.json();
};
