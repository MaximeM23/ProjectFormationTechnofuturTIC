export class Category {
    id: number;
    categoryName: string;
    tagId: number

    /**
     *
     */
    constructor(id: number, categoryName: string,tagId : number) {
        this.categoryName = categoryName;
        this.id = id;
        this.tagId = tagId;
    }
}
