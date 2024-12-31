import 'react';
import ProductCard from './ProductCard';
import PropTypes from 'prop-types';

const ProductList = ({ products }) => {
    return (
        <div className="row">
            {products.map((product) => (
                <ProductCard key={product.productId} product={product} />
            ))}
        </div>
    );
};

export default ProductList;

ProductList.propTypes = {
    products: PropTypes.arrayOf(
        PropTypes.shape({
            productId: PropTypes.oneOfType([PropTypes.string, PropTypes.number]).isRequired, // Ürün ID'si
            name: PropTypes.string.isRequired, // Ürün adı
            productNumber: PropTypes.string.isRequired, // Ürün numarası
            color: PropTypes.oneOfType([PropTypes.string, PropTypes.oneOf([null])]), // Renk
            standardCost: PropTypes.number.isRequired, // Standart maliyet
            listPrice: PropTypes.number.isRequired, // Liste fiyatı
            size: PropTypes.oneOfType([PropTypes.string, PropTypes.oneOf([null])]), // Boyut
            sizeUnitMeasureCode: PropTypes.oneOfType([PropTypes.string, PropTypes.oneOf([null])]), // Boyut birim kodu
            weight: PropTypes.oneOfType([PropTypes.number, PropTypes.oneOf([null])]), // Ağırlık
            weightUnitMeasureCode: PropTypes.oneOfType([PropTypes.string, PropTypes.oneOf([null])]), // Ağırlık birim kodu
            style: PropTypes.oneOfType([PropTypes.string, PropTypes.oneOf([null])]), // Stil
            productSubcategoryId: PropTypes.oneOfType([PropTypes.number, PropTypes.oneOf([null])]), // Alt kategori ID'si
            productModelId: PropTypes.oneOfType([PropTypes.number, PropTypes.oneOf([null])]), // Ürün model ID'si
            productCategoryId: PropTypes.oneOfType([PropTypes.number, PropTypes.oneOf([null])]), // Kategori ID'si
            productCategoryName: PropTypes.oneOfType([PropTypes.string, PropTypes.oneOf([null])]), // Kategori adı
            productSubcategoryName: PropTypes.oneOfType([PropTypes.string, PropTypes.oneOf([null])]), // Alt kategori adı
            productPhoto: PropTypes.oneOfType([PropTypes.string, PropTypes.oneOf([null])]), // Ürün fotoğrafı
            productDescription: PropTypes.oneOfType([PropTypes.string, PropTypes.oneOf([null])]), // Ürün açıklaması
        })
    ).isRequired, // products bir dizi ve tanımlanan yapıya uygun elemanlar içermeli
};
