from pyspark.sql import DataFrame
from pyspark.sql.functions import col

def get_product_category_pairs(products_df: DataFrame, 
                              categories_df: DataFrame, 
                              product_category_links_df: DataFrame) -> DataFrame:
    """
    Возвращает датафрейм с:
    1. Всеми парами "Имя продукта - Имя категории"
    2. Продуктами без категорий
    
    Параметры:
    products_df - датафрейм с колонками: product_id, product_name
    categories_df - датафрейм с колонками: category_id, category_name
    product_category_links_df - датафрейм с колонками: product_id, category_id
    """

    product_with_cats = products_df.join(
        product_category_links_df, 
        "product_id", 
        "left"
    ).join(
        categories_df, 
        "category_id", 
        "left"
    )
    
    result = product_with_cats.select(
        col("product_name"), 
        col("category_name")
    ).distinct()
    
    return result
