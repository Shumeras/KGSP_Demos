export class Interval {
    name: string;
    minutes: number;
    seconds: number;
    miliSeconds: number;

    constructor(n: string, m: number, s: number, ms: number) {
        this.name = n;
        this.minutes = m;
        this.seconds = s;
        this.miliSeconds = ms;
    }

    clone() : Interval
    {
        return new Interval(this.name, this.minutes, this.seconds, this.miliSeconds);
    }

    format(): string {
      return ("0" + this.minutes).slice(-2) + ":" + ("0" + this.seconds).slice(-2) + "." + this.miliSeconds/100;
    }

    divide(i: Interval) : number
    {
      return this.toMs() / i.toMs();
    }

    toMs()
    {
        return ((this.minutes * 60)+this.seconds)*1000+this.miliSeconds;
    }

    addMs(ms: number) : boolean
    {
        this.miliSeconds += ms;
        if(this.miliSeconds >= 1000)
        {
            this.miliSeconds -= 1000;
            this.seconds++;
            if(this.seconds >= 60)
            {
                this.seconds -= 60;
                this.minutes++;
                if(this.minutes > 99)
                {
                    return false;
                }
            }
        }
        return true;
    }

    subMs(ms: number) {
        this.miliSeconds -= ms;
        if(this.miliSeconds < 0)
        {
            this.miliSeconds += 1000;
            this.seconds--;
            if(this.seconds < 0)
            {
                this.seconds += 60;
                this.minutes--;
                if(this.minutes < 0)
                {
                    this.minutes = 0;
                    this.seconds = 0;
                    this.miliSeconds = 0;
                    return false;
                }
            }
        }
        return true;
    }
    

}
