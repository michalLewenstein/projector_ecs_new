export class RequestDetails {
    id!: number
    authNumber!: number
    authStatusId!: number
    authDate!: string//תאריך בקשה
    lastUpdate!: string//תאריך עדכון
    planNumber!: string//============מספר תוכניות./תרשימים?????.????
    workDescription!: string//שדה טקסט עבור מהות העבודה
    diggingLength!: string
    diggingDepth!: string
    diggingWidth!: string
    comments!: string//שדה הערות לפרטי הבקשה

}