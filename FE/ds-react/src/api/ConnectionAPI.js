export default function Category() {
    const [data ,setData] = useState([])
      const url = "https://localhost:7101/api/categories"
      
      useEffect(() => {
        fetch(url)
        .then(response => response.json()).then(json => {
          console.log("json", json)
          setData(json)
        }).catch(e => {
          console.log("e", e)
        })
      }, [])
    
      return (
        <div>
          {
            data.map(item => {
              return (
                <div>{item.categoryName}</div>
              )
            })
          }
        </div>
      );
    }