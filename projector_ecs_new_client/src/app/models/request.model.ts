export class Request {
    id!: string; //
    authNumber!:number ; // בקשה
    street!: string; // מיקומים
    contactPersonName!: string; // מגיש
    toAuthorityName!:string; // עבור היזם
    authStatusId!:number; // סטטוס
    authDatePlanning!: string; // תאריך בקשה
    totalApprovedPlanningApproversCount!:number; // כמה מאשרים
    totalPlanningApproversCount!:number //מתוך כמה מאשרים

 }