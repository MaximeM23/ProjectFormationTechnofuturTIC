export class Category {
    idCategory: number;
    categoryName: string;
    tagId: number

    /**
     *
     */
    constructor(idCategory: number, categoryName: string,tagId : number) {
        this.categoryName = categoryName;
        this.idCategory = idCategory;
        this.tagId = tagId;
    }
}
