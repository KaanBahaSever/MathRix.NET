using System.Data.SqlTypes;

class Vector{
    private dynamic values;
    private int _length = 0;

    public int length{
        get{
            return _length;
        }
        set{
            _length = value;
        }
    }
    public Vector(params dynamic[] values){
        this.values = values;
    }

    public static Vector operator +(Vector vec1, Vector vec2){
        if (vec1 == null || vec2 == null){
            throw new ArgumentNullException("");
        }
        if (vec1.length != vec2.length){
            throw new ArgumentException("");
        }
        
        for (int i = 0; i < vec1.length; i++){
            vec1.values[i] += vec2.values[i];
        }
        return vec1;
    }

    public static Vector operator -(Vector vec1, Vector vec2){
        if (vec1 == null || vec2 == null){
            throw new ArgumentNullException("");
        }
        if (vec1.length != vec2.length){
            throw new ArgumentException("");
        }

        for (int i = 0; i < vec1.length; i++){
            vec1.values[i] -= vec2.values[i];
        }
        return vec1;
    }

    public static Vector operator *(Vector vec1, double constant){
        if (vec1 == null){
            throw new ArgumentNullException("");
        }

        for (int i = 0; i < vec1.length; i++){
            vec1.values[i] *= constant;
        }
        return vec1;
    }

    public dynamic dotProduct(Vector vec1, Vector vec2){
        if (vec1 == null || vec2 == null){
            throw new ArgumentNullException("");
        }
        if (vec1.length != vec2.length){
            throw new ArgumentException("");
        }

        dynamic sum = 0;
        for (int i = 0; i < vec1.length; i++){
            sum += vec1.values[i] * vec2.values[i];
        }
        return sum;
    }
}