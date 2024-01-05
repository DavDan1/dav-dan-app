import ChuckNorrisJoke from '../components/ChuckNorrisJoke';

const IndexPage: React.FC = () => {
  const getJoke = async (): Promise<string> => {
    try {
      const response = await fetch(
        'https://weather-app-davitdanielyan-e3uzzxqbva-uc.a.run.app/',
      );

      if (!response.ok) {
        throw new Error(`Failed to fetch data. Status: ${response.status}`);
      }

      const data = await response.json();
      return data;
    } catch (error) {
      console.error('Error fetching data:', error);
      return 'Failed to fetch Chuck Norris Joke'; // You can handle the error gracefully
    }
  };

  return <ChuckNorrisJoke getJoke={getJoke} />;
};

export default IndexPage;
